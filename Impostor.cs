using System;

public abstract class Impostor : Personaje{
    #region Atributos
    #endregion

    #region Setters y Getters
        
    #endregion

    #region Metodos
        public abstract void RealizarActoMalvado();
    #endregion

    #region Contructores
        public Impostor(string color, float peso, string nombre) : base(color, peso, nombre){
        }
        public Impostor() : base(){
        }
    #endregion
}