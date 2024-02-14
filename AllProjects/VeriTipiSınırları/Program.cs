using static System.Console;
using static System.Math;
WriteLine($"byte....=>min:{byte.MinValue}");
WriteLine($"byte....=>max:{byte.MaxValue}");
WriteLine($"2^8. kuvveti - 1 : {Pow(2, 8) - 1}");
WriteLine($"byte...=>(RAM): {sizeof(byte)}");
WriteLine("______________________________");

WriteLine($"ushort....=>min:{ushort.MinValue}");
WriteLine($"ushort....=>max:{ushort.MaxValue}");
WriteLine($"2^16. kuvveti - 1 : {Pow(2, 16) - 1}");
WriteLine($"ushort...=>(RAM): {sizeof(ushort)}");
WriteLine("______________________________");

WriteLine($"uint....=>min:{uint.MinValue}");
WriteLine($"uint....=>max:{uint.MaxValue}");
WriteLine($"2^32. kuvveti - 1 : {Pow(2, 32) - 1}");
WriteLine($"uint...=>(RAM): {sizeof(uint)}");
WriteLine("______________________________");

WriteLine($"ulong....=>min:{ulong.MinValue}");
WriteLine($"ulong....=>max:{ulong.MaxValue}");
WriteLine($"2^64. kuvveti - 1 : {Pow(2, 64) - 1}");
WriteLine($"ulong...=>(RAM): {sizeof(ulong)}");
WriteLine("______________________________");

WriteLine($"sbyte....=>min:{sbyte.MinValue}");
WriteLine($"sbyte....=>max:{sbyte.MaxValue}");
WriteLine($"2^7. kuvveti - 1 : {Pow(2, 7) - 1}");
WriteLine($"sbyte...=>(RAM): {sizeof(sbyte)}");
WriteLine("______________________________");

WriteLine($"short....=>min:{short.MinValue}");
WriteLine($"short....=>max:{short.MaxValue}");
WriteLine($"2^15. kuvveti - 1 : {Pow(2, 15) - 1}");
WriteLine($"short...=>(RAM): {sizeof(short)}");
WriteLine("______________________________");

WriteLine($"int....=>min:{int.MinValue}");
WriteLine($"int....=>max:{int.MaxValue}");
WriteLine($"2^31. kuvveti - 1 : {Pow(2, 31) - 1}");
WriteLine($"int...=>(RAM): {sizeof(int)}");
WriteLine("______________________________");

// short
WriteLine($"short....=>min:{short.MinValue}");
WriteLine($"short....=>max:{short.MaxValue}");
WriteLine($"2^15. kuvveti - 1 : {(1 << 15) - 1}");
WriteLine($"short...=>(RAM): {sizeof(short)} bytes");
WriteLine("______________________________");

// int
WriteLine($"int....=>min:{int.MinValue}");
WriteLine($"int....=>max:{int.MaxValue}");
WriteLine($"2^31. kuvveti - 1 : {(1L << 31) - 1}");
WriteLine($"int...=>(RAM): {sizeof(int)} bytes");
WriteLine("______________________________");

// long
WriteLine($"long....=>min:{long.MinValue}");
WriteLine($"long....=>max:{long.MaxValue}");
WriteLine($"2^63. kuvveti - 1 : ((1L << 63) - 1)");
WriteLine($"long...=>(RAM): {sizeof(long)} bytes");
WriteLine("______________________________");

// char
WriteLine($"char....=>min:{(int)char.MinValue}");
WriteLine($"char....=>max:{(int)char.MaxValue}");
WriteLine($"char...=>(RAM): {sizeof(char)} bytes");
WriteLine("______________________________");

// float
WriteLine($"float....=>min:{float.MinValue}");
WriteLine($"float....=>max:{float.MaxValue}");
WriteLine($"float...=>(RAM): {sizeof(float)} bytes");
WriteLine("______________________________");

// double
WriteLine($"double....=>min:{double.MinValue}");
WriteLine($"double....=>max:{double.MaxValue}");
WriteLine($"double...=>(RAM): {sizeof(double)} bytes");
WriteLine("______________________________");

//// decimal
WriteLine($"decimal....=>min:{decimal.MinValue}");
WriteLine($"decimal....=>max:{decimal.MaxValue}");
WriteLine($"decimal...=>(RAM): {sizeof(decimal)} bytes");
WriteLine("______________________________");

// bool
WriteLine($"bool....=>min:{bool.FalseString}");
WriteLine($"bool....=>max:{bool.TrueString}");
WriteLine($"bool...=>(RAM): {sizeof(bool)} bytes");
WriteLine("______________________________");

// DateTime
WriteLine($"DateTime....=>min:{DateTime.MinValue}");
WriteLine($"DateTime....=>max:{DateTime.MaxValue}");
WriteLine("______________________________");
unsafe
{
	WriteLine($"DateTime....=>(RAM) : {sizeof(DateTime)} Byte");
}
ReadKey();
