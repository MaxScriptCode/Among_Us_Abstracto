using System;
public class Seguridad : Inocente{
    #region Atributos
    private int CantidadCamaras;
    #endregion

    #region  Stters y Getters

    #endregion

    #region Metodos
    public override void RealizarTarea()
    {
       Console.WriteLine("Puedo revisar las camaras.");

    }
    #endregion

    #region Constructores
    public Seguridad(string color, float peso, string nombre, int cantCamaras) : base (color, peso, nombre){
            this.CantidadCamaras = cantCamaras;
    }
    public Seguridad() : base (){
            this.CantidadCamaras = 0;
    }
    #endregion
}