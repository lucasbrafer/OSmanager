namespace OSmanager
{
    partial class FormSO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSO));
            this.ProgressCPU = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DataViewRam = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AbrirNetflix = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridVM = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.RefreshAutoT = new System.Windows.Forms.Timer(this.components);
            this.TimerCPU = new System.Windows.Forms.Timer(this.components);
            this.PBmemory = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharWord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVM)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressCPU
            // 
            this.ProgressCPU.Location = new System.Drawing.Point(1294, 48);
            this.ProgressCPU.Name = "ProgressCPU";
            this.ProgressCPU.Size = new System.Drawing.Size(22, 93);
            this.ProgressCPU.TabIndex = 1;
            this.ProgressCPU.Tag = "";
            // 
            // DataViewRam
            // 
            this.DataViewRam.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataViewRam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewRam.Location = new System.Drawing.Point(913, 48);
            this.DataViewRam.Name = "DataViewRam";
            this.DataViewRam.RowHeadersWidth = 20;
            this.DataViewRam.Size = new System.Drawing.Size(220, 309);
            this.DataViewRam.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Abrir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AbrirNetflix
            // 
            this.AbrirNetflix.Location = new System.Drawing.Point(36, 261);
            this.AbrirNetflix.Name = "AbrirNetflix";
            this.AbrirNetflix.Size = new System.Drawing.Size(55, 34);
            this.AbrirNetflix.TabIndex = 5;
            this.AbrirNetflix.Text = "Abrir";
            this.AbrirNetflix.UseVisualStyleBackColor = true;
            this.AbrirNetflix.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Abrir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(267, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 34);
            this.button5.TabIndex = 7;
            this.button5.Text = "Abrir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(267, 154);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 34);
            this.button6.TabIndex = 8;
            this.button6.Text = "Abrir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridVM
            // 
            this.dataGridVM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVM.Location = new System.Drawing.Point(583, 48);
            this.dataGridVM.Name = "dataGridVM";
            this.dataGridVM.RowHeadersWidth = 20;
            this.dataGridVM.Size = new System.Drawing.Size(220, 309);
            this.dataGridVM.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RefreshAutoT
            // 
            this.RefreshAutoT.Enabled = true;
            this.RefreshAutoT.Interval = 500;
            this.RefreshAutoT.Tick += new System.EventHandler(this.RefreshAutoT_Tick);
            // 
            // TimerCPU
            // 
            this.TimerCPU.Interval = 1000;
            this.TimerCPU.Tick += new System.EventHandler(this.TimerCPU_Tick);
            // 
            // PBmemory
            // 
            this.PBmemory.Location = new System.Drawing.Point(913, 363);
            this.PBmemory.Name = "PBmemory";
            this.PBmemory.Size = new System.Drawing.Size(220, 23);
            this.PBmemory.TabIndex = 12;
            this.PBmemory.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(1189, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 93);
            this.panel1.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(27, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Word";
            // 
            // btnFecharWord
            // 
            this.btnFecharWord.Location = new System.Drawing.Point(109, 48);
            this.btnFecharWord.Name = "btnFecharWord";
            this.btnFecharWord.Size = new System.Drawing.Size(54, 34);
            this.btnFecharWord.TabIndex = 15;
            this.btnFecharWord.Text = "Fechar";
            this.btnFecharWord.UseVisualStyleBackColor = true;
            this.btnFecharWord.Click += new System.EventHandler(this.BtnFecharWord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Chrome";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(109, 154);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 34);
            this.button7.TabIndex = 17;
            this.button7.Text = "Fechar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Netflix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Visual Studio";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(109, 261);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 34);
            this.button8.TabIndex = 20;
            this.button8.Text = "Fechar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 34);
            this.button3.TabIndex = 21;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Excel";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(337, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 34);
            this.button9.TabIndex = 23;
            this.button9.Text = "Fechar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Power Point";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(337, 154);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 34);
            this.button10.TabIndex = 25;
            this.button10.Text = "Fechar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Bloco de Notas";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(267, 261);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 34);
            this.button11.TabIndex = 27;
            this.button11.Text = "Abrir";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(337, 261);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 34);
            this.button12.TabIndex = 28;
            this.button12.Text = "Fechar";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Photoshop";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(267, 363);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 34);
            this.button13.TabIndex = 30;
            this.button13.Text = "Abrir";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(337, 363);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 34);
            this.button14.TabIndex = 31;
            this.button14.Text = "Fechar";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // processBindingSource
            // 
            this.processBindingSource.DataSource = typeof(OSmanager.Process);
            // 
            // memoryBindingSource
            // 
            this.memoryBindingSource.DataSource = typeof(OSmanager.Memory);
            // 
            // FormSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFecharWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBmemory);
            this.Controls.Add(this.dataGridVM);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AbrirNetflix);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataViewRam);
            this.Controls.Add(this.ProgressCPU);
            this.Name = "FormSO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSJFcs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource memoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeExecutedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource processBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DataViewRam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AbrirNetflix;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridVM;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer RefreshAutoT;
        public System.Windows.Forms.Timer TimerCPU;
        public System.Windows.Forms.ProgressBar ProgressCPU;
        private System.Windows.Forms.ProgressBar PBmemory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}