Console.WriteLine("Введите номер дня недели");
string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write(array[Convert.ToInt32(Console.ReadLine()) - 1]);