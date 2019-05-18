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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridVM = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.processBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressCPU
            // 
            this.ProgressCPU.Location = new System.Drawing.Point(1242, 48);
            this.ProgressCPU.Name = "ProgressCPU";
            this.ProgressCPU.Size = new System.Drawing.Size(105, 99);
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
            this.DataViewRam.Size = new System.Drawing.Size(195, 309);
            this.DataViewRam.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 72);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 72);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(50, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 72);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(172, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 72);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(172, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 72);
            this.button6.TabIndex = 8;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(172, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 72);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(172, 315);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 72);
            this.button8.TabIndex = 10;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridVM
            // 
            this.dataGridVM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVM.Location = new System.Drawing.Point(583, 48);
            this.dataGridVM.Name = "dataGridVM";
            this.dataGridVM.RowHeadersWidth = 20;
            this.dataGridVM.Size = new System.Drawing.Size(187, 309);
            this.dataGridVM.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.Controls.Add(this.dataGridVM);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataViewRam);
            this.Controls.Add(this.ProgressCPU);
            this.Name = "FormSO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSJFcs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource memoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeExecutedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource processBindingSource;
        private System.Windows.Forms.ProgressBar ProgressCPU;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DataViewRam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridVM;
        private System.Windows.Forms.Timer timer;
    }
}