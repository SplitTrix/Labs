using System;

class Lab3C {
    public static void Main(string[] args) {
        int iQuarters = 0;
        int iDimes = 0;
        int iNickels = 0;
        int iPennies = 0;

        Console.Write("Enter the number of quarters: ");
        iQuarters = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of dimes: ");
        iDimes = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of nickels: ");
        iNickels = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of pennies ");
        iPennies = int.Parse(Console.ReadLine());

        Console.WriteLine($"You entered {iQuarters} quarters.");
        Console.WriteLine($"You entered {iDimes} dimes.");
        Console.WriteLine($"You entered {iNickels} nickels.");
        Console.WriteLine($"You entered {iPennies} pennies.");

        int iTotalCents = (iQuarters * 25) + (iDimes * 10) + (iNickels * 5) + (iPennies);
        int iDollars = iTotalCents / 100;
        int iCents = iTotalCents % 100;
        Console.WriteLine($"Your total is {iDollars} dollars and {iCents} cents.");
    }
}