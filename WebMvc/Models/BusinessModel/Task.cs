using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace WebMvc.Models.BusinessModel
{
    public class Task
    {

        private DateTime _created;
        public int ID { get; set; }
        public DateTime Created
        {
            set { value = _created; }
            get { return _created; }
        }

        [Required]
        [MaxLength(50)]
        public string Subject { get; set; }
        
        public string Description { get; set; }

        public bool IsComplated { get; set; }

        [MaxLength(50)]
        public string Owner { get; set; }

    }
}
