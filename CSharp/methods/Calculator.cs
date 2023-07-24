
namespace Methods{


    
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = numbers.Sum();
            
            return sum;
        }
    }
}