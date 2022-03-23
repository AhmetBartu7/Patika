using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            


            // Rekürsif - Öz Yineleme
            

            int result =1;
            for (int i=1; i<5; i++)
            result = result =3;
            System.Console.WriteLine(result);

            Islemler instance = new();
            System.Console.WriteLine(instance.Expo(3,4));

        
            //Extension Metotlar
        string ifade = "BB7";
        bool sonuc = ifade.CheckSpaces();
        System.Console.WriteLine(sonuc);
        if(sonuc)
        
        System.Console.WriteLine(ifade.RemoveWhiteSpaces());
        System.Console.WriteLine(ifade.MakeUpperCase());
        System.Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi = {9,3,6,2,5,0};
        
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi =5;
        System.Console.WriteLine(sayi.IsEvenNumber());  
        System.Console.WriteLine(ifade.GetFirstCharacter());   




        }
    }

    public class Islemler
{
    public int Expo (int sayi, int üs)
    {
        if(üs<2)
        return sayi;
        return Expo(sayi, üs-1)*sayi;
    }

    //Expo(3,4)
    //Expo(3,3)*3;
    //Expo(3,2)*3*3;
    //Expo(3-1)*3*3*3;
    // 3*3*3*3 = 3*4;


}

public static class Extension

{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains("");
    } 

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split("");
        return string.Join("", dizi);

    }

     public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    } 
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param)
    {
        foreach(int item in param)
        System.Console.WriteLine(item);
    }

    public static bool IsEvenNumber(this int param)
    {
        return param%2 ==0;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }

}



}