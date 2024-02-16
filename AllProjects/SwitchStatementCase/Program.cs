using static System.Console;
IShape kare = new Kare(25);
WriteLine(kare.AlanHesabi(kare));
IShape dortgen = new Dortgen(50,20);
WriteLine(dortgen.AlanHesabi(dortgen));
ReadKey();

public class Kare : IShape
{
	public Kare(int kenar) => kenar = kenar;
	public int kenar { get; }
}

public class Dortgen : IShape
{
	public Dortgen(int uzunluk, int yukseklik) =>
		(Uzunluk,Yukseklik) = (uzunluk,yukseklik);
	public int Uzunluk { get; }
	public int Yukseklik { get;}
}

public interface IShape
{
	string AlanHesabi(dynamic shape) => shape switch //Shape'in kare veya dikdörtgen geldiğini switch kullanarak kontrol ediyoruz.
	{
		Kare k => $"{shape.GetType().Name} alanı" +
					$"{k.kenar * k.kenar:0,00}",
		Dortgen d => $"{shape.GetType().Name} alanı" +
					$"{d.Uzunluk * d.Yukseklik:0,00}",
		_ => throw new Exception($"Alan hesaplanamadı.")
	};
}