using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace OSmanager
{
    public partial class FormSO : Form
    {
        byte _Type;

        FormBase _MyBase;

        public void ThTimer()
        {
            System.Threading.Thread.Sleep(1000);
        }

        public void FCFS()
        {
            //executar se a memoria não estiver vazia
            if (!Memory.EmptyProcessUser())
            {
                //tira processo da fila
                Process p = Memory.KillProcess();
                RefreshData();

                //progressbar CPU
                ProgressCPU.Value = 0;
                ProgressCPU.Maximum = p.Time;

                //nome do processo na cpu
                lblName.Text = p.Name;

                while (!CPU.Execute(ref p))
                {
                    //tempo do processo na cpu
                    lblTime.Text = p.Time.ToString();

                    //tempo de execução
                    Thread MinhaThread = new Thread(ThTimer);
                    MinhaThread.Start();

                    ProgressCPU.Increment(1);
                }

                //MMU traduz
                MMU.Translate(ref p);

                //reseta progressBar CPU
                ProgressCPU.Value = 0;


                //reseta nome e tempo CPU
                lblName.Text = "";
                lblTime.Text = "";


            }
            //começa novamente o timer que irá chamar os escalonadores
            TimerCPU.Start();
        }

        public void RoundRobin()
        {
            if (!Memory.EmptyProcessUser())
            {
                //tira processo da fila
                Process p = Memory.KillProcess();
                RefreshData();

                //Progressbar CPU
                ProgressCPU.Value = 0;
                ProgressCPU.Maximum = p.Time;

                //Nome do processo na CPU
                lblName.Text = p.Name;

                int i = 1;
                while (i <= 20)
                {
                    //executa se for true break 
                    if (CPU.Execute(ref p))
                        break;

                    //tempo do processo na CPU
                    lblTime.Text = p.Time.ToString();
                    RefreshData();

                    //tempo de execução 
                    Thread MinhaThread = new Thread(ThTimer);
                    MinhaThread.Start();

                    ProgressCPU.Increment(1);
                    i++;
                }

                //mmu traduz
                MMU.Translate(ref p);
                ProgressCPU.Value = 0;

                //reseta nome e tempo CPU
                lblName.Text = "";
                lblTime.Text = "";

            }

            //começa novamente o timer que irá chamar os escalonadores
            TimerCPU.Start();
        }

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

            _Type = Type;

            timer.Start();

            RefreshAutoT.Start();

            TimerCPU.Start();

            PBmemory.Minimum = 0;
            PBmemory.Maximum = 1024;

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
            p.Time = 40;

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
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Memory.KillProcess();


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //se tiver espaço na memoria para o primeiro processo da memoria virtual
            if (!VirtualMemory.Empyt())
                if (!Memory.MemoryFull(VirtualMemory.FirstLenght()))
                    Memory.InitializeProcess(VirtualMemory.KillProcess());

        }

        private void RefreshAutoT_Tick(object sender, EventArgs e)
        {
            RefreshData();
            PBmemory.Value = Convert.ToInt32(Memory.Length);
        }

        private void TimerCPU_Tick(object sender, EventArgs e)
        {
            TimerCPU.Stop();

            if (_Type == 0)
                FCFS();
            else
                RoundRobin();

        }
    }
}
