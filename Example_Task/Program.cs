/* Task1. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// можно любой метод выполнять void, но желательно использовать под свои задачи
int NumDigits(int num) // пишем название метода
{
    int count = 0;
    if(num == 0) count = 1;
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



/* Цикл for - всегда три блока
for(int current = -number; current <= number; current++) // инициализируем рабочую переменную current
{
    Console.WriteLine(current + "");
}

Task2. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNums(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num;
        num--;
    }
    return sum;
}
Console.Write("Input an integer number N: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNums(number);
Console.WriteLine($"Sum of numbers from 1 to N is {result}");


// Task3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 1 способ:
int Factorial(int num)
{
    int fact = 1;
    while(num > 1)
    {
        fact *= num;
        num--;
    }
    return fact;
}
Console.Write("Input an integer number N: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Factorial(number);
Console.WriteLine($"Factorial of numbers N is {result}");

// 2 способ:
int Factorial(int num)
{
    int fact = 1;
    for(int i=2; i <= num; i++)
    {
        fact *=i;
    }
    return fact;
}
Console.Write("Input an integer number N: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Factorial(number);
Console.WriteLine($"Factorial of numbers N is {result}");
*/

// массивы - набор однотипных данных
// тип данных [] имя
// тип данных = новый тип данных [] {}
 //[]     имя метода       размер   диапазон случайных чисел(значения)
int[] CreateRandomArray(int size, int minValue, int maxValue)
{   //выделяем память под массив
    // имя массива
    int[] array = new int[size];
    for (int i = 0; i < size; i++)// проходим по каждому элементу, если хотим по каждому 2 элементу, то i+=2
    
        array[i] = new Random().Next(minValue, maxValue +1); // +1 добавили, чтобы последнее число доже отобразилось
      
    return array; // возвращаем массив указываем только имя
}
//    имя
void ShowArray(int[] array)      // вывести массив на экран
{                 //количество элементов в массиве
    for(int i = 0; i < array.Length; i++)
    {
       // Console.WriteLine($"array[{i + 1}] is {array[i]}"); // написали + 1, чтобы array, выводился как array[1], а не array[0]
          Console.Write(array[i] + " "); // можно записать так будет вывод в одну строку
    }    
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);