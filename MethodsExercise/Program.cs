using System;

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

		Console.WriteLine("\n"); // Adding in a new line to make the math more readable
		Console.WriteLine("If we call the Sum method with the numbers three and four, we get the following output:"); // Setting up a reason to call Sum
		Console.WriteLine(Sum(3, 4)); // calling the Sum method with the numbers there and four (for exercise #2)

		Console.WriteLine("If we call the Sub method with the numbers four and three, we get the following output:"); // Setting up a reason to call Sub
		Console.WriteLine(Sub(4, 3)); // calling the Sub function with the numbers four and three (for exercise #2)

		Console.WriteLine("If we call the Mult method with the numbers three and four, we get the following output:"); // Setting up a reason to call Mult
		Console.WriteLine(Mult(3, 4)); // calling the Mult function with the numbers three and four (for exercise #2)

		Console.WriteLine("If we call the Divis method with the numbers six and three, we get the following output:"); // Setting up a reason to call Divis
		Console.WriteLine(Divis(6, 3));// calling the Divis function with the numbers six and three (for exercise #2)
	}
		

	// method definition and remember, Pascal case. Start with the access modifier - return type - method name - parameter list - scope (what the method does)
        public static void Story (string name, string least, string animal, string band)
	    {
		Console.WriteLine($"Hello dear reader, and welcome to the story of {name}. Today we are going to tell a tale of woe, where our hero {name} was tragically accosted by a {least}-colored {animal}. Normally, {name} is a big fan of {animal}, but something about the site of the {least} just made their blood run cold. Our hero was right to be concerned, as immediately upon laying eyes on our hero, the {least}-colored {animal} ran across the helicopter pad. Unfortunately for the {animal} it couldn't hear the helicopter landing on its head, and {name} was saved. Woooo! While the crowd went wild with cheering, the music of {band} slowly faded in, and we all rocked out until the credits roll.");
	    }

	
	public static int Sum (int a, int b) // method declaration
	{
		return a + b; // return the math

	}

	public static int Sub (int a, int b) // declare the method
	{
		return a - b; // return the math
	}
	public static int Mult (int a, int b) // declare the method
	{
		return a * b; // return the math
	}
	public static int Divis (int a, int b) // declare the method
	{
		return a / b; // return the math
	}
    }
}

