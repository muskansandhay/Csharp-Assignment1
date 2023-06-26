using System;

namespace Assignment1
{
    //properties
    public class Patient
    {
        public string _firstName;
        public string _lastName;
        public double _weight;
        public double _height;

        //constructors
        public Patient(string fname, string lname, double height, double weigth)
        {
            _firstName = fname;
            _lastName = lname;
            _weight = weigth;
            _height = height;

        }

        public Patient() { }

        //methods
        public string calculateBP(int SYSTOLIC,int DIASTOLIC)
        {
            string msg;
            if (SYSTOLIC<120&& DIASTOLIC<80) {
                msg = "normal";
            }else if ((SYSTOLIC >= 120&& SYSTOLIC<=129 )&& (DIASTOLIC <80))
            {
                msg = "Elevated";
            }else if ((SYSTOLIC >= 130 && SYSTOLIC<=139 )|| (DIASTOLIC >=80 && DIASTOLIC <= 89))
            {
                msg = "High Blood Pressure(Hypertension stage 1)";
           }else if (SYSTOLIC >=140 && DIASTOLIC >=90 )
            {
                msg = "High Blood Pressure(Hypertension stage 2)";
            }
            else if (SYSTOLIC < 180 && DIASTOLIC < 120)
            {
                msg = "HYPERTENSIVE CRISIS( Consult a doctor )";
            }
            else
            {
                msg = "not a valid input";
            }
            return msg;
        }

        public double calculateBMI()
        {
            return (_weight *10000/ (_height * _height));
        }

        public void printingInfo()
        {
            Console.WriteLine("fullName: " + _firstName + " " + _lastName);
            Console.WriteLine("weight: " + _weight);
            Console.WriteLine("Height: " + _height);
            Console.WriteLine("blood pressure: "+calculateBP(120,80));
            Console.WriteLine("BMI: " + calculateBMI());

            double bmi = calculateBMI();
            if (bmi >= 25.0)
            {
                Console.WriteLine("BMI Status: Overweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("BMI Status: Normal (In the healthy range)");
            }
            else
            {
                Console.WriteLine("BMI Status: Underweight");
            }


        }
    }

    
}
