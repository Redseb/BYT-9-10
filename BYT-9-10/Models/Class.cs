﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_9_10.Models 
{
    internal class Class : Event 
    {
        
        [Required]
        [StringLength(4, MinimumLength =4)] //ie. A122
        public string RoomNumber { get; set; }

        [Required]
        public bool IsLecture { get; set; }

        [Required]
        [StringLength(3, MinimumLength =3)] //ie. 14c
        public string Group { get; set; }

        private List<Student> students;
        public Teacher Teacher { get; set; }
        [Required]
        public Subject Subject { get; set; }


        public List<Student> GetListOfStudents() 
        {
            return students;
        }

        public static List<Class> getAllclasses() 
        {
            return new List<Class> { }; //Would somehow get every class
        }

        public void viewRouteTo() 
        {
            //Would interact with the screen to display the route
            return;
        }

        public void addStudent(Student newStudent) 
        { 
            this.students.Add(newStudent);
        }

        public void removeStudent(Student newStudent) 
        { 
            this.students.Remove(newStudent);
        }
    }
}
