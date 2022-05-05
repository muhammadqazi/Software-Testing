namespace PowerApp
{
    public class Power_App
    {
        private int n;
        private int p;
        public Power_App(int n , int p)
        {
           this.n = n;
           this.p = p;
        }
        
        public int CalculatePower()
        {
            int ans = 1;

            if (p > 0)
            {
                int i = 1;
                while(i <= p)
                {
                    ans = ans * n;
                    ++i;
                }
                
            }
            return ans;
        }




        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the number :");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the power :");
                int power = int.Parse(Console.ReadLine());

                Power_App app = new Power_App(num, power);
                int ans = app.CalculatePower();

                Console.WriteLine("The " +power+ " power of " + num + " is " + ans);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }

    


}