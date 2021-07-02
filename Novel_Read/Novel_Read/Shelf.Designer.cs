namespace Novel_Read
{
    partial class Shelf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.gotobookstore = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.novel8 = new System.Windows.Forms.Button();
            this.novel7 = new System.Windows.Forms.Button();
            this.novel6 = new System.Windows.Forms.Button();
            this.novel5 = new System.Windows.Forms.Button();
            this.novel2 = new System.Windows.Forms.Button();
            this.novel4 = new System.Windows.Forms.Button();
            this.novel3 = new System.Windows.Forms.Button();
            this.novel1 = new System.Windows.Forms.Button();
            this.gotonextpage = new System.Windows.Forms.Button();
            this.gotolastpage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.gotobookstore);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 117);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "书架";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(639, 36);
            this.search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(92, 49);
            this.search.TabIndex = 7;
            this.search.Text = "搜索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBox.Location = new System.Drawing.Point(362, 40);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(257, 50);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.refresh.Location = new System.Drawing.Point(262, 36);
            this.refresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(92, 49);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // gotobookstore
            // 
            this.gotobookstore.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gotobookstore.Location = new System.Drawing.Point(160, 36);
            this.gotobookstore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gotobookstore.Name = "gotobookstore";
            this.gotobookstore.Size = new System.Drawing.Size(92, 49);
            this.gotobookstore.TabIndex = 2;
            this.gotobookstore.Text = "书城";
            this.gotobookstore.UseVisualStyleBackColor = true;
            this.gotobookstore.Click += new System.EventHandler(this.gotobookstore_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.novel8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.novel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.novel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.novel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.novel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.novel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.novel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.novel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 126);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 368);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // novel8
            // 
            this.novel8.Location = new System.Drawing.Point(371, 281);
            this.novel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.novel8.Name = "novel8";
            this.novel8.Size = new System.Drawing.Size(360, 82);
            this.novel8.TabIndex = 7;
            this.novel8.Text = "小说8";
            this.novel8.UseVisualStyleBackColor = true;
            this.novel8.Click += new System.EventHandler(this.novel8_Click);
            // 
            // novel7
            // 
            this.novel7.Location = new System.Drawing.Point(4, 281);
            this.novel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.novel7.Name = "novel7";
            this.novel7.Size = new System.Drawing.Size(359, 82);
            this.novel7.TabIndex = 6;
            this.novel7.Text = "小说7";
            this.novel7.UseVisualStyleBackColor = true;
            this.novel7.Click += new System.EventHandler(this.novel7_Click);
            // 
            // novel6
            // 
            this.novel6.Location = new System.Drawing.Point(371, 189);
            this.novel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.novel6.Name = "novel6";
            this.novel6.Size = new System.Drawing.Size(360, 82);
            this.novel6.TabIndex = 5;
            this.novel6.Text = "小说6";
            this.novel6.UseVisualStyleBackColor = true;
            this.novel6.Click += new System.EventHandler(this.novel6_Click);
            // 
            // novel5
            // 
            this.novel5.Location = new System.Drawing.Point(4, 189);
            this.novel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.novel5.Name = "novel5";
            this.novel5.Size = new System.Drawing.Size(359, 82);
            this.novel5.TabIndex = 4;
            this.novel5.Text = "小说5";
            this.novel5.UseVisualStyleBackColor = true;
            this.novel5.Click += new System.EventHandler(this.novel5_Click);
            // 
            // novel2
            // 
            this.novel2.Location = new System.Drawing.Point(371, 5);
            this.novel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.novel2.Name = "novel2";
            this.novel2.Size = new System.Drawing.Size(360, 82);
            this.novel2.TabIndex = 1;
            this.novel2.Text = "小说2";
            this.novel2.UseVisualStyleBackColor = true;
            this.novel2.Click += new System.EventHandler(this.novel2_Click);
            // 
            // novel4
            // 
            this.novel4.Location = new System.Drawing.Point(371, 97);
            this.novel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.novel4.Name = "novel4";
            this.novel4.Size = new System.Drawing.Size(360, 82);
            this.novel4.TabIndex = 3;
            this.novel4.Text = "小说4";
            this.novel4.UseVisualStyleBackColor = true;
            this.novel4.Click += new System.EventHandler(this.novel4_Click);
            // 
            // novel3
            // 
            this.novel3.Location = new System.Drawing.Point(4, 97);
            this.novel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.novel3.Name = "novel3";
            this.novel3.Size = new System.Drawing.Size(359, 82);
            this.novel3.TabIndex = 2;
            this.novel3.Text = "小说3";
            this.novel3.UseVisualStyleBackColor = true;
            this.novel3.Click += new System.EventHandler(this.novel3_Click);
            // 
            // novel1
            // 
            this.novel1.Location = new System.Drawing.Point(4, 5);
            this.novel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.novel1.Name = "novel1";
            this.novel1.Size = new System.Drawing.Size(359, 82);
            this.novel1.TabIndex = 0;
            this.novel1.Text = "小说1";
            this.novel1.UseVisualStyleBackColor = true;
            this.novel1.Click += new System.EventHandler(this.novel1_Click);
            // 
            // gotonextpage
            // 
            this.gotonextpage.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gotonextpage.Location = new System.Drawing.Point(649, 505);
            this.gotonextpage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gotonextpage.Name = "gotonextpage";
            this.gotonextpage.Size = new System.Drawing.Size(89, 46);
            this.gotonextpage.TabIndex = 8;
            this.gotonextpage.Text = "下一页";
            this.gotonextpage.UseVisualStyleBackColor = true;
            this.gotonextpage.Click += new System.EventHandler(this.gotonextpage_Click);
            // 
            // gotolastpage
            // 
            this.gotolastpage.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gotolastpage.Location = new System.Drawing.Point(550, 505);
            this.gotolastpage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gotolastpage.Name = "gotolastpage";
            this.gotolastpage.Size = new System.Drawing.Size(89, 46);
            this.gotolastpage.TabIndex = 9;
            this.gotolastpage.Text = "上一页";
            this.gotolastpage.UseVisualStyleBackColor = true;
            this.gotolastpage.Click += new System.EventHandler(this.gotolastpage_Click);
            // 
            // Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gotolastpage);
            this.Controls.Add(this.gotonextpage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Shelf";
            this.Text = "shelf";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button gotobookstore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button novel8;
        private System.Windows.Forms.Button novel7;
        private System.Windows.Forms.Button novel6;
        private System.Windows.Forms.Button novel5;
        private System.Windows.Forms.Button novel4;
        private System.Windows.Forms.Button novel3;
        private System.Windows.Forms.Button novel2;
        private System.Windows.Forms.Button novel1;
        private System.Windows.Forms.Button gotonextpage;
        private System.Windows.Forms.Button gotolastpage;
        private System.Windows.Forms.Label label2;
    }
}