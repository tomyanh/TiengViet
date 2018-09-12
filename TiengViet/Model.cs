using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiengViet
{
    
    public class BaiHoc
    {
        public int Id { get; set; }
        public string tieude { get; set; }
        public List<Noidung> baihoc { get; set; }
        public int thutu { get; set; }
    }

    public class Noidung
    {
        public int dong { get; set; }
        public string noidung { get; set; }

    }
}
