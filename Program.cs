using System;

namespace SwapElephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };

            Console.Write("Press 1 for Lloyd, 2 for Lucinda, 3 to swap ");

            #region MyWay
            //while (true)
            //{
            //    string line = Console.ReadLine();
            //    if (int.TryParse(line, out int i) )
            //    {
            //        if (i == 1) lloyd.WhoAmI(); 
            //        if (i == 2) lucinda.WhoAmI();
            //        if (i == 3)
            //        {
            //            Elephant newElephant = lucinda;
            //            lucinda = lloyd;
            //            lloyd = newElephant;
            //            Console.WriteLine("References have been swapped");

            //        }                                  
            //    }
                #endregion

            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine();
                Console.WriteLine("You pressed " + input);


                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been swapped");
                }
                else if (input == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if (input == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi Lloyd!");
                }

                else return;
                Console.WriteLine();
            }

        }
    }
}