using Calculator;

namespace calculator
{
    class Calculator
    {
        public static void Main(String []args)
        {
            double[] data = new double[2];
            data = UserInput.UserData();

            Calculate.Result(data);
        }
    }
}