Console.WriteLine("Welocome into Temperature Scale");
Console.WriteLine("\n");
// Declaring variables
var a = "Choose the Temperature Scale to Convert From : \n 1. Celsius \n 2. Fahrenheit";
var error = "Invalid input! the value must be in integer"; // it will be used in carch block
var input = "Enter the Temperature for the conversion from Celsius to Fahrenheit : ";
var input2 = "Enter the Temperature for the conversion from Fahrenheit to Celsius : ";
string ask = "Do you want to Convert the another Temperature Y/N?";
bool c = true;
while (c)
{
    try
    {
        Console.WriteLine(a);

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write(input);
            double Celsius_temp = Convert.ToDouble(Console.ReadLine());
            
            if (Celsius_temp <= 200)
            {
                double fahrenheit = (Celsius_temp * 9 / 5) + 32;
                Console.WriteLine("\n");
                Console.WriteLine($"The Conversion of {Celsius_temp}°C in Fahrenheit is {fahrenheit}°F");
                Console.WriteLine("\n");
                bool restart = true;
                while (restart)
                {
                Console.WriteLine(ask);
                    var answer = Console.ReadLine();

                    if (answer == "Y" || answer == "y")
                    {
                        restart = false;
                        c = true;
                    }
                    else if (answer == "N" || answer == "n")
                    {
                        c = false;
                        restart = false;
                        Console.WriteLine("Thank You For Using the Temperature Coverter :)");
                    }
                    else
                    {
                        Console.WriteLine("Kindly type 'Y' as yes or 'N' as No ");
                    }
                }
            }
            else
            {
                Console.WriteLine("kindly Enter the temperature upto 200 or less");
                Console.WriteLine("\n");
            }
        } else if (choice == 2)
        {
            Console.Write(input2);
            double fahrenheit_temp = Convert.ToDouble(Console.ReadLine());
            if (fahrenheit_temp <= 200)
            {
                double celsius = (fahrenheit_temp - 32) * 5 / 9;
                Console.WriteLine("\n");
                Console.WriteLine($"The Conversion of {fahrenheit_temp}°F in Celsius is {celsius}°C");
                Console.WriteLine("\n");
                bool restart = true;
                while (restart)
                {


                    Console.WriteLine(ask);
                    var answer = Console.ReadLine();

                    if (answer == "Y" || answer == "y")
                    {
                        restart = false;
                        c = true;
                    }
                    else if (answer == "N" || answer == "n")
                    {
                        c = false;
                        restart = false;
                        Console.WriteLine("Thank You For Using the Temperature Coverter :)");

                    }
                    else
                    {
                        Console.WriteLine("Kindly type 'Y' as yes or 'N' as No ");
                    }
                }
            }
            else
            {
                Console.WriteLine("kindly Enter the temperature upto 200 or less");
                    Console.WriteLine("\n"); 
            }
        }
        else
        {
            Console.WriteLine("Please write a valid input from the given options");
            Console.WriteLine("\n");

            c = true;
           


    }
    }
    catch (FormatException)
    {
        Console.WriteLine(error);
        Console.WriteLine("\n");
    }

}
Console.ReadKey();