using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Persistence.DTO
{
    class Dto
    {
        [Key]
        public int Id { get; set; }

        public int Name { get; set; }
    }
}
