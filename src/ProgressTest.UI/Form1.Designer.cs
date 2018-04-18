namespace ProgressTest.UI
{
    partial class Form1
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
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.spiner = new MetroFramework.Controls.MetroProgressSpinner();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.btnPause = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(23, 117);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(490, 23);
            this.progressBar.TabIndex = 0;
            // 
            // spiner
            // 
            this.spiner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spiner.Location = new System.Drawing.Point(523, 112);
            this.spiner.Maximum = 100;
            this.spiner.Name = "spiner";
            this.spiner.Size = new System.Drawing.Size(38, 33);
            this.spiner.TabIndex = 1;
            this.spiner.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label1.Location = new System.Drawing.Point(574, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "\'\'";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(23, 88);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(106, 88);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pausar";
            this.btnPause.UseSelectable = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(188, 88);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Parar";
            this.btnStop.UseSelectable = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 193);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spiner);
            this.Controls.Add(this.progressBar);
            this.Name = "Form1";
            this.Text = "Formulário de Teste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroProgressSpinner spiner;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroButton btnPause;
        private MetroFramework.Controls.MetroButton btnStop;
    }
}

