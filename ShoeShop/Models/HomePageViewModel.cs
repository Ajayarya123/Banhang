﻿using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeShop.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<NhomSanPham> Danhmucsanphams { get; set; }
        public IEnumerable<SanPham> Sanphams { set; get; }
        public Footer Footer { get; set; }
        public Slider Slider { get; set; }
        public IEnumerable<Menu> Menus { get; set; }
        public LienHe Lienhe { get; set; }
    }
}
