// Домашняя задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размерность массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[sizeArray];
Console.WriteLine("Для поиска количества положительных чисел введите их с клавиатуры:");
for (int i = 0; i < sizeArray; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int positiveNumber = 0;
for (int j = 0; j < sizeArray; j++)
{
    if (array[j] > 0)
        positiveNumber += 1;
}
Console.WriteLine(
    $"Массив [ {String.Join("; ", array)} ] содержит {positiveNumber} положительных числа"
);
