namespace AbstractFactoryDesignPattern.Sample
{
    public class C : CourseFactory
    {
        public override Course CourseState() => new CCourse();

        public override Process Process() => new CProcess();
    }
}

