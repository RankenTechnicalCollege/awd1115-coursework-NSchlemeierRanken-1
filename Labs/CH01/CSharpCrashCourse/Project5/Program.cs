//Write a CLI application that masks all but the last 4 digits of a credit card number
//with a x
//Leave the last four digits as is.
//Leave any spaces and dashes as is.
//Replace any number or letter with a X
//HINT ** Research Char.IsDigit() & Char.IsLetter()
//The program must support credit card numbers with spaces, dashes, or no seperator.

//P2
//The program should work for credit card numbers that are any length
//(including numbers that are less than four digits long).

//Get User Input
string ccNum;
do
{
    Console.WriteLine("Enter a CC Num");
    ccNum = Console.ReadLine();
} while (string.IsNullOrEmpty(ccNum));

string maskedNum = string.Empty;

//Loop over the ccNum and Build the maskedNum string
for (int index = 0; index < ccNum.Length; index++)
{
    if (ccNum[index] == '-' || Char.IsWhiteSpace(ccNum[index]) || index >= ccNum.Length - 4)
        maskedNum += ccNum[index];
    else
        maskedNum += 'X';
}

//Output the masked number
Console.WriteLine(maskedNum);