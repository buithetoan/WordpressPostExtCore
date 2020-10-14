using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace Extension.Data.Entities.Models
{
    public class TblPost : IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
