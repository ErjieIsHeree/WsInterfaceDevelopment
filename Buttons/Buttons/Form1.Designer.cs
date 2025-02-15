namespace Buttons
{
    partial class Form1
    {

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.subtitleLbl1 = new SubtitleLbl();
            this.titleLbl1 = new TitleLbl();
            this.previousBtn1 = new PreviousBtn();
            this.pauseBtn1 = new PauseBtn();
            this.nextBtn1 = new NextBtn();
            this.imagen1 = new Imagen();
            this.quitBtn1 = new QuitBtn();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // subtitleLbl1
            // 
            this.subtitleLbl1.AutoSize = true;
            this.subtitleLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.subtitleLbl1.Location = new System.Drawing.Point(297, 333);
            this.subtitleLbl1.Name = "subtitleLbl1";
            this.subtitleLbl1.Size = new System.Drawing.Size(234, 24);
            this.subtitleLbl1.TabIndex = 7;
            this.subtitleLbl1.Text = "C# WPF Mp3 Music Player";
            // 
            // titleLbl1
            // 
            this.titleLbl1.AutoSize = true;
            this.titleLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.titleLbl1.Location = new System.Drawing.Point(306, 296);
            this.titleLbl1.Name = "titleLbl1";
            this.titleLbl1.Size = new System.Drawing.Size(190, 37);
            this.titleLbl1.TabIndex = 6;
            this.titleLbl1.Text = "Song name";
            // 
            // previousBtn1
            // 
            this.previousBtn1.BackColor = System.Drawing.Color.Red;
            this.previousBtn1.FlatAppearance.BorderSize = 0;
            this.previousBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousBtn1.Image = ((System.Drawing.Image)(resources.GetObject("previousBtn1.Image")));
            this.previousBtn1.Location = new System.Drawing.Point(296, 371);
            this.previousBtn1.Name = "previousBtn1";
            this.previousBtn1.Size = new System.Drawing.Size(40, 40);
            this.previousBtn1.TabIndex = 4;
            this.previousBtn1.UseVisualStyleBackColor = false;
            // 
            // pauseBtn1
            // 
            this.pauseBtn1.BackColor = System.Drawing.Color.Red;
            this.pauseBtn1.FlatAppearance.BorderSize = 0;
            this.pauseBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseBtn1.Image = ((System.Drawing.Image)(resources.GetObject("pauseBtn1.Image")));
            this.pauseBtn1.Location = new System.Drawing.Point(378, 371);
            this.pauseBtn1.Name = "pauseBtn1";
            this.pauseBtn1.Size = new System.Drawing.Size(40, 40);
            this.pauseBtn1.TabIndex = 3;
            this.pauseBtn1.UseVisualStyleBackColor = false;
            // 
            // nextBtn1
            // 
            this.nextBtn1.BackColor = System.Drawing.Color.Red;
            this.nextBtn1.FlatAppearance.BorderSize = 0;
            this.nextBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn1.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn1.Image")));
            this.nextBtn1.Location = new System.Drawing.Point(456, 371);
            this.nextBtn1.Name = "nextBtn1";
            this.nextBtn1.Size = new System.Drawing.Size(40, 40);
            this.nextBtn1.TabIndex = 2;
            this.nextBtn1.UseVisualStyleBackColor = false;
            // 
            // imagen1
            // 
            this.imagen1.Image = ((System.Drawing.Image)(resources.GetObject("imagen1.Image")));
            this.imagen1.Location = new System.Drawing.Point(296, 83);
            this.imagen1.Name = "imagen1";
            this.imagen1.Size = new System.Drawing.Size(200, 200);
            this.imagen1.TabIndex = 0;
            this.imagen1.TabStop = false;
            // 
            // quitBtn1
            // 
            this.quitBtn1.BackColor = System.Drawing.Color.Red;
            this.quitBtn1.FlatAppearance.BorderSize = 0;
            this.quitBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn1.Image = ((System.Drawing.Image)(resources.GetObject("quitBtn1.Image")));
            this.quitBtn1.Location = new System.Drawing.Point(456, 31);
            this.quitBtn1.Name = "quitBtn1";
            this.quitBtn1.Size = new System.Drawing.Size(40, 40);
            this.quitBtn1.TabIndex = 9;
            this.quitBtn1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 651);
            this.Controls.Add(this.quitBtn1);
            this.Controls.Add(this.subtitleLbl1);
            this.Controls.Add(this.titleLbl1);
            this.Controls.Add(this.previousBtn1);
            this.Controls.Add(this.pauseBtn1);
            this.Controls.Add(this.nextBtn1);
            this.Controls.Add(this.imagen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Imagen imagen1;
        private NextBtn nextBtn1;
        private PauseBtn pauseBtn1;
        private PreviousBtn previousBtn1;
        private TitleLbl titleLbl1;
        private SubtitleLbl subtitleLbl1;
        private QuitBtn quitBtn1;
    }
}