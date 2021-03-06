﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OrdersWeb.Model
{
    public class OrderRowHistory : IDbObject
    {
        public int Id { get; set; }
        [Required]
        public int OrderRowId { get; set; }
        public OrderRow OrderRow { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public double Procent { get; set; }
        [Required]
        public int OrderRowStatusId { get; set; }
        public  OrderRowStatus OrderRowStatus { get; set; }
        public  int? CommentId { get; set; }
    }
}
