using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{




    class Program

    {
        static void Main(string[] args)
        {
            //linq1();
            //Linq2();

            //linq3();
            //linq4();
            //linq5();
           // linq6();
           // linq7();
          

        }

       

        public static void linq7()
        {
            //This sample uses select to produce a sequence of strings representing the text version of a sequence of ints.

            int[] numbers= new int[]{4,3,8,1};
            string[] names=new string[]{"one","two","three","four","five","six","seven","eight","nine"};

            var modop = from n in numbers
                select names[n-1];

            foreach (var ab in modop)
            {
                Console.WriteLine(ab);
            }

            Console.ReadLine();




        }

        public static void linq6()
        {
            //produce a sequence of the uppercase and lowercase versions of each word in the original array.
            string[] words = new string[]{"one","two","three"};

            var formatterWords = from w in words
                select new {upper = w.ToUpper(),lower= w.ToLower()};

            foreach (var x in formatterWords)
            {
                Console.WriteLine($"to upper {x.upper} to lower {x.lower}");
            }

            Console.ReadLine();
        }

        public static void linq5()
        {

//            return a sequence of just the names of a list of products.

            List<Product> myProd = GetProductList();

            var pp = from p in myProd
                select p.name;
            foreach (var x in pp)
            {
                Console.WriteLine(x);

            }

            Console.ReadLine();
        }

        public static void linq4()
        {
            //This sample uses select to produce a sequence of ints one higher than those in an existing array of ints.

            int[] numbers = new int[]{5,6,7,8,9};

            var modifiedNumbers = from nos in numbers
                select nos + 1;

            foreach (var nos  in modifiedNumbers)
            {
                Console.WriteLine(nos);
            }

            Console.ReadLine();
        }

        public static void linq3()
        {
            //returns digits whose name is shorter than their value.

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((a, b) => a.Length < b);

            foreach (var name in shortDigits)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }



        //This sample uses where to find all products that are out of stock.

        public static void linq1()
        {
        int[] numbers = new int[] { 10, 1, 5, 8, 2, 3, 7, 9 };

        var set = from n in numbers
                where n < 5
                select n;

            foreach (var n in set)
        {
            Console.WriteLine(n);

        }

        Console.ReadLine();

    }

public static void Linq2()
        {
            List<Product> products = GetProductList();

            var soldOutProducts = from prod in products
                where prod.amt == 0
                select prod;

                        Console.WriteLine("Sold out products:");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine("{0} is sold out!", product.id);
            }

            Console.ReadLine();
        }

        private static List<Product> GetProductList()
        {
            Product[] prodcts = new Product[]
            {
                new Product{id=1,amt=50,name="clothes"},
                new Product{amt=60,id=2,name="books"},
                new Product{id=3,amt  =10,name="toys"},
                new Product{id=4,amt  =70,name="pen"},
                new Product{id=5,amt  =0,name="pencils"},
                new Product{id=6,amt  =100,name="brush"}
            };

            return prodcts.ToList();


        }
    }

    class Product
    {
        public int id { get; set; }
        public int amt { get; set; }
        public String name { get; set; }
    }
}