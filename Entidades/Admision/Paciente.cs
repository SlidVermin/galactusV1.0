using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactus.Entidades.Admision
{
    class Paciente
    {
#region propiedades

        
        public string idPaciente { get; set; }
        public int tipoIdentificacion { get; set; }
        public string documentoIndentidad { get; set; }
        public int idMunicipioExpedicion { get; set; }
        public string primeroNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public int idGenero { get; set; }
        public int idMunicipioResidencia { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public int celular { get; set; }
        public string correo { get; set;}
        public int idUsuario { get; set;}

#endregion

    }
}
