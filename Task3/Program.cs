// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = new int[] { 1, 2, 5, 0, 10, 34 };

void ReversArrayOutput(int[] array, int i = 5)
{
    if (i < 0)
    {
        return;
    }
    else
    {
        Console.Write(" " + array[i--]);
        ReversArrayOutput(array, i);
    }
}

ReversArrayOutput(array);