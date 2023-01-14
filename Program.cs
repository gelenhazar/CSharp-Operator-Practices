using System;

namespace operatorler
{
class Program
{
static void Main(string[] args)
{
   int x = 3;
   int y = 3;
   y = y+2;

   Console.WriteLine(y);
   y+=2;
   Console.WriteLine(y);
   y/=1;
   Console.WriteLine(y);
   x*=2;
   Console.WriteLine(x);

   bool IsSuccess= true;
   bool IsCompleted= false;

   if(IsSuccess && IsCompleted)
   Console.WriteLine("Perfect!");

   if(IsSuccess || IsCompleted)
   Console.WriteLine("Great!");

   if(IsSuccess && !IsCompleted)
   Console.WriteLine("Fine!");

   Console.WriteLine("*******İlişkisel Operatörler******");

   int a = 3;
   int b = 4;
   bool sonuc = a<b;

   Console.WriteLine(sonuc);
   sonuc = a>b;
   Console.WriteLine(sonuc);
   sonuc = a>=b;
   Console.WriteLine(sonuc);
   sonuc = a<=b;
   Console.WriteLine(sonuc);
   sonuc = a==b;
   Console.WriteLine(sonuc);
   sonuc = a!=b;

   Console.WriteLine("*****Aritmetik Operatörler******");

   int sayi1= 10;
   int sayi2= 5;
   int sonuc1= sayi1/sayi2;
   Console.WriteLine(sonuc1);
   sonuc1= sayi1*sayi2;
   Console.WriteLine(sonuc1);
   sonuc1= sayi1+sayi2;
   Console.WriteLine(sonuc1);
   sonuc1= sayi1++;
   Console.WriteLine(sonuc1);
   










}

}
}

