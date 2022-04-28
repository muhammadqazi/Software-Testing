namespace DecimalToBinary
{
    public class Decimal_To_Binary
    {
        string ans = "";
        int num;

        public Decimal_To_Binary(int num)
        {
            this.num = num;
        }

        public string Convert()
        {
            for (int i = 0; num > 0; i++)
            {
                this.ans = this.num % 2 + this.ans;
                this.num = this.num / 2;
            }
            return this.ans;
        }

    public static void Main(string[] args)
        {

           
            Console.WriteLine("Please enter the number ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                Decimal_To_Binary d = new Decimal_To_Binary(num);

                string ans =  d.Convert();

                Console.WriteLine("The given number in binary is " + ans);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
  

        }
    }
}