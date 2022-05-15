using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //   bool gostoDePizza = true;
         //   if (gostoDePizza == false) // == True ou false
         //   {
         //       Console.WriteLine("Eu compro");
         //   }
         //   else
          //  {
           //     Console.WriteLine("Eu não compro");
          //  }

            int time = 20;
            if (time < 12)    
            {
                Console.WriteLine("Bom dia");
            }
            else if(time < 18)
            {
                Console.WriteLine("Boa Tarde");
            }
            else
            {
                Console.WriteLine("Boa Noite");
            }
        }
    }
}

        // Você está no mercado fazendo compras e nao seção de lanches você vê uma pizza
       
        // Se (Eu gosto de Pizza)
       // {
       //   EU compro   
       // }
       // Se não
       // {
       // Não compro 
       // }