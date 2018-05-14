using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryManagement.Data.Models
{
    public class Book : LibraryAsset
    {
        [Required]
        public string IBAN { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string  DeweyInbox { get; set; }
    }
}
