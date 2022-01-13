

class Person
{
    public int age;
    public Person(int _initialAge)
    {
        // Add some more code to run some checks on initialAge
        if (_initialAge < 0)
        {
            age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
        else
        {
            age = _initialAge;
        }
    }

    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console
        if (age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are old.");
        }
    }

    public void yearPasses()
    {
        // Increment the age of the person in here
        age++;
    }

}