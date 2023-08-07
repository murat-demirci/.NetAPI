namespace SingletonDesignPattern.Sample
{
    public class Context
    {
        private Context()
        {

        }

        private static Context instance;
        public static Context CreateContext()
        {
            if (instance == null)
                instance = new Context();
            return instance;
        }
    }
}
