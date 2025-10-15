using System;
using System.Threading;

class Program
{
    static void Main()
    {
        #region Max Min Call
        //int max= Max(new int[] { 1, 2, 3, 4, 5 });
        //Console.WriteLine(max);
        //int min = Min(new int[] { 1, 3, 5, 6, 7, 9, 32, 12 });
        //Console.WriteLine(min);
        #endregion
        #region Copy Call
        // int[] a= Copy(new int[] { 1, 2, 3, 4, 5 });

        //foreach (int i in a)
        // {
        //     Console.WriteLine(i);
        // }
        #endregion
        #region IndexDelete Call
        //Console.WriteLine("Indexi daxil edin");
        //int index=Convert.ToInt32(Console.ReadLine());
        //int[] array = DeleteIndex(new int[] { 1, 2, 3, 4, 5 },index);
        //foreach (var item in array)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region Add && Delete Call
        //Console.WriteLine("Massive elave etmek istediyiniz ededi daxil edin");
        //int number= Convert.ToInt32(Console.ReadLine());
        //int [] array = Add(new int[] { 1, 2, 3, 4, 5 }, number);

        //Console.WriteLine("Massiveden silmek istediyiniz indexi daxil edin");

        //int index=Convert.ToInt32(Console.ReadLine());
        //int[] array2 = array;
        //array2 = Delete(array, index);
        //foreach (var item in array2)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion
        #region ContainsString Call
        //Console.WriteLine("Cumleni daxil edin");
        //string cumle = Console.ReadLine();
        //Console.WriteLine("Sozu daxil edin");
        //string word = Console.ReadLine();
        //cumle = cumle.ToLower();
        //word = word.ToLower();
        //word=Contains(cumle, word);
        //Console.WriteLine(word);
        #endregion
        #region ContainsChar Call
        //string cumle1= "Salam necesen";
        // char word1 = 's';
        // cumle1 = cumle1.ToLower();

        //string word3 = Contains(cumle1, word1);
        // Console.WriteLine(word3);
        #endregion
        #region Faktorial Call
        Console.WriteLine("Ededi daxil edin");
        int n=Convert.ToInt32(Console.ReadLine());
        int result=Factorial(n);
        Console.WriteLine(result
            );







        #endregion
    }
    #region Min Max

    //public static int Max(int[] a)
    //{
    //    int max = 0;

    //    for (int i = 0; i < a.Length; i++)
    //    {
    //        if (a[i]>max)
    //        {
    //            max = a[i]; 
    //        }
    //    }
    //    return max;
    //}
    //public static int Min(int[] a )
    //{
    //        int min = 1; 
    //    for (int i = 0; i < a.Length; i++)
    //    {

    //        if (a[i] < min)
    //        {
    //            min = a[i];
    //        }
    //    }
    //    return min;
    //}
    #endregion
    #region Copy
    //public static int[] Copy(int[] a)
    //{
    //    int[] b = new int[a.Length];
    //    for (int i = 0; i < a.Length; i++)
    //    {
    //        b[i] = a[i];
    //    }
    //    return b;
    //}
    #endregion
    #region DeleteIndex
    //public static int[] DeleteIndex(int[] a,int index)
    //{
    //    int[] b=new int[a.Length-1];
    //    for (int i = 0; i < a.Length; i++)
    //    {
    //        if (i==index)
    //        {
    //            for (int j = i; j < a.Length-1; j++)
    //            {
    //                a[j] = a[j + 1];
    //            }
    //            Array.Resize(ref a, a.Length - 1);
    //            return a;
    //        }
    //        b[i]=a[i];
    //    }
    //    return b;
    //}

    #endregion
    #region ADD && Delete
    //public static int[] Add(int[] a, int b)
    //{
    //    Array.Resize(ref a, a.Length + 1);
    //    a[a.Length - 1] = b;
    //    return a;
    //}
    //public static int[] Delete(int[] a, int index)
    //{
    //    int[] b = new int[a.Length - 1];
    //    for (int i = 0; i < a.Length; i++)
    //    {
    //        if (a[i] == index)
    //        {
    //            for (int j = i; j < a.Length - 1; j++)
    //            {
    //                a[j] = a[j + 1];
    //            }
    //            Array.Resize(ref a, a.Length - 1);
    //            return a;
    //        }
    //        b[i] = a[i];
    //    }
    //    return b;
    //}
    #endregion
    #region Contains String
    //public static string Contains(string cumle, string word)
    //{
    //    cumle = cumle.ToLower();
    //    word = word.ToLower();
    //    bool isContains = false;
    //    for (int i = 0; i <= cumle.Length - word.Length; i++)
    //    {
    //        bool tapildi = true;
    //        for (int j = 0; j < word.Length; j++)
    //        {
    //            if (cumle[i + j] != word[j])
    //            {
    //                tapildi = false;
    //                break;
    //            }
    //        }
    //        if (tapildi)
    //        {
    //            isContains = true;
    //            break;
    //        }
    //    }
    //    if (isContains)
    //        return "Var";
    //    else
    //        return "Yoxdur";
    //}
    #endregion
    #region Contains String
    //public static string Contains(string cumle, char word1)
    //{
    //    bool isContains = false;
    //    for (int i = 0; i < cumle.Length; i++)
    //    {
    //        if (cumle[i]==word1)
    //        {
    //            isContains = true;
    //            break;
    //        }
    //    }
    //    return isContains ? "Var" : "Yoxdur";
    //}
    #endregion
    #region Faktorial
    static int Factorial(int n)
    {
        if (n == 1) return 1;
        return n * Factorial(n - 1);
    }

    #endregion
}
