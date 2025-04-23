using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appweb1.model
{
 
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public String Nombres { get; set; }

        public String Apellidos { get; set; }

        public String DNI { get; set; }
    }
}



