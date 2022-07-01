using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            int month=DateTime.Now.Month;
            switch(month)
            {
                case 1:
                Console.WriteLine("ocak");
                break;
                case 2:
                Console.WriteLine("subat");
                break;
                case 3:
                Console.WriteLine("mart");
                break;
                case 7:
                Console.WriteLine("temmuz");
                break;
                default:
                break;

            } 
        }
    }
}
