namespace BuilderDesignPattern.Sample
{
    public class MercedesConcreteBuilder : IArabaBuilder
    {
        public MercedesConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 50_000;

        public override void SetMarka() => araba.Marka = "Mercedes";

        public override void SetModel() => araba.Model = "AMG";

        public override void SetVites() => araba.Vites = false;
    }
}
