Console.WriteLine("Введите число");
string text = Console.ReadLine();
char[] reverseText = text.ToCharArray();
Array.Reverse(reverseText);
string finalText = new string(reverseText);
if(text == finalText)
{
    Console.WriteLine("палидром");
}
else
{
    Console.WriteLine("не палиндром");
}