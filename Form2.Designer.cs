namespace Example01
{
    partial class Form2
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
            this.tbSox = new System.Windows.Forms.TextBox();
            this.tbSoy = new System.Windows.Forms.TextBox();
            this.Soo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.tbKetQua = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbSox
            // 
            this.tbSox.Location = new System.Drawing.Point(128, 30);
            this.tbSox.Name = "tbSox";
            this.tbSox.Size = new System.Drawing.Size(623, 20);
            this.tbSox.TabIndex = 0;
            this.tbSox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSoy
            // 
            this.tbSoy.Location = new System.Drawing.Point(128, 75);
            this.tbSoy.Name = "tbSoy";
            this.tbSoy.Size = new System.Drawing.Size(623, 20);
            this.tbSoy.TabIndex = 1;
            // 
            // Soo
            // 
            this.Soo.AutoSize = true;
            this.Soo.Location = new System.Drawing.Point(49, 37);
            this.Soo.Name = "Soo";
            this.Soo.Size = new System.Drawing.Size(28, 13);
            this.Soo.TabIndex = 3;
            this.Soo.Text = "So x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "So y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ket qua";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(35, 398);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(72, 23);
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "Luu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(462, 398);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(75, 23);
            this.btCong.TabIndex = 7;
            this.btCong.Text = "Cong ";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(574, 398);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(75, 23);
            this.btNhan.TabIndex = 8;
            this.btNhan.Text = "Nhan";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(681, 398);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(70, 23);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(128, 126);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(623, 253);
            this.tbKetQua.TabIndex = 11;
            this.tbKetQua.Text = "";
            this.tbKetQua.TextChanged += new System.EventHandler(this.tbKetQua_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Soo);
            this.Controls.Add(this.tbSoy);
            this.Controls.Add(this.tbSox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSox;
        private System.Windows.Forms.TextBox tbSoy;
        private System.Windows.Forms.Label Soo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.RichTextBox tbKetQua;
    }
}