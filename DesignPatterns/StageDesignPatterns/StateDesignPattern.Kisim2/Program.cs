using StateDesignPattern.Kisim2.StateContext;

MusicPlayer player = new();

player.Play();
Console.WriteLine("---------------");
player.Play();
Console.WriteLine("---------------");
player.Stop();
Console.WriteLine("---------------");
player.Stop();
Console.WriteLine("---------------");
player.Play();

