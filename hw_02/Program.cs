// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Find  intersection point
int IntersectionPointX(int k1, int k2, int b1, int b2){
    // y = k1 * x + b1, y = k2 * x + b2
    // find y
    //y = k1 * x + b1;
    // find x
    //x =(y - b2)/k2;
    // Во второе уровнение вносим значение y
    //x =(k1 * x + b1 - b2)/k2;
    // Находим x
    int x = (b1 - b2) / (k2 - k1);
    //int y = k1 * x + b1;

    return x;
}

int IntersectionPointY(int k1, int b1, int intPointX){
    // y = k1 * x + b1, y = k2 * x + b2
    // find y
    //y = k1 * x + b1;
    // find x
    //x =(y - b2)/k2;
    // Во второе уровнение вносим значение y
    //x =(k1 * x + b1 - b2)/k2;
    // Находим x
    //int x = (b1 - b2) / (k2 - k1);
    int x = intPointX;
    int y = k1 * x + b1;

    return y;
}

Console.WriteLine("Задайте зачение k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте зачение b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте зачение k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте зачение b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
// int[] array = ArraySet(length);

// ArrayPrint(array);
//QuantityEvenNumbers();
//IntersectionPoint(k1, k2, b1, b2);

int intPointX = IntersectionPointX(k1, b1, k2, b2);
int intPointY = IntersectionPointY(k1, b1, intPointX);
Console.WriteLine($"Точка пересечения двух прямых: ({intPointX},{intPointY})");


