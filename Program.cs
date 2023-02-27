/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] InputNumbers (int length){
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++){
        array[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

string CountPositiveNumbers (int[] array){
    int count = 0;
    foreach(int element in array){
        if(element > 0) count++;
    }
    return $"Количество положительных чисел в массиве: {count}";
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] array = InputNumbers(length);
Console.WriteLine(CountPositiveNumbers(array));

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
5 * -0.5 + 2 = y, y = -0.5
9 * -0.5 + 4 = y, y = -0.5
*/
int InputNumber () {
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string CrossPoint (int k1, int b1, int k2, int b2, double x){
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    if(y1 == y2){
        return $"({x}, {y1})";
    }else{
        return "";
    }
}

int k1 = InputNumber();
int b1 = InputNumber();
int k2 = InputNumber();
int b2 = InputNumber();
double x = -0.5;
Console.WriteLine($"Точка пересечения: {CrossPoint(k1, b1, k2, b2, x)}");

