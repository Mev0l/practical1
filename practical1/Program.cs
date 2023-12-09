//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string[] nums = { "a", "b", "3", "a", "b" };

//        Dictionary<string, int> counts = new Dictionary<string, int>();

//        // Подсчитываем количество вхождений каждого элемента
//        foreach (string num in nums)
//        {
//            if (counts.ContainsKey(num))
//            {
//                counts[num]++;
//            }
//            else
//            {
//                counts[num] = 1;
//            }
//        }

//        // Находим элемент, у которого количество вхождений равно 1
//        foreach (KeyValuePair<string, int> pair in counts)
//        {
//            if (pair.Value == 1)
//            {
//                Console.WriteLine("Единственный элемент: " + pair.Key);
//            }
//        }
//    }
//}

//using System;

//class Program
//{
//    static int CountWays(int n)
//    {
//        // Базовые случаи: если осталось 0 или 1 ступенька, то только один способ добраться до вершины
//        if (n <= 1)
//            return 1;

//        // Рекурсивно вычисляем количество способов для n-1 ступеньки и n-2 ступенек
//        return CountWays(n - 1) + CountWays(n - 2);
//    }

//    static void Main()
//    {
//        Console.Write("Введите количество ступенек: ");
//        int n = int.Parse(Console.ReadLine());

//        int ways = CountWays(n);
//        Console.WriteLine("Количество способов подняться на вершину: " + ways);
//    }
//}

//List<int> RemoveDuplicates(List<int> sortedList)
//{
//    List<int> result = new List<int>();

//    if (sortedList.Count > 0)
//    {
//        result.Add(sortedList[0]); // добавляем первый элемент в результат

//        for (int i = 1; i < sortedList.Count; i++)
//        {
//            // проверяем, не является ли текущий элемент дубликатом предыдущего
//            if (sortedList[i] != sortedList[i - 1])
//            {
//                result.Add(sortedList[i]); // добавляем только уникальные элементы в результат
//            }
//        }
//    }

//    return result;
//}
//List<int> sortedList = new List<int> { 1, 2, 2, 3, 3, 3, 4, 5, 5 };
//List<int> uniqueList = RemoveDuplicates(sortedList);

//// Выводит: 1 2 3 4 5
//foreach (int num in uniqueList)
//{
//    Console.Write(num + " ");
//}
