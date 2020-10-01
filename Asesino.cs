using System;
public class Asesino : Impostor{
    #region Atributos
    private int CantidadCuchillos;
    #endregion

    #region  Stters y Getters

    #endregion

    #region Metodos
    public override void RealizarActoMalvado()
    {
       Console.WriteLine("Puedo asesinar tripulantes.");

    }
    #endregion

    #region Constructores
        public Asesino(string color, float peso, string nombre, int cantCuchillos) : base (color, peso, nombre){
            this.CantidadCuchillos = cantCuchillos;
        }
        public Asesino() : base (){
            this.CantidadCuchillos = 0;
        }
    #endregion
}