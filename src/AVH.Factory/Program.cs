// See https://aka.ms/new-console-template for more information
using AVH.Factory.Enums;
using AVH.Factory.Factories;

Console.WriteLine("Start Factory Pattern");

var bankAccountFactory = new BankAccountFactory();

while (true)
{    
    Console.Write("Enter type of bank account (0,1,2,3,4): ");

    var strType = Console.ReadLine();
    if (!int.TryParse(strType, out var type) || !Enum.IsDefined(typeof(BankAccountType), type))
    {
        Console.WriteLine("Invalid input" + Environment.NewLine);
        continue;
    }

    var bankAccountType = (BankAccountType)(type);

    try
    {
        var bankAcocunt = bankAccountFactory.Create(bankAccountType);
        var result = bankAcocunt.GetBankAccountInformation() + Environment.NewLine
            + bankAcocunt.GetCreditCard().GetCardInformation();

        Console.WriteLine(result + Environment.NewLine);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex + Environment.NewLine);
    }       
}
