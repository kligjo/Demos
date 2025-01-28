
//Create a program that collects and displays personal information:

//Full Name(First and Last)
//Age
//Email Address
//Phone Number
//List of Hobbies (at least 3)


//The program should:

//Welcome the user with a friendly message
//Collect information one field at a time
//Store the hobbies in an array or list

//Name is not empty
//Age is between 0 and 120

//Display all information in a formatted summary

using System;
using System.Collections.Generic;

class PersonalInfoManager
{
    // Declare variables to store personal information
    private string firstName;
    private string lastName;
    private int age;
    private string email;
    private string phoneNumber;
    private List<string> hobbies;

    // Method to collect user input
    public void CollectInformation()
    {
        // TODO: Implement input collection
    }

    // Method to validate email
    private bool IsValidEmail(string email)
    {
        // TODO: Implement email validation
    }

    // Method to validate phone number
    private bool IsValidPhoneNumber(string phone)
    {
        // TODO: Implement phone validation
    }

    // Method to display information
    public void DisplayInformation()
    {
        // TODO: Implement display message
    }
}

class Program
{
    static void Main(string[] args)
    {
        // TODO: Implement main program flow
    }
}
