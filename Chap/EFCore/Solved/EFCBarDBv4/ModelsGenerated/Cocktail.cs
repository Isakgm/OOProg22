﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Cocktail")]
public partial class Cocktail
{
    public Cocktail()
    {
        CocktailIngredients = new HashSet<CocktailIngredient>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }


    [InverseProperty("Cocktail")]
    public virtual ICollection<CocktailIngredient> CocktailIngredients { get; set; }
}