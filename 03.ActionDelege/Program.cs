using System;

namespace _03.ActionDelege
{
    //DELEGELER:FUNCTION,ACTION,PREDİCATE
    internal class Program
    {
        static void Main(string[] args)
        {
           


            Action myAction = new Action(() =>
            {
                Console.WriteLine("Basariyla çalıştı");



            });

            myAction.Invoke();
        }


    }
}
