using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConfigurationORM.Models;
[Table("Insanlar")]
public class Person
{
    [Key]
    public string FinCode { get; set; }
    [Column("Ad",TypeName = "varchar(250)")]
    public string Name { get; set; }
    [Column("Soyad")]
    [ MinLength(5),MaxLength(50)]
   
    public string?  Surname { get; set; }
    public int Age { get; set; }
    [NotNull]
    public string Email { get; set; }
    [Length(5,50)]
    public string Address { get; set; }
    [NotMapped]
    public string Status { get; set; }
    public int IsYerininNomresi { get; set; }
    [ForeignKey("IsYerininNomresi")]
    public Work Work { get; set; }
}