// See https://aka.ms/new-console-template for more information
Console.Write("Enter Grade Point: ");
double numberGrade = Convert.ToDouble(Console.ReadLine());
String letterGrade;
if (numberGrade >= 88)

{

    letterGrade = "A";

}

else if (numberGrade >= 80 && numberGrade <= 87)

{

    letterGrade = "B";

}

else if (numberGrade >= 68 && numberGrade <= 79)

{

    letterGrade = "C";

}

else if (numberGrade >= 60 && numberGrade <= 67)

{

    letterGrade = "D";

}

else

{

    letterGrade = "F";

}

char repeatChar = '=';
int repeatCount = 12;
string repeatedString = new string(repeatChar, repeatCount);
Console.WriteLine(repeatedString +"     " + repeatedString);
Console.WriteLine("|Grade Point     Letter Grade|");
Console.WriteLine(repeatedString +"     " + repeatedString);
Console.WriteLine("{0, -1}{1, -12}{2,5}{3,12}", "|", numberGrade, letterGrade, "|");
repeatCount = 29;
string repeatedString2 = new string(repeatChar, repeatCount);
Console.WriteLine(repeatedString2);


