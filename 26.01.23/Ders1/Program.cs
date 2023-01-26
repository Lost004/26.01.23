using System;

namespace Ders1
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                int birinci, ikinci, ucuncu;
                Console.WriteLine("Birinci ededi daxil edin!");
                birinci = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ikinci ededi daxil edin!");
                ikinci = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ucuncu ededi daxil edin!");
                ucuncu = Convert.ToInt32(Console.ReadLine());

                if (birinci > ikinci)
                {
                    if (ucuncu > ikinci)
                    {
                        Console.WriteLine("En boyuk reqem:" + birinci);
                    }
                    else
                    {
                        Console.WriteLine("En boyuk reqem;" + ucuncu);
                    }
                }
                else
                {
                    if (ikinci > ucuncu)
                    {
                        Console.WriteLine("En boyuk reqem!" + ikinci);
                    }
                    else
                    {
                        Console.WriteLine("En boyuk reqem:" + ucuncu);
                    }
                }
            }
    }
}
