public class SeqFibonacci
{
    public int Fibo(int n)
        {
            if (n == 1)
                {
                    return n;
                }

                else if(n < 1)
                {
                    return -1;                                        
                }

                else
                {
                    var conta = (n - 1) + (n - 2);
                    return conta ;
                }
         }        
}
