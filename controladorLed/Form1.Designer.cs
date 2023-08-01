namespace controladorLed
{
    partial class Formulario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.ligaLed1 = new System.Windows.Forms.Button();
            this.desligaLed1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ligaLed2 = new System.Windows.Forms.Button();
            this.desligaLed2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.imgLed1 = new System.Windows.Forms.PictureBox();
            this.imgLed2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLed2)).BeginInit();
            this.SuspendLayout();
            // 
            // ligaLed1
            // 
            this.ligaLed1.Location = new System.Drawing.Point(326, 213);
            this.ligaLed1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ligaLed1.Name = "ligaLed1";
            this.ligaLed1.Size = new System.Drawing.Size(109, 50);
            this.ligaLed1.TabIndex = 1;
            this.ligaLed1.Text = "LIGA";
            this.ligaLed1.UseVisualStyleBackColor = true;
            this.ligaLed1.Click += new System.EventHandler(this.ligaLed1_Click);
            // 
            // desligaLed1
            // 
            this.desligaLed1.Location = new System.Drawing.Point(485, 213);
            this.desligaLed1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desligaLed1.Name = "desligaLed1";
            this.desligaLed1.Size = new System.Drawing.Size(108, 50);
            this.desligaLed1.TabIndex = 2;
            this.desligaLed1.Text = "DESLIGA";
            this.desligaLed1.UseVisualStyleBackColor = true;
            this.desligaLed1.Click += new System.EventHandler(this.desligaLed1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "LED 1 -";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "LED 2 -";
            // 
            // ligaLed2
            // 
            this.ligaLed2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ligaLed2.Location = new System.Drawing.Point(326, 348);
            this.ligaLed2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ligaLed2.Name = "ligaLed2";
            this.ligaLed2.Size = new System.Drawing.Size(109, 50);
            this.ligaLed2.TabIndex = 5;
            this.ligaLed2.Text = "LIGA";
            this.ligaLed2.UseVisualStyleBackColor = true;
            this.ligaLed2.Click += new System.EventHandler(this.ligaLed2_Click_1);
            // 
            // desligaLed2
            // 
            this.desligaLed2.Location = new System.Drawing.Point(485, 348);
            this.desligaLed2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desligaLed2.Name = "desligaLed2";
            this.desligaLed2.Size = new System.Drawing.Size(108, 50);
            this.desligaLed2.TabIndex = 6;
            this.desligaLed2.Text = "DESLIGA";
            this.desligaLed2.UseVisualStyleBackColor = true;
            this.desligaLed2.Click += new System.EventHandler(this.desligaLed2_Click);
            // 
            // imgLed1
            // 
            this.imgLed1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgLed1.Location = new System.Drawing.Point(647, 151);
            this.imgLed1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgLed1.Name = "imgLed1";
            this.imgLed1.Size = new System.Drawing.Size(104, 112);
            this.imgLed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLed1.TabIndex = 7;
            this.imgLed1.TabStop = false;
            // 
            // imgLed2
            // 
            this.imgLed2.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgLed2.Location = new System.Drawing.Point(647, 287);
            this.imgLed2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgLed2.Name = "imgLed2";
            this.imgLed2.Size = new System.Drawing.Size(104, 112);
            this.imgLed2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLed2.TabIndex = 9;
            this.imgLed2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(257, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(336, 43);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "MANIPULANDO LEDS";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imgLed2);
            this.Controls.Add(this.imgLed1);
            this.Controls.Add(this.desligaLed2);
            this.Controls.Add(this.ligaLed2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desligaLed1);
            this.Controls.Add(this.ligaLed1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Formulario";
            this.Text = "Leonardo Led\'s";
            ((System.ComponentModel.ISupportInitialize)(this.imgLed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLed2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ligaLed1;
        private System.Windows.Forms.Button desligaLed1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ligaLed2;
        private System.Windows.Forms.Button desligaLed2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox imgLed1;
        private System.Windows.Forms.PictureBox imgLed2;
        private System.Windows.Forms.Label lblTitulo;
    }
}

