﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingWeb.Modules.SearchingFilter.Dto
{
    public class PhongSearchinhFilterDto
    {
        public int HinhThucPhongId { get; set; }

        public int DonViKinhDoanhId { get; set; }

        public string? TenDonVi { get; set; }

        public string? DiaChiChiTiet { get; set; }

        public int PhongId { get; set; }

        public string TenFileAnhDaiDien { get; set; }

        public int DoPhoBien { get; set; }

        public double DiemDanhGiaTB { get; set; }

        public double DanhGiaSaoTb { get; set; }

        public List<LoaiPhongSearchingFilterDto>? ListLoaiPhong { get; set; }

    }
}