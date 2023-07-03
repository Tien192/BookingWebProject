﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingWeb.DbEntities
{
    public class NhanXetDanhGia : FullAuditedEntity, IMayHaveTenant
    {
        public float DiemDanhGia { get; set; }

        public float DanhGiaSao { get; set; }

        public string NhanXet { get; set; }

        public int DichVuTienIchId { get; set; }

        public int KhachHangId { get; set; }

        public int ChiTietDatPhongId { get; set; }

        public int? TenantId { get; set; }
    }
}
