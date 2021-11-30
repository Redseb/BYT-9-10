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
        public List<Application> repliedApplications { get; set; }
        [Required]
        public List<Class> classesTaught { get; set; }
        public List<Subject> subjectsSupervised { get; set; }
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
