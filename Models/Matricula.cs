using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace demomvc.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]  
        public int Id { get; set; }
        [Column("apellidos")]
        public string Apellidos { get; set; }
        [Column("nombres")]
        public string Phone { get; set; }
        [Column("fecha_nacimiento")]
        public string Fecha_nacimiento {get; set;}
        [Column("dni")]
        public string DNI {get; set; }     
        [Column("genero")]
        public DateTime Genero { get; set; }
        [Column("gender")]
        public string Gender { get; set; }

    }
}