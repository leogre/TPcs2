using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace TPcs2
{
    class Program
    {
        static void Main(string[] args)
        {
            who_are_you();
            even_or_odd();
            greater_or_lower(10);
            Console.WriteLine("My mult of 7 time 6");
            my_multiplication(7, 6);
            Console.WriteLine("My eucl div of 12 by 3");
            my_eucl_div(12, 3);
            Console.WriteLine("My pow of 3 power 3");
            my_pow(3, 3);
            Console.WriteLine("My abs of -12");
            my_abs(-12);
            Console.WriteLine("My sqrt of 10");
            my_sqrt(10);
            Console.WriteLine("My fibo of 13");
            my_fibo_iter(13);
            Console.WriteLine("Is prime of 3");
            is_prime(3);
            jedi_or_sith();
            print_alpha();
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Speak("The bulshit is strong with this one");
            SpeechSynthesizer voic = new SpeechSynthesizer();
            voice.Speak("42");
            Console.Read();
        }
       
        static void who_are_you() 
        {
            Console.WriteLine ( "Please , enter your name");
            string x = Console.ReadLine();
            Console.WriteLine("Hi " + x + " !");
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Speak("Hy" + x);
        }

        static void even_or_odd ()
        {
            Console.WriteLine("Please , enter the number");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) 
            {
                Console.WriteLine("Your number is even");
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.Speak("Your number is even");
            }
            else 
            {
                Console.Error.WriteLine("Your number is odd");
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.Speak("Your number is odd");
            }
        }

        static void greater_or_lower(int sup) 
        {
            sup = new Random().Next(0, sup+1);
            Console.WriteLine("You have to find a number between 0 and 10");
            Console.WriteLine("You think that the number is ...?");
            int n = -1;
            for (int nb = 1; n != sup; nb++)
            {
                n = int.Parse(Console.ReadLine());
                if (n > sup) 
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    if (n < sup) 
                    {
                        Console.WriteLine("Greater!");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations ! The secret number is " + sup + " (found after " + nb + " attempts)");
                        SpeechSynthesizer voice = new SpeechSynthesizer();
                        voice.Speak("You win");
                    }
                }
            }
        }

        static int my_multiplication(uint a, uint b) 
        {
            int y = 0;
            int q = Convert.ToInt32(a);
            for (int i = 0; i < b; i++)
            {
                y = y + q;
            }
            Console.WriteLine(y);
            return y;
        }

        static int my_eucl_div(int a, int b) 
        {
            int i = 0;
            while (a > 0) 
            {
                a = a - b;
                i++;
            }
            Console.WriteLine(i);
            return i;
        }

        static long my_pow(int n, int pow) 
        {
            long y = 1;
            for (int i = 0; i < pow; i++)
            {
                y = y * n;
            }
            Console.WriteLine(y);
            return y;   
        }

        static float my_abs(float f)
        {
            if (f < 0)
            {
                f = -f;
                Console.WriteLine(f);
                return f;
            }
            else
            {
                Console.WriteLine(f);
                return f;
            }
            
        }

        static float my_sqrt(int n)
        {
            float x = 1;
            for (int i = 0; i < 5; i++)
            {
                x = (x + n / x)/2;
            }
            Console.WriteLine(x);
            return x;
        }

        static long my_fibo_iter(int n)
        {
            long w = 0;
            long y = 1;
            if (n == 0)
            {
                Console.WriteLine(w);
                return w;
            }
            else
            {
                if (n == 1)
                {
                    Console.WriteLine(y);
                    return y;
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            w = y + w;
                        }
                        else
                        {
                            y = w + y;
                        }
                    }
                    if (y > w)
                    {
                        Console.WriteLine(y);
                    }
                    else
                    {
                        Console.WriteLine(w);
                    }
                    return w;
                }
            }
        }

        static bool is_prime(int n)
        {
            int a = n - 1;
            while (a > 1)
            {
                if (n % a == 0)
                {
                    Console.WriteLine("false");
                    return false;                    
                }
                else
                {
                    a--;
                }
            }
            Console.WriteLine("true");
            return true;
        }

        static void jedi_or_sith()
        {
            Console.WriteLine("Please , enter your name");
            string x = Console.ReadLine();
            int q = x.Length;
            if (is_prime(q) == true)
            {
                Console.WriteLine(x + "is a jedi");
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.Speak(x + "is a jedi");
            }
            else
            {
                Console.WriteLine(x + "is are a sith");
                SpeechSynthesizer voice = new SpeechSynthesizer();
                voice.Speak(x + "is a sith");
                print_vader("       ");
            }
        }

        static void print_alpha()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("a");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("b");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("c");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("d");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("e");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("f");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("g");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Speak(" a b c d e f g       would you like to sing with me?");

        }

        static void print_vader(string space)
        {
            Console.WriteLine(space + "         _.-'~~~~~~`-._");
            Console.WriteLine(space + "        /      ||      \\");
            Console.WriteLine(space + "       /       ||       \\");
            Console.WriteLine(space + "      |        ||        |");
            Console.WriteLine(space + "      | _______||_______ |");
            Console.WriteLine(space + "      |/ ----- \\/ ----- \\|");
            Console.WriteLine(space + "     /  (     )  (     )  \\");
            Console.WriteLine(space + "    / \\  ----- () -----  / \\");
            Console.WriteLine(space + "   /   \\      /||\\      /   \\");
            Console.WriteLine(space + "  /     \\    /||||\\    /     \\");
            Console.WriteLine(space + " /       \\  /||||||\\  /       \\");
            Console.WriteLine(space + "/_        \\o========o/        _\\");
            Console.WriteLine(space + "  `--...__|`-._  _.-'|__...--'\" ");
            Console.WriteLine(space + "          |    `'    |");
        }
                
    }
}
