// Output

Console.WriteLine("Hello World"); // new line at the end of string
Console.Write("Hello World "); // no new line at the end of string
Console.Clear(); // clears the console

// Input
 
Console.ReadLine(); // reads a line of text from the console
Console.Read(); // reads a single character from the console
Console.ReadKey(); // reads a key press, including special keys like function keys.

// How to get any key (e.g. arrow, esc, enter) without displaying it
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine(key.Key.ToString()); // output key
if (key.Key == ConsoleKey.Enter) return;
