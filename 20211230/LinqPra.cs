var hoge = new[]
{
    new { id = "a", num = 20},
    new { id = "b", num = 21},
    new { id = "c", num = 22},
    new { id = "d", num = 23},
    new { id = "e", num = 24},
}
var sum = hoge.Sum(x => x.num);
Console.WriteLine(hoge.Average(x => x.num));