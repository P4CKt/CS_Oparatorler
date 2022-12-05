using System;

namespace odev_2
{    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birleşebilir işlemli atama");
            // atama
            int x = 3;
            int y = 3;
            y= y+2;
            //birleşebilir işlemli atama--> y+=2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2; //x=x*2
            Console.WriteLine(x);
            // Mantıksal Operatörler
            //||,&&,!
            Console.WriteLine("Mantıksal Operatörler");
            bool isSuccess = true;
            Boolean isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
            Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
            Console.WriteLine("Final!");

            // İlişkisel Operatörler (<,>,==,!=)
            int a =3 ;
            int b =4;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc= a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

             // Aritemetik Operatörler (+,-,*,-)
             Console.WriteLine("Aritemetik Operatörler");

             int sayi1 =10;
             int sayi2=5;
             int sonuc1=sayi1/sayi2;
             Console.WriteLine(sonuc1);
             sonuc1=sayi1*sayi2;
             Console.WriteLine(sonuc1);
             sonuc1=sayi1+sayi2;
             Console.WriteLine(sonuc1);
             sayi1+=1;
             Console.WriteLine(sayi1);
            Console.WriteLine("Mod Sonucu");
             //mod al %
             int sonuc2 = 20%3;
             Console.WriteLine(sonuc2);


        }
    }
}
