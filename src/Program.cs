// See https://aka.ms/new-console-template for more information

string session_user = "";

Console.WriteLine("Welcome to the library. Please enter your username below:");

while (session_user == null)
{
    session_user = Console.ReadLine();
}