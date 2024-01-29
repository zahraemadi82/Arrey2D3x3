// See https://aka.ms/new-console-template for more information
int[,] myArray = new int[3, 3];
for(int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("Enter Number : ");
        myArray[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

int maxNumber = 0;

foreach (int i in myArray)
{
    if(maxNumber <= i)
    {
        maxNumber = i;
    }
}

Console.WriteLine(maxNumber.ToString());
