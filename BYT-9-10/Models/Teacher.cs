using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models {
    internal class Teacher : Account {

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string emailPrefix { get; set; }
        
        private List<Class> classes;


        public override bool login()
        {
            //check this.emailprefix and this.password
            return true;
        }
        public List<Class> getListOfClasses()
        {
            return classes;
        }
    }
}
