using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_вектора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int arraySize = 1000; 
            Vector[] vectors = new Vector[arraySize];
            Random rnd = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                vectors[i] = Vector.CreateVector(
                    new Point(rnd.Next(-10, 11), rnd.Next(-10, 11)),
                    new Point(rnd.Next(-10, 11), rnd.Next(-10, 11))
                );
            }

            Console.WriteLine("=== 1. ВИЗУАЛИЗАЦИЯ ВЕКТОРОВ (ПЕРВЫЕ 5 ШТУК) ===");
            PrintFirstVectorsVisual(vectors, 5);

            Console.WriteLine("\n=== 2. ПОИСК ОДИНАКОВЫХ ВЕКТОРОВ ===");
            FindAndPrintDuplicates(vectors);

            Console.ReadLine();
        }

        static void PrintFirstVectorsVisual(Vector[] vectors, int count)
        {
            int limit = Math.Min(count, vectors.Length);
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine($"Вектор #{i}: {vectors[i].Start.X_},{vectors[i].Start.Y_} -> {vectors[i].End.X_},{vectors[i].End.Y_}");
                VectorRenderer.DrawArrow(vectors[i]);
                Console.WriteLine();
            }
            Console.WriteLine("... (остальные векторы скрыты для экономии места)");
        }

        static void FindAndPrintDuplicates(Vector[] vectors)
        {
            bool foundAny = false;

            for (int i = 0; i < vectors.Length; i++)
            {
                bool alreadyPrinted = false;
                for (int k = 0; k < i; k++)
                {
                    if (Vector.IsEquals(vectors[i], vectors[k]))
                    {
                        alreadyPrinted = true;
                        break;
                    }
                }
                if (alreadyPrinted) continue;

                List<int> matches = new List<int>();
                matches.Add(i);

                for (int j = i + 1; j < vectors.Length; j++)
                {
                    if (Vector.IsEquals(vectors[i], vectors[j]))
                    {
                        matches.Add(j);
                    }
                }

                if (matches.Count > 1)
                {
                    foundAny = true;
                    Console.WriteLine($"Найдены одинаковые векторы: {vectors[i].Start.X_},{vectors[i].Start.Y_} -> {vectors[i].End.X_},{vectors[i].End.Y_}");
                    Console.Write("Номера (индексы): ");
                    foreach (int index in matches)
                    {
                        Console.Write($"#{index} ");
                    }
                    Console.WriteLine("\n");
                }
            }

            if (!foundAny)
            {
                Console.WriteLine("Одинаковых векторов не найдено. Попробуйте увеличить arraySize.");
            }
        }
    }
}