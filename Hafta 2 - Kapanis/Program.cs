using System.Diagnostics.Metrics;
using System;

//1.Çıktıyı Yazdıran Program

Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın ?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın ?");

//2.Metinsel ve Tam Sayı Değişken Tanımlama ve Yazdırma

string isim = "Ekin";
int yas = 33;
Console.WriteLine($"İsim: {isim}, Yaş: {yas}");

//3.Rastgele Sayı Üretip Yazdırma

Random random = new Random();
int rastgeleSayi = random.Next(1, 101);
Console.WriteLine($"Rastgele sayı: {rastgeleSayi}");

//4.Rastgele Sayının 3'e Bölümünden Kalanı Yazdırma

int kalan = rastgeleSayi % 3;
Console.WriteLine($"Rastgele sayının 3'e bölümünden kalanı: {kalan}");

//5.Yaşa Göre "+" veya "-" Yazdırma

Console.Write("Yaşınızı giriniz: ");
int kullaniciYasi = int.Parse(Console.ReadLine());
Console.WriteLine(kullaniciYasi >= 18 ? "+" : "-");

//6. 10 Defa Belirtilen Cümleyi Yazdırma

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
}

//7.İki Metnin Yerini Değiştirme

string isim1 = "Gülse Birsel";
string isim2 = "Demet Evgar";
(string yeniIsim1, string yeniIsim2) = (isim2, isim1);
Console.WriteLine($"Yeni İsim 1: {yeniIsim1}, Yeni İsim 2: {yeniIsim2}");

//8.Değer Döndürmeyen Metot

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
}
BenDegerDondurmem();

//9.İki Sayının Toplamını Döndüren Metot

int Toplam(int sayi1, int sayi2) => sayi1 + sayi2;
Console.WriteLine($"Toplam: {Toplam(5, 7)}");

//10.Kullanıcıdan True / False Alıp String Döndüren Metot

string TrueFalseCevap(bool deger) => deger ? "Doğru" : "Yanlış";
Console.WriteLine(TrueFalseCevap(true));

//11.En Yaşlı Olan Kişiyi Bulan Metot
int EnYasliBul(int yas1, int yas2, int yas3) => Math.Max(yas1, Math.Max(yas2, yas3));
Console.WriteLine($"En yaşlı olanın yaşı: {EnYasliBul(30, 45, 27)}");

//12.Sınırsız Sayıda Sayı Alıp En Büyüğünü Döndüren Metot
int EnBuyukSayiBul()
{
    int enBuyuk = int.MinValue;
while (true)
{
    Console.Write("Bir sayı giriniz (Çıkış için 'q'): ");
    string girdi = Console.ReadLine();
    if (girdi.ToLower() == "q") break;
    int sayi = int.Parse(girdi);
    if (sayi > enBuyuk) enBuyuk = sayi;
}
return enBuyuk;
}
Console.WriteLine($"En büyük sayı: {EnBuyukSayiBul()}");

//13.İki İsmin Yerini Değiştiren Metot
void IsimDegistir(ref string isim1, ref string isim2)
{
    (isim1, isim2) = (isim2, isim1);
}
string isimA = "Ali", isimB = "Ayşe";
IsimDegistir(ref isimA, ref isimB);
Console.WriteLine($"Yeni isimler: {isimA}, {isimB}");

//14.Sayının Tek / Çift Olduğunu Dönen Metot
bool TekMiCiftMi(int sayi) => sayi % 2 == 0;
Console.WriteLine(TekMiCiftMi(5) ? "Çift" : "Tek");

//15.Hız ve Zaman ile Yol Hesaplayan Metot
int YolHesapla(int hiz, int zaman) => hiz * zaman;
Console.WriteLine($"Gidilen yol: {YolHesapla(60, 3)} km");

//16.Yarıçap İle Daire Alanını Hesaplayan Metot
double DaireAlan(double yaricap) => Math.PI * Math.Pow(yaricap, 2);
Console.WriteLine($"Dairenin alanı: {DaireAlan(10):F2}");

//17.Cümleyi Büyük ve Küçük Harflerle Yazdırma

string cumle = "Zaman bir GeRi SayIm";
Console.WriteLine(cumle.ToUpper());
Console.WriteLine(cumle.ToLower());

//18.Başındaki ve Sonundaki Boşlukları Silme

string metin = "    Selamlar   ";
metin = metin.Trim();
Console.WriteLine(metin);