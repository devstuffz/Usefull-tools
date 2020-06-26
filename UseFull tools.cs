using System;


namespace UsefullTools
{

    class MathTools
    {
        public static void AddInt(int num1, int num2)
        {
            string answer = (num1 + num2).ToString();

            Console.WriteLine(answer);
        }


        public static void AddFloat(float num1, float num2)
        {
            string answer = (num1 + num2).ToString();

            Console.WriteLine(answer);
        }

        public static void SubtractInt(int num1, int num2)
        {
            string answer = (num1 - num2).ToString();

            Console.WriteLine(answer);
        }

        public static void SubtractFloat(float num1, float num2)
        {
            string answer = (num1 - num2).ToString();

            Console.WriteLine(answer);
        }

        public static void MultiplyInt(int num1, int num2)
        {
            string answer = (num1 * num2).ToString();

            Console.WriteLine(answer);
        }

        public static void MultiplyFloat(float num1, float num2)
        {
            string answer = (num1 * num2).ToString();

            Console.WriteLine(answer);
        }

        public static void DivideInt(int num1, int num2)
        {
            string answer = (num1 / num2).ToString();

            Console.WriteLine(answer);
        }

        public static void DivideFloat(float num1, float num2)
        {
            string answer = (num1 / num2).ToString();

            Console.WriteLine(answer);
        }
    }


    class Tools
    {
        public static void Print(string ToWrite)
        {
            Console.WriteLine(ToWrite);
        }
        
        public static void Introduction(string appName, string appDev, string appVersion)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} by {1} Version : {2}", appName, appDev, appVersion);
            Console.ResetColor();
        }

        public static void Beep(int Beeps)
        {
            for (int i = 0; i < Beeps; i++)
            {
                Console.Beep();
            }
        }

     
        //skips lines
        public static void SkipLines(int Skips)
        {
            for (int i = 0; i < Skips; i++)
            {
                Console.WriteLine("");
            }
        }


    
      
    }
}
