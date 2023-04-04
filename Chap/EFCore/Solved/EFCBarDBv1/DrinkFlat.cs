﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DrinkFlat")]
public partial class DrinkFlat
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(50)]
    public string AlcoholicPart { get; set; }

    public int AlcoholicPartAmount { get; set; }

    [Required]
    [StringLength(50)]
    public string NonAlcoholicPart { get; set; }

    public int NonAlcoholicPartAmount { get; set; }

    public override string ToString()
    {
        return $"[{Id,2}]  {Name} " +
            $"({AlcoholicPartAmount} cl. {AlcoholicPart}, " +
                $"{NonAlcoholicPartAmount} cl. {NonAlcoholicPart})";
    }
}