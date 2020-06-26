using System;
using System.Runtime.Versioning;

namespace UsefullTools
{
    //MathTools
    class MathTools
    {
        public static class Square
        {

            public static void sqrdInt(int Num)
            {
                Num = Num * Num;
            }

            public static void sqrdFloat(float Num)
            {
                Num = Num * Num;
            }

            public static void sqrtInt(int Num)
            {
                Num = Num / Num;

              
            }

            public static void sqrtFloat(float num)
            {
                MathF.Sqrt(num);
            }

        }


        public static void AddInt(int num1, int num2, int answer)
        {
             answer = (num1 + num2);

        }


        public static void AddFloat(float num1, float num2, float answer)
        {
             answer = (num1 + num2);

           
        }

        public static void SubtractInt(int num1, int num2, int answer)
        {
             answer = (num1 - num2);

        
        }

        public static void SubtractFloat(float num1, float num2, float answer)
        {
             answer = (num1 - num2);

 
        }

        public static void MultiplyInt(int num1, int num2,  int answer)
        {
             answer = (num1 * num2);

          
        }

        public static void MultiplyFloat(float num1, float num2, float answer)
        {
             answer = (num1 * num2);

        }

        public static void DivideInt(int num1, int num2, int answer)
        {
             answer = (num1 / num2);

        }

        public static void DivideFloat(float num1, float num2, float answer)
        {
             answer = (num1 / num2);

           
        }


        public static class RandomNum
        { 
        
             public static void Float(float num1, float num2, float answer)
            {
                Random random = new Random();

                int intNumOne = Convert.ToInt32(num1);
                int intNumTwo = Convert.ToInt32(num2);

                answer = random.Next(intNumOne, intNumTwo + 1);
            }    


            public static void Int(int num1, int num2, int answer)
            {
                Random random = new Random();

                answer = random.Next(num1, num2);
            }

        }
    }

    
    //ConsoleTools
    class ConsoleTools
    {
        public static class Fun
        {
            public static void Troll(int length)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine("Never Gonna Give You Up");
                    Console.WriteLine("Never Gonna Let You Down");
                    Console.WriteLine("Never Gonna Run Around");
                    Console.WriteLine("Or Desert You");
                    Console.WriteLine("Never Gonna make you cry");
                    Console.WriteLine("Never Gonna say goodbye");
                    Console.WriteLine("Never gonna tell a lie");
                    Console.WriteLine("Or Hurt You");
                    
                    
                }
            }


            public static void Trianle(int length)
            {

                int i, j, k;
                for (i = 1; i <= length; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write("");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.ReadLine();
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

