using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Excel2Json.CSVAndXml
{
    class CSV2XML
    {
        bool bStart = false;
        /// <summary>
        /// 写入xml文件
        /// </summary>
        /// <param name="path"></param>
        public void WriteToXml(string path)
        {
            DataTable table = GetCSVContent(path);
            ///开始写入xml
            
            //2.创建XML文档对象
            XmlDocument xmldoc = new XmlDocument();
            //3.创建第一行描述信息，添加到xmldoc文档中
            XmlDeclaration xmldec = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmldoc.AppendChild(xmldec);
            //4.创建根节点，xml文档有且只能有一个根节点
            XmlElement root = xmldoc.CreateElement("resources");
            //5.将根节点添加到xmldoc文档中
            xmldoc.AppendChild(root);
            //6.创建子节点
            for (int i = 1; i < table.Rows.Count; i++)
            {
                XmlElement str = xmldoc.CreateElement("string");
                str.InnerText = table.Rows[i]["content"].ToString();
                str.SetAttribute("name", table.Rows[i]["name"].ToString());
                root.AppendChild(str);
            }

            string dirPath = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            if(!Directory.Exists(dirPath + "\\CSV文件夹"))
            {
                Directory.CreateDirectory((dirPath + "\\CSV文件夹"));
            }
            xmldoc.Save(dirPath + "\\CSV文件夹\\" + fileName + ".xml");

        }

        /// <summary>
        /// 获取CSV文件的内容
        /// </summary>
        /// <param name="path">这里传过来的要是全路径</param>
        /// <returns></returns>
        private DataTable GetCSVContent(string path)
        {
            DataTable myDT = new DataTable();
            int colCount = 0;
            bool flag = true;
            DataColumn myDC;
            DataRow myDR;
            string strLine;
            string[] arrayLine;
            try
            {
                StreamReader reader = new StreamReader(path, Encoding.Default);
                while ((strLine = reader.ReadLine()) != null)
                {
                    arrayLine = strLine.Split(',');
                    if (flag)
                    {
                        flag = false;
                        colCount = arrayLine.Length;
                        for (int i = 0; i < arrayLine.Length; i++)
                        {
                            myDC = new DataColumn(arrayLine[i]);
                            myDT.Columns.Add(myDC);
                        }
                    }

                    myDR = myDT.NewRow();
                    for (int i = 0; i < colCount; i++)
                    {
                        myDR[i] = arrayLine[i];
                    }
                    myDT.Rows.Add(myDR);
                }
                reader.Close();
                return myDT;
            }
            catch (Exception)
            {
                throw new Exception("要转换的文件可能在编辑，请关闭后重试");
            }
            
        }
    }
}
