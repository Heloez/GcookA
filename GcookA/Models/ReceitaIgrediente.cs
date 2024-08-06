using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GcookA.Models;
[Table("ReceitaIgrediente")]
    public class ReceitaIgrediente
    {
      [Key, Column(Order =1)]
      public int ReceitaId { get; set; }
      [ForeignKey("ReceitaId")]

      public Receita Receita { get; set; }  
      [Key,Column(Order =2)]
      public int IgredientesId { get; set; }
      [ForeignKey("IgredienteId")]
      public Ingrediente Ingrediente { get; set;}

      [Required]
      [StringLength(30)]
      public string Quantidade { get; set;}

      [StringLength(200)]
      public string Preparo { get; set;}

    }
