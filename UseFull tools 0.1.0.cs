 class UsefullTools
    {
        public static void Random(int m_RandomInt)
        {
            Random random = new Random();

            m_RandomInt = random.Next(1, 10000)
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
