using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PedidosAPI.Core.Dominio.Entidades
{
    
        [Table("pedidos")]
        public class Pedido
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }

            [Required]
            [MaxLength(100)]
            public string cliente { get; set; }

            [Required]
            public DateTime fecha { get; set; }

            [Required]
            public decimal total { get; set; }

        }
    
}