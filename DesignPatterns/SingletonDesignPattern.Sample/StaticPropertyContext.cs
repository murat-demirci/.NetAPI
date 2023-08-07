namespace SingletonDesignPattern.Sample
{
    public class StaticPropertyContext
    {
        private StaticPropertyContext()
        {

        }
        private static StaticPropertyContext staticContext;
        public static StaticPropertyContext CreateStaticContext
        {
            get { return staticContext; }
        }
        //static constructorlar static elemanlardan birisi calistirilmaya kalkisildiginda
        //ondan önce calisir.
        static StaticPropertyContext()
        {
            staticContext = new StaticPropertyContext();
        }
    }
}
