namespace IlmaAPI
{
    partial class Ilma_API
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
            this.peaLinn = new System.Windows.Forms.Label();
            this.temper = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.riik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // peaLinn
            // 
            this.peaLinn.AutoSize = true;
            this.peaLinn.BackColor = System.Drawing.Color.Transparent;
            this.peaLinn.Font = new System.Drawing.Font("Arial Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peaLinn.ForeColor = System.Drawing.Color.DarkCyan;
            this.peaLinn.Location = new System.Drawing.Point(22, 23);
            this.peaLinn.Name = "peaLinn";
            this.peaLinn.Size = new System.Drawing.Size(363, 95);
            this.peaLinn.TabIndex = 0;
            this.peaLinn.Text = "TALLINN";
            // 
            // temper
            // 
            this.temper.AutoSize = true;
            this.temper.BackColor = System.Drawing.Color.Transparent;
            this.temper.Font = new System.Drawing.Font("Arial Black", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temper.ForeColor = System.Drawing.Color.DarkCyan;
            this.temper.Location = new System.Drawing.Point(205, 565);
            this.temper.Name = "temper";
            this.temper.Size = new System.Drawing.Size(119, 95);
            this.temper.TabIndex = 1;
            this.temper.Text = "°C";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::IlmaAPI.Properties.Resources.Cloud___Lightning1;
            this.pictureBox2.Location = new System.Drawing.Point(38, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(453, 441);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // riik
            // 
            this.riik.AutoSize = true;
            this.riik.BackColor = System.Drawing.Color.Transparent;
            this.riik.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riik.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.riik.Location = new System.Drawing.Point(383, 67);
            this.riik.Name = "riik";
            this.riik.Size = new System.Drawing.Size(108, 38);
            this.riik.TabIndex = 3;
            this.riik.Text = "EESTI";
            // 
            // Ilma_API
            // 
            this.BackgroundImage = global::IlmaAPI.Properties.Resources.KSAiRwR1;
            this.ClientSize = new System.Drawing.Size(558, 695);
            this.Controls.Add(this.riik);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.temper);
            this.Controls.Add(this.peaLinn);
            this.Name = "Ilma_API";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label linn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label peaLinn;
        private System.Windows.Forms.Label temper;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label riik;
    }
}

