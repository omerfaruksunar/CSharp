﻿using System.Runtime.CompilerServices;
using static System.Math;
namespace BlazorOrnek1.Data
{
	public static class SwitchExpression
	{
		public static Dictionary<double, string> Alisveris = new()
		{
			{5, "Ekmek" },
			{65,"Yumurta" },
			{20, "Süt" },
			{125,"Peynir" },
			{160,"Tereyağı" },
			{185,"Bal" }
		};

		public static double CalcMath(List<double> nums, islemler operation)
		{
			double result = operation switch
			{
				islemler.Sum => nums.Sum(),
				islemler.Max => Round(nums.Max(), 2), //Virgülden sonra iki hane için 2
				islemler.Min => Round(nums.Min(), 2),
				islemler.Count => nums.Count(),
				islemler.Avg => Round(nums.Average(), 2),
				islemler.First => Round(nums.FirstOrDefault(), 2),
				islemler.Last => Round(nums.LastOrDefault(), 2),
				islemler.WeightedAvg => Round(nums.Where
				(x => x > nums.Min() && x < nums.Max()).Average(), 2),
				_ => 0
			};
			return result;
		}
		public static string C2(this double sayi)
			=> sayi.ToString("0.00₺");
		public enum islemler
		{
			Sum = 0, Max = 1, Min = 2, Count = 3, Avg = 4, First = 5, Last = 6, WeightedAvg = 7
		}
	}
}
