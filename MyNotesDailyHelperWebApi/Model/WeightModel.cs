using System.ComponentModel.DataAnnotations.Schema;

namespace MyNotesDailyHelperWebApi.Model
{
    [Table("weight")]
    public class WeightModel
    {
        [Column("id")]
        public Guid? Id { get; set; }

        [Column("contactid")]
        public Guid ContactId { get; set; }

        public virtual ContactModel Contact { get; set; }

        [Column("createdate")]
        public DateTime? CreateDate { get; set; }

        [Column("value")]
        public float? Value { get; set; }
    }
}
