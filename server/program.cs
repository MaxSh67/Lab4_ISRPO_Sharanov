Console.WriteLine("Добро пожаловать!");
Console.WriteLine("Шаранов Максим Иванович");
Console.WriteLine("ИСП-242");
Console.WriteLine("26.10.2026");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Меню:");
    Console.WriteLine("1 - Показать ФИО");
    Console.WriteLine("2 - Показать группу");
    Console.WriteLine("3 - Показать дату");
    Console.WriteLine("4 - Выход");

    string choice = Console.ReadLine();
            
    if (choice == "1")
        Console.WriteLine("Шаранов Максим Иванович");
    else if (choice == "2")
        Console.WriteLine("ИСП-242");
    else if (choice == "3")
        Console.WriteLine("26.10.2026");
    else if (choice == "4")
        return;
    else
        Console.WriteLine("Неверный выбор");
}
