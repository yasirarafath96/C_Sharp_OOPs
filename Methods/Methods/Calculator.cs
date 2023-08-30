namespace Method
{
    class Calculator
    {
        public int Sum(params int[] numbers)  // PARAMS is used in method, to accept n mumber of parameters from the signatures
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum = sum + item;
            }
            return sum;
        }
    }
}