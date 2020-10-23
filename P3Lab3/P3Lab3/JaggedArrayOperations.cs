namespace P3Lab3
{
    public class JaggedArrayOperations
    {
        double[][] jaggedArray;
        public JaggedArrayOperations(double[][] jaggedArray)
        {
            this.jaggedArray = jaggedArray;
        }

        public double jaggedArraySum()
        {
            double sum = 0;

            for (int i = 0; i < jaggedArray.Length; i++)
            {

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    sum += jaggedArray[i][j];
                }
            }

            return sum;
        }

        public void printJaggedArray()
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", jaggedArray[i][j], j == (jaggedArray[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}