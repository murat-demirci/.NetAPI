namespace AbstractFactoryDesignPattern.Sample
{
    public class Creater
    {
        CourseFactory courseFactory;
        Course course;
        Process process;

        public Creater(CourseFactory courseFactory)
        {
            this.courseFactory = courseFactory;
            course = courseFactory.CourseState();
            process = courseFactory.Process();
        }

        public void Start()
        {
            if (course.Price < 100)
            {
                course.Buy();
                process.Start("C");
                course.Sell();
            }
        }
    }
}
