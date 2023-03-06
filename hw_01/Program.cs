// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] ArraySet (int length){
    int index = 0;
    int[] array = new int[length];
    Console.WriteLine("Задаем массив");
    while (index < length){
        // array[index] = new Random().Next(0,100);
        Console.WriteLine($"Задайте Значение {index} -элемента массива:");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    Console.WriteLine();
    return array;
}

void ArrayPrint(int[] col){
    int l = col.Length;
    int index = 0;
    Console.Write("[ ");
    while (index < l){
        Console.Write($"{col[index]}, ");
        index++;
    }
    //Console.Write($"|array[array.length-1]|");
    Console.Write("]");
    Console.WriteLine();

}

// Find max and min
int CountPlus(int length, int[] array){
    int count = 0;
    for (int index = 0; index < length; index++){
        if (array[index] > 0){
            count = count+1;
        }
    }
    return count;
}

// Разница
// int DiffMaxMin(int maxArray, int minArray){
//     int diff =  maxArray - minArray;
//     return diff;
// }

Console.WriteLine("Задайте размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = ArraySet(length);

ArrayPrint(array);
//QuantityEvenNumbers();

int countPlus = CountPlus(length, array);
Console.WriteLine($"Количество положительных элементов в массиве: {countPlus}");



