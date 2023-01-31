using System;
class Car {

 //Fields
        public string make;
        public string model;
        public string registration;
        public int year;
        public double current_value;


        //Add constructor to the Car class using five parameters set to the corresponding fields
        public Car(string make, string model, string registration, int year, double current_value)
        {
            this.make = make;
            this.model = model;
            this.registration = registration;
            this.year = year;
            this.current_value = current_value;
        }
     

        public static void Main(string[] args)
        {
            //Test Class
            Car result = new Car("Ford", "Focus", "G Reg", 1995, 456.78);


            //Override the ToString
            string yearStr = result.year.ToString();
            string valueStr = result.current_value.ToString();

            //Output Results To Console
            Console.WriteLine("The make of the car is a " + result.make + " and the model is a " + result.model + ". The car is a " + result.registration
             + " and was build in the year " + yearStr + " and has a value of " + "£"+valueStr);
        }
}