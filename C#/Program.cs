//Программа, которая из имеющегося массива строк формирует массив
//из строк, длина которых меньше либо равна 3 символа.

//набор массивов данных на выбор

//string[] stringArray = new string[] {"1234", "1567", "-2", "computer science"};
//string[] stringArray = new string[] {"Russia", "Denmark", "Kazan"};
string[] stringArray = new string[] { "hello", "2", "world", ":-)" };

int stringSize = 3; //условие отбора

string[] stringArrayNew = StrnigArrayNew(stringSize, stringArray);

System.Console.Write($"[");
for (int i = 0; i < stringArrayNew.Length; i++)
{
    System.Console.Write($"{stringArrayNew[i]}  ");
}
System.Console.Write($"]");

// метод принимает целое число stringSize и массив строк и возвращает массив
// из имеющихся строк, длинна которых <= stringSize

string[] StrnigArrayNew(int stringSize, string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= stringSize) count++;
    }
    string[] stringArrayNew = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= stringSize)
        {
            stringArrayNew[j] = stringArray[i];
            j++;
        }
    }
    return stringArrayNew;
}

