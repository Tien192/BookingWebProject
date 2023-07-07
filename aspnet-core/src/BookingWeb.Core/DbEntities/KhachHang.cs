﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace BookingWeb.DbEntities
{
    public class KhachHang : FullAuditedEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public long CCCD { get; set; }

        public string HoTen { get; set; }

        public long SoDienThoai { get; set; }

        public string Email { get; set; }

        public DateTime NgaySinh { get; set; }

        public int? LoaiKhachHangId { get; set; }

        public int? TaiKhoanId { get; set; }

        public ICollection<NhanXetDanhGia> NhanXetDanhGias { get; set; }

        public ICollection<DatPhong> DatPhongs { get; set; }

    }
}
