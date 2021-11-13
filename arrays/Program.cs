using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayidizisi ={0,1,2,3,4,5,9,7,8,7,10};

            Console.WriteLine("**** Sırasız Dizi ****");
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("**** Sıralı Dizi ****");
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("**** Array Clear ****");
            Array.Clear(sayidizisi,3,1);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }        
            Console.WriteLine("**** Array Reverse ****");
            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("**** array indexof ****");
            Console.WriteLine(Array.IndexOf(sayidizisi,7));

            Console.WriteLine("**** array resize ****");
            Array.Resize(ref sayidizisi,4);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}
