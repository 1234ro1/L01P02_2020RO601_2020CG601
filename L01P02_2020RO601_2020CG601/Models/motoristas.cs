using System.ComponentModel.DataAnnotations;
namespace L01P02_2020RO601_2020CG601.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string nombreMotorista { get; set; }

    }
}
