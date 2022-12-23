// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// можно любой метод выполнять void, но желательно использовать под свои задачи
int NumDigits(int num) // пишем название метода
{
    int count = 0;

    while(num != 0)   // не равно 0
    {
         count++;
         num /= 10;    //num = num / 10;
    }     
         return count;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumDigits(number);
Console.WriteLine($"Number {number} consists of {result} digits ");
