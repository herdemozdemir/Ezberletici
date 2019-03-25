namespace TurkceIngProje
{
    partial class Form1
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
            this.btnGstr = new System.Windows.Forms.Button();
            this.btnAyrlr = new System.Windows.Forms.Button();
            this.TxtTurkce = new System.Windows.Forms.TextBox();
            this.txtIng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGstr
            // 
            this.btnGstr.Location = new System.Drawing.Point(24, 115);
            this.btnGstr.Name = "btnGstr";
            this.btnGstr.Size = new System.Drawing.Size(90, 32);
            this.btnGstr.TabIndex = 0;
            this.btnGstr.Text = "Göster";
            this.btnGstr.UseVisualStyleBackColor = true;
            this.btnGstr.Click += new System.EventHandler(this.btnGstr_Click);
            // 
            // btnAyrlr
            // 
            this.btnAyrlr.Location = new System.Drawing.Point(120, 115);
            this.btnAyrlr.Name = "btnAyrlr";
            this.btnAyrlr.Size = new System.Drawing.Size(95, 32);
            this.btnAyrlr.TabIndex = 1;
            this.btnAyrlr.Text = "Ayarlar";
            this.btnAyrlr.UseVisualStyleBackColor = true;
            this.btnAyrlr.Click += new System.EventHandler(this.btnAyrlr_Click);
            // 
            // TxtTurkce
            // 
            this.TxtTurkce.Location = new System.Drawing.Point(131, 36);
            this.TxtTurkce.Name = "TxtTurkce";
            this.TxtTurkce.Size = new System.Drawing.Size(180, 26);
            this.TxtTurkce.TabIndex = 3;
            // 
            // txtIng
            // 
            this.txtIng.Location = new System.Drawing.Point(131, 68);
            this.txtIng.Name = "txtIng";
            this.txtIng.Size = new System.Drawing.Size(180, 26);
            this.txtIng.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Türkçe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "İngilizce:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIng);
            this.Controls.Add(this.TxtTurkce);
            this.Controls.Add(this.btnAyrlr);
            this.Controls.Add(this.btnGstr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGstr;
        private System.Windows.Forms.Button btnAyrlr;
        private System.Windows.Forms.TextBox TxtTurkce;
        private System.Windows.Forms.TextBox txtIng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

