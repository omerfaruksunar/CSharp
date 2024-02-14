using System.Numerics;
using static System.Console;
WriteLine("Vücut Kitle Endeks Durumu");
WriteLine($"{KitleEndeks(1.78f, 95.5f)}");
WriteLine($"{KitleEndeks(1.78m, 95.5m)}");
WriteLine($"{KitleEndeks(1.78d, 95.5d)}");


ReadLine();
T KitleEndeks<T>(T _boy, T _kilo) where T : struct, INumber<T>
		=> _kilo / (_boy * _boy);
