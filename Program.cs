namespace COMP003A.Assignment4
{ //Author: Demetrius Richards
  //Course: COMP003A-L01
  //Purpose: Assignment 4
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("For loop section");
            Console.WriteLine("Output a right triangle based on users output");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Enter a positive whole number");
            string input = Console.ReadLine();
            //Converting the user input to an integer
            int limit;
            while (!int.TryParse(input, out limit));
            //We are going to declare the string variable output
            string output = "#";
            for (int i = 0; i < limit; i++)
            {
                // outputting the value of the variable output
                Console.WriteLine("Output:" + output);
                //Concatenate the current value of output with "#"
                output += "#";
            }
            Console.WriteLine("**************************************");
            Console.WriteLine("For-Each Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("**************************************");
            string[] friends = { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Pheobe" };
            //Foreach statement to enumerate the names of each friend in the array
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("**************************************");
            Console.WriteLine("do-while section");
            Console.WriteLine("Output 0-50 by 5s");
            //decale the integer named counter and assign the value 0 
            int counter = 0;
            //do while loop with specified condition
            do
            {
                Console.WriteLine("Counter:" + counter);
                //add 5 to the current value of the counter
                counter += 5;
            } while (counter <= 50);

            Console.WriteLine("********************************************");
            Console.WriteLine("While Secttion");
            Console.WriteLine("if the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output foobar");
            Console.WriteLine("********************************************");
            int limit2;
            while (!int.TryParse(Console.ReadLine(), out limit2));  
            int counter2 = 1;
            //while loop with specified condition
            while (counter2 <= 20)
            {
                string output2 = "";

                if (counter2 % 2 == 0)
                    output2 += "Foo";


                if (counter2 % 5 == 0)
                    output2 += "Bar";


                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                    output2 = "FooBar";

                Console.WriteLine(output != "" ? output2 : counter2.ToString());
                //increment the counter2
                counter2++;
            }






        }   
    }       
}
