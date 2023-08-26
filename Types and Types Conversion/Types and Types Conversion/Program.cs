using Types_and_Types_Conversion;

// Anonymous data types: var and dynamic

// var
// type is set during compile time, its type can't be changed afterwards, meaning whatever type its initial value is, all modifications must be of that type

// Example: (error)
//var name = "Name";
//name = 15; // Error


// dynamic
// type is set during runtime, its type can be changed afterwards, unlike var

// Example: (okay)
    // dynamic name_2 = "Step";
    // Console.WriteLine(name_2.ToLower());
    // name_2 = 15.35;