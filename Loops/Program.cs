for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("**************************************");
for (int i = 0; i <=10; i+=2)
{
    Console.WriteLine(i);
}
Console.WriteLine("**************************************");

//string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
//string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
//string kurs3 = "Java";
//string kurs4 = "Python";
////string kurs5 = "C#";
//Console.WriteLine(kurs2);
//console.writeline(kurs2);
//Console.WriteLine(kurs3);
//Console.WriteLine(kurs4);
//Console.WriteLine(kurs5);

string[] kurslar = new string[] 
{ "Yazılım Geliştirici Yetiştirme Kampı",
  "Programlamaya Başlangıç İçin Temel Kurs",
  "Java", "Python", "C#" };

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
