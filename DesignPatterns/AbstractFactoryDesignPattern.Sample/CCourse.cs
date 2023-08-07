namespace AbstractFactoryDesignPattern.Sample
{
    public class CCourse : Course
    {
        public override double Price => 69.90;

        public override bool Buy()
        {
            Console.WriteLine("C Course Satin alindi");
            return true;
        }

        public override bool Sell()
        {
            Console.WriteLine("C Course satildi");
            return false;
        }
    }
}
