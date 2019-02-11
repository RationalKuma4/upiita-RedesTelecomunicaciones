using System.Collections.Generic;

namespace CalculadoraTrafico
{
    public class Departamento
    {
        public string Nombre { get; set; }
        public int NumeroPersonas { get; set; }
        public List<ServicioTelematico> ServicioTelematicos { get; set; }
        public Protocolo Protocolo { get; set; }
        public GradoServicio GradoServicio { get; set; }
    }
}
