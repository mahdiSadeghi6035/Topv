namespace Topv
{
    public class ResultModel
    {
        public double Benefit { get; set; }
        public double Paymenet { get; set; }

        public ResultModel(double benefit, double paymenet)
        {
            Benefit = benefit;
            Paymenet = paymenet;
        }
    }
}
