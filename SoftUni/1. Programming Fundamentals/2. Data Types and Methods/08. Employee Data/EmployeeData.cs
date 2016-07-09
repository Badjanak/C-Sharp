using System;

class EmployeeData
{
    static void Main()
    {
        string name = "Amanda";
        string lastName = "Jonson";
        byte age = 27;
        char gender = 'f';
        string id = "8306112507";
        ushort uen = 3571;

        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: 2756{5}", name, lastName, age, gender, id, uen);
    }
}