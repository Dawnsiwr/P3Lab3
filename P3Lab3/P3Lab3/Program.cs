using System;
using System.Data;

namespace P3Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DataReader reader = new DataReader();
            SentenceCorrector corrector = new SentenceCorrector(reader.readSentence());
            Console.WriteLine(corrector.correctSentence());
            
            JaggedArrayOperations array = new JaggedArrayOperations(reader.menu());
            array.printJaggedArray();
            Console.WriteLine(array.jaggedArraySum());
        }
    }
}
