namespace SemaphoreTest
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
            this.components = new System.ComponentModel.Container();
            this.QuantidadeH = new System.Windows.Forms.TextBox();
            this.QuantidadeV = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cars1 = new System.Windows.Forms.PictureBox();
            this.Cars2 = new System.Windows.Forms.PictureBox();
            this.SemaphoreV = new System.Windows.Forms.PictureBox();
            this.SemaphoreH = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_TempoSemaforo = new System.Windows.Forms.TextBox();
            this.textBox_TempoH = new System.Windows.Forms.TextBox();
            this.textBox_TempoV = new System.Windows.Forms.TextBox();
            this.textBox_TempoT = new System.Windows.Forms.TextBox();
            this.textBox_Modo = new System.Windows.Forms.TextBox();
            this.textBox_timesync = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cars1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cars2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemaphoreV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemaphoreH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // QuantidadeH
            // 
            this.QuantidadeH.Location = new System.Drawing.Point(10, 170);
            this.QuantidadeH.Name = "QuantidadeH";
            this.QuantidadeH.Size = new System.Drawing.Size(52, 20);
            this.QuantidadeH.TabIndex = 4;
            // 
            // QuantidadeV
            // 
            this.QuantidadeV.Location = new System.Drawing.Point(209, 4);
            this.QuantidadeV.Name = "QuantidadeV";
            this.QuantidadeV.Size = new System.Drawing.Size(52, 20);
            this.QuantidadeV.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox1.Image = global::SemaphoreTest.Properties.Resources.white;
            this.pictureBox1.InitialImage = global::SemaphoreTest.Properties.Resources.vermelho;
            this.pictureBox1.Location = new System.Drawing.Point(158, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Cars1
            // 
            this.Cars1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cars1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Cars1.Image = global::SemaphoreTest.Properties.Resources.ca;
            this.Cars1.InitialImage = global::SemaphoreTest.Properties.Resources.vermelho;
            this.Cars1.Location = new System.Drawing.Point(27, 143);
            this.Cars1.Name = "Cars1";
            this.Cars1.Size = new System.Drawing.Size(35, 21);
            this.Cars1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cars1.TabIndex = 3;
            this.Cars1.TabStop = false;
            // 
            // Cars2
            // 
            this.Cars2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cars2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Cars2.Image = global::SemaphoreTest.Properties.Resources.ca;
            this.Cars2.InitialImage = global::SemaphoreTest.Properties.Resources.vermelho;
            this.Cars2.Location = new System.Drawing.Point(158, 3);
            this.Cars2.Name = "Cars2";
            this.Cars2.Size = new System.Drawing.Size(35, 21);
            this.Cars2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cars2.TabIndex = 2;
            this.Cars2.TabStop = false;
            // 
            // SemaphoreV
            // 
            this.SemaphoreV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SemaphoreV.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.SemaphoreV.Image = global::SemaphoreTest.Properties.Resources.vermelho;
            this.SemaphoreV.InitialImage = global::SemaphoreTest.Properties.Resources.vermelho;
            this.SemaphoreV.Location = new System.Drawing.Point(158, 42);
            this.SemaphoreV.Name = "SemaphoreV";
            this.SemaphoreV.Size = new System.Drawing.Size(35, 33);
            this.SemaphoreV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SemaphoreV.TabIndex = 1;
            this.SemaphoreV.TabStop = false;
            // 
            // SemaphoreH
            // 
            this.SemaphoreH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SemaphoreH.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.SemaphoreH.Image = global::SemaphoreTest.Properties.Resources.vermelho;
            this.SemaphoreH.InitialImage = global::SemaphoreTest.Properties.Resources.vermelho;
            this.SemaphoreH.Location = new System.Drawing.Point(79, 131);
            this.SemaphoreH.Name = "SemaphoreH";
            this.SemaphoreH.Size = new System.Drawing.Size(35, 33);
            this.SemaphoreH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SemaphoreH.TabIndex = 0;
            this.SemaphoreH.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBox2.Image = global::SemaphoreTest.Properties.Resources.white;
            this.pictureBox2.InitialImage = global::SemaphoreTest.Properties.Resources.vermelho;
            this.pictureBox2.Location = new System.Drawing.Point(114, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_TempoSemaforo
            // 
            this.textBox_TempoSemaforo.Enabled = false;
            this.textBox_TempoSemaforo.Location = new System.Drawing.Point(264, 235);
            this.textBox_TempoSemaforo.Name = "textBox_TempoSemaforo";
            this.textBox_TempoSemaforo.Size = new System.Drawing.Size(162, 20);
            this.textBox_TempoSemaforo.TabIndex = 9;
            this.textBox_TempoSemaforo.Text = "Tempo Semaforo:";
            // 
            // textBox_TempoH
            // 
            this.textBox_TempoH.Enabled = false;
            this.textBox_TempoH.Location = new System.Drawing.Point(264, 261);
            this.textBox_TempoH.Name = "textBox_TempoH";
            this.textBox_TempoH.Size = new System.Drawing.Size(162, 20);
            this.textBox_TempoH.TabIndex = 10;
            this.textBox_TempoH.Text = "Tempo Sensor H:";
            // 
            // textBox_TempoV
            // 
            this.textBox_TempoV.Enabled = false;
            this.textBox_TempoV.Location = new System.Drawing.Point(264, 287);
            this.textBox_TempoV.Name = "textBox_TempoV";
            this.textBox_TempoV.Size = new System.Drawing.Size(162, 20);
            this.textBox_TempoV.TabIndex = 11;
            this.textBox_TempoV.Text = "Tempo Sensor V:";
            // 
            // textBox_TempoT
            // 
            this.textBox_TempoT.Enabled = false;
            this.textBox_TempoT.Location = new System.Drawing.Point(264, 313);
            this.textBox_TempoT.Name = "textBox_TempoT";
            this.textBox_TempoT.Size = new System.Drawing.Size(162, 20);
            this.textBox_TempoT.TabIndex = 12;
            this.textBox_TempoT.Text = "Tempo T:";
            // 
            // textBox_Modo
            // 
            this.textBox_Modo.Enabled = false;
            this.textBox_Modo.Location = new System.Drawing.Point(264, 209);
            this.textBox_Modo.Name = "textBox_Modo";
            this.textBox_Modo.Size = new System.Drawing.Size(162, 20);
            this.textBox_Modo.TabIndex = 13;
            this.textBox_Modo.Text = "Modo Semaforo:";
            // 
            // textBox_timesync
            // 
            this.textBox_timesync.Location = new System.Drawing.Point(382, 49);
            this.textBox_timesync.Name = "textBox_timesync";
            this.textBox_timesync.Size = new System.Drawing.Size(37, 20);
            this.textBox_timesync.TabIndex = 14;
            this.textBox_timesync.Text = "1";
            this.textBox_timesync.TextChanged += new System.EventHandler(this.textBox_timesync_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tempo Sincronização TimeServer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_timesync);
            this.Controls.Add(this.textBox_Modo);
            this.Controls.Add(this.textBox_TempoT);
            this.Controls.Add(this.textBox_TempoV);
            this.Controls.Add(this.textBox_TempoH);
            this.Controls.Add(this.textBox_TempoSemaforo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QuantidadeV);
            this.Controls.Add(this.QuantidadeH);
            this.Controls.Add(this.Cars1);
            this.Controls.Add(this.Cars2);
            this.Controls.Add(this.SemaphoreV);
            this.Controls.Add(this.SemaphoreH);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cars1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cars2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemaphoreV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemaphoreH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SemaphoreH;
        private System.Windows.Forms.PictureBox SemaphoreV;
        private System.Windows.Forms.PictureBox Cars2;
        private System.Windows.Forms.PictureBox Cars1;
        private System.Windows.Forms.TextBox QuantidadeH;
        private System.Windows.Forms.TextBox QuantidadeV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_TempoSemaforo;
        private System.Windows.Forms.TextBox textBox_TempoH;
        private System.Windows.Forms.TextBox textBox_TempoV;
        private System.Windows.Forms.TextBox textBox_TempoT;
        private System.Windows.Forms.TextBox textBox_Modo;
        private System.Windows.Forms.TextBox textBox_timesync;
        private System.Windows.Forms.Label label1;
    }
}

