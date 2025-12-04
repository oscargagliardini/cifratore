namespace cifratore
{
    internal class Program
    {
        static char [] cesare(char[]alf,int k, char[] v)
        {

            for(int i = 0;i < v.Length; i++)
            {
                int rest = 0;
                int j = 0;
                bool t= true;
                while (t==true)
                {
                    if (v[i] == alf[j])
                    {
                        if (j + k > alf.Length)
                        {
                            rest = j + k - alf.Length;
                            v[i] = alf[rest];
                        }
                        else
                        {
                            v[i] = alf[j + k];
                            
                        }
                        t = false;
                    }
                    j++;
                }
                t = true;
            }
            return v;
            
        }
        static char[] transposizione(char[]v,int k)
        {
            char[]v2 = new char[v.Length];
            for(int n = 0; n < v.Length; n++)
            {
                v2[n] = v[(n+k )% v.Length];
            }
            return v2;
        }
        static void Main(string[] args)
        {
            int y = 2;
            int k = 6;
            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','k','l','m','n','o' ,'p','q','r','s','t','u','v','w','x','y','z'};
            char[] v = { 'v', 'a', 'l', 'e' };
            char[] risultato = cesare(alfabeto, k, v);
            for (int i = 0; i < risultato.Length; i++)
            {
                Console.Write(risultato[i]);
            }
            Console.WriteLine();
           char [] risultato1=transposizione(risultato, k);
            for(int s=0;s<risultato1.Length; s++)
            {
                Console.Write(risultato1[s]);
            }
        }
    }
}
