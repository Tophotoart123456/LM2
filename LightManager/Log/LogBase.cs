using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Threading;


namespace LightManager
{
    public class LogBase
    {
        string filedir = "";
        string name = "";
        public string GetCurrentPath()
        {
            string reslut = "";
            reslut=/*Directory.GetCurrentDirectory()+*/"..\\LightManagerLog\\";
            return reslut;
        }
        public bool IsCheckFile(string path)
        {
            bool success = false;
            if (Directory.Exists(path))
                success = true;
            return success;
        }
        public string CreateFileName()
        {
            var v= DateTime.Now.Date;
            name = string.Format("{0}-{1}-{2}.log", v.Year, v.Month, v.Day);
            return name;
        }
        public void CreateFile()
        {
            name = CreateFileName();
            filedir = GetCurrentPath();
            
            if (!IsCheckFile(filedir))//open file
            {
                Directory.CreateDirectory(filedir);
            }
        }
        public void WriteInfo(string cmd,string message)
        {
            if(IsCheckFile(filedir))
            {
                using (FileStream f =  File.Open(filedir+name, FileMode.Append))
                {
                    DateTime dt = DateTime.Now;
                    string tm = dt.ToString("yyyyMMdd HH: mm:ss");
                    byte[] buffer = new UTF8Encoding(true).GetBytes(tm);
                    f.Write(buffer, 0, buffer.Length);
                    buffer= new UTF8Encoding(true).GetBytes("命令"+cmd +"::::");
                    f.Write(buffer, 0, buffer.Length);
                    
                    buffer = new UTF8Encoding(true).GetBytes("路点"+message+"\r\n");
                    f.Write(buffer, 0, buffer.Length);
                    
                    f.Close();
                }
            }
        }
        public void WriteInfo(string message)
        {
            if (IsCheckFile(filedir))
            {
                using (FileStream f = File.Open(filedir + name, FileMode.Append))
                {
                    DateTime dt = DateTime.Now;
                    string tm = dt.ToString("yyyyMMdd HH: mm:ss");
                    byte[] buffer = new UTF8Encoding(true).GetBytes(tm);
                    f.Write(buffer, 0, buffer.Length);
                    buffer = new UTF8Encoding(true).GetBytes("3D 数据:" + message + "\r\n");
                    f.Write(buffer, 0, buffer.Length);

                    f.Close();
                }
            }
        }

    }
}
