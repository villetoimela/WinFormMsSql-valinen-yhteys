
namespace WinFormMsSql_valinen_yhteys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OpiskelijaIDtextBox = new System.Windows.Forms.TextBox();
            this.NimitextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RyhmanIDtextBox = new System.Windows.Forms.TextBox();
            this.buttonLisaa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Haebutton = new System.Windows.Forms.Button();
            this.PoistaTietuebutton = new System.Windows.Forms.Button();
            this.HaeRyhmabutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opiskelijan ID";
            // 
            // OpiskelijaIDtextBox
            // 
            this.OpiskelijaIDtextBox.Location = new System.Drawing.Point(97, 20);
            this.OpiskelijaIDtextBox.Name = "OpiskelijaIDtextBox";
            this.OpiskelijaIDtextBox.Size = new System.Drawing.Size(48, 23);
            this.OpiskelijaIDtextBox.TabIndex = 1;
            // 
            // NimitextBox
            // 
            this.NimitextBox.Location = new System.Drawing.Point(271, 20);
            this.NimitextBox.Name = "NimitextBox";
            this.NimitextBox.Size = new System.Drawing.Size(152, 23);
            this.NimitextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opiskelijan Nimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ryhman ID";
            // 
            // RyhmanIDtextBox
            // 
            this.RyhmanIDtextBox.Location = new System.Drawing.Point(516, 20);
            this.RyhmanIDtextBox.Name = "RyhmanIDtextBox";
            this.RyhmanIDtextBox.Size = new System.Drawing.Size(48, 23);
            this.RyhmanIDtextBox.TabIndex = 5;
            // 
            // buttonLisaa
            // 
            this.buttonLisaa.Location = new System.Drawing.Point(605, 20);
            this.buttonLisaa.Name = "buttonLisaa";
            this.buttonLisaa.Size = new System.Drawing.Size(170, 23);
            this.buttonLisaa.TabIndex = 6;
            this.buttonLisaa.Text = "Lisää";
            this.buttonLisaa.UseVisualStyleBackColor = true;
            this.buttonLisaa.Click += new System.EventHandler(this.buttonLisaa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 142);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 296);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(776, 142);
            this.dataGridView2.TabIndex = 8;
            // 
            // Haebutton
            // 
            this.Haebutton.Location = new System.Drawing.Point(294, 62);
            this.Haebutton.Name = "Haebutton";
            this.Haebutton.Size = new System.Drawing.Size(105, 31);
            this.Haebutton.TabIndex = 9;
            this.Haebutton.Text = "Hae nimet";
            this.Haebutton.UseVisualStyleBackColor = true;
            this.Haebutton.Click += new System.EventHandler(this.Haebutton_Click);
            // 
            // PoistaTietuebutton
            // 
            this.PoistaTietuebutton.Location = new System.Drawing.Point(405, 62);
            this.PoistaTietuebutton.Name = "PoistaTietuebutton";
            this.PoistaTietuebutton.Size = new System.Drawing.Size(105, 31);
            this.PoistaTietuebutton.TabIndex = 10;
            this.PoistaTietuebutton.Text = "Poista tietue";
            this.PoistaTietuebutton.UseVisualStyleBackColor = true;
            this.PoistaTietuebutton.Click += new System.EventHandler(this.PoistaTietuebutton_Click);
            // 
            // HaeRyhmabutton
            // 
            this.HaeRyhmabutton.Location = new System.Drawing.Point(294, 259);
            this.HaeRyhmabutton.Name = "HaeRyhmabutton";
            this.HaeRyhmabutton.Size = new System.Drawing.Size(216, 31);
            this.HaeRyhmabutton.TabIndex = 11;
            this.HaeRyhmabutton.Text = "Hae ryhmat";
            this.HaeRyhmabutton.UseVisualStyleBackColor = true;
            this.HaeRyhmabutton.Click += new System.EventHandler(this.HaeRyhmabutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HaeRyhmabutton);
            this.Controls.Add(this.PoistaTietuebutton);
            this.Controls.Add(this.Haebutton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLisaa);
            this.Controls.Add(this.RyhmanIDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NimitextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpiskelijaIDtextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OpiskelijaIDtextBox;
        private System.Windows.Forms.TextBox NimitextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RyhmanIDtextBox;
        private System.Windows.Forms.Button buttonLisaa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Haebutton;
        private System.Windows.Forms.Button PoistaTietuebutton;
        private System.Windows.Forms.Button HaeRyhmabutton;
    }
}

