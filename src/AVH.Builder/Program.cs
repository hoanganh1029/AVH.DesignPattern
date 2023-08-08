// See https://aka.ms/new-console-template for more information

using AVH.Builder.Builders;
using AVH.Builder.Enums;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection()
    .AddSingleton<IDebitCardBuilder, DebitCardBuilder>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var debitCardBuilder = serviceProvider.GetRequiredService<IDebitCardBuilder>();


var diamonCard = debitCardBuilder
    .WithCardNumber("1234 5678 0000")
    .WithName("Andy Smith")
    .WithType(DebitCardType.Diamond)
    .WithEnableContactless(true)
    .Build();

Console.WriteLine(diamonCard.DisplayInformation());


var normalCard = debitCardBuilder.FromDefault()
    .WithCardNumber("9876 5678 2222")
    .WithName("Lisa Cruise")
    .WithType(DebitCardType.Normal)
    .Build();

Console.WriteLine(normalCard.DisplayInformation());