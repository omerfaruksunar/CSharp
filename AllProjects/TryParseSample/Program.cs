using static System.Console;
using static System.Convert;
string sayi = "1.250.785,23";
bool dene = decimal.TryParse(sayi, out decimal tryDecimal);
WriteLine($"Deneme yapilacak sayi {sayi}");
WriteLine($"Sonuc: {(dene ? tryDecimal : "Basarisiz"): 0,0.00}");

dene = int.TryParse(sayi, out int tryInt);
WriteLine($"Sonuc: {(dene ? tryInt : "Basarisiz"): 0,0.00}");
WriteLine($"{ToDecimal(sayi):0,0.00}");
sayi = sayi.Split( "," ).First().Replace(".","");
WriteLine($"{ToUInt32(sayi):0,0}");
string[] sayimiz = sayi.Split( "," );
ReadKey();