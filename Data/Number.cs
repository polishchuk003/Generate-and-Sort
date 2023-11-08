using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brighteye.Data
{
    public class Number
    {
        [Key]
        public int ValueId { get; private set; }

        public int Value { get; set; }
    }
}
