namespace Topv
{
    public class CalculateModel
    {
        public double Price { get; set; }
        public double Month { get; set; }
        public double Percent { get; set; }
        public double Space { get; set; }
        public CalculateModel(double price, double month, double percent, double space)
        {
            Price = price;
            Month = month;
            Percent = percent;
            Space = space;
        }


    }
}
