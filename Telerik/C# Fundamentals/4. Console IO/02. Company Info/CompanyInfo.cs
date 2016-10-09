using System;

class CompanyInfo
{
    static void Main()
    {
        string cName = Console.ReadLine();
        string cAddress = Console.ReadLine();
        string cPhone = Console.ReadLine();
        string cFax = Console.ReadLine();
        if (cFax.Length == 0)
        {
            cFax = "(no fax)";
        }
        string cWebSite = Console.ReadLine();
        string mFName = Console.ReadLine();
        string mLName = Console.ReadLine();
        string mAge = (Console.ReadLine());
        string mPhone = Console.ReadLine();

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}"
                            , cName, cAddress, cPhone, cFax, cWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", mFName, mLName, mAge, mPhone);
    }
}