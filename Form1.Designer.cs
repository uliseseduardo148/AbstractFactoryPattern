namespace AbstractFactoryPattern
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckCenter = new System.Windows.Forms.CheckBox();
            this.ckBorder = new System.Windows.Forms.CheckBox();
            this.ckShade = new System.Windows.Forms.CheckBox();
            this.gdPic1 = new AbstractFactoryPattern.GdPic();
            this.opAnnual = new System.Windows.Forms.RadioButton();
            this.opVegetable = new System.Windows.Forms.RadioButton();
            this.opPerennial = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdPic1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Location = new System.Drawing.Point(202, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(225, 241);
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // ckCenter
            // 
            this.ckCenter.AutoSize = true;
            this.ckCenter.Location = new System.Drawing.Point(265, 409);
            this.ckCenter.Name = "ckCenter";
            this.ckCenter.Size = new System.Drawing.Size(57, 17);
            this.ckCenter.TabIndex = 2;
            this.ckCenter.Text = "Centro";
            this.ckCenter.UseVisualStyleBackColor = true;
            this.ckCenter.CheckedChanged += new System.EventHandler(this.ckCenter_CheckedChanged);
            // 
            // ckBorder
            // 
            this.ckBorder.AutoSize = true;
            this.ckBorder.Location = new System.Drawing.Point(351, 409);
            this.ckBorder.Name = "ckBorder";
            this.ckBorder.Size = new System.Drawing.Size(54, 17);
            this.ckBorder.TabIndex = 3;
            this.ckBorder.Text = "Borde";
            this.ckBorder.UseVisualStyleBackColor = true;
            this.ckBorder.CheckedChanged += new System.EventHandler(this.ckBorder_CheckedChanged);
            // 
            // ckShade
            // 
            this.ckShade.AutoSize = true;
            this.ckShade.Location = new System.Drawing.Point(433, 409);
            this.ckShade.Name = "ckShade";
            this.ckShade.Size = new System.Drawing.Size(62, 17);
            this.ckShade.TabIndex = 4;
            this.ckShade.Text = "Sombra";
            this.ckShade.UseVisualStyleBackColor = true;
            this.ckShade.CheckedChanged += new System.EventHandler(this.ckShade_CheckedChanged);
            // 
            // gdPic1
            // 
            this.gdPic1.BackColor = System.Drawing.Color.Honeydew;
            this.gdPic1.Location = new System.Drawing.Point(202, 12);
            this.gdPic1.Name = "gdPic1";
            this.gdPic1.Size = new System.Drawing.Size(370, 377);
            this.gdPic1.TabIndex = 5;
            this.gdPic1.TabStop = false;
            // 
            // opAnnual
            // 
            this.opAnnual.AutoSize = true;
            this.opAnnual.Location = new System.Drawing.Point(17, 19);
            this.opAnnual.Name = "opAnnual";
            this.opAnnual.Size = new System.Drawing.Size(63, 17);
            this.opAnnual.TabIndex = 1;
            this.opAnnual.TabStop = true;
            this.opAnnual.Text = "Anuales";
            this.opAnnual.UseVisualStyleBackColor = true;
            this.opAnnual.CheckedChanged += new System.EventHandler(this.opAnnual_CheckedChanged);
            // 
            // opVegetable
            // 
            this.opVegetable.AutoSize = true;
            this.opVegetable.Location = new System.Drawing.Point(16, 42);
            this.opVegetable.Name = "opVegetable";
            this.opVegetable.Size = new System.Drawing.Size(72, 17);
            this.opVegetable.TabIndex = 1;
            this.opVegetable.TabStop = true;
            this.opVegetable.Text = "Vegetales";
            this.opVegetable.UseVisualStyleBackColor = true;
            this.opVegetable.CheckedChanged += new System.EventHandler(this.opVegetable_CheckedChanged);
            // 
            // opPerennial
            // 
            this.opPerennial.AutoSize = true;
            this.opPerennial.Location = new System.Drawing.Point(16, 65);
            this.opPerennial.Name = "opPerennial";
            this.opPerennial.Size = new System.Drawing.Size(70, 17);
            this.opPerennial.TabIndex = 1;
            this.opPerennial.TabStop = true;
            this.opPerennial.Text = "Perennes";
            this.opPerennial.UseVisualStyleBackColor = true;
            this.opPerennial.CheckedChanged += new System.EventHandler(this.opPerennial_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opAnnual);
            this.groupBox1.Controls.Add(this.opPerennial);
            this.groupBox1.Controls.Add(this.opVegetable);
            this.groupBox1.Location = new System.Drawing.Point(34, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de jardines";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gdPic1);
            this.Controls.Add(this.ckShade);
            this.Controls.Add(this.ckBorder);
            this.Controls.Add(this.ckCenter);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdPic1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.CheckBox ckCenter;
        private System.Windows.Forms.CheckBox ckBorder;
        private System.Windows.Forms.CheckBox ckShade;
        private GdPic gdPic1;
        private System.Windows.Forms.RadioButton opAnnual;
        private System.Windows.Forms.RadioButton opVegetable;
        private System.Windows.Forms.RadioButton opPerennial;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

