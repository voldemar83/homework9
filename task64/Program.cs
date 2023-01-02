Console.Write("Введите N: ");
var str = Console.ReadLine() ?? "";

var N = int.Parse(str);

static void DownFrom(int n)
{
    if (n == 0) return;
    Console.Write($"{n--}" + (n != 0 ? ", " : ""));
    DownFrom(n);
}

DownFrom(N);
