using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    internal class Teacher : Account 
    {

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string EmailPrefix { get; set; }
        
        private List<Class> Classes { get; set; }
        public List<Application> RepliedApplications { get; set; }
        [Required]
        public List<Class> ClassesTaught { get; set; }
        public List<Subject> SubjectsSupervised { get; set; }
        public override bool Login()
        {
            //check this.emailprefix and this.password
            return true;
        }
        public List<Class> GetListOfClasses()
        {
            return Classes;
        }
    }
}
