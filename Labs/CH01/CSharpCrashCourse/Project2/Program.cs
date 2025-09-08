////Loops - Make your program POWERFUL - Write a little bit of code, that does something repetitively
////and makes your program DO a lot of work

////Count Controlled Loop
////PreTest loop - The condition is tested before the body executes the first iteration of the loop

//Fizz Buzz
//Write a program that prints the numbers from 1 to N (where N is a given upper limit).
//For numbers divisible by 3, print "Fizz" instead of the number.
//For numbers divisible by 5, print "Buzz" instead of the number.
//For numbers divisible by both 3 and 5, print "FizzBuzz" instead of the number.

Console.WriteLine("What is the upper limit of our Fizz Buzz?");
int upperLimit = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= upperLimit; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}

//unary
//i++

//binary operator
//i+3

//Ternary Conditional Operator
//Short Hand for if-else

//int i = 100;

//string result = i < 200 ? "i less than 200" : "i greater or equal to 200";