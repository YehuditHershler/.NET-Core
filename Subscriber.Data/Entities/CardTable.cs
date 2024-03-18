using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.Data.Entities
{
    [Table("CardTablecs")]
    public class CardTable
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(SubscriberId))]
        public int SubscriberId { get; set; }
        [Required]
        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:dd/mm/yyyy ")]
        public DateTime OpenDate { get; set; }
        public double BMI { get; set; }
        [Required]
        public double height { get; set; }
        [Required]
        public double weight { get; set; }
        [Required]
        [Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:dd/mm/yyyy ")]
        public DateTime UpdateDate { get; set; }

    }
}
