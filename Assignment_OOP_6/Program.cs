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
        }
    }
}
