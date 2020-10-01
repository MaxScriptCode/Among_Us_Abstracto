using System;

public abstract class Personaje{
    #region Atributos
        private string Color;
        private float Peso;
        private string Nombre;
    #endregion

    #region Setters y Getters
        public void SetColor(string color){
            this.Color = color;
        }
        public void SetPeso(float peso){
            this.Peso = peso;
        }
        public void SetNombre(string nombre){
            this.Nombre = nombre;
        }

        public string GetColor(){
            return this.Color;
        }
        public float GetPeso(){
            return this.Peso;
        }
        public string GetNombre(){
            return this.Nombre;
        }
    #endregion

    #region Metodos
        public void Correr(){
            Console.WriteLine("Puedo correr.");
        }

        public void UsarPuertas(){
            Console.WriteLine("Puedo abrir puertas.");
        }
    #endregion

    #region Contructores
        public Personaje(string color, float peso, string nombre){
            this.Color = color;
            this.Peso = peso;
            this.Nombre = nombre;
        }
        public Personaje(){
            this.Color = "";
            this.Peso = 0;
            this.Nombre = "";
        }
    #endregion
}