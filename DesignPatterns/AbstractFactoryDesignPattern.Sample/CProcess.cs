namespace AbstractFactoryDesignPattern.Sample
{
    public class CProcess : Process
    {
        public override void Start(string courseName)
        {
            Console.WriteLine($"{courseName} basladi");
        }
    }
}
