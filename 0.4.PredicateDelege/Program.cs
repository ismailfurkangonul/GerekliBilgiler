using System;
using System.Collections.Generic;

namespace _0._4.PredicateDelege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> musteriler = new() {
             new Customer{Id=0,Name="Furkan",Surname="Gonul"},
             new Customer{Id=1,Name="Dries",Surname="Mertens"}
             };
            musteriler.Remove(musteriler.Find(x => x.Id == 0)); //predicate example

            Console.WriteLine("Hello World!");
        }
    }
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }



    }
}
