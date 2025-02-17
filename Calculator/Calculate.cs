namespace Calculator
{
    class Calculate
    {


        public static void Result(double[] data)
        {


            double sum = data[0] + data[1];
            double sub = data[0] - data[1];
            double multiplication = data[0] * data[1];

            Console.WriteLine($"The sum of the {data[0]} and {data[1]} is {sum}");
            Console.WriteLine($"The substraction of the {data[0]} and {data[1]} is {sub}");
            Console.WriteLine($"The multiplication of the {data[0]} and {data[1]} is {multiplication}");

            if (data[1] == 0)
            {
                Console.WriteLine("can Not divide by Zero");
            }
            else
            {
                double division = data[0] / data[1];
                Console.WriteLine($"The division of the {data[0]} and {data[1]} is {division}");

            }

        }
    }
}
