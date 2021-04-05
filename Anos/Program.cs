using System;
using System.Globalization;
using System.Collections;


namespace Anos
{
    class Program
    {
        static void Main(string[] args)
        {
        
              int t = Convert.ToInt32(Console.ReadLine());
		          int pa, pb;
              double cpa, cpb;
              string[] aux2 = new string[t];
              int anos=0;
              for (int i = 0; i < t; i++)
              {
                
                string[] aux = Console.ReadLine().Split();
                
                pa = Convert.ToInt32(aux[0]);
                if ((100 <= pa) && (pa<1000000))
                {
                  pb = Convert.ToInt32(aux[1]);
                  if ((pa < pb) && (pb<=100000000))
                    {
                      cpa = Math.Round(Convert.ToDouble(aux[2],new CultureInfo("en-US")),1);
            
                      if ((0.1 <= cpa) && (cpa<=10))
                      {
                         cpb = Math.Round(Double.Parse(aux[3],new CultureInfo("en-US")),1);
                          if ((cpb<=10) && cpb<cpa)
                            {
                              cpa = cpa/100;
                              cpb = cpb/100;
                              while (pa <= pb)
                              {

                   //complete o while
                    //pa += Convert.ToInt32(pa*(cpa/100));
                    //pb += Convert.ToInt32(pb*(cpb/100));
                                 pa = (int)(pa*(1+cpa));
                                 pb = (int)(pb*(1+cpb));
                                 anos++;
                    
                                  if(pa>pb)
                                  {
                                    aux2[i] = $"{anos} anos.";
                                    anos=0;
                                    break;
                                  }
                    
                                  if (anos > 100)
                                  { 
                       //complete a condicional
                                    aux2[i] ="Mais de 1 seculo.";
                                    anos=0;
                                    break;
                                  }

                              }
                              
                              
                              //Console.WriteLine("O número deve estar entre 0 e 10 e maior que {0}!",cpa);
                              //break;
                            }
                        
                      }
                    }
                }
               // Console.WriteLine("O número deve estar entre 100 e 1000000!");
               // break;
               //Console.WriteLine($"O número deve estar entre {pa} e 1000000!");
              //break;
                
               //declare as variaveis corretamente
                //cpa = Math.Round(Convert.ToDouble(Console.ReadLine(), NumberFormatInfo.InvariantInfo),1); 
                //cpb = Math.Round(Convert.ToDouble(Console.ReadLine(), NumberFormatInfo.InvariantInfo),1);*/
                 //Console.WriteLine("O número deve estar entre 0,1 e 10!");
                        //break;
               
               
                
               // for (int anos = 1; anos<=100; anos++)
               
               
              // double dpa = Convert.ToInt64(pa);
               //double dpb = Convert.ToInt64(pb);
                
                    
                }
            
                for (int i = 0; i < t; i++)
                {

                Console.WriteLine(aux2[i]);
                }
		        
            
            
   	}
	 
 }
}
