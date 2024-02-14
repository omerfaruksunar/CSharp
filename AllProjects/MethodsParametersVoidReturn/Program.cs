using static System.Console;
using System.Globalization;

namespace MethodsParametersVoidReturn;

internal class Program
{
	static void Main(string[] args)
	{
		string ayracNedir = SistemNumericAyraci();
		AyracOku(ayracNedir);
		ayracNedir = SistemNumericAyraci(1055);
		bool onlukBinlik = false;
		ayracNedir = SistemNumericAyraci(onlukBinlik);
		AyracOku(onlukBinlik, ayracNedir);
		ReadLine();
	}
	/// <summary>
	/// Sistemdeki sayıların ondalık kısımları için kullanılan 
	/// ayracı döndürür
	/// </summary>
	/// <param name="kod">Parametre olarak, ondalık ayraç
	/// istenen ülke kodunu alır.</param>
	/// <returns>Dönüş değeri string tipindedir.
	/// nokta veya virgül döner.</returns>
	private static string SistemNumericAyraci(int kod = 1055)
	{
		CultureInfo culture = new(kod);
		return culture.NumberFormat.NumberDecimalSeparator;
	}

	/// <summary>
	/// Sistemdeki sayıların ondalık kısımları için 
	/// kullanılan ayracı döndürür.
	/// </summary>
	/// <returns>Dönüş değeri string tipindedir.
	/// nokta veya virgül döner.</returns>
	private static string SistemNumericAyraci()
		=> CultureInfo.CurrentCulture.NumberFormat
		.NumberDecimalSeparator;
	/// <summary>
	/// Sistemdeki sayıların ondalık veya binlik kısımları
	/// için kullanılan ayracı döndürür
	/// </summary>
	/// <param name="On_Bin">Ondalık mı binlik mi ayraç 
	/// istediğinizi sorar.
	/// Eğer <code>true</code> gönderirseniz ondalık ayraç döner.
	/// Eğer <code>false</code> gönderirseniz binlik ayraç döner.
	/// </param>
	/// <remarks>
	/// Ayraçların doğru olarak bulunması sayesinde, sayıların 
	/// okunması sırasında bir hata ile karşılaşmayacaksınız.
	/// </remarks>
	/// <returns>Dönüş değeri string tipindedir.
	/// Nokta veya virgül döner.</returns>
	private static string SistemNumericAyraci(bool On_Bin = true)// Opsiyonel bir parametre on bin degeri sunulmadıgında true alınacak.
	{
		CultureInfo tr = new(1055);
		NumberFormatInfo f = tr.NumberFormat;
		string ayrac = On_Bin ? f.NumberDecimalSeparator
			: f.CurrencyGroupSeparator;
		return ayrac;
	}

	/// <summary>
	/// Bu metot ondalık ayracı okur.
	/// </summary>
	/// <param name="OndalikAyrac"></param>
	private static void AyracOku(string OndalikAyrac = ".")
	{
		string oku = "Ondalik Ayraç : ";
		oku += OndalikAyrac == ","
			? "Virgül (,)" : "Nokta (.)";
		WriteLine(oku);
	}
	private static void AyracOku(bool AyracTipi, string Ayrac)
	{
		string oku = AyracTipi ? "Ondalık Ayraç : "
			: "Binlik Ayraç : ";
		oku += Ayrac == "," ? "Virgül(,)" : "Nokta (.)";
		WriteLine(oku);
	}
}
