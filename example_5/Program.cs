Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();


if(username.ToLower() == "мурад")
{
    Console.Write("Привет, никто) а ой, сорян, Мурад!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}