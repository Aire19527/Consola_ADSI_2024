using System;

namespace AppConsola.Model
{
    public class PersonaModel_Normal
    {
        public int Edad { get; set; }
        public double Estatura { get; set; }
        public string Sexo { get; set; } = "Masculino";
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
