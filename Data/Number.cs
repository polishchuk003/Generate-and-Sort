using System.ComponentModel.DataAnnotations;

namespace Brighteye
{
    public class Number
    {
        [Key]
        public int ValueId { get; private set; }

        public int Value { get; set; }
    }
}
