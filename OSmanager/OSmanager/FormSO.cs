using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace OSmanager
{
    public partial class FormSO : Form
    {

        byte _Type;

        FormBase _MyBase;

        public void RefreshData()
        {
            DataViewRam.DataSource = Memory.Ram.ToList();
            dataGridVM.DataSource = VirtualMemory.VM.ToList();
        }

        public void ExecuteFunction()
        {

            while (true)
            {
                //se tiver espaço na memoria para o primeiro processo da memoria virtual
                if (!VirtualMemory.Empyt())
                    if (!Memory.MemoryFull(VirtualMemory.FirstLenght()))
                        Memory.InitializeProcess(VirtualMemory.KillProcess());

                //executar se a memoria não estiver vazia
                if (!Memory.EmptyProcessUser())
                {
                    if (_Type == 0)
                        FCFS.Execute(Memory.KillProcess());
                    else
                        RoudRobin.Execute(Memory.KillProcess());
                }
            }
        }

        public FormSO(FormBase MyBase, byte Type)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            _MyBase = MyBase;

            _Type = Type;

            timer.Start();

            //executar em looping
            //Thread MinhaThread = new Thread(ExecuteFunction);

            //MinhaThread.Start();

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

        private void timer_Tick(object sender, EventArgs e)
        {
            RefreshData();

            //se tiver espaço na memoria para o primeiro processo da memoria virtual
            if (!VirtualMemory.Empyt())
                if (!Memory.MemoryFull(VirtualMemory.FirstLenght()))
                    Memory.InitializeProcess(VirtualMemory.KillProcess());

            //executar se a memoria não estiver vazia
            if (!Memory.EmptyProcessUser())
            {
                //FCFS sem usar classe
                if (_Type == 0)
                {
                    Process p = Memory.KillProcess();
                    RefreshData();
                    while (!CPU.Execute(p))
                    {
                        ProgressCPU.Increment(1);
                        RefreshData();
                    }
                    //se ja tiver executado completo não necessario enfileirar
                    if (p.Size != 0)
                    {
                        MMU.Translate(p);
                    }
                    RefreshData();
                }
                //usando a classe -> bug multiplicando
                else
                    RoudRobin.Execute(Memory.KillProcess());
            }

            RefreshData();
        }
    }
}
