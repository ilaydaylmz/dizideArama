/******************************************************************************************************************************************************************************************************
**                                                                             SAKARYA ÜNİVERSİTESİ 
**                                                                    BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                                                          BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                                                      NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                                                            2020-2021 BAHAR DÖNEMİ
**
**                                                                          ÖDEV NUMARASI..........: 1
**			                                                                ÖĞRENCİ ADI............: İLAYDA YILMAZ
**				                                                            ÖĞRENCİ NUMARASI.......: B201210057
**                                                                          DERSİN ALINDIĞI GRUP...: 1C GRUBU
**
******************************************************************************************************************************************************************************************************/
using System;

namespace ndp_ödev1_soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            Console.WriteLine("..........MENÜ.......");     //kullanıcının seçim yapabilmesi için menü oluşturdum.
            Console.WriteLine("1-String bir degişkende, string deger substring kullanmadan deger ara");
            Console.WriteLine("2-String bir degiskende ,string degeri substring kullanarak ara");
            Console.WriteLine("3-Alfabenin karakterlerini bir stringde ara kaç adet geçiyor bul ve çiz");
            Console.WriteLine("seciminiz:");
           secim = Convert.ToInt32(Console.ReadLine());    //kullanıcının girdiği sayıyı okudum.

            if (secim ==1)      //birinci seçeneği seçerse bu if bloğu çalışır.
            {

                string metin;
                string aranan;
                string Karakter_dizini;
                Console.WriteLine("Aranacak kelime:");          //aranan kelimenin girilmesini istedim.
                aranan=Console.ReadLine();                     //girilen kelimeyi aranan değişkenine atadım.
                Console.WriteLine("Karakter dizini:");         //metini girmesini istedim.
                metin= Console.ReadLine();                //girilen metni metin değişkenine atadım
                int metin_uzunluk = metin.Length;
                int aranan_uzunluk = aranan.Length;
                int indis = metin.IndexOf(aranan);          //indexof yöntemiyle aranan kelimenin indisini buldurdum.
                Console.WriteLine("Kelime "+aranan+" indis: "+indis);   //bulunan indisi ekrana yazdırdım.
                int indis2 = metin.LastIndexOf(aranan);              //aranan ikinci indisi buldurdum
                Console.WriteLine("Kelime "+aranan+" indis: "+indis2);         //ikinci indisi ekrana yazdırdım.
            }

            if(secim==2)      // ikinci seçeneği seçerse bu if bloğu çalışır.
            {
                string metin; ;
                string aranan;
                Console.WriteLine("Aranılacak kelime:");    //aranan kelimenin girilmesini istedim.
                aranan = Console.ReadLine();             //girilen kelimeyi aranan değişkenine atadım.
                Console.WriteLine("karakter dizini:");      // metini girmesini istedim.
                metin = Console.ReadLine();         //girilen metni metin değişkenine atadım.
                int metin_uzunluk = metin.Length;
                int aranan_uzunluk = aranan.Length;
                for (int i = 0; i < metin.Length-aranan.Length; i++)   //metin.Length-aranan.Length uzunluğundan küçük olacak for döngüsü kurdum.
                {
                    if (metin.Substring(i, aranan.Length)==aranan)  //substring ile aranan aranan kelimeye denk ise çalışır.
                    {
                        Console.WriteLine("kelime " + aranan + " indis: " + (metin.Length - aranan.Length)); //aranan kelimeyi ve indisini ekrana yazdırır.
                    }
                }
               
              
            }
           
            if(secim==3) //üçüncü seçenek seçildiği zaman bu if bloğu çalışır.
            {

                Console.WriteLine("Cümleyi Girin :"); //kullanıcıdan cümle girmesini istedim.
                String metin = Console.ReadLine();  //girilen metni metin değişkenine atadım.
                Console.WriteLine("Karakter sayısı      grafik gösterimi");
                Console.WriteLine("---------------------------------------");
                metin = metin.ToLower(); //girilen metindeki bütün harflerin küçük harflere çevrilmesini sağladım.
                String karakterler = "abcdefghijklmnopqrstuvwxyz"; 
                int[] count = new int[karakterler.Length]; //count isimli bir dizi oluşturdum.

                for (int i = 0; i < metin.Length; i++) //metindeki harf sayısı kadar tekrar eden for döngüsü kurdum.
                {
                    int index = karakterler.IndexOf(metin[i]); //metindeki harflerin sayısını 
                    if(index>=0)//index 0 dan büyük ve eşit ise çalışır.
                    {
                        count[index]++; //indexi bir arttırdım.
                    }
                
                }
              
                for(int i=0;i<count.Length;i++) //count.Lengthten küçük olacak şekilde for döngüsü kurdum.
                {
                    if(count[i]>=0) //index 0dan büyük ve eşit ise çalışır.
                    {
                       Console.Write(karakterler[i] + " sayısı: "+"    " + count[i] );//ekrana harfleri ve metindeki sayılarını yazdırdım.

                        for(int x=0;x<count[i];x++) //harflerin kelimedeki sayısı kadar yıldız bastırmak için for döngüsü kurdurdum
                        {
                            Console.Write(" * ");  // ekrana yıldız yazdırdım.
                        }
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();

            }
        }
    }
}
