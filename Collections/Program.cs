

string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" };

foreach (var name in names)
{
    Console.WriteLine(name);
}


List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

names2.Add("İlker");
foreach (var name in names2)
{
    Console.WriteLine(name);
}