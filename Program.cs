namespace C__Intro_Övningar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Person!");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine(" Hello " + name + " ! ");



            Console.WriteLine("How old are you " + name);
            const int CurrenctYear = 2026;
            string age = Console.ReadLine();
            int year = int.Parse(age);
            int Birthday = CurrenctYear - year;

            Console.WriteLine("Your are born " + Birthday + "!");



            Console.WriteLine("Can you write a heltal ?");
            string nummer = Console.ReadLine();
            int heltal = int.Parse(nummer);
            Console.WriteLine("Good " + heltal + " Now write a decimaltal");

            string NummerIDecial = Console.ReadLine();
            double decimaltal = double.Parse(NummerIDecial);
            Console.WriteLine("Good " + NummerIDecial + " Now write a ture or false");

            string TrueOrFalse = Console.ReadLine();
            bool TrueFalse = bool.Parse(TrueOrFalse);
            Console.WriteLine("Very good " + name + "! " +  heltal  +  decimaltal  + TrueOrFalse);




            Console.WriteLine("Now write a heltal ");
            string number1 = Console.ReadLine();
            int heltal1 = Convert.ToInt32(number1);
            Console.WriteLine("Your number: " + number1 + " Now write youe secound heltal");

            string number2 = Console.ReadLine();
            int heltal2 = Convert.ToInt32(number2);

            int totalt = heltal1 + heltal2;

            Console.WriteLine("The total is: " + totalt);
            Console.WriteLine("OBS! PREES ENTER!");
            Console.ReadLine();
            Console.WriteLine("Do you wanna know a secret?");

            int totalt2 = heltal1 * heltal2;

            Console.WriteLine(totalt2);





            

        }
    }
}
