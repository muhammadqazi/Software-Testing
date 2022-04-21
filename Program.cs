namespace CalculatorApp
{
    public class Calculator_app
    {

        private float x, y;

        public Calculator_app(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Calculator_app()
        {
        }

        public float Add()
        {
            return x + y;
        }

        public float Subtract()
        {
            return x - y;
        }


        public float Multiply()
        {
            return x * y;
        }

        public float Divide()
        {
            return y / x;
        }


        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter the first number");

                float x = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number");

                float y = float.Parse(Console.ReadLine());

                Console.WriteLine("Please select the operation you want to perform");

                Console.WriteLine("1) Add \t 2) Subtract \t 3) Multiplt \t 4) Divide");

                int opr = int.Parse(Console.ReadLine());

                Calculator_app cal = new Calculator_app(x, y);


                switch (opr)
                {
                    case 1:
                        Console.WriteLine(cal.Add());
                        break;
                    case 2:
                        Console.WriteLine(cal.Subtract());
                        break;
                    case 3:
                        Console.WriteLine(cal.Multiply());
                        break;
                    case 4:
                        Console.WriteLine(cal.Divide());
                        break;
                    default:
                        Console.WriteLine("Please enter the correct choice");
                        break;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}