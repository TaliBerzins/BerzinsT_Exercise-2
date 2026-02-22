// See https://aka.ms/new-console-template for more information
Console.ReadLine("Enter Grade Point: ");
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
Console.WriteLine($"The letter grade is: {letterGrade}");

