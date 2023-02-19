using System;

namespace Topv
{
    public class Calculate : ICalculate
    {
        public ResultModel CalculateNew(CalculateModel command)
        {
            var newRate = command.Percent / 1200;
            var power = Math.Pow((1 + newRate), command.Month);
            var sorat = command.Price * newRate * power;
            var makraj = power - 1;
            var payment = sorat / makraj;
            var benefit = ((command.Month * payment) - command.Price);
            return new ResultModel(benefit, payment);
        }

        public ResultModel CalculateOld(CalculateModel command)
        {
            var benefit = ((command.Price * command.Percent) * (command.Month + command.Space)) / 2400; // سود
            var payment = (command.Price + benefit) / command.Month; // قسط
            return new ResultModel(benefit, payment);
        }

    }
}
