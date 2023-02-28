using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnPunto_En_El_PLano
{
    /// <summary>
    /// 22/02/2023
    /// Jaider Andres Oquendo Zapata
    /// programa que represente un punto en el plano y tiene los siguientes métodos: 
    /// cargar los valores de x e y. Imprimir en que cuadrante se encuentra dicho punto.
    /// </summary>
    internal class Program
    {
        double X;
        double Y;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de un punto en el plano.");
            //instancia la clase para llamar los metodos.
            Program punto=new Program();
            punto.ValoresX_Y();
            punto.cuadrante();

            Console.ReadKey();
        }
        //metodos
        //metodo para cargar los valores de x e y.
        public void ValoresX_Y()
        {
            Console.WriteLine("Por favor ingrese el valor para X :");
            X=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese el valor para Y :");
            Y =Convert.ToDouble(Console.ReadLine());
        }
        //metodo para imprimir en que cuadrante se encuentra dicho punto
        public void cuadrante()
        {
            //selecciona el cuadrante mediante la estructura de desicion logica.
            if (X>0 && Y>0)
            {

                Console.WriteLine("Dicho punto se encuentra en el primer cuadrante");
              
            }
            else
            {
                if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Dicho punto se encuentra en el segundo cuadrante");
                }
                else
                {
                    if (X < 0 && Y < 0)
                    {
                        Console.WriteLine("Dicho punto se encuentra en el tercer cuadrante");
                    }
                    else
                    {
                        if (X > 0 && Y < 0)
                        {
                            Console.WriteLine("Dicho punto se encuentra en el cuarto cuadrante");
                        }
                        else
                        {
                            Console.WriteLine("Dicho punto NO se encuentra en ningun cuadrante");
                        }
                    }
                    
                }
                
            }
           
        }
    }
}
