// Random

Console.WriteLine(".Next(): "+ Random.Shared.Next());
Console.WriteLine(".Next(min_value): "+ Random.Shared.Next(20));
Console.WriteLine(".Next(min_value, max_value): "+ Random.Shared.Next(20, 50));

Console.WriteLine(".NextDouble(): "+ Random.Shared.NextDouble()); // between 0 and 1
Console.WriteLine(".NextSingle(): "+ Random.Shared.NextSingle()); // between 0 and 1
