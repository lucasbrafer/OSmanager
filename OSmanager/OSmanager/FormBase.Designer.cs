namespace OSmanager
{
    partial class FormBase
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
            this.RRButton = new System.Windows.Forms.Button();
            this.FCFSButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RRButton
            // 
            this.RRButton.Location = new System.Drawing.Point(12, 12);
            this.RRButton.Name = "RRButton";
            this.RRButton.Size = new System.Drawing.Size(106, 95);
            this.RRButton.TabIndex = 0;
            this.RRButton.Text = "RR";
            this.RRButton.UseVisualStyleBackColor = true;
            this.RRButton.Click += new System.EventHandler(this.RRButton_Click);
            // 
            // FCFSButton
            // 
            this.FCFSButton.Location = new System.Drawing.Point(141, 12);
            this.FCFSButton.Name = "FCFSButton";
            this.FCFSButton.Size = new System.Drawing.Size(106, 95);
            this.FCFSButton.TabIndex = 1;
            this.FCFSButton.Text = "FCFS";
            this.FCFSButton.UseVisualStyleBackColor = true;
            this.FCFSButton.Click += new System.EventHandler(this.FCFSButton_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(259, 117);
            this.Controls.Add(this.FCFSButton);
            this.Controls.Add(this.RRButton);
            this.MaximizeBox = false;
            this.Name = "FormBase";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RRButton;
        private System.Windows.Forms.Button FCFSButton;
    }
}

