using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp4
{
    class LinqExamples
    {
        public void linq9()
        {
            //This sample uses select to produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //eg" Chai is in the category Beverages and costs 18.0000 per unit.

            List<Product> myprod = GetProductList();

            var getprod = from m in myprod
                select new {category = m.category,name =m.name, price = m.amt};

            foreach (var prod in getprod)
            {
                Console.WriteLine($"{prod.name} is in the catergory {prod.category} and costs {prod.price} per unit");
            }

            Console.ReadLine();

        }

        public void linq10()
        {
            // This sample uses an indexed Select clause to determine if the value of ints in an array match their position in the array.

            int[] numbers = { 0, 5, 1, 23, 6 };
             //string[] names = new string[] {"zero", "one", "two", "three", "four", "six"};

          

            var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });
            foreach (var n in numsInPlace)
            {
                Console.Write("{0}: {1}", n.Num, n.InPlace);
            }




        }


        public void linq11()
        {
            //this sample combines select and where to make a simple query that returns the text form of each digit less than 5.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var xxx = from n in numbers
                where n > 5
                select digits[n];

            foreach (var xx in xxx)
            {
                Console.WriteLine(xx);
            }

            Console.ReadLine();
        }


        //public void linq10()
        //{
        //    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //    var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });

        //    Console.WriteLine("Number: In-place?");
        //    foreach (var n in numsInPlace)
        //    {
        //        Console.WriteLine("{0}: {1}", n.Num, n.InPlace);
        //    }
        //}
        public  void linq8()
        {
            // produce a sequence of the uppercase and lowercase versions of each word in the original array.

            string[] names = new string[]{"one", "two", "three"};

            var formattedName = from n in names
                select new {uppercase = n.ToUpper(), lowercase = n.ToLower()};

            foreach (var x in formattedName)
            {
                Console.WriteLine($"lower cases is  {x.lowercase} upper case is {x.uppercase}");
            }

            Console.ReadLine();
        }


        public  void linq7()
        {
            //This sample uses select to produce a sequence of strings representing the text version of a sequence of ints.

            int[] numbers = new int[] { 4, 3, 8, 1 };
            string[] names = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var modop = from n in numbers
                        select names[n - 1];

            foreach (var ab in modop)
            {
                Console.WriteLine(ab);
            }

            Console.ReadLine();




        }

        public  void linq6()
        {
            //produce a sequence of the uppercase and lowercase versions of each word in the original array.
            string[] words = new string[] { "one", "two", "three" };

            var formatterWords = from w in words
                                 select new { upper = w.ToUpper(), lower = w.ToLower() };

            foreach (var x in formatterWords)
            {
                Console.WriteLine($"to upper {x.upper} to lower {x.lower}");
            }

            Console.ReadLine();
        }

        public  void linq5()
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
        public  void linq4()
        {
            //This sample uses select to produce a sequence of ints one higher than those in an existing array of ints.

            int[] numbers = new int[] { 5, 6, 7, 8, 9 };

            var modifiedNumbers = from nos in numbers
                                  select nos + 1;

            foreach (var nos in modifiedNumbers)
            {
                Console.WriteLine(nos);
            }

            Console.ReadLine();
        }

        public  void linq3()
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

        public  void linq1()
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

        public  void Linq2()
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

        private  List<Product> GetProductList()
        {
            Product[] prodcts = new Product[]
            {
                new Product{id=1,amt=50,name="clothes", category = "Essentials"},
                new Product{amt=60,id=2,name="books" ,category = "Essentials"},
                new Product{id=3,amt  =10,name="toys",category = "Fun"},
                new Product{id=4,amt  =70,name="pen",category = "Essentials"},
                new Product{id=5,amt  =0,name="pencils",category = "Essentials"},
                new Product{id=6,amt  =100,name="brush",category = "Essentials"},
                new Product{id=7,amt  =75,name="tent",category = "fun"}
            };

            return prodcts.ToList();


        }
   

    class Product
    {
        public int id { get; set; }
        public int amt { get; set; }
        public string category { get; set; }
        public String name { get; set; }
    }
}
}
