Console.WriteLine("Введите кол-во элементов массива:  ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int[num];

for (int i = 0; i < num; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива: ");
    array[i]= Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Кол-во чисел больше 0 =" + count);