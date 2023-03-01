 //type safety
string kategoriEtiketi = "Kategori";
Console.WriteLine(kategoriEtiketi);
//do not repeat yourself
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = false;

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}


double dolarDun = 7.35;
double dolarBugun = 7.45;
if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Değişmedi Butonu");
}
//array
string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python", "C#" };
for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For bitti");
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
Console.WriteLine("Sayfa Sonu - Footer");
Console.ReadLine();
