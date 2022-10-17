using System;
using System.Collections.Generic;

namespace CRUD_mvc.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gmail { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public bool? ActiveUser { get; set; }
    }
}
