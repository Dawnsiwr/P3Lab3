using System;
using System.Collections.Generic;


namespace P3Lab3
{
    public class DataReader
    {
        public string readSentence()
        {
            string sentence;
            do
            {
                Console.Write("Wprowadź zdanie: ");
                sentence = Console.ReadLine();
            } while (sentence == null);

            return sentence;
        }

        public double returnDoubleValue()
        {
            bool doubleValueError = false;
            double value = 0;
            do
            {
                doubleValueError = false;
                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Niepoprawna wartość");
                    doubleValueError = true;
                    continue;
                }

            } while (doubleValueError);

            return value;
        }

        public int readIntValue()
        {
            bool valueError = false;
            int value = 0;
            do
            {
                valueError = false;
                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Niepoprawna wartość");
                    valueError = true;
                    continue;
                }

            } while (valueError || value<1);

            return value;
        }

        public double[][] readJaggedArray()
        {


            List<Double> dimension = new List<double>();
            Console.WriteLine("Wprowadź liczbę wierszy w tablicy ");
            int arrayRows = readIntValue();
            double value = 0;
            double[][] jaggedArray = new double[arrayRows][];

            for (int i = 0; i < arrayRows; i++)
            {
                do
                {
                    Console.WriteLine("Wprowadź liczbę do "+(i+1)+" wiersza. (Aby przejść dalej wprowadź 0)");
                    
                    dimension.Add(returnDoubleValue());

                } while (!dimension.Contains(0));

                dimension.RemoveAt(dimension.Count - 1);
                jaggedArray[i] = dimension.ToArray();
                dimension.Clear();
            }

           

            return jaggedArray;
        }

        public double[][] readRandomJaggedArray()
        {
            double[][] jaggedArray = new double[new Random().Next(11)][];

            for(int i=0; i<jaggedArray.Length;i++)
            {
                jaggedArray[i] = new double[new Random().Next(11)];
                for(int j=0; j<jaggedArray[i].Length;j++)
                {
                    jaggedArray[i][j] = Math.Round(new Random().NextDouble()*10,2);
                }
            }


            return jaggedArray;
        }

        public double[][] menu()
        {
            double[][] jaggedArray;
            int option = 0;
            do
            {
                Console.WriteLine("Wprowadź 1 aby uzupełnić tablicę, 2 aby wypełniona została losowo");
                option = readIntValue();
                Console.WriteLine(option);
            } while (option != 1 && option != 2);
            if (option == 1)
                jaggedArray = readJaggedArray();
            else
                jaggedArray = readRandomJaggedArray();

            return jaggedArray;
        }
    }
}