using System;
using System.IO;

namespace LexiconTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise = 0;
            bool goOn = true;

            while (goOn)
            {

                Console.WriteLine("Gör ditt val, 0 för att avsluta.");
                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 0:
                        goOn = false;
                        break;

                    case 1:
                        Console.WriteLine("Hello World!");
                        break;

                    case 2:
                        NameAndAge();
                        break;

                    case 3:
                        ChangeColor();
                        break;

                    case 4:
                        DateToday();
                        break;

                    case 5:
                        LargestOfTwoValues();
                        break;

                    case 6:
                        GuessMyNumber();
                        break;
                    case 7:
                        WriteToDisk();
                        break;
                    case 8:
                        ReadFromDisk();
                        break;
                    case 9:
                        SomeCalculus();
                        break;
                    case 10:
                        Multiplication();
                        break;
                    case 11:
                        SortingARandomArray();    
                        break;
                    case 12:
                        Palindrome();             
                        break;
                    case 13:
                        NumbersBetween();
                        break;
                    case 14:
                        SortingOddsAdEvens();
                        break;
                    case 15:
                        AddInput();
                        break;
                    case 16:
                        CreateCharacter();
                        break;
                }


            }
        }

        static void NameAndAge()
        {
            Console.WriteLine("Förnamn: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Efternamn: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Ålder: ");
            string age = Console.ReadLine();

            Console.WriteLine("Du heter " + firstname + " " + lastname + " och är " + age + " år gammal.");
            Console.WriteLine();
        }

        static void ChangeColor()
        {
            if (Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
        }
        static void DateToday()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
        }

        static void LargestOfTwoValues()
        {
            Console.WriteLine("Mata in ett tal: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Ett tal till: ");
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne + " är störst.");
            }
            else if (numberOne == numberTwo)
            {
                Console.WriteLine("Talen är lika stora.");
            }
            else
            {
                Console.WriteLine(numberTwo + " är störst.");
            }
            Console.WriteLine();
        }

        static void GuessMyNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            int guess;
            int guesses = 0;

            while (true)
            {
                Console.WriteLine("Gissa ett tal, 1-100");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess == number)
                {
                    Console.WriteLine("Du gissade rätt!!! Det tog dig " + guesses + " gissningar");
                    break;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Du gissade för högt.");
                }
                else
                {
                    Console.WriteLine("Du gissade för lågt.");

                }
            }
            Console.WriteLine();

        }

        static void WriteToDisk()
        {
            Console.WriteLine("Skriv in något du vill skriva till filen dummy.txt");
            string text = Console.ReadLine();
            File.WriteAllText("dummy.txt",text) ;
            Console.WriteLine();
        }
        static void ReadFromDisk()
        {
            Console.WriteLine("Hämtar innehållet i filen dummy.text som du tidigare skrivit in.");
            Console.WriteLine(File.ReadAllText("dummy.txt"));
            Console.WriteLine();
        }

        static void SomeCalculus()
        {
            Console.WriteLine("Skriv in ett tal.");

           float number = float.Parse(Console.ReadLine());

            Console.WriteLine("Roten ur " + number + " är: " + Math.Sqrt(number));
            Console.WriteLine("Kvadraten  av " + number + " är: " + number*number);
            Console.WriteLine(number + " upphöjt till 10 är: " + Math.Pow(number,10));
            Console.WriteLine();
        }


        static void Multiplication()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(string.Format("{0,4}", (i * j)));
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        
        static void SortingARandomArray() //11
        {
            Random rnd = new Random();
            int[] array1 = new int[20];
            int[] array2 = new int[20];

            Console.WriteLine();
            Console.WriteLine("Slumpar fram en array");

            for (int i=0; i<20 ; i++){
                array1[i] = rnd.Next(1, 100);            
                array2[i] = array1[i];
                Console.Write(array1[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Samma array sorterad");            
            Array.Sort(array2);
            
            foreach (int value in array2)
            {
                Console.Write(value + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Palindrome()
        {
            Console.WriteLine("Skriv in ett ord så kollar jag om det är en palindrome.");
            string word = Console.ReadLine();
            bool palindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1]){
                    palindrome = false;
                }
            }
            if (palindrome)
            {
                Console.WriteLine("Ordet är en palindrom.");
            }
            else
            {
                Console.WriteLine("Ordet är ingen palindrom.");
            }
        }

        static void NumbersBetween()
        {
            
            Console.WriteLine("Skriv in ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal till");
            int tal2 = int.Parse(Console.ReadLine());

            if (tal1 > tal2)
            {
                int tmp = tal1;
                tal1 = tal2;
                tal2 = tmp;
            }
            Console.WriteLine(tal1);
            Console.WriteLine(tal2);
            Console.WriteLine("Talen mellan dina två tal är:");
            for (int i = tal1 +1; i < tal2; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void SortingOddsAdEvens()
        {
            Console.WriteLine("Skriv in ett antal kommaseparerade heltal.");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            Array.Sort(numbers);

            Console.WriteLine("Udda tal: ");
            foreach (int i in numbers)
            {
                if ((i % 2) == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Jämna tal: ");
            foreach (int i in numbers)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void AddInput()
        {
            Console.WriteLine("Skriv in ett antal kommaseparerade heltal så adderar jag dem åt dig.");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine("Summan blir: " + sum); 
        }

        static void CreateCharacter()
        {
            Random rnd = new Random();

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Vad heter din motståndare?");
            string opponent = Console.ReadLine();

            Character You = new Character(name, rnd.Next(3, 18), rnd.Next(3, 18), rnd.Next(3, 18));

            Console.WriteLine(name + ", dina värden är: ");
            Console.WriteLine("Styrka: " + You.Strength);
            Console.WriteLine("Hälsa:  " + You.Health);
            Console.WriteLine("Tur:    " + You.Luck);

            Character Opponent = new Character(name, rnd.Next(3, 18), rnd.Next(3, 18), rnd.Next(3, 18));

            Console.WriteLine(Opponent + ", dina värden är: ");
            Console.WriteLine("Styrka: " + Opponent.Strength);
            Console.WriteLine("Hälsa:  " + Opponent.Health);
            Console.WriteLine("Tur:    " + Opponent.Luck);
        }
    }
}
