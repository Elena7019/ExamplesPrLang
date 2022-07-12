// Задача приветствия любимого пользователя, но имя может быть написано либо строчными, либо заглавными буквами

Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.Write("Ура, это же Маша");
}
else
{    
    Console.Write("Привет, ");
    Console.WriteLine(username);
}