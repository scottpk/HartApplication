using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HartWebApi
{
    [Table("InventoryEntry")]
    public class InventoryEntry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        public InventoryItem Item { get; set; }
    }
}
