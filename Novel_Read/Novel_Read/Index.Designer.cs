
namespace Novel_Read
{
    partial class Index
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
            this.tv_index = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tv_index
            // 
            this.tv_index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_index.Location = new System.Drawing.Point(0, 0);
            this.tv_index.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tv_index.Name = "tv_index";
            this.tv_index.Size = new System.Drawing.Size(600, 360);
            this.tv_index.TabIndex = 0;
            this.tv_index.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_index_AfterSelect);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tv_index);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Index";
            this.Text = "目录";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_index;
    }
}