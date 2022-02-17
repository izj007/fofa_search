
namespace fofa
{
    partial class PopForm
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
            this.rtb_keyword = new System.Windows.Forms.RichTextBox();
            this.btn_addsok = new System.Windows.Forms.Button();
            this.label_adds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_keyword
            // 
            this.rtb_keyword.Location = new System.Drawing.Point(4, 28);
            this.rtb_keyword.Name = "rtb_keyword";
            this.rtb_keyword.Size = new System.Drawing.Size(318, 354);
            this.rtb_keyword.TabIndex = 0;
            this.rtb_keyword.Text = "";
            // 
            // btn_addsok
            // 
            this.btn_addsok.Location = new System.Drawing.Point(98, 388);
            this.btn_addsok.Name = "btn_addsok";
            this.btn_addsok.Size = new System.Drawing.Size(106, 24);
            this.btn_addsok.TabIndex = 1;
            this.btn_addsok.Text = "确定";
            this.btn_addsok.UseVisualStyleBackColor = true;
            this.btn_addsok.Click += new System.EventHandler(this.btn_addsok_Click);
            // 
            // label_adds
            // 
            this.label_adds.AutoSize = true;
            this.label_adds.Location = new System.Drawing.Point(6, 8);
            this.label_adds.Name = "label_adds";
            this.label_adds.Size = new System.Drawing.Size(89, 12);
            this.label_adds.TabIndex = 2;
            this.label_adds.Text = "批量添加关键词";
            // 
            // PopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 420);
            this.Controls.Add(this.label_adds);
            this.Controls.Add(this.btn_addsok);
            this.Controls.Add(this.rtb_keyword);
            this.Name = "PopForm";
            this.Text = "批量添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_keyword;
        private System.Windows.Forms.Button btn_addsok;
        private System.Windows.Forms.Label label_adds;
    }
}