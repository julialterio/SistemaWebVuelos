using SistemaWebVuelos.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaWebVuelos.Models
{
    [Table("Vuelo")]
    public class Vuelo
    {

        public int VueloID { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [CheckFecha]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage ="Campo obligatorio")]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        [DisplayName("Destino")]

        public string Destino { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Origen")]
        public string Origen { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar")]
        [StringLength(5)]
        public string Matricula { get; set; }
    }
}