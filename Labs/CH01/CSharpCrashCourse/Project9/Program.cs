using Project9;

//Create an application that creates four classes: Page, Corner, Pancake and Leaf

//Create an interface named ITurnable that contains a method named Turn()

//The 4 classes should implement that interface and a different implementation of Turn()

//In Program.cs Create a List<ITurnable> and add instances of each class to the list

//Write a single method in Program.cs that accepts a List<ITurnable> and calls the
//Turn() method on each item in the list

Leaf leaf = new();
Pancake pancake = new();
Corner corner = new();
Page page = new();

List<ITurnable> turnables = new List<ITurnable> { leaf, pancake, corner, page };

static void Turning(List<ITurnable> t)
{
    foreach (ITurnable turn in t)
    {
        Console.WriteLine(turn.Turn());
    }
}

Turning(turnables);
