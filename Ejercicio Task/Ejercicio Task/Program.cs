using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Ejercicio_task
{
    class program
    {
        
        static void Main()
        {

            Task tarea1 = Task.Run(() => Proceso1());
            Task tarea2 = Task.Run(() => Proceso2());
            Task tarea3 = Task.Run(() => Proceso3());

            Task.WaitAll(tarea1, tarea2, tarea3);

            Console.WriteLine("Todas las tareas han finalizado.");

        }


        static void Proceso1()
        {

            for (int i = 0; i < 5; i++)
            {               
                Console.WriteLine($"hilo 1 vuelta{i}");
                Thread.Sleep(500);
            }
            
        }
        static void Proceso2()
        {
            for (int i = 0; i < 5; i++)
            {                
                Console.WriteLine($"hilo 2 vuelta{i}");
                Thread.Sleep(1000);
            }
        }
        static void Proceso3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"hilo 3 vuelta{i}");
                Thread.Sleep(750);
            }
        }





    }
}

