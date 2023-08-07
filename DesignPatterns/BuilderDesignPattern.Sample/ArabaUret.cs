namespace BuilderDesignPattern.Sample
{
    public class ArabaUret
    {
        private ArabaUret()
        {

        }
        private static ArabaUret uret;

        public static ArabaUret Uret()
        {
            if (uret == null)
                uret = new ArabaUret();
            return uret;
        }
        public void ArabaBilgiUret(IArabaBuilder builder)
        {
            builder.SetMarka();
            builder.SetModel();
            builder.SetKM();
            builder.SetVites();
        }
    }
}
