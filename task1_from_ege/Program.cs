//Дан целочисленный массив из 10 элементов.Элементы массива могут принимать значения от 0 до 10000 включительно. Составьте программу, позволяющую найти и вывести количество пар элементов массива,
// в которых десятичная запись обоих чисел оканчивается на 9. Под парой подразумевается два подряд идущих элемента массива.
// ex: [160, 244, 56, 224, 125, 109, 589, 25, 421, 78] => 1  

int[] array1 = new int[10] { 160, 244, 56, 224, 125, 109, 589, 25, 421, 78 };

int[] array2 = new int[10] { 169, 2445, 569, 2249, 125, 1090, 5896, 25, 4219, 79 };

int[] array3 = new int[10] { 16, 2445, 56, 224, 125, 1090, 58, 25, 421, 7 };

int[] array4 = new int[10] { 169, 24459, 569, 2249, 1259, 1099, 589, 259, 4219, 79 };

int FindAPair(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] % 10 == 9 && array[i + 1] % 10 == 9) count++;
    }
    return count;
}
Console.WriteLine($"[ {string.Join(", ", array1)} ]");
int count1 = FindAPair(array1);
Console.WriteLine($"Количество пар чисел, оканчивающихся на 9 = {count1}");

Console.WriteLine($"[ {string.Join(", ", array2)} ]");
int count2 = FindAPair(array2);
Console.WriteLine($"Количество пар чисел, оканчивающихся на 9 = {count2}");

Console.WriteLine($"[ {string.Join(", ", array3)} ]");
int count3 = FindAPair(array3);
Console.WriteLine($"Количество пар чисел, оканчивающихся на 9 = {count3}");

Console.WriteLine($"[ {string.Join(", ", array3)} ]");
int count4 = FindAPair(array4);
Console.WriteLine($"Количество пар чисел, оканчивающихся на 9 = {count4}");
