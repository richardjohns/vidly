﻿using System;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public string MembershipTypeStr { get; set; }
        public DateTime BirthDate { get; set; }
        public byte MembershipTypeId { get; set; } // treated as foreig key.
    }
};
