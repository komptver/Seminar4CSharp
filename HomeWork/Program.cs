/* Task 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.Write("Input an number A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an number B: ");
double B = Convert.ToDouble(Console.ReadLine());

void Two(double A, double B)
{
          Console.WriteLine($"Number {A} in {B} degree = {Math.Pow(A,B)}");
}
Two(A,B);



// Task29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Массивы - набор однотипных данных
// Тип данных [] имя
// Тип данных [] = новый тип данных [] {}

string [] numbers = new string [] {"1", "6", "9", "8", "3", "7", "5","2"};
for(int a = 0; a < numbers.Length; a++)
{
    Console.Write($"{numbers[a]} ");
}

*/

