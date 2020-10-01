using System;
public class Saboteador : Impostor{
    #region Atributos
    private int CantidadSabotajes;
    #endregion

    #region  Stters y Getters

    #endregion

    #region Metodos
    public override void RealizarActoMalvado()
    {
       Console.WriteLine("Puedo sabotear sistemas.");

    }
    #endregion

    #region Constructores
        public Saboteador(string color, float peso, string nombre, int cantSabotajes) : base (color, peso, nombre){
            this.CantidadSabotajes = cantSabotajes;
        }
        public Saboteador() : base (){
            this.CantidadSabotajes = 0;
        }
    #endregion
}