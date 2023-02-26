// поиск максимального числа
int a1 = 3;
int b1 = 8;
int c1 = 55555;
int a2 = 7;
int b2 = 10;
int c2 = 13;
int a3 = 56;
int b3 = 14;
int c3 = 22;

int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);
