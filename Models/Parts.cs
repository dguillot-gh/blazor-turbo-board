using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace TurboKanban.Models;

public class Parts
{
    public int Id { get; set; }
    public string? PartName { get; set; }
    public string? PartNumber { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }
}
