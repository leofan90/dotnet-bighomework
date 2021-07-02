
namespace Novel_Read
{
    partial class ReadNovel
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
            this.lab_title = new System.Windows.Forms.Label();
            this.btn_index = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_Novel = new System.Windows.Forms.TextBox();
            this.link_branch1 = new System.Windows.Forms.LinkLabel();
            this.link_branch2 = new System.Windows.Forms.LinkLabel();
            this.link_branch3 = new System.Windows.Forms.LinkLabel();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_adBranch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lab_title);
            this.panel1.Controls.Add(this.btn_index);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 43);
            this.panel1.TabIndex = 0;
            // 
            // lab_title
            // 
            this.lab_title.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.Location = new System.Drawing.Point(14, 7);
            this.lab_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(284, 24);
            this.lab_title.TabIndex = 3;
            this.lab_title.Text = "title";
            this.lab_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_index
            // 
            this.btn_index.Location = new System.Drawing.Point(873, 7);
            this.btn_index.Margin = new System.Windows.Forms.Padding(2);
            this.btn_index.Name = "btn_index";
            this.btn_index.Size = new System.Drawing.Size(88, 24);
            this.btn_index.TabIndex = 1;
            this.btn_index.Text = "目录";
            this.btn_index.UseVisualStyleBackColor = true;
            this.btn_index.Click += new System.EventHandler(this.btn_index_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(770, 7);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(84, 24);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "上一页";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_Novel
            // 
            this.txt_Novel.Location = new System.Drawing.Point(10, 57);
            this.txt_Novel.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Novel.Multiline = true;
            this.txt_Novel.Name = "txt_Novel";
            this.txt_Novel.ReadOnly = true;
            this.txt_Novel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Novel.Size = new System.Drawing.Size(954, 336);
            this.txt_Novel.TabIndex = 1;
            // 
            // link_branch1
            // 
            this.link_branch1.AutoSize = true;
            this.link_branch1.Location = new System.Drawing.Point(106, 403);
            this.link_branch1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_branch1.Name = "link_branch1";
            this.link_branch1.Size = new System.Drawing.Size(77, 12);
            this.link_branch1.TabIndex = 2;
            this.link_branch1.TabStop = true;
            this.link_branch1.Text = "link_branch1";
            this.link_branch1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_branch1_LinkClicked);
            // 
            // link_branch2
            // 
            this.link_branch2.AutoSize = true;
            this.link_branch2.Location = new System.Drawing.Point(106, 435);
            this.link_branch2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_branch2.Name = "link_branch2";
            this.link_branch2.Size = new System.Drawing.Size(77, 12);
            this.link_branch2.TabIndex = 3;
            this.link_branch2.TabStop = true;
            this.link_branch2.Text = "link_branch2";
            this.link_branch2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_branch2_LinkClicked);
            // 
            // link_branch3
            // 
            this.link_branch3.AutoSize = true;
            this.link_branch3.Location = new System.Drawing.Point(106, 464);
            this.link_branch3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_branch3.Name = "link_branch3";
            this.link_branch3.Size = new System.Drawing.Size(77, 12);
            this.link_branch3.TabIndex = 4;
            this.link_branch3.TabStop = true;
            this.link_branch3.Text = "link_branch3";
            this.link_branch3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_branch3_LinkClicked);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(10, 403);
            this.btn_change.Margin = new System.Windows.Forms.Padding(2);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(84, 34);
            this.btn_change.TabIndex = 5;
            this.btn_change.Text = "换一批";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_adBranch
            // 
            this.btn_adBranch.Location = new System.Drawing.Point(10, 445);
            this.btn_adBranch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_adBranch.Name = "btn_adBranch";
            this.btn_adBranch.Size = new System.Drawing.Size(84, 31);
            this.btn_adBranch.TabIndex = 3;
            this.btn_adBranch.Text = "添加分支";
            this.btn_adBranch.UseVisualStyleBackColor = true;
            this.btn_adBranch.Click += new System.EventHandler(this.btn_adBranch_Click);
            // 
            // ReadNovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 486);
            this.Controls.Add(this.btn_adBranch);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.link_branch3);
            this.Controls.Add(this.link_branch2);
            this.Controls.Add(this.link_branch1);
            this.Controls.Add(this.txt_Novel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReadNovel";
            this.Text = "ReadNovel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_index;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_Novel;
        private System.Windows.Forms.LinkLabel link_branch1;
        private System.Windows.Forms.LinkLabel link_branch2;
        private System.Windows.Forms.LinkLabel link_branch3;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_adBranch;
        private System.Windows.Forms.Label lab_title;
    }
}