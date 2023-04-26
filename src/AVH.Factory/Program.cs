// See https://aka.ms/new-console-template for more information
using AVH.Factory.Constants;
using AVH.Factory.Enums;
using AVH.Factory.Factories.AbstractFactory;
using AVH.Factory.Factories.FactoryMethod;
using Microsoft.Extensions.DependencyInjection;


var serviceProvider = new ServiceCollection()
    .AddSingleton<IBankAccountCardAbstractFactory, PersonalBankAccountCardAbstractFactory>()
    .AddSingleton<IBankAccountCardAbstractFactory, BusinessBankAccountCardAbstractFactory>()
    .AddSingleton<IBankAccountFactory, BankAccountFactory>()
    .AddSingleton<ICreditCardFactory, CreditCardFactory>()
    .BuildServiceProvider();

Console.WriteLine("Start Factory Pattern");

var bankAccountFactory = serviceProvider.GetRequiredService<IBankAccountFactory>();
var bankAccountCardAbtractFactoryServices = serviceProvider.GetServices<IBankAccountCardAbstractFactory>();

while (true)
{
    Console.Write("Enter pattern: 1 - Factory Method, 2 - Abstract Factory: ");

    if (!int.TryParse(Console.ReadLine(), out var factoryType))
    {
        Console.WriteLine("Invalid input of factory type" + Environment.NewLine);
        continue;
    }

    switch (factoryType)
    {
        case 1:
            DoFactoryMethod();
            break;
        case 2:
            DoAbstractFactory();
            break;
        default:
            Console.WriteLine("Invalid input of factory type" + Environment.NewLine);
            break;
    }
}

#region Factory
void DoFactoryMethod()
{
    Console.Write("Enter type of bank account (0,1,2,3,4): ");

    var strType = Console.ReadLine();
    if (!int.TryParse(strType, out var type) || !Enum.IsDefined(typeof(BankAccountType), type))
    {
        Console.WriteLine("Invalid input" + Environment.NewLine);
        return;
    }

    var bankAccountType = (BankAccountType)(type);

    try
    {
        var bankAcocunt = bankAccountFactory.Create(bankAccountType);
        var result = bankAcocunt.GetBankAccountInformation();

        Console.WriteLine(result + Environment.NewLine);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex + Environment.NewLine);
    }
}
#endregion

#region Abstract Factory
void DoAbstractFactory()
{
    #region Init abstract factory
    Console.Write("Enter type Peronal - 0, Business - 1: ");
    var strType = Console.ReadLine();
    if (!ValidateInputAsEnum(strType, typeof(AccountCardType)))
    {
        return;
    }
    var accountCardType = Enum.Parse<AccountCardType>(strType);

    if (!CommonConstant.DictionaryAbstractFactoryType.TryGetValue(accountCardType, out var factoryType))
    {
        Console.WriteLine($"Type {accountCardType} is not implemented");
        return;
    }

    IBankAccountCardAbstractFactory? bankAccountCardAbstractFactory;
    bankAccountCardAbstractFactory = bankAccountCardAbtractFactoryServices.FirstOrDefault(x => x.GetType() == CommonConstant.DictionaryAbstractFactoryType[accountCardType]);
    if (bankAccountCardAbstractFactory == null)
    {
        Console.WriteLine($"Factory type {factoryType?.Name} is not registered in DI");
        return;
    }
    #endregion


    Console.Write("Enter type of bank account (0,1,2,3,4): ");
    strType = Console.ReadLine();
    if (!ValidateInputAsEnum(strType, typeof(BankAccountType)))
    {
        return;
    }
    var bankAccountType = Enum.Parse<BankAccountType>(strType);


    Console.Write("Enter type of credit card (0,1,2,3,4): ");
    strType = Console.ReadLine();
    if (!ValidateInputAsEnum(strType, typeof(CreditCardType)))
    {
        return;
    }
    var creditCardType = Enum.Parse<CreditCardType>(strType);


    try
    {
        var bankAccountCard = bankAccountCardAbstractFactory.Create(bankAccountType, creditCardType);

        var result = $" {bankAccountCard.BankAccount.GetBankAccountInformation()}\n {bankAccountCard.CreditCard.GetCardInformation()}";

        Console.WriteLine(result + Environment.NewLine);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex + Environment.NewLine);
    }
}

bool ValidateInputAsEnum(string strInput, Type type)
{
    if (string.IsNullOrEmpty(strInput) || !int.TryParse(strInput, out var input) || !Enum.IsDefined(type, input))
    {
        Console.WriteLine("Invalid input" + Environment.NewLine);
        return false;
    }
    return true;
}

#endregion