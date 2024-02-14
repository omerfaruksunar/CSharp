namespace ObjetOrientedSample;
using static Console;
using static DateTime;

public interface IKisi
{
	public string Ad { get; set; }
	public string Soyad { get; set; }
	public DateTime DogTar { get; set; }
	public int Yas(DateTime _dogTar);
	public float KitleEndeks(float _boy, float _kilo);
	public decimal KitleEndeks(decimal _boy, decimal _kilo);
	public double KitleEndeks(double _boy, double _kilo);


}

public interface IPersonel
{
	public DateTime IseGirisTarihi { get; set; }
	public long SGK_No {  get; set; }
}

public abstract class Kisi : IKisi
{
    public Kisi(string _ad, string _soyad, DateTime _dogTar) 
		=> (Ad, Soyad, DogTar) = (_ad, _soyad, _dogTar);
    public string Ad { get ; set ; }
	public string Soyad { get; set; }

	public DateTime DogTar { get; set; }

public float KitleEndeks(float _boy, float _kilo) 
	=> _kilo / (_boy * _boy);

public decimal KitleEndeks(decimal _boy, decimal _kilo)
		=> _kilo / (_boy * _boy);

public double KitleEndeks(double _boy, double _kilo)
		=> _kilo / (_boy * _boy);


	public abstract int Yas(DateTime _dogTar);
}

public class Personel : Kisi, IPersonel
{
	public Personel(string _ad, string _soyad, DateTime _dogTar, 
		DateTime _iseGiris, long _sgkNo) 
		: base(_ad, _soyad, _dogTar)
		=>(IseGirisTarihi, SGK_No)
		=(_iseGiris, _sgkNo);

	public DateTime IseGirisTarihi { get; set; }
	public long SGK_No { get; set; }
	public override int Yas(DateTime _dogTar) //Abstract Kisi sinifini inherit ettigimiz icin onun icerisindeki  abstract Yas sinifini override etmemiz gerekti.
					=> Today.Year - DogTar.Year;
}

public class Program
{
	static void Main(string[] args)
	{
		Personel personel = new
			(_ad: "Ömer Faruk",
			_soyad: "Sunar",
			_dogTar: new DateTime(2001, 05, 27),
			_iseGiris: new DateTime(2010, 05, 01),
			_sgkNo: 1231231231231);
		WriteLine($"Ad:{personel.Ad}");
		WriteLine($"Soyad:{personel.Soyad}");
		Write("Doğum Tarihi: ");
		WriteLine(personel.DogTar.ToShortDateString());
		Write("İse Giriş Tarihi: ");
		WriteLine(personel.IseGirisTarihi.ToShortDateString());
		WriteLine($"SGK No: {personel.SGK_No}");
		WriteLine($"Yaşı: {personel.Yas(personel.DogTar)}");
		WriteLine( "Vücut Kitle Endeks durumu");
		WriteLine($"{personel.KitleEndeks( 1.78f,  99.5f)}");
		WriteLine($"{personel.KitleEndeks(1.78m, 99.5m)}");
		WriteLine($"{personel.KitleEndeks(1.78d, 99.5d)}");
		ReadLine();

	}
}