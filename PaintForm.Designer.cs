namespace WindowsFormsApp1
{
    partial class PaintForm
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
            this.pictureBoxDibujo = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDibujo
            // 
            this.pictureBoxDibujo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxDibujo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDibujo.Location = new System.Drawing.Point(1, 41);
            this.pictureBoxDibujo.Name = "pictureBoxDibujo";
            this.pictureBoxDibujo.Size = new System.Drawing.Size(799, 304);
            this.pictureBoxDibujo.TabIndex = 0;
            this.pictureBoxDibujo.TabStop = false;
            this.pictureBoxDibujo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            // 
            // btnColor1
            // 
            this.btnColor1.Location = new System.Drawing.Point(12, 351);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(131, 42);
            this.btnColor1.TabIndex = 1;
            this.btnColor1.Text = "Selecciona Color";
            this.btnColor1.UseVisualStyleBackColor = true;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cambiar Fondo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.pictureBoxDibujo);
            this.Name = "PaintForm";
            this.Text = "PaintForm";
            this.Load += new System.EventHandler(this.PaintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDibujo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.PictureBox pictureBoxDibujo;
        public System.Windows.Forms.ColorDialog btnColor;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button button1;
    }
}