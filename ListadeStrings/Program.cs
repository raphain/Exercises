using System;
using System.Collections.Generic;

namespace Lista_de_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int suavariavel = int.Parse(Console.ReadLine());

       //declare suas variaveis aqui   

            string[] n = Console.ReadLine().Split();
            int m2 = 0;
            int m3 = 0;
            int m4 = 0;
            int m5 = 0;

      //continue a solução
            for (int i =0; i<suavariavel; i++ )
            {
                if ((Convert.ToInt32(n[i]) % 2) ==0)
                {
                    m2++;
                }
                if ((Convert.ToInt32(n[i]) % 3) ==0)
                {
                    m3++;
                }
                if ((Convert.ToInt32(n[i]) % 4) ==0)
                {
                    m4++;
                }
                if ((Convert.ToInt32(n[i]) % 5) ==0)
                {
                    m5++;
                }
            }

            Console.WriteLine("{0} Multiplo(s) de 2",  m2   );
            Console.WriteLine("{0} Multiplo(s) de 3",  m3   );
            Console.WriteLine("{0} Multiplo(s) de 4",   m4  );
            Console.WriteLine("{0} Multiplo(s) de 5",   m5  );
            
            /* var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            string[] result = null;
            List<string> list = new List<string>();
            
            for (int i = 0; i < totalDeCasosDeTeste; i++)
             {
    
                string[] valores = Console.ReadLine().Split();
        
                for(int k = 0; k < valores.Length; k++)    
                 {
                    if(!list.Contains(valores[k]))
                        {               
                            list.Add(valores[k]);
                        }
                 
                 }
                list.Sort();
                result = list.ToArray();
                foreach (var name in list)
                Console.Write("   {0}", name);
             }    */
            
            
      
        }
    }
}
