using System.ComponentModel.DataAnnotations.Schema;

namespace MyNotesDailyHelperWebApi.Model
{
    [Table("contact")]
    public class ContactModel
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("fio")]
        public string FIO { get; set; }

    }
}
