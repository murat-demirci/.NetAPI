using PrototypeDesignPattern.Sample;

Book book = new("kitap", "murat", 250, "10.07,2010", 150);
Book book2 = (Book)book.Clone();
if (book.Equals(book2))
    Console.WriteLine("Esit");
else
    Console.WriteLine("Farkli");

