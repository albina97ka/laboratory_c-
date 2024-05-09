using System;

class GenericArray<T>
{
   private T[] array;
   private int size;

   public GenericArray(int capacity)
   {
       array = new T[capacity];
       size = 0;
   }

   public void Add(T item)
   {
       if (size < array.Length)
       {
           array[size] = item;
           size++;
       }
       else
       {
           Console.WriteLine("Массив полон. Невозможно добавить больше элементов");
       }
   }

   public void RemoveAt(int index)
   {
       if (index >= 0 && index < size)
       {
           for (int i = index; i < size - 1; i++)
           {
               array[i] = array[i + 1];
           }
           size--;
       }
       else
       {
           Console.WriteLine("Недопустимый индекс");
       }
   }

   public T Get(int index)
   {
       if (index >= 0 && index < size)
       {
           return array[index];
       }
       else
       {
           Console.WriteLine("Недопустимый индекс");
           return default(T);
       }
   }

   public int Length()
   {
       return size;
   }
}

class Program
{
   static void Main(string[] args)
   {
       GenericArray<int> intArray = new GenericArray<int>(5);
       intArray.Add(1);
       intArray.Add(2);
       intArray.Add(3);

       Console.WriteLine("Длина целочисленного массива: " + intArray.Length());
       Console.WriteLine("Элемент с индексом 1: " + intArray.Get(1));

       intArray.RemoveAt(1);
       Console.WriteLine("Целочисленная длина массива после удаления элемента с индексом 1: " + intArray.Length());

       GenericArray<string> stringArray = new GenericArray<string>(3);
       stringArray.Add("Привет");
       stringArray.Add("Мир");

       Console.WriteLine("Длина строкового массива: " + stringArray.Length());
       Console.WriteLine("Элемент с индексом 0: " + stringArray.Get(0));

       GenericArray<double> doubleArray = new GenericArray<double>(4);
       doubleArray.Add(6.2535234);
       doubleArray.Add(2.35465);

       Console.WriteLine("Длина массива чисел с плавающей точкой: " + doubleArray.Length());
       Console.WriteLine("Элемент с индексом 1: " + doubleArray.Get(1));
   }
}
