using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgressTest.DI.Helpers;

namespace ProgressTest.UI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public event OnProcessDocumentsHandle OnProcessDoc;
        public event OnProcessDocumentsHandle OnStartProcessDoc;
        public event OnProcessDocumentsHandle OnEndProcessDoc;

        public int Count { get; set; }

        public Form1()
        {
            InitializeComponent();

            progressBar.Visible = false;
            spiner.Visible = false;
            label1.Visible = false;

            SignEventsProgress();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ProgressStart();
        }

        private void ProgressStart()
        {
            Count = 0;

            timer1.Enabled = true;
            timer1.Interval = 100;
            timer1.Start();
            timer1.Tick += Timer1_Tick;

            SetOnStartProcessDoc("Teste de Barra de Progresso!!!");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Count++;
            var percent = timer1.Interval * Count / 100;
            SetOnProcessDoc(percent);

            EndProcess();
        }

        private bool EndProcess()
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                timer1.Stop();
                SetOnEndProcessDoc("Teste Finalizado!!!");
                return true;
            }

            return false;
        }

        private void SignEventsProgress()
        {
            OnStartProcessDoc += Form1_OnStartProcessDoc;
            OnProcessDoc += Form1_OnProcessDoc;
            OnEndProcessDoc += Form1_OnEndProcessDoc;
        }

        private void Form1_OnStartProcessDoc(object sender, ProcessDocumentsArgs args)
        {
            Text = args.Description;
            Refresh();
            progressBar.Maximum = spiner.Maximum = timer1.Interval;
            progressBar.Visible = spiner.Visible = label1.Visible = args.ShowPressBar;
            progressBar.Value = spiner.Value = args.Percent;
            label1.Text = $"{args.Percent}%";
        }

        private void Form1_OnProcessDoc(object sender, ProcessDocumentsArgs args)
        {
            if (EndProcess()) return;

            progressBar.Value = spiner.Value = args.Percent;
            label1.Text = $"{args.Percent}%";
        }

        private void Form1_OnEndProcessDoc(object sender, ProcessDocumentsArgs args)
        {
            Text = args.Description;
            Refresh();
            progressBar.Value = spiner.Value = args.Percent;
            label1.Text = $"{args.Percent}%";
        }

        public void SetOnStartProcessDoc(string description = "", bool showProgressBar = true)
        {
            OnStartProcessDoc?.Invoke(this, new ProcessDocumentsArgs(0, description, showProgressBar));
        }

        public void SetOnEndProcessDoc(string description = "", bool showProgressBar = true)
        {
            OnEndProcessDoc?.Invoke(this, new ProcessDocumentsArgs(100, description, showProgressBar));
        }

        public void SetOnProcessDoc(int percent, bool showProgressBar = true)
        {
            OnProcessDoc?.Invoke(this, new ProcessDocumentsArgs(percent, "", showProgressBar));
        }
    }
}
