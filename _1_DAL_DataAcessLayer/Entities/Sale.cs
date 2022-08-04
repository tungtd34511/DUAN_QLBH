﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1_DAL_DataAcessLayer.Entities
{
    [Table("SALE")]
    [Serializable]
    public class Sale
    {
        [Key]
        public int Id { set; get; }
        [StringLength(55)]
        public string Name { set; get; }
        public string Note { set; get; }
        public string Detail { set; get; }
        public int SalePercent { get; set; }
        public bool Status { set; get; }
        public DateTime Started { get; set; }
        public DateTime Finished { get; set; }
    }
}