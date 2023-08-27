using Ref__Out__In_keywords;

void Change(int num) // By value copy
{
    num = 11234;
}

void RefChange(ref int num) // By Reference (original)
{
    num = 11234;
}

void OutChange(out int num) // By Reference (original)
{
    // when out is specified, the parameter must be assigned in the function at least once
    num = 11234;
    Console.WriteLine(num);

}

void InChange(in int num) // ReadOnly (like const)
{
    //num = 11234; // can't be assigned
    Console.WriteLine(num);
}

void ChangePerosn(Person person) // Reference copy
{
    Console.WriteLine("IN Function Before change: " + person.GetHashCode());
    person.name = "Hesen";

    person = new Person(); // Original doesn't change

    Console.WriteLine("IN Function after change: " + person.GetHashCode());
}

void RefChangePerosn(ref Person person) // Reference Original
{
    Console.WriteLine("IN Function Before change: " + person.GetHashCode());
    person.name = "Hesen";

    person = new Person(); // original changes, it moves to a new address

    Console.WriteLine("IN Function after change: " + person.GetHashCode());
}