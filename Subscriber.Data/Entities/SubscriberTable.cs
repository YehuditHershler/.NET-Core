using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.Data.Entities
{
    [Table("Subscriber")]
    public class SubscriberTable
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        public string? TZ { get; set; }
        [Required]
        [MaxLength(100)]
        public string? FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string? LastName { get; set; }
        [Required]
        // [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        // ErrorMessage = "Please enter correct email address")]
        public string? Email { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(9)]
        public string? Password { get; set; }
    }
}
