using System.Collections.Generic;

namespace CalculadoraTrafico
{
    internal static class Program
    {
        private static void Main()
        {
            var protocoloPPP=new Protocolo{TipoProtocolo = "PPP"};
            var departamentos = new List<Departamento>
            {
                new Departamento {Nombre = "Presidencia", NumeroPersonas = 10}
            };

        }
    }
}
