// Yousef
// [05/11/2024]
internal class Program
{
    private static void Main(string[] args)
    {
        int i = 20;
        while(i>0) {
            if ((i & 1)==0)
            {
                Console.WriteLine(i);
            }
            i--;
        }
        //other solution
        int j = 20;
        while (j > 0)
        {
                Console.WriteLine(j);
            
            j-=2;
        }
    }
}