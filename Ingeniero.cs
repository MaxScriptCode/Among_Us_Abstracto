using System;
public class Ingeniero : Inocente{
    #region Atributos
    private int CantidadTareas;
    #endregion

    #region  Stters y Getters

    #endregion

    #region Metodos
    public override void RealizarTarea()
    {
       Console.WriteLine("Puedo reparar el nucleo.");

    }
    #endregion

    #region Constructores
        public Ingeniero(string color, float peso, string nombre, int cantTareas) : base (color, peso, nombre){
            this.CantidadTareas = cantTareas;
        }
        public Ingeniero() : base ("",0,""){
            this.CantidadTareas = 0;
        }
    #endregion
}