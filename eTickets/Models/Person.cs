﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
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