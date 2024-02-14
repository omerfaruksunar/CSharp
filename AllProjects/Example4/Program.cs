using static System.Console;
using static System.Convert;
WriteLine($"Bir Sayi Yaziniz.");
int rakam1 = ToInt32( ReadLine() );
WriteLine($"Bir Sayi daha yaziniz.");
int rakam2 = ToInt32(ReadLine());
WriteLine($"Toplam: {HesapMakinesi(sayi1: rakam1, sayi2: rakam2, DortIslem.Topla)}");
WriteLine($"Farki: {HesapMakinesi(sayi1: rakam1, sayi2: rakam2, DortIslem.Cikar)}");
WriteLine($"Carpim: {HesapMakinesi(sayi1: rakam1, sayi2: rakam2, DortIslem.Carp)}");
WriteLine($"Bolme: {HesapMakinesi(sayi1: rakam1, sayi2: rakam2, DortIslem.Bol)}");

ReadLine();

int HesapMakinesi(int sayi1, int sayi2, DortIslem islem) => islem switch
{
	DortIslem.Topla => sayi1 + sayi2,
	DortIslem.Cikar => sayi1 - sayi2,
	DortIslem.Carp => sayi1 * sayi2,
	DortIslem.Bol => sayi1 / sayi2,
	_ => 0  //Discard ifadesi bu ifade kullanildigi anda hafizadan silinecek.

} ;
enum DortIslem //enum: numaralandirilmis bir liste
{
	Topla, Cikar, Carp, Bol
}