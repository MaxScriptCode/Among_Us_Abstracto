using System;

public abstract class Inocente : Personaje{
    #region Atributos
    #endregion

    #region Setters y Getters
        
    #endregion

    #region Metodos
        public abstract void RealizarTarea();
    #endregion

    #region Contructores
    public Inocente(string color, float peso, string nombre) : base(color, peso, nombre){
        }
    public Inocente() : base(){
        }
    #endregion
}