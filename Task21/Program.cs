
Func<String, int[]> func = (String text) =>
{
    String[] chars = text.Split(',');
    int[] result = new int[chars.Length];
    for (int i = 0; i < chars.Length; i++)
    {
        result[i] = int.Parse(chars[i]);
    }
    return result;
};


Console.WriteLine("Введите координаты первой точки через запятую: ");
int[] dot1 = func(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки через запятую: ");
int[] dot2 = func(Console.ReadLine());


double x1 = dot1[0] - dot2[0];
double y1 = dot1[1] - dot2[1];
double z1 = dot1[2] - dot2[2];
double distanse = Math.Sqrt(x1 * x1 + y1 * y1+ z1*z1);

Console.WriteLine("Расстояние=" +Math.Round(distanse,2));
