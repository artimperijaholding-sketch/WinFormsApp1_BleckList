using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using static WinFormsApp1_lesson4.Form1;

namespace WinFormsApp1_lesson4
{
    
    public partial class Form1 : Form
    {
        private DBHandler bleckList;
        DBHadlerBleckList db = new DBHadlerBleckList();
        public Form1()
        {
            InitializeComponent();
           
            bleckList = new DBHandler(db,false);
            LoadBleckList();
            
        }
        private void LoadBleckList()
        {
            listBoxBlack.Items.Clear();
            List<string> blackList = db
                .BlackLists.Select(x=>x.BlackListName)
                .ToList();
            for (int i = 0; i < blackList.Count; i++)
            {
                listBoxBlack.Items.Add(blackList[i]);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartProcess);
            thread.Start();

        }
        private void StartProcess()
        {
            ProcessHelper.Start(textBoxInput.Text);
            UpdateProcessList(true);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (GetActualSelected() is ProcessWraper processWraper)
            {
                Thread thread = new Thread(StopProcess);
                thread.Start(processWraper.GetInnerProcess().ProcessName);
            }

        }
        private void StopProcess(object processName)
        {

            ProcessHelper.Stop(processName as string);
            UpdateProcessList(true);
        }


        private void UpdateProcessList(bool makeDelay = false)
        {
            if (makeDelay)
            {
                Thread.Sleep(1000);
            }
            if (listBoxProcesses.InvokeRequired)
            {
                listBoxProcesses.Invoke(delegate () { UpdateList(); });
            }
            else
            {
                UpdateList();
            }
        }

        private void UpdateList()
        {
            listBoxProcesses.Items.Clear();

            List<ProcessWraper> allProcesses = ProcessHelper.GetProcesses();

            for (int i = 0; i < allProcesses.Count; i++)
            {
                listBoxProcesses.Items.Add(allProcesses[i]);
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateProcessList(true);
        }

        private void listBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxInfo.Text = GetActualSelected()?.GetProcessInfo() ?? string.Empty;

        }
        private ProcessWraper GetActualSelected()
        {
            if (listBoxProcesses.SelectedIndex >= 0)
            {
                if (listBoxProcesses.SelectedItem is ProcessWraper processWraper)
                {
                    return processWraper;
                }
            }
            return null!;
        }

        private void buttonStartAndWatch_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = textBoxInput.Text;
            process.StartInfo.UseShellExecute = true;
            process.EnableRaisingEvents = true;

            process.Exited += Process_Exited;
            process.Start();

        }

        private void Process_Exited(object? sender, EventArgs e)
        {
            Debug.WriteLine("Process exited");
        }
        Logger loger = new Logger();
        private void button1_Click(object sender, EventArgs e)
        {
            Logger loger = new Logger();
            loger.LogData(LogLevel.Info, "Some message");
        }
        
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxBlack.Items.Clear();
           string blackList = textBoxInputBlack.Text.Trim();
            if (string.IsNullOrEmpty(blackList)) return;
            bool exists = db.BlackLists.Any(x => x.BlackListName == blackList);
            if(!exists)
            {
                db.BlackLists.Add(new BlackList() { BlackListName = blackList });
                db.SaveChanges();
            }
            
            textBoxInputBlack.Clear();
            LoadBleckList();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            string selected = listBoxBlack.SelectedItem as string ?? string.Empty;
            if (string.IsNullOrEmpty(selected)) return;
            var itemToDelete = db.BlackLists.FirstOrDefault(x => x.BlackListName == selected);
            if(itemToDelete != null)
            {
                db.BlackLists.Remove(itemToDelete);
                db.SaveChanges();
            }
            LoadBleckList();

        }
       
        private void buttonDetect_Click(object sender, EventArgs e)
        {
            timer .Tick+= Timer_Tick;
            timer.Interval = 1000*10;
            timer.Start();
        }
        private  void Timer_Tick(object? sender, EventArgs e)
        {
            List<ProcessWraper> processes = ProcessHelper.GetProcesses();
            for (int i = 0; i < processes.Count; i++)
            {
                if (db.BlackLists.Any(x => x.BlackListName == processes[i].GetInnerProcess().ProcessName))
                {
                    ProcessHelper.Stop(processes[i].GetInnerProcess().ProcessName);
                }
            }
        }
    }
}

