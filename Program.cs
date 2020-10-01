using System;

namespace Abstracto_Among_Us
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Ingeniero Ing = new Ingeniero("blanco",80.5f, "Juan",10);
            Console.WriteLine("Color: " + Ing.GetColor());
            Console.WriteLine("Peso: " + Ing.GetPeso().ToString());
            Console.WriteLine("Nombre: " + Ing.GetNombre());
            Ing.Correr();
            Ing.UsarPuertas();
            Ing.RealizarTarea();
            
            Console.WriteLine("-------------------------------------------------------");
            Ingeniero Ing2 = new Ingeniero();
            Console.WriteLine("Color: " + Ing2.GetColor());
            Console.WriteLine("Peso: " + Ing2.GetPeso().ToString());
            Console.WriteLine("Nombre: " + Ing2.GetNombre());
            Ing2.Correr();
            Ing2.UsarPuertas();
            Ing2.RealizarTarea();

            Console.WriteLine("-------------------------------------------------------");
            Seguridad Seg = new Seguridad("azul",80.5f, "Cele",10);
            Console.WriteLine("Color: " + Seg.GetColor());
            Console.WriteLine("Peso: " + Seg.GetPeso().ToString());
            Console.WriteLine("Nombre: " + Seg.GetNombre());
            Seg.Correr();
            Seg.UsarPuertas();
            Seg.RealizarTarea();

            Console.WriteLine("-------------------------------------------------------");
            Seguridad Seg2 = new Seguridad();
            Console.WriteLine("Color: " + Seg2.GetColor());
            Console.WriteLine("Peso: " + Seg2.GetPeso().ToString());
            Console.WriteLine("Nombre: " + Seg2.GetNombre());
            Seg2.Correr();
            Seg2.UsarPuertas();
            Seg2.RealizarTarea();

            Console.WriteLine("-------------------------------------------------------");
            Asesino Ase = new Asesino("negro",80.5f, "Max",10);
            Console.WriteLine("Color: " + Ase.GetColor());
            Console.WriteLine("Peso: " + Ase.GetPeso().ToString());
            Console.WriteLine("Nombre: " + Ase.GetNombre());
            Ase.Correr();
            Ase.UsarPuertas();
            Ase.RealizarActoMalvado();

            Console.WriteLine("-------------------------------------------------------");
            Asesino Ase2 = new Asesino();
            Console.WriteLine("Color: " + Ase2.GetColor());
            Console.WriteLine("Peso: " + Ase2.GetPeso().ToString());
            Console.WriteLine("Nombre: " + Ase2.GetNombre());
            Ase2.Correr();
            Ase2.UsarPuertas();
            Ase2.RealizarActoMalvado();

            Console.WriteLine("-------------------------------------------------------");
            Saboteador Sab = new Saboteador("rojo",80.5f, "Sim",10);
            Console.WriteLine("Color: " + Sab.GetColor());
            Console.WriteLine("Peso: " + Sab.GetPeso().ToString());
            Console.WriteLine("Nombre: " + Sab.GetNombre());
            Sab.Correr();
            Sab.UsarPuertas();
            Sab.RealizarActoMalvado();

            Console.WriteLine("-------------------------------------------------------");
            Saboteador Sab2 = new Saboteador();
            Console.WriteLine("Color: " + Sab2.GetColor());
            Console.WriteLine("Peso: " + Sab2.GetPeso().ToString());
            Console.WriteLine("Nombre: " + Sab2.GetNombre());
            Sab2.Correr();
            Sab2.UsarPuertas();
            Sab2.RealizarActoMalvado();


        }
    }
}
