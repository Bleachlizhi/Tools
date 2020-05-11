using System.IO;
using System.Xml;
using System.Collections.Generic;
using System;
using System.Text;

namespace Excel2Json.CSVAndXml
{
    class XML2CSV
    {
        private string path;
        private Dictionary<string, string> xmlKeyAndValue;

        public XML2CSV(string path)
        {
            this.path = path;
            xmlKeyAndValue = new Dictionary<string, string>();
        }

        public void WriteToCSV()
        {
            GetXmlContent();

            string csvDir = Path.GetDirectoryName(path) + "\\" + Path.GetFileNameWithoutExtension(path);
            //创建CSV文件
            if(!Directory.Exists(csvDir))
            {
                Directory.CreateDirectory(csvDir);
            }
            string csvFileName = csvDir + "\\" + Path.GetFileNameWithoutExtension(path) + ".csv";
            StringBuilder content = new StringBuilder();
            content.Append("name").Append(",").Append("content").Append("\r\n");
            //添加内容
            foreach (var item in xmlKeyAndValue)
            {
                content.Append(item.Key).Append(",").Append(item.Value).Append("\r\n");
            }
            FileStream fs = new FileStream(csvFileName, FileMode.Create);
            byte[] bytes = Encoding.UTF8.GetBytes(content.ToString());
            fs.Write(bytes, 0, bytes.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        /// <summary>
        /// 获取XML的内容
        /// </summary>
        private void GetXmlContent()
        {
            XmlTextReader reader = new XmlTextReader(Path.GetFullPath(path));
            while(reader.Read())
            {
                if (reader.Name == "string") //判断节点名称
                {
                    xmlKeyAndValue.Add(reader.GetAttribute("name"), reader.ReadString());
                }
            }
        }
    }
}
