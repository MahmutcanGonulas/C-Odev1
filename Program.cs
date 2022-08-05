using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger=2;
            //Degiskenlerin ilk degerei null verilebilir
            //aynı isimde degisken olamaz
            //küçük büyük harf ayrımı vardır
            string Degisken=null;
            string degisken=null;

            //1 byte yer kaplar
            //0-255 arası
            byte b=5;

            //1byte yer kaplar
            //-128 127 arası
            sbyte sb=2;

            //2 byte yer kapalr
            //-32 000 +32 000
            short s=5;

            //0 - 65 365
            //2 byte yer kaplar
            ushort us=3;

            //2 byte yer kaplar
            Int16 i16=2;

            //4 byte yer kaplar
            int i=4;

            //4 byte yer kaplar
            Int32 i32 =4 ;
            
            //8 byte yer kaplar
            Int64 i64=4;

            //4 byte yer kaplar
            uint ui=2;

            //8 byte yer kaplar
            long l=4;

            //8 byte yer kaplar
            ulong ul=3;

            //tam ve reel sayı tutar
            //4 byte yer kaplar
            float f=5;

            //8 byte yer kaplar
            double db=8;

            //16 byte
            decimal dc=16;

            //tek karakter
            //2 byte yer kaplar
            char ch='a';

            bool b1=true;
            bool b2=false;

            //DateTime
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);

            object o1='x';
            object o2="y";
            object o3=4;
            object o4=4.3;

            //Bos String
            string str1=string.Empty;
            str1="Deneme";
            string ad="AdDeneme";
            string soyad="SoyadDeneme";
            string tamIsım=ad+ " "+soyad;

            //int
            int int1=5;
            int int2=3;
            int int3=int1*int2;

            bool bb1=10<2;

            //Degisken Donusumleri
            string str2="20";
            int int22=20;
            
        }
    }
}