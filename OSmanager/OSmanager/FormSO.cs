using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSmanager
{
    public partial class FormSO : Form
    {
        Object Scheduler;

        FormBase _MyBase;

        public void RefreshData()
        {
            DataViewRam.DataSource = Memory.Ram.ToList();
            dataGridVM.DataSource = VirtualMemory.VM.ToList();
        }

        public FormSO(FormBase MyBase, byte Type)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            _MyBase = MyBase;


            if (Type == 0)
            {
                Scheduler = new SJF();
            }
            else
            {
                Scheduler = new RoudRobin(20); ; 
            }                       

        }


        private void FormSJFcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MyBase.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.Name = "Lixeira1";
            p.Size = 102;
            p.Time = 4;

            if (Memory.MemoryFull(p.Size))
                VirtualMemory.InitializeProcess(p);
            else
                Memory.InitializeProcess(p);

            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.Name = "Lixeira2";
            p.Size = 8;
            p.Time = 4;

            if (Memory.MemoryFull(p.Size))
                VirtualMemory.InitializeProcess(p);
            else
                Memory.InitializeProcess(p);

            RefreshData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.Name = "Lixeira3";
            p.Size = 8;
            p.Time = 4;

            if (Memory.MemoryFull(p.Size))
                VirtualMemory.InitializeProcess(p);
            else
                Memory.InitializeProcess(p);

            RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.Name = "Lixeira4";
            p.Size = 8;
            p.Time = 4;

            if (Memory.MemoryFull(p.Size))
                VirtualMemory.InitializeProcess(p);
            else
                Memory.InitializeProcess(p);

            RefreshData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.Name = "Lixeira5";
            p.Size = 8;
            p.Time = 4;

            if (Memory.MemoryFull(p.Size))
                VirtualMemory.InitializeProcess(p);
            else
                Memory.InitializeProcess(p);

            RefreshData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.Name = "Lixeira6";
            p.Size = 8;
            p.Time = 4;

            if (Memory.MemoryFull(p.Size))
                VirtualMemory.InitializeProcess(p);
            else
                Memory.InitializeProcess(p);

            RefreshData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.Name = "Lixeira7";
            p.Size = 8;
            p.Time = 4;

            if (Memory.MemoryFull(p.Size))
                VirtualMemory.InitializeProcess(p);
            else
                Memory.InitializeProcess(p);

            RefreshData();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.Name = "Lixeira8";
            p.Size = 8;
            p.Time = 4;

            if (Memory.MemoryFull(p.Size))
                VirtualMemory.InitializeProcess(p);
            else
                Memory.InitializeProcess(p);

            RefreshData();
        }

        
    }
}
