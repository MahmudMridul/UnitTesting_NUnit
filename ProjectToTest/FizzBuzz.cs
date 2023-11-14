

namespace ProjectToTest
{
    public class FizzBuzz
    {
        public string GetOutput(int number)
        {
            if(number % 3 == 0 && number % 5 == 0) { return "FizzBuzz"; }
            if(number % 3 == 0) { return "Fizz"; }
            if (number % 5 == 0) { return "Buzz"; }
            return number.ToString();
        }

        public string GetOutput(int num1, int num2)
        {
            if(num1 % 3 == 0 && num2 % 5 == 0) { return "FizzBuzz"; }
            if(num1 % 3 == 0) { return "Fizz"; }
            if(num2 % 5 == 0) { return "Buzz"; }
            return num1.ToString() + num2.ToString();
        }
    }
}
