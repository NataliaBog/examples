Console.Write("введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "natali")
{
    Console.WriteLine("Ура это же Natali!");
}
else
{
    Console.Write("привет, ");
    Console.Write(username);
}