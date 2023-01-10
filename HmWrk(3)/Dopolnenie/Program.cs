void SimpleNumber(int numb)
{
    int[] arr = new int[numb];                  //создаем массив
    for (int index = 0; index < numb; index++)
    {
        arr[index] = index + 1;
    }

    for (int i = 1; i < numb; i++)
    {
        for(int j = 2; j <= numb; j++)
        {
        if (arr[i] % j != 0)
            {
            arr[i] = i;
            }
            Console.WriteLine(arr[i]);
        }
    
    }
}


Console.WriteLine("Введите число ");
int numb = int.Parse(Console.ReadLine()!);

SimpleNumber(numb);
