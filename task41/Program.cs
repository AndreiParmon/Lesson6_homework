// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите M:");
int count = 0;
while(true)
{
    string? M = Console.ReadLine();
    if(M == "stop")
    {
        break;
    }
    else
    {
        int num = Convert.ToInt32(M);
        M = num.ToString();
        if (num > 0)
        {
            count ++;
        }
    }    
}
Console.WriteLine($"Количество чисел больше 0: {count}");
