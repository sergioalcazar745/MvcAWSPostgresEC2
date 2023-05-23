using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAWSPostgresEC2.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [Column("DEPT_NO")]
        public int IdDepartamento { get; set; }

        [Column("DNOMBRE")]
        public string Nombre { get; set; }

        [Column("LOC")]
        public string Localidad { get; set; }
    }
}
