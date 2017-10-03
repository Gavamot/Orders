using OrdersWeb.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OrdersWeb.Model
{
    public class Comment : IDbObject
    {
        public int Id { get; set; }
        [StringLength(256)]
        public string Content { get; set; }

        public DateTime TimeStamp { get; set; }
        [Required]
        public int CommentThemeId { get; set; }
        public CommentTheme CommentTheme { get; set; }

        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
