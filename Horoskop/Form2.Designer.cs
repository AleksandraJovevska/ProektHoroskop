namespace Horoskop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Дневен = new System.Windows.Forms.TabPage();
            this.tbDneven = new System.Windows.Forms.TextBox();
            this.Неделен = new System.Windows.Forms.TabPage();
            this.tbNedelen = new System.Windows.Forms.TextBox();
            this.Месечен = new System.Windows.Forms.TabPage();
            this.tbMesecen = new System.Windows.Forms.TextBox();
            this.Годишен = new System.Windows.Forms.TabPage();
            this.tbGodisen = new System.Windows.Forms.TextBox();
            this.lblZnak = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Дневен.SuspendLayout();
            this.Неделен.SuspendLayout();
            this.Месечен.SuspendLayout();
            this.Годишен.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Дневен);
            this.tabControl1.Controls.Add(this.Неделен);
            this.tabControl1.Controls.Add(this.Месечен);
            this.tabControl1.Controls.Add(this.Годишен);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 269);
            this.tabControl1.TabIndex = 0;
            // 
            // Дневен
            // 
            this.Дневен.BackColor = System.Drawing.Color.LavenderBlush;
            this.Дневен.BackgroundImage = global::Horoskop.Properties.Resources.rsz_nebula_background_3_by_ohsnapjenny_d5bpx2i3;
            this.Дневен.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Дневен.Controls.Add(this.tbDneven);
            this.Дневен.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Дневен.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Дневен.Location = new System.Drawing.Point(4, 27);
            this.Дневен.Name = "Дневен";
            this.Дневен.Padding = new System.Windows.Forms.Padding(3);
            this.Дневен.Size = new System.Drawing.Size(503, 238);
            this.Дневен.TabIndex = 0;
            this.Дневен.Text = "Дневен";
            this.Дневен.UseVisualStyleBackColor = true;
            // 
            // tbDneven
            // 
            this.tbDneven.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbDneven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDneven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDneven.Location = new System.Drawing.Point(3, 3);
            this.tbDneven.MaximumSize = new System.Drawing.Size(503, 261);
            this.tbDneven.MinimumSize = new System.Drawing.Size(503, 261);
            this.tbDneven.Multiline = true;
            this.tbDneven.Name = "tbDneven";
            this.tbDneven.ReadOnly = true;
            this.tbDneven.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDneven.Size = new System.Drawing.Size(503, 261);
            this.tbDneven.TabIndex = 1;
            // 
            // Неделен
            // 
            this.Неделен.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Неделен.BackgroundImage = global::Horoskop.Properties.Resources.rsz_nebula_background_3_by_ohsnapjenny_d5bpx2i3;
            this.Неделен.Controls.Add(this.tbNedelen);
            this.Неделен.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Неделен.Location = new System.Drawing.Point(4, 27);
            this.Неделен.Name = "Неделен";
            this.Неделен.Padding = new System.Windows.Forms.Padding(3);
            this.Неделен.Size = new System.Drawing.Size(503, 256);
            this.Неделен.TabIndex = 1;
            this.Неделен.Text = "Неделен";
            // 
            // tbNedelen
            // 
            this.tbNedelen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbNedelen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNedelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNedelen.Location = new System.Drawing.Point(3, 3);
            this.tbNedelen.MaximumSize = new System.Drawing.Size(503, 261);
            this.tbNedelen.MinimumSize = new System.Drawing.Size(503, 261);
            this.tbNedelen.Multiline = true;
            this.tbNedelen.Name = "tbNedelen";
            this.tbNedelen.ReadOnly = true;
            this.tbNedelen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNedelen.Size = new System.Drawing.Size(503, 261);
            this.tbNedelen.TabIndex = 1;
            // 
            // Месечен
            // 
            this.Месечен.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Месечен.BackgroundImage = global::Horoskop.Properties.Resources.rsz_nebula_background_3_by_ohsnapjenny_d5bpx2i3;
            this.Месечен.Controls.Add(this.tbMesecen);
            this.Месечен.Location = new System.Drawing.Point(4, 27);
            this.Месечен.Name = "Месечен";
            this.Месечен.Size = new System.Drawing.Size(503, 256);
            this.Месечен.TabIndex = 2;
            this.Месечен.Text = "Месечен";
            // 
            // tbMesecen
            // 
            this.tbMesecen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbMesecen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMesecen.Location = new System.Drawing.Point(0, 0);
            this.tbMesecen.MaximumSize = new System.Drawing.Size(503, 261);
            this.tbMesecen.MinimumSize = new System.Drawing.Size(503, 261);
            this.tbMesecen.Multiline = true;
            this.tbMesecen.Name = "tbMesecen";
            this.tbMesecen.ReadOnly = true;
            this.tbMesecen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMesecen.Size = new System.Drawing.Size(503, 261);
            this.tbMesecen.TabIndex = 1;
            // 
            // Годишен
            // 
            this.Годишен.BackColor = System.Drawing.Color.Violet;
            this.Годишен.BackgroundImage = global::Horoskop.Properties.Resources.rsz_nebula_background_3_by_ohsnapjenny_d5bpx2i3;
            this.Годишен.Controls.Add(this.tbGodisen);
            this.Годишен.Location = new System.Drawing.Point(4, 27);
            this.Годишен.Name = "Годишен";
            this.Годишен.Size = new System.Drawing.Size(503, 256);
            this.Годишен.TabIndex = 3;
            this.Годишен.Text = "Годишен";
            // 
            // tbGodisen
            // 
            this.tbGodisen.BackColor = System.Drawing.Color.Violet;
            this.tbGodisen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGodisen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGodisen.Location = new System.Drawing.Point(0, 0);
            this.tbGodisen.MinimumSize = new System.Drawing.Size(503, 261);
            this.tbGodisen.Multiline = true;
            this.tbGodisen.Name = "tbGodisen";
            this.tbGodisen.ReadOnly = true;
            this.tbGodisen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGodisen.Size = new System.Drawing.Size(503, 261);
            this.tbGodisen.TabIndex = 1;
            // 
            // lblZnak
            // 
            this.lblZnak.AutoSize = true;
            this.lblZnak.BackColor = System.Drawing.Color.Transparent;
            this.lblZnak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZnak.ForeColor = System.Drawing.Color.Black;
            this.lblZnak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblZnak.Location = new System.Drawing.Point(256, 9);
            this.lblZnak.Name = "lblZnak";
            this.lblZnak.Size = new System.Drawing.Size(46, 18);
            this.lblZnak.TabIndex = 1;
            this.lblZnak.Text = "Знак";
            this.lblZnak.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(321, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Затвори";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Horoskop.Properties.Resources.rsz_nebula_background_3_by_ohsnapjenny_d5bpx2i2;
            this.ClientSize = new System.Drawing.Size(532, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblZnak);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Хороскоп";
            this.tabControl1.ResumeLayout(false);
            this.Дневен.ResumeLayout(false);
            this.Дневен.PerformLayout();
            this.Неделен.ResumeLayout(false);
            this.Неделен.PerformLayout();
            this.Месечен.ResumeLayout(false);
            this.Месечен.PerformLayout();
            this.Годишен.ResumeLayout(false);
            this.Годишен.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Дневен;
        private System.Windows.Forms.TabPage Неделен;
        private System.Windows.Forms.TabPage Месечен;
        private System.Windows.Forms.TabPage Годишен;
        private System.Windows.Forms.Label lblZnak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbDneven;
        private System.Windows.Forms.TextBox tbNedelen;
        private System.Windows.Forms.TextBox tbMesecen;
        private System.Windows.Forms.TextBox tbGodisen;
    }
}