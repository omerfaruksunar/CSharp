using static System.Console;
WriteLine(nameof(Kus));
Kus minikKus = new Kus();
minikKus.SolunumYap();
Kus.Uyu();
WriteLine(nameof(Balik));
Balik minikBalik = new Balik();
minikBalik.SolunumYap();
Balik.Uyu();
ReadKey();
abstract class Canli
{
	public abstract void SolunumYap();
	public static void Uyu() => WriteLine("Uyudum");
}


class Kus : Canli //inheritance
{
	public override void SolunumYap() //polimorphism
		=> WriteLine("Oksijenli Solunum yapıyorum.");
	private string Gaga {  get; set; } //Kapsülleme
}

class Balik : Canli
{
	public override void SolunumYap() //polimorphism
		=> WriteLine("Solungacli Solunum yapıyorum.");

}
