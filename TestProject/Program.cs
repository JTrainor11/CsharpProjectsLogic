var coin = new Random();
int coinFlipOutcome = coin.Next(1,3);

Console.WriteLine(coinFlipOutcome == 1 ? "Heads" : "Tails");