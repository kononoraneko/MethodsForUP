
void BubbleSort(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        for (int j = 0; j < A.Length - 1; j++)
        {
            if (A[j] < A[j + 1])
            {
                int z = A[j];
                A[j] = A[j + 1];
                A[j + 1] = z;
            }
        }
    }
  
}


void BubbleSortReverse(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        for (int j = 0; j < A.Length - 1; j++)
        {
            if (A[j] > A[j + 1])
            {
                int z = A[j];
                A[j] = A[j + 1];
                A[j + 1] = z;
            }
        }
    }
}



int[] MergeArrays(int[] A, int[] B)
{
    int[] res = new int[A.Length + B.Length];

    for (int i = 0; i < A.Length; i++)
    {
        res[i] = A[i];
    }
    for (int i = A.Length; i < res.Length; i++)
    {
        res[i] = B[i - A.Length];
    }
    return res;
}


int CalculateAbsoluteDifference(int n)
{
    int diff = Math.Abs(n - 123);

    if (n > 123)
    {
        return diff * 3;
    }
    return diff;
}



int[] myArr = { 1, 5 ,6 , 3,1, 2, -1};
int[] myArr2 = { 1, 2, 4, 1, 3 };


BubbleSort(myArr);
Console.WriteLine("Отсортированный массив: ");
foreach (int i in myArr)
{
    Console.WriteLine(i);
}


BubbleSortReverse(myArr);
Console.WriteLine("\nОтсортированный массив наоборот: ");
foreach (int i in myArr)
{
    Console.WriteLine(i);
}


int[] mergedArrs = MergeArrays(myArr, myArr2);
Console.WriteLine("\nСоединённый массив: ");
foreach (int i in mergedArrs)
{
    Console.WriteLine(i);
}


Console.WriteLine("Введите число: ");
int num;
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Ошибка ввода!");
}
Console.WriteLine(CalculateAbsoluteDifference(num));