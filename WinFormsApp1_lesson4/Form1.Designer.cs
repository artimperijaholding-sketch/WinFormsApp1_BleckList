namespace WinFormsApp1_lesson4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxProcesses = new ListBox();
            buttonUpdate = new Button();
            buttonStart = new Button();
            buttonStop = new Button();
            textBoxInfo = new TextBox();
            textBoxInput = new TextBox();
            label1 = new Label();
            buttonStartAndWatch = new Button();
            button1 = new Button();
            listBoxBlack = new ListBox();
            label2 = new Label();
            textBoxInputBlack = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonDetect = new Button();
            SuspendLayout();
            // 
            // listBoxProcesses
            // 
            listBoxProcesses.FormattingEnabled = true;
            listBoxProcesses.Location = new Point(12, 26);
            listBoxProcesses.Name = "listBoxProcesses";
            listBoxProcesses.Size = new Size(185, 259);
            listBoxProcesses.TabIndex = 0;
            listBoxProcesses.SelectedIndexChanged += listBoxProcesses_SelectedIndexChanged;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(99, 299);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(490, 299);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(588, 299);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(203, 27);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(460, 117);
            textBoxInfo.TabIndex = 4;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(198, 299);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(274, 23);
            textBoxInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 6;
            label1.Text = "Process info";
            // 
            // buttonStartAndWatch
            // 
            buttonStartAndWatch.Location = new Point(490, 262);
            buttonStartAndWatch.Name = "buttonStartAndWatch";
            buttonStartAndWatch.Size = new Size(173, 23);
            buttonStartAndWatch.TabIndex = 7;
            buttonStartAndWatch.Text = "Start and Watch";
            buttonStartAndWatch.UseVisualStyleBackColor = true;
            buttonStartAndWatch.Click += buttonStartAndWatch_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "LogText";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxBlack
            // 
            listBoxBlack.FormattingEnabled = true;
            listBoxBlack.Location = new Point(203, 165);
            listBoxBlack.Name = "listBoxBlack";
            listBoxBlack.Size = new Size(120, 94);
            listBoxBlack.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 147);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 10;
            label2.Text = "Black List";
            // 
            // textBoxInputBlack
            // 
            textBoxInputBlack.Location = new Point(329, 165);
            textBoxInputBlack.Name = "textBoxInputBlack";
            textBoxInputBlack.Size = new Size(334, 23);
            textBoxInputBlack.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(588, 196);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(490, 196);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 13;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonDetect
            // 
            buttonDetect.Location = new Point(329, 194);
            buttonDetect.Name = "buttonDetect";
            buttonDetect.Size = new Size(143, 25);
            buttonDetect.TabIndex = 14;
            buttonDetect.Text = "Detect";
            buttonDetect.UseVisualStyleBackColor = true;
            buttonDetect.Click += buttonDetect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 334);
            Controls.Add(buttonDetect);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxInputBlack);
            Controls.Add(label2);
            Controls.Add(listBoxBlack);
            Controls.Add(button1);
            Controls.Add(buttonStartAndWatch);
            Controls.Add(label1);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxInfo);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(buttonUpdate);
            Controls.Add(listBoxProcesses);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxProcesses;
        private Button buttonUpdate;
        private Button buttonStart;
        private Button buttonStop;
        private TextBox textBoxInfo;
        private TextBox textBoxInput;
        private Label label1;
        private Button buttonStartAndWatch;
        private Button button1;
        private ListBox listBoxBlack;
        private Label label2;
        private TextBox textBoxInputBlack;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonDetect;
    }
}
