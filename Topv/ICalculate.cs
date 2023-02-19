namespace Topv
{
    public interface ICalculate
    {
        ResultModel CalculateNew(CalculateModel command);
        ResultModel CalculateOld(CalculateModel command);


    }
}
