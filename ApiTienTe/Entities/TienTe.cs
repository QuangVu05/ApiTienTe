using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiTienTe.Entities
{
    public partial class TienTe
    {
        [Key]
        public int Id { get; set; }
        public string? TienTeNguon { get; set; }
        public string? TienTeDich { get; set; }
        public decimal? TyGia { get; set; }
    }
}
