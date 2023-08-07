using BuilderDesignPattern.Sample;

var araba = new MercedesConcreteBuilder();
ArabaUret uret = ArabaUret.Uret();
uret.ArabaBilgiUret(araba);
Console.WriteLine(araba.Araba.ToString());