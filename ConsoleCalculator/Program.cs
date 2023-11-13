namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            double result;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hello, Welcome to the C# Console Calculator");
            Console.WriteLine("--------------------------------------------");

            do
            {

                try
                {

                    Console.ReadLine();

                    Console.WriteLine("Enter a  number:   ");
                    x = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter another  number:   ");
                    y = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("What operation would you like to run?  \n(+)add, (-)subtract, (*)multiply, (/)divide");
                    String operation = Console.ReadLine();

                    Console.ReadLine();


                    // Alternative to many else if statements
                    switch (operation)
                    {

                        case "+":
                            result = add(x, y);
                            Console.WriteLine(result);
                            break;

                        case "-":
                            result = subtract(x, y);
                            Console.WriteLine(result);
                            break;

                        case "/":
                            result = divide(x, y);
                            Console.WriteLine(result);
                            break;

                        case "*":
                            result = multiply(x, y);
                            Console.WriteLine(result);
                            break;

                    }

                    if (y == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    // Ask if the user wants to perform another calculation
                    Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                    string rerun = Console.ReadLine();

                    if (rerun.ToLower() != "yes")
                    {
                        break; // Exit the loop if the user enters anything other than "yes"
                    }

                }


                //Exception handling to make sure use only inputs numeric values  
                catch (FormatException e)
                {
                    Console.WriteLine("Enter numeric values only please");

                } //Exception handling to make sure user does not try to divide by 0 
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("It is not possible to divide by zero!");
                }

                Console.ReadLine();


            } while (true);

            Console.WriteLine("Thank you for using the calculator!");


            Console.ReadKey();

        }

        static double multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }

        static double divide(double x, double y)
        {
            double z = x / y;
            return z;
        }

        static double add(double x, double y)
        {
            double z = x + y;
            return z;
        }
        static double subtract(double x, double y)
        {
            double z = x - y;
            return z;
        }

    }
}
