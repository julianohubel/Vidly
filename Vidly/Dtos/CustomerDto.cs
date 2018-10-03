﻿using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {      
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }    
        [Min18YearsOldIfMember]
        public DateTime? BirthDate { get; set; }
        public bool IsSubstribedToNewsletter { get; set; }   
        public byte MembershipTypeId { get; set; }
    
    }
}