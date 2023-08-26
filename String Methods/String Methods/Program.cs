/* 
 
string is a reference type, but it behaves as a value type practically
its contents are stored in the heap

*/

string name = "hakuna";
string name2 = "hakuna";

name.GetHashCode(); // output: same adddress
name2.GetHashCode(); // output: same adddress

/* ^^^^^^^^^^^^^^
name and name2 have the same address because
c# compiler optimization sees they have the same values
*/

// when we change one of them, the changed one's address changes
name2 = "hakuna matata";

// different addresses:
name.GetHashCode();
name2.GetHashCode();

// works according to the ASCII table
name.ToLower(); // output: hakuna
name.ToUpper(); // output: HAKUNA

// works according to Unicode:
Console.WriteLine(name.ToUpperInvariant());
name.ToLowerInvariant();

// returns index of first found char. if it can't find any, returns -1
Console.WriteLine(name2.IndexOfAny(new char[] {'k', 'u', 'a'}));