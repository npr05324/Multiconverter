namespace multicoder
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.base64d = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.base64e = new System.Windows.Forms.Button();
            this.asciie = new System.Windows.Forms.Button();
            this.asciid = new System.Windows.Forms.Button();
            this.asciistr = new System.Windows.Forms.TextBox();
            this.asciiint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // base64d
            // 
            this.base64d.Location = new System.Drawing.Point(603, 59);
            this.base64d.Name = "base64d";
            this.base64d.Size = new System.Drawing.Size(86, 23);
            this.base64d.TabIndex = 1;
            this.base64d.Text = "Base64 DE";
            this.base64d.UseVisualStyleBackColor = true;
            this.base64d.Click += new System.EventHandler(this.base64d_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // base64e
            // 
            this.base64e.Location = new System.Drawing.Point(603, 29);
            this.base64e.Name = "base64e";
            this.base64e.Size = new System.Drawing.Size(86, 23);
            this.base64e.TabIndex = 0;
            this.base64e.Text = "Base64 EN";
            this.base64e.UseVisualStyleBackColor = true;
            this.base64e.Click += new System.EventHandler(this.base64e_Click);
            // 
            // asciie
            // 
            this.asciie.Location = new System.Drawing.Point(603, 108);
            this.asciie.Name = "asciie";
            this.asciie.Size = new System.Drawing.Size(86, 23);
            this.asciie.TabIndex = 3;
            this.asciie.Text = "Ascii EN";
            this.asciie.UseVisualStyleBackColor = true;
            this.asciie.Click += new System.EventHandler(this.asciie_Click);
            // 
            // asciid
            // 
            this.asciid.Location = new System.Drawing.Point(603, 137);
            this.asciid.Name = "asciid";
            this.asciid.Size = new System.Drawing.Size(86, 23);
            this.asciid.TabIndex = 4;
            this.asciid.Text = "Ascii DE";
            this.asciid.UseVisualStyleBackColor = true;
            this.asciid.Click += new System.EventHandler(this.asciid_Click);
            // 
            // asciistr
            // 
            this.asciistr.Location = new System.Drawing.Point(25, 109);
            this.asciistr.Name = "asciistr";
            this.asciistr.Size = new System.Drawing.Size(562, 21);
            this.asciistr.TabIndex = 5;
            this.asciistr.TextChanged += new System.EventHandler(this.asciistr_TextChanged);
            // 
            // asciiint
            // 
            this.asciiint.Location = new System.Drawing.Point(25, 139);
            this.asciiint.Name = "asciiint";
            this.asciiint.Size = new System.Drawing.Size(562, 21);
            this.asciiint.TabIndex = 6;
            this.asciiint.TextChanged += new System.EventHandler(this.asciiint_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 362);
            this.Controls.Add(this.asciiint);
            this.Controls.Add(this.asciistr);
            this.Controls.Add(this.asciid);
            this.Controls.Add(this.asciie);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.base64d);
            this.Controls.Add(this.base64e);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button base64d;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button base64e;
        private System.Windows.Forms.Button asciie;
        private System.Windows.Forms.Button asciid;
        private System.Windows.Forms.TextBox asciistr;
        private System.Windows.Forms.TextBox asciiint;
    }
}

