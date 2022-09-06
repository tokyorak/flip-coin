using console_flipcoin.Model;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

serviceCollection.AddLogging();
serviceCollection.AddSingleton<Coin>();

var app = serviceCollection.BuildServiceProvider();

var coin = app.GetRequiredService<Coin>();

var result = coin.FlipCoin();
System.Console.WriteLine("Result: {0}", result.ToString());

// foreach(var i in Enumerable.Range(0,10))
// {
//     var result = coin.FlipCoin();
//     System.Console.WriteLine("Itteration No {0} - result: {1}", i, result.ToString());
// }
