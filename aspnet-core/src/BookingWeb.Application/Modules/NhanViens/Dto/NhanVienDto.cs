﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingWeb.Modules.NhanViens.Dto
{
    public class NhanVienDto
    {
        public string HoTen { get; set; }

        public long SoDienThoai { get; set; }

        public string Que { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int PhanLoai { get; set; }
    }
}