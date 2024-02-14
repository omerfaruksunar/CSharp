Person Suleyman = new();
Suleyman.Old = 47;
Suleyman.Name = "Süleyman UZUNKÖPRÜ";
Person Fatih =new();
Fatih.Old = 17;
Fatih.Name = "Muhammed Fatih";
Fatih = Suleyman;
Console.WriteLine("1.Adım");
Console.WriteLine("Suleyman.Old: "+Suleyman.Old);
Console.WriteLine("Suleyman.name: "+Suleyman.Name);
Console.WriteLine("Fatih.old: "+Fatih.Old);
Console.WriteLine("Fatih.name : "+Fatih.Name);
Suleyman.Name = "Ahmet Yasin";
Suleyman.Old = 10;
Console.WriteLine("Suleyman.old: "+Suleyman.Old);
Console.WriteLine("Suleyman.Name: "+Suleyman.Name);
Console.WriteLine("Fatih.Old:" + Fatih.Old);
Console.WriteLine("Fatih.name: "+Fatih.Name);
Console.ReadLine();

class Person
{
	public byte Old { get; set; }
	public string Name { get; set; }
}
