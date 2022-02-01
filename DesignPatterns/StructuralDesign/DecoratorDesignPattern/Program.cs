using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Step1: Creating the Car interface
//Create an interface with the name ICar and then copy and paste the following code into it. 
//This interface has one abstract method i.e.ManufactureCar and this method is going to be implemented by
//the concrete subclasses.
namespace DecoratorDesignPattern
{
    public interface ICar
    {
        ICar ManufactureCar();
    }
}

//Step2: Creating Concrete Car
//Create a class file with the name BMWCar and then copy and paste the following code into it.
//This is a concrete class and implements the ICar interface i.e.provides an implementation for the ManufactureCar method.
//What this ManufactureCar method will do is, it will manufacture Car Body, Door, Wheels, and Glass.
//So, when we call this ManufactureCar method it returns the BMW car without an engine.
namespace DecoratorDesignPattern
{
    public class BMWCar : ICar
    {
        private string CarName = "BMW";
        public string CarBody { get; set; }
        public string CarDoor { get; set; }
        public string CarWheels { get; set; }
        public string CarGlass { get; set; }
        public string Engine { get; set; }
        public override string ToString()
        {
            return "BMWCar [CarName=" + CarName + ", CarBody=" + CarBody + ", CarDoor=" + CarDoor + ", CarWheels="
                            + CarWheels + ", CarGlass=" + CarGlass + ", Engine=" + Engine + "]";
        }
        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "4 car doors";
            CarWheels = "6 car glasses";
            CarGlass = "4 MRF wheels";
            return this;
        }
    }
}

//Step3: Creating Car Decorator
//Create a class with the name CarDecorator and then copy and paste the following code into it. 
//This is going to be an abstract class and it also implements the ICar interface i.e.the ManufactureCar method.
//We declare the ManufactureCar method as virtual and this is because it is going to be overridden by the child classes.
namespace DecoratorDesignPattern
{
    public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }
}

//Step4: Creating Diesel Car Decorator
//Create a class file with the name DieselCarDecorator and then copy and paste the following code into it.
//    This is a concrete class and inherited from the CarDecorator abstract class.
//    This class overrides the ManufactureCar method. What this ManufactureCar method will do is,
//    it will add a diesel engine to the car and will return the BMW car with Diesel Engine.
namespace DecoratorDesignPattern
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
            }
        }
    }
}

//Step5: Creating Petrol Car Decorator
//Create a class file with the name PetrolCarDecorator and then copy and paste the following code into it. 
//    It is the same as the DieselCarDecorator. 
//    This means it is also inherited from the CarDecorator class and overrides the ManufactureCar method. 
//    The ManufactureCar method will add the Petrol engine to the car and it will return the BMW car with Petrol Engine.
namespace DecoratorDesignPattern
{
    class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar)
            {
                BMWCar BMWCar = (BMWCar)car;
                BMWCar.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }
}

//Step6: Client code
//The client class contains the Main method.
//    So, please modify the Main method as shown below. Here, first, we create an object of BMWCar and 
//    then call the ManufactureCar method which will create the car without an engine. 
//    Then we create the instance of DieselCarDecorator and pass the BMWCar instance as a parameter to the constructor.
//    And when we call the ManufactureCar method of the DieselCarDecorator instance, then it will add Diesel Engine to the Car.
namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();
            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            Console.ReadKey();
        }
    }
}