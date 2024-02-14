using static System.Console;
using static System.DateTime;

int Yil = Today.Year;

var kisi = new Kisi { Ad = "Ömer Faruk", Soyad = "Sunar", DogumTarihi = 2001 };
WriteLine($"Adı: {kisi.Ad}, Soyadi: {kisi.Soyad}, Yasi: {Yil-kisi.DogumTarihi}");

public class Kisi
{
	public required string Ad { get; init; }
	public required string Soyad { get; init; }
	public required int DogumTarihi { get; set; }
}
