namespace iberWatch
{
    partial class iberWatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iberWatch));
            this.paneli = new System.Windows.Forms.Panel();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblOra = new System.Windows.Forms.Label();
            this.lblDitaMuaji = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblViti = new System.Windows.Forms.Label();
            this.lblDita = new System.Windows.Forms.Label();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paneli.Controls.Add(this.lblDita);
            this.paneli.Controls.Add(this.lblViti);
            this.paneli.Controls.Add(this.lblTT);
            this.paneli.Controls.Add(this.lblOra);
            this.paneli.Controls.Add(this.lblDitaMuaji);
            this.paneli.Controls.Add(this.foto);
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(298, 446);
            this.paneli.TabIndex = 0;
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.lblTT.Font = new System.Drawing.Font("Bison Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.ForeColor = System.Drawing.Color.White;
            this.lblTT.Location = new System.Drawing.Point(198, 216);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(47, 38);
            this.lblTT.TabIndex = 3;
            this.lblTT.Text = "AM";
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.lblOra.Font = new System.Drawing.Font("Bison Bold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOra.ForeColor = System.Drawing.Color.White;
            this.lblOra.Location = new System.Drawing.Point(94, 195);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(122, 64);
            this.lblOra.TabIndex = 1;
            this.lblOra.Text = "00:00";
            // 
            // lblDitaMuaji
            // 
            this.lblDitaMuaji.AutoSize = true;
            this.lblDitaMuaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.lblDitaMuaji.Font = new System.Drawing.Font("Grold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDitaMuaji.ForeColor = System.Drawing.Color.White;
            this.lblDitaMuaji.Location = new System.Drawing.Point(68, 259);
            this.lblDitaMuaji.Name = "lblDitaMuaji";
            this.lblDitaMuaji.Size = new System.Drawing.Size(45, 17);
            this.lblDitaMuaji.TabIndex = 2;
            this.lblDitaMuaji.Text = "01 jun";
            // 
            // foto
            // 
            this.foto.Image = ((System.Drawing.Image)(resources.GetObject("foto.Image")));
            this.foto.Location = new System.Drawing.Point(3, 0);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(289, 446);
            this.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.foto.TabIndex = 0;
            this.foto.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblViti
            // 
            this.lblViti.AutoSize = true;
            this.lblViti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.lblViti.Font = new System.Drawing.Font("Grold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViti.ForeColor = System.Drawing.Color.White;
            this.lblViti.Location = new System.Drawing.Point(127, 259);
            this.lblViti.Name = "lblViti";
            this.lblViti.Size = new System.Drawing.Size(38, 17);
            this.lblViti.TabIndex = 4;
            this.lblViti.Text = "2021";
            // 
            // lblDita
            // 
            this.lblDita.AutoSize = true;
            this.lblDita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.lblDita.Font = new System.Drawing.Font("Grold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDita.ForeColor = System.Drawing.Color.White;
            this.lblDita.Location = new System.Drawing.Point(192, 259);
            this.lblDita.Name = "lblDita";
            this.lblDita.Size = new System.Drawing.Size(38, 17);
            this.lblDita.TabIndex = 5;
            this.lblDita.Text = "Wed";
            // 
            // iberWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 446);
            this.Controls.Add(this.paneli);
            this.Name = "iberWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iber watch";
            this.Load += new System.EventHandler(this.iberWatch_Load);
            this.paneli.ResumeLayout(false);
            this.paneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneli;
        private System.Windows.Forms.Label lblDitaMuaji;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblViti;
        private System.Windows.Forms.Label lblDita;
    }
}

