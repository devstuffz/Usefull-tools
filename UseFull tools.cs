using System

namespace YourProgram
{


    class UsefullTools
    {

        public static void Draw()
        {
            Console.WriteLine("O");
            Console.WriteLine("OO");
            Console.WriteLine("OOO");
            Console.WriteLine("OOOO");
        }

        public static void Introduction(string appName, string appDev, string appVersion)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} by {1} Version : {2}", appName, appDev, appVersion);
            Console.ResetColor();
        }
        public static void Random(int m_RandomInt)
        {
            Random random = new Random();

            m_RandomInt = random.Next(1, 10000);
        }

        public static void Beep(int Beeps)
        {
            for (int i = 0; i < Beeps; i++)
            {
                Console.Beep();
            }
        }

        public static void Multiply(int Num1, int Num2)
        {
            Console.WriteLine((Num1 * Num2).ToString());
        }

        //skips lines
        public static void SkipLines(int Skips)
        {
            for (int i = 0; i < Skips; i++)
            {
                Console.WriteLine("");
            }
        }


    
        //adds two ints
        public static void Calculator(int Num1, int Num2)
        {
            Console.WriteLine((Num1 + Num2).ToString());
        }

      
    }
 
}
