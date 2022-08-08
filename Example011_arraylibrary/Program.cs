void Fillarray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {

        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintAray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;

        }
        index++;

    }

    return position;
}

int[] array = new int[10];

Fillarray(array);
PrintAray(array);
Console.WriteLine();
string namb = Console.ReadLine();
int namber = Convert.ToInt32(namb);

int pos = IndexOff(array, namber);
if (pos == -1)
{
    Console.WriteLine("Данного числа "+namber+" - нет!");
}
else
{
    Console.WriteLine("Искомое число "+namber+" на позиции: " + pos);
}