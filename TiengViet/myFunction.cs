using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;
using ConvertDB;

namespace TiengViet
{
     
    public static class MyFunction
    {
        public static List<BaiHoc> danhsachBaihoc;

        static string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\data.xml";
        static string path_NoiCau = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\data_NoiCau.xml";
        public static void ToXml()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<BaiHoc>));

            
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, danhsachBaihoc);
            file.Close();
        }



        public static bool FromXml()
        {
            danhsachBaihoc = new List<BaiHoc>();
            List<BaiHoc> data;

            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                    new System.Xml.Serialization.XmlSerializer(typeof(List<BaiHoc>));
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                data = (List<BaiHoc>)reader.Deserialize(file);
                file.Close();

                danhsachBaihoc = data.OrderBy(x => x.thutu).ToList();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }


        public static bool FromXml_NoiCau()
        {
            danhsachBaihoc = new List<BaiHoc>();
            List<BaiHoc> data;

            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                    new System.Xml.Serialization.XmlSerializer(typeof(List<BaiHoc>));
                System.IO.StreamReader file = new System.IO.StreamReader(path_NoiCau);

                data = (List<BaiHoc>)reader.Deserialize(file);
                file.Close();

                danhsachBaihoc = data.OrderBy(x => x.thutu).ToList();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }


        public static void ToXml_NoiCau()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<BaiHoc>));


            System.IO.FileStream file = System.IO.File.Create(path_NoiCau);

            writer.Serialize(file, danhsachBaihoc);
            file.Close();
        }

        public static BaiHoc ThongtinBaihoc(int id)
        {
            return danhsachBaihoc.FirstOrDefault(x => x.Id == id);
        }

        public static string NoidungToText(List<Noidung> data)
        {
            string str = "";
             
            foreach (Noidung nd in data)
            {
                str += nd.noidung + Environment.NewLine;
            }

            return str;
        }

        

        public static int Get_MaxId()
        {
              
            if (danhsachBaihoc == null || danhsachBaihoc.Count == 0)
                return 0;
            return danhsachBaihoc.Max(x => x.Id);

        }


        public static string ConvertUNI2TCV(string strInput)
        {
            string res = "";
            res = strInput;
            ConvertFont convert = new ConvertFont();
            convert.Convert(ref res, FontIndex.iUNI, FontIndex.iTCV);

            return res;
        }


        public static PrivateFontCollection myfonts = new PrivateFontCollection();
        public static void Load_font()
        {
            // specify embedded resource name
            string resource = "TiengViet.VNAVAN.TTF";

            // receive resource stream
            Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);

            // create a buffer to read in to
            byte[] fontdata = new byte[fontStream.Length];

            // read the font data from the resource
            fontStream.Read(fontdata, 0, (int)fontStream.Length);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);

            // pass the font to the font collection
            myfonts.AddMemoryFont(data, (int)fontStream.Length);

             


            // close the resource stream
            fontStream.Close();

            // free up the unsafe memory
            Marshal.FreeCoTaskMem(data);
            // free up the unsafe memory
            //Marshal.FreeCoTaskMem(data_B);
        }

        public static void copy_font()
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\VNAVAN.TTF";
            string fontFolder = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            string fileName = System.IO.Path.GetFileName(path);
            string targetPath = System.IO.Path.Combine(fontFolder, fileName);
            File.Copy(path, targetPath, false);
        }

    }
}
