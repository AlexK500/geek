// Цикл for

string Metod4(int count, string text)
{
string result = String.Empty;
for (int i = 0; i<count; i++) //вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
{
result = result + text;
}
return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);

// Цикл в цикле

for (int i = 2; i <= 10; i++)
{
for (int j = 2; j <= 10; j++)
{
Console.WriteLine($"{i} * {j} = {i * j}");
}
Console.WriteLine();
}
