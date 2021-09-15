using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema 
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Sisesta matemaatika eksami tulemus:");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta keemia eksami tulemus:");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta bioloogia eksami tulemus:");
            int biology = Convert.ToInt32(Console.ReadLine());

            if(math >= 85 && chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("Tubli! saad arstiks õppida.");
            }
            else
            {
                Console.WriteLine("Proovi järgmine aasta.");
            }



        }
    }
}
