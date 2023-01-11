/*Задача: Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символа*/

string[] FillArrayStrings() //функция заполняет массив строками, вводиемые с клавиатуры
{
    Console.Write("Введите размер массива: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());

    string[] arrayLocal = new string[sizeArray];

    for (int i = 0; i < arrayLocal.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку символов: ");

        while(true) 
        {
            arrayLocal[i] = Console.ReadLine();
            if (arrayLocal[i] != string.Empty) break;
            else Console.Write($"Невозможно сохранить пустую строку! Пожалуйста, перезапишите {i + 1} строку: ");
        }
    }

    return arrayLocal;
}

string[] FilterCharacter(string[] arrayLocal) //функция принимает массив и формирует из него массив из строк, длина которых меньше либо равна 3 символа
{
    int count = 0;

    for (int l = 0; l < arrayLocal.Length; l++)
    {
        string box = arrayLocal[l];

        if (box.Length <= 3)
        {
            count++;
        }
    }

    string[] arrayLocalTwo = new string[count];
    count = 0;

    for (int l = 0; l < arrayLocal.Length; l++)
    {
        string boxTwo = arrayLocal[l];

        if (boxTwo.Length <= 3)
        {
            arrayLocalTwo[count] = boxTwo;
            count++;
        }
    }

    return arrayLocalTwo;
}

void PrintArray(string[] arrayLocal) //функция выводит массив на консоль
{
    for (int k = 0; k < arrayLocal.Length; k++)
    {
        if(k < arrayLocal.Length - 1) Console.Write($"{arrayLocal[k]}, ");
        else Console.Write($"{arrayLocal[k]}");
    }
    Console.WriteLine();
}

string[] array = FillArrayStrings();
Console.WriteLine();
Console.Write("Изначальный массив: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Отфильтрованный массив: ");
PrintArray(FilterCharacter(array));
Console.WriteLine();