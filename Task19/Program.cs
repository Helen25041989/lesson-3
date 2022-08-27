String numberStr;
Console.WriteLine("Введите пятизначное число: ");
numberStr = Console.ReadLine();
String invertedNumbers = new String(numberStr.Reverse().ToArray());
if (numberStr.Equals(invertedNumbers))
{
    Console.WriteLine("да,палиндром");
}
else
{
    Console.WriteLine("нет");
}
