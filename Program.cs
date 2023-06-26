using System;
namespace Assignment1
{

    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the system");

            //asking the user to input patient
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //asking user to insert patient information
            Console.WriteLine("\n Enter the patient information:");
            Console.Write("First Name:");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Weight (in KG): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height (in CM): ");
            double height = Convert.ToDouble(Console.ReadLine());

            //Create a Patient object based on user input
            Patient patient = new Patient(firstName, lastName, height, weight);

            //printing patient information
            patient.printingInfo();
            Console.ReadLine();
        }
    }
}