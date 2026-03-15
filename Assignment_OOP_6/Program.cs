using System;

namespace Assignment_OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Q1 : What is abstraction in OOP? How is it different from encapsulation? Give a real-world example (not from the session) that shows the difference between the two
            //-- Abstraction is the process of exposing only what the user needs and hiding how it is implemented
            //Abstraction:What an object does/Design level
            //Encapsulation:How data is protected/IMplementation level
            //-- Abstraction decides WHAT to show — Encapsulation decides HOW to protect what's hidden
            //ATM Machine 
            //abstracyion :When you withdraw money from an ATM, you only interact with options like Withdraw, Deposit, and Check Balance do not see the internal banking processes 
            //encapsulation: Your bank account balance is stored securely inside the banking system, and you cannot modify it directly
            #endregion
            #region Question 2
            //Q2 : What is the difference between an abstract class and an interface? Give at least four differences. When would you choose one over the other?
            //1)Abstraction:What you can do - Defines identity & shared behavior -Can have fields and constructors-Methods can have any access modifier - A class can inherit only one abstract class - Can have fields and constructors
            //1)Interface:What you are - Defines roles & capabilities - Cannot have fields or constructors - Methods are public by default - A class can implement multiple interfaces - Cannot have fields or constructors
            //2)Usage
            //Abstraction : You want to provide default behavior ,Classes share common implementation
            //Interfaces:Multiple unrelated classes need the same behavior,You want to define a capability or contract
            #endregion
            #region Question 3
            //a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
            //Because Appliance is an abstract class, and abstract classes cannot be instantiated directly they are meant to be inherited by other classes
            //b) What is the difference between the three methods: PowerConsumption(), Status(), and Label()? Why did the designer make each one abstract, virtual, or concrete?
            //PowerConsumption(): abstract method , has no implementation and every derived class must override it ,Different appliances consume different amounts of power, so each class must define its own implementation
            //Status(): virtual method, has a default implementation but can be overridden by derived classes, allows for a common status message while still giving flexibility for specific appliances to provide their own status if needed
            //Label(): concrete method, has a complete implementation and cannot be overridden,Child classes inherit it as it is provides a standard way to label appliances with their brand name, ensuring consistency across all appliances
            //c) If you call Status() on a Toaster object, what will it return? Why?
            //Standby , because the Toaster class does not override the Status() method, so it uses the default implementation from the base class Appliance
            #endregion
        }
    }
}
