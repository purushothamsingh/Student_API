﻿using Student_api.Data;

namespace Student_api.DomainModels
{
    public class Students
   {
          // public Guid Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public DateTime DateOfBirth { get; set; }

            public string Email { get; set; }

            public long Mobile { get; set; }

            public string? ProfileImageUrl { get; set; }

            public Guid GenderId { get; set; }

            //navigation

            public Gender Gender { get; set; }

           public Address  Address { get; set; } 

        }
    }

    