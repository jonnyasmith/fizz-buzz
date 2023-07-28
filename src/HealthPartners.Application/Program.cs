var game = GameBuilder.Build();
var numbers = Enumerable.Range(1, 100); 

game.Play(numbers, Console.WriteLine);