
namespace Novel_Read
{
    partial class SetPost
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
            this.txt_postTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_setPost = new System.Windows.Forms.Button();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_postTitle
            // 
            this.txt_postTitle.Location = new System.Drawing.Point(119, 38);
            this.txt_postTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_postTitle.Name = "txt_postTitle";
            this.txt_postTitle.Size = new System.Drawing.Size(305, 25);
            this.txt_postTitle.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "分支标题";
            // 
            // btn_setPost
            // 
            this.btn_setPost.Location = new System.Drawing.Point(339, 346);
            this.btn_setPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setPost.Name = "btn_setPost";
            this.btn_setPost.Size = new System.Drawing.Size(131, 50);
            this.btn_setPost.TabIndex = 7;
            this.btn_setPost.Text = "发送分支";
            this.btn_setPost.UseVisualStyleBackColor = true;
            this.btn_setPost.Click += new System.EventHandler(this.btn_setPost_Click);
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(119, 90);
            this.txt_content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_content.Size = new System.Drawing.Size(607, 224);
            this.txt_content.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "分支正文";
            // 
            // SetPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 422);
            this.Controls.Add(this.txt_postTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_setPost);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SetPost";
            this.Text = "发送分支";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_postTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_setPost;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Label label1;
    }
}