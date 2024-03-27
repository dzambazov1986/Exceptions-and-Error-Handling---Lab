namespace Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            try
            {
                number = NotNegativeNumber(number);
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        private static double NotNegativeNumber(double number)
        {
            throw new NotImplementedException("Invalid number.");
        }
    }
}
