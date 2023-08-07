namespace AbstractFactoryDesignPattern.Sample
{
    public abstract class Course
    {
        public abstract bool Buy();
        public abstract bool Sell();
        public abstract double Price { get; }
    }
}
