using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPClient.Acces
{

        public class taiLieu
        {
            public string maTL { set; get; }
            public string giaTri { set; get; }
            public string donVi { set; get; }
            public string date { set; get; }
            public string trangThai { set; get; }

            public override string ToString()
            {
                return maTL + "\r" + giaTri + "\r" + donVi + "\r" + date + "\r" + trangThai;
            }
        
    }
}
