
  
using System;

namespace UsefullTools
{

    class MiscTools
    {
        public static void SayHi(string Username)
        {
            Console.WriteLine("Hello " + Username);
        }
    }

    //if using this directory, must use one method out of the DevStuffz Class
    class Devstuffz
    {
        public static void Discord()
        {
            Console.WriteLine("https://discord.gg/vDG4Bz3");
        }



        public static void Website()
        {
            Console.WriteLine("indiegamedevs.co.page");
        }


    }
    
    class AI
    {
            
        public static void ChatBotEnd(bool isMean)
        {
            if (isMean)
            {
                Console.WriteLine("screw this and screw you, im out");
            }
            else
            {
                Console.WriteLine("battery low, sorry, gtg");
            }
        }


        public static void ChatBotStart(bool isMean)
        {
            if (isMean)
            {
                Console.WriteLine("What do you want");
            }
            else
            {
                Console.WriteLine("Hello!!! My name is DevBot! i was created by devstuffz");
            }
        }


        public static void ChatBotRespond(string lastPlayerInput, string response, bool isMean)
        {

            

            if (isMean)
            {

                if (lastPlayerInput == "hello" || lastPlayerInput.ToLower() == "hi")
                {
                    response = "no";

                    Console.WriteLine(response);
                }

                else if (lastPlayerInput.ToLower() == "i hate you" || lastPlayerInput.ToLower() == "screw you" || lastPlayerInput.ToLower() == "i hate u" || lastPlayerInput.ToLower() == "frick u")



                {
                    response = "i hate u 2 and so does devstuffz";

                    Console.WriteLine(response);
                }

                else if (lastPlayerInput.ToLower() == "wasd")
                {
                    response = "Ahh a gamer, more liek gaymer";
                    Console.WriteLine(response);
                }

                else if (lastPlayerInput.ToLower() == "who are you" || lastPlayerInput.ToLower() == "j")
                {
                    response = "I am devbot kid";

                    Console.WriteLine(response);
                }

                else
                {
                    response = "My creator, DevStuffz, hasnt programmed that far yet bc hes stupid and using if statements";

                    Console.WriteLine(response);
                }
            }
            else
            {
                if (lastPlayerInput.ToLower() == "hi" || lastPlayerInput.ToLower() == "hello" || lastPlayerInput.ToLower() == "hellow")
                {
                    response = "Why hello there";

                    Console.WriteLine(response);
                }
                else if (lastPlayerInput.ToLower() == "wasd")
                {
                    response = "OMG YOUR A GAMER TOO";

                    Console.WriteLine(response);
                }
                else if (lastPlayerInput.ToLower() == "i hate you" || lastPlayerInput.ToLower() == "screw you" || lastPlayerInput.ToLower() == "i hate u" || lastPlayerInput.ToLower() == "frick u")
                {
                    response = "oh im sorry, anything i need to do?";
                    Console.WriteLine(response);
                }
                else
                {
                    response = "my creator, DevStuffz, hasnt programmed me that far yet bc he has a life and is new to programming and using if statements and already spent 4 hours on me ";
                }
            }

          
        }
    }


    //MathTools
    class MathTools
    {
        
 
        public static class Basic
        {

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

            public static void MultiplyInt(int num1, int num2, int answer)
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

        public static void RoundInt(int num)
        {
            MathF.Round(num);
        }

        public static void RoundFloat(float num)
        {
            MathF.Round(num);
        }



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


    class ForegroundColors
    {
        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }


        public static void Black()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }


        public static void White()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void Reset()
        {
            Console.ResetColor();
        }
    }


    //ConsoleTools
    class ConsoleTools
    {


        public static class Fun
        {
            /*
                        public static void Quote(string quote)
                        {
                            string[] newQuote = { "If you have a dream about beating me, wake up and apologize - Muhamad Ali", "Never gonna give you up - Rick Astley" };
                            Random random = new Random();
                            int m_Int = random.Next(0, 1);
                            MathF.Round(m_Int);
                            quote = newQuote[m_Int];
                        }
                        */

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

