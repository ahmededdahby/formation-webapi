using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRepository.Model
{
    public class Cuisine
    {
        [Key]
        public int CuisineId { get; set; }
        public string Name { get; set; }
    }
}
