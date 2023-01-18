using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Modelos
{
    [Table("Avion")]
    public class Avion
    {
        [Key]
        public int IdAvion { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Capacidad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Denominación { get; set; }

        public int LineaId { get; set; }

        #region propiedades de navegación
        [ForeignKey("LineaId")]
        public LineaAerea LineaAerea { get; set; }
        #endregion
    }
}
