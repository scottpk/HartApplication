using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HartWebApi
{
    [Table("Setting")]
    public class SettingsEntry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("Name")]
        public string Name { get; set; }
        [Required]
        [Column("Value")]
        public string Value { get; set; }
    }
}
