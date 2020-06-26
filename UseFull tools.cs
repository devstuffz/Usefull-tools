using System;


namespace UsefullTools
{
    //MathTools
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

    
    //ConsoleTools
    class ConsoleTools
    {
        
     
        //skips lines
        public static void SkipLines(int Skips)
        {
            for (int i = 0; i < Skips; i++)
            {
                Console.WriteLine("");
            }
        }

        

        public static void RenameTitle(string ConsoleName)
        {
            Console.Title = ConsoleName;
        }
    
      
    }
}

