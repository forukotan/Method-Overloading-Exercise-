namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
			
			var answer = Add(2, 2 );
			var answer2 = Add(3m, .3m);
			var answer3 = Add(4, 4, true);
			var answer4 = Add(0,1, true);
			Console.WriteLine($" for the int add: {answer}, for the decimal add: {answer2}");
			Console.WriteLine(answer3);
			Console.WriteLine(answer4);
		}


        public static int Add(int x, int y)
        {

            return x + y;
        }


        public static decimal Add(decimal x, decimal y)
        {
            return x + y; 
        
        }

		public static string Add(int x, int y, bool check)
		{
			var sum = x + y;

			if (check == true && sum > 1)
			{
				return $"{sum} dollars";
			}
			else if (check == true && sum == 1)
			{
				return $"{sum} dollar";
			}
			else if (check == true && sum < 1)
			{
				return $"{sum} dollars";
			}
			else
			{
				return sum.ToString();
			}
		}
	}



}
