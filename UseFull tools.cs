using System;


namespace UsefullTools
{
    //MathTools
    class MathTools
    {
        public static class Special
        {
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

