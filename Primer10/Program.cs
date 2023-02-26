// поиск позиции нужного элемента
int[] array = {1, 52, 3, 8, 13, 5, 3};
int n = array.Length;
int find = 3;
int index = 0;
while (index<n)
{
  if (array[index]==find)
  {
    Console.WriteLine(index);
    break;
  }

  index++;
}