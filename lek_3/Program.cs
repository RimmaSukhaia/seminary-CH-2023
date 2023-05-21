/*
int Max(int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if(arg2 > resalt) resalt = arg2;
    if(arg3 > resalt) resalt = arg3;
    return resalt;
}


int a1 = 4;
int b1 = 6;
int c1 = 1;
int a2 = 6767;
int b2 = 16;
int c2 = 7;
int a3 = 23;
int b3 = 61;
int c3 = 145678;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

System.Console.WriteLine(max);

*/

/*
int Max(int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if(arg2 > resalt) resalt = arg2;
    if(arg3 > resalt) resalt = arg3;
    return resalt;
}

int [] array = {21, 34, 203, 4, 56, 74, 12, 37, 8};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

System.Console.WriteLine(max);

*/

/*
int []array = {1, 2, 13, 24, 55, 6, 17, 1};

int n = array.Length;
int find = 1;
int index =0;

while(index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
*/

void FillArray(int []collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(0,10);
        index++;
    }

}

void PrintArray(int []col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int []collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);