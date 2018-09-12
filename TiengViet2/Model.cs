using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiengViet2
{
    
    public class BaiHoc
    {
        public int Id { get; set; }
        public int tieude { get; set; }
        public List<Noidung> baihoc { get; set; }
        public int thutu { get; set; }
    }

    public class Noidung
    {
        public int dong { get; set; }
        public string noidung { get; set; }

    }

    public class Cau
    {
        public int id { get; set; }
        public string noidung { get; set; }

    }
}
