// Задача к контрольной работе.
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arrayStart = new string[6] { "5", "1234", "hello", "world", "yes", "+-)" };
string[] arrayFinish = new string[arrayStart.Length];
int count = 0;
for (int i = 0; i < arrayStart.Length; i++)
{
    if (arrayStart[i].Length <= 3)
    {
        arrayFinish[count] = arrayStart[i];
        count++;
    }
}
for (int i = 0; i < arrayFinish.Length; i++)
{
    Console.Write($"{arrayFinish[i]} ");
}

