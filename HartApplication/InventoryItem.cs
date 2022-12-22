using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HartWebApi
{
    [Table("InventoryItem")]
    public class InventoryItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
