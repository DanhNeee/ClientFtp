using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPClient.Acces
{
    public class files
    {
        //đọc file
        public static List<taiLieu> readFile(string path)
        {
            List<taiLieu> ltl = new List<taiLieu>();
            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split('\t');
                    if (arr.Length == 5)
                    {
                        taiLieu tl = new taiLieu();
                        tl.maTL = arr[0].Trim();
                        tl.giaTri = arr[1].Trim();
                        tl.donVi = arr[2].Trim();
                        tl.date = arr[3].Trim();
                        tl.trangThai = arr[4].Trim();
                        ltl.Add(tl);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ltl;
        }
    }
}
