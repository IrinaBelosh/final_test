// // напишите программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна трем символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] text = { "home", "789", "ver", "pusan", "9", "go", "=-0", "not", "Hi", "Hello" }; //задали исходный массив
int newArrayLength = KnowLengthOfNewArray(text); // посчитали длину нового массива
string[] newArray = SortOutArray(text, newArrayLength); //заполнили новый массив
PrintArray(newArray);

void PrintArray(string[] array) // метод печатает массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int KnowLengthOfNewArray(string[] array2) // метод считает длину нового массива
{
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i].Length <= 3) count = count + 1;
    }
    return count;
}

string[] SortOutArray(string[] array3, int length) //метод создает новый массив со строками короче 3 символов
{
    string[] newArray = new string[length];
    int j = 0;
    for (int i = 0; i < array3.Length; i++)
    {
        if(array3[i].Length<=3)
        {
            newArray[j] = array3[i];
            j++;
        }
    }
    return newArray;
}
