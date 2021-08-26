using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace demomvc.Models
{
    [Table("t_alumno")]
    public class Matricula
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]  
        public int Id { get; set; }
        [Column("apellidos")]
        public string Apellidos { get; set; }
        [Column("nombres")]
        public string Nombres { get; set; }
        [Column("fecha_nacimiento")]
        public string fecha_nacimiento { get; set; }
        [Column("dni")]
        public string dni {get; set; }     
        [Column("genero")]
        public string Genero { get; set; }
        [Column("carrera")]
        public string Carrera { get; set; }

    }
}