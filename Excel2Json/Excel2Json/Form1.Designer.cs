namespace Excel2Json
{
    partial class Excel2JSON工具
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excel2JSON工具));
            this.SelectExcel = new System.Windows.Forms.Button();
            this.Tips = new System.Windows.Forms.TextBox();
            this.SingleOrMul = new System.Windows.Forms.CheckBox();
            this.XMLOrJson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExcelToXML = new System.Windows.Forms.RadioButton();
            this.XML2Excel = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectExcel
            // 
            this.SelectExcel.Location = new System.Drawing.Point(70, 37);
            this.SelectExcel.Name = "SelectExcel";
            this.SelectExcel.Size = new System.Drawing.Size(116, 65);
            this.SelectExcel.TabIndex = 0;
            this.SelectExcel.Text = "Excel->JSON";
            this.SelectExcel.UseVisualStyleBackColor = true;
            this.SelectExcel.Click += new System.EventHandler(this.SelectExcel_Click);
            // 
            // Tips
            // 
            this.Tips.Enabled = false;
            this.Tips.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tips.Location = new System.Drawing.Point(40, 211);
            this.Tips.Multiline = true;
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(593, 284);
            this.Tips.TabIndex = 2;
            // 
            // SingleOrMul
            // 
            this.SingleOrMul.AutoSize = true;
            this.SingleOrMul.Location = new System.Drawing.Point(70, 131);
            this.SingleOrMul.Name = "SingleOrMul";
            this.SingleOrMul.Size = new System.Drawing.Size(132, 16);
            this.SingleOrMul.TabIndex = 3;
            this.SingleOrMul.Text = "每个表单都生成文件";
            this.SingleOrMul.UseVisualStyleBackColor = true;
            // 
            // XMLOrJson
            // 
            this.XMLOrJson.Location = new System.Drawing.Point(77, 37);
            this.XMLOrJson.Name = "XMLOrJson";
            this.XMLOrJson.Size = new System.Drawing.Size(116, 65);
            this.XMLOrJson.TabIndex = 4;
            this.XMLOrJson.Text = "XML/CSV互转";
            this.XMLOrJson.UseVisualStyleBackColor = true;
            this.XMLOrJson.Click += new System.EventHandler(this.XMLOrJson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectExcel);
            this.groupBox1.Controls.Add(this.SingleOrMul);
            this.groupBox1.Location = new System.Drawing.Point(27, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel/JSON专区";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExcelToXML);
            this.groupBox2.Controls.Add(this.XML2Excel);
            this.groupBox2.Controls.Add(this.XMLOrJson);
            this.groupBox2.Location = new System.Drawing.Point(335, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 181);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CSV/XML专区";
            // 
            // ExcelToXML
            // 
            this.ExcelToXML.AutoSize = true;
            this.ExcelToXML.Location = new System.Drawing.Point(135, 131);
            this.ExcelToXML.Name = "ExcelToXML";
            this.ExcelToXML.Size = new System.Drawing.Size(71, 16);
            this.ExcelToXML.TabIndex = 6;
            this.ExcelToXML.TabStop = true;
            this.ExcelToXML.Text = "CSV转XML";
            this.ExcelToXML.UseVisualStyleBackColor = true;
            // 
            // XML2Excel
            // 
            this.XML2Excel.AutoSize = true;
            this.XML2Excel.Location = new System.Drawing.Point(34, 131);
            this.XML2Excel.Name = "XML2Excel";
            this.XML2Excel.Size = new System.Drawing.Size(71, 16);
            this.XML2Excel.TabIndex = 5;
            this.XML2Excel.TabStop = true;
            this.XML2Excel.Text = "XML转CSV";
            this.XML2Excel.UseVisualStyleBackColor = true;
            // 
            // Excel2JSON工具
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Excel2JSON工具";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本地化工具";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectExcel;
        private System.Windows.Forms.TextBox Tips;
        private System.Windows.Forms.CheckBox SingleOrMul;
        private System.Windows.Forms.Button XMLOrJson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton XML2Excel;
        private System.Windows.Forms.RadioButton ExcelToXML;
    }
}

