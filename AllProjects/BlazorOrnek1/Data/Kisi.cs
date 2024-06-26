﻿using Newtonsoft.Json;
using static System.Environment;
namespace BlazorOrnek1.Data

{
	public class Kisi
	{
		public Kisi() { }
		public Kisi(string adi, string soyadi, string cinsiyeti,
			string dYeri, int dYili) 
			=> (Adi, Soyadi, Cinsiyeti, DogumYeri, DogumYili) = 
			(adi,soyadi, cinsiyeti, dYeri, dYili);
		public string Adi {  get; set; }
		public string Soyadi { get; set;}
		public string Cinsiyeti { get; set;}
		public string DogumYeri { get;set;}
		public int DogumYili { get; set;}
		public List<Kisi> KisilerListesi()
		{
			var path = new DirectoryInfo(CurrentDirectory); // DirectoryInfo sınıfından CurrentDirectory bizim projemizin yolunu verir.
			var yol = path + "/Data/Kisi.json";
			var kisiler = JsonConvert
				.DeserializeObject<JsonResponseKisi>
				(File.ReadAllText (yol)); //File sınıfının ReadAllText metoduyla json dosyamızı okuyoruz.
			return kisiler!.Data; //!. kisiler listesinin bos olmadıgını garanti eder.
		}
		public class JsonResponseKisi
		{
			public List<Kisi> Data { get; set; } = null!;
		}
	}
}
