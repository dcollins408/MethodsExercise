namespace MethodsExercise
{
    public class Program
    {

        static void Main(string[] args)
        {


		Console.WriteLine("Yooooo. What is your name?"); // This is the output, asking your name
		string name = Console.ReadLine(); // there is where input comes in 

		// If you forget to include the $ before the command, where it says {name} it won't interpret, it'll just literally output {name}
	 	Console.WriteLine($"Thanks {name}, now tell me your least favorite color."); // asking for their least favorite color
	    	var least = Console.ReadLine(); // get input from the user

	    	Console.WriteLine($"Good looking out {name}, tell me, what's your favorite animal?"); //What do they like? I mean, for animals
	    	var animal = Console.ReadLine(); // moar user input                      

	    	Console.WriteLine($"What's your mother's maiden name? Just kidding champ. Real last question - who is your favorite band?"); // have a little fun then ask their favorite band
		var band = Console.ReadLine(); // last little bit of user input

		
	        Story(name, least, animal, band); // call the Story method (for exercise #1)
		Mathmagical(name); // call the Math method (for exercise #2)
	}
		

	// method definition and remember, Pascal case. Start with the access modifier - return type - method name - parameter list - scope (what the method does)
        public static void Story (string name, string least, string animal, string band)
	    {
		Console.WriteLine($"Hello dear reader, and welcome to the story of {name}. Today we are going to tell a tale of woe, where our hero {name} was tragically accosted by a {least}-colored {animal}. Normally, {name} is a big fan of {animal}, but something about the site of the {least} just made their blood run cold. Our hero was right to be concerned, as immediately upon laying eyes on our hero, the {least}-colored {animal} ran across the helicopter pad. Unfortunately for the {animal} it couldn't hear the helicopter landing on its head, and {name} was saved. Woooo! While the crowd went wild with cheering, the music of {band} slowly faded in, and we all rocked out until the credits roll.");
	    }

	
	public static void Mathmagical (string name)
	{
		Console.WriteLine($"Hey there {name}, let's have a little fun and do some math! First, give me a number."); // Output, asking the user for a number
		var numberOneString = Console.ReadLine(); // user input for variable one
		int numberOne = Int32.Parse(numberOneString); // convert the user input into an Int

		Console.WriteLine($"Thanks {name}, can you give me a second number as well?"); // Output, asking for a second number
		var numberTwoString = Console.ReadLine(); // user input for variable two
		int numberTwo = Int32.Parse(numberTwoString); // convert the user input into an Int

		int sum = numberOne + numberTwo; // math for the sum.
		Console.WriteLine($"When you add them up, you get {sum}"); // output for the math

		int sub = numberOne - numberTwo; // math for the subtraction. 
		Console.WriteLine($"When you subtract them, you get {sub}"); // output for the math

		int multi = numberOne * numberTwo; // math for the multiplication
		Console.WriteLine($"When you multiply them, you get {multi}"); // output for the math

		double divisio = numberOne / numberTwo; // math for the division
		Console.WriteLine($"When you divide them, you get {divisio}"); // output for the math


	}
    }
}

