﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //public Person(int id, string profilePictureURL, string fullName,string bio)
        //{
        //    Id= id;
        //    ProfilePictureURL= profilePictureURL;
        //    FullName= fullName;
        //    Bio= bio;
        // }
    }
}
