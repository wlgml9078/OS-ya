namespace Scheduling_Jh
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ProcessList = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.TextBox();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.burstTime = new System.Windows.Forms.TextBox();
            this.timeSlice = new System.Windows.Forms.TextBox();
            this.priority = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.processNameText = new System.Windows.Forms.Label();
            this.arrivalTimeText = new System.Windows.Forms.Label();
            this.burstTimeText = new System.Windows.Forms.Label();
            this.timeSliceText = new System.Windows.Forms.Label();
            this.priorityText = new System.Windows.Forms.Label();
            this.scheduleText = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.processInfo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(509, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "스케줄링 시작";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 400);
            this.listBox1.TabIndex = 1;
            // 
            // ProcessList
            // 
            this.ProcessList.AutoSize = true;
            this.ProcessList.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProcessList.ForeColor = System.Drawing.Color.White;
            this.ProcessList.Location = new System.Drawing.Point(13, 16);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(135, 24);
            this.ProcessList.TabIndex = 2;
            this.ProcessList.Text = "스케줄러 프로그램";
            this.ProcessList.Click += new System.EventHandler(this.label1_Click);
            // 
            // processName
            // 
            this.processName.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processName.Location = new System.Drawing.Point(375, 148);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(106, 25);
            this.processName.TabIndex = 3;
            this.processName.TextChanged += new System.EventHandler(this.processName_TextChanged);
            // 
            // arrivalTime
            // 
            this.arrivalTime.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.arrivalTime.Location = new System.Drawing.Point(375, 208);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(106, 25);
            this.arrivalTime.TabIndex = 4;
            this.arrivalTime.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.arrivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arrivalTime_KeyPress);
            // 
            // burstTime
            // 
            this.burstTime.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.burstTime.Location = new System.Drawing.Point(375, 271);
            this.burstTime.Name = "burstTime";
            this.burstTime.Size = new System.Drawing.Size(106, 25);
            this.burstTime.TabIndex = 5;
            this.burstTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTime_KeyPress);
            // 
            // timeSlice
            // 
            this.timeSlice.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeSlice.Location = new System.Drawing.Point(375, 467);
            this.timeSlice.Name = "timeSlice";
            this.timeSlice.Size = new System.Drawing.Size(106, 25);
            this.timeSlice.TabIndex = 6;
            this.timeSlice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeSlice_KeyPress);
            // 
            // priority
            // 
            this.priority.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priority.Location = new System.Drawing.Point(375, 337);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(106, 25);
            this.priority.TabIndex = 7;
            this.priority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priority_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(375, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "프로세스 추가";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // processNameText
            // 
            this.processNameText.AutoSize = true;
            this.processNameText.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processNameText.Location = new System.Drawing.Point(372, 124);
            this.processNameText.Name = "processNameText";
            this.processNameText.Size = new System.Drawing.Size(80, 21);
            this.processNameText.TabIndex = 9;
            this.processNameText.Text = "프로세스 ID";
            this.processNameText.Click += new System.EventHandler(this.label2_Click);
            // 
            // arrivalTimeText
            // 
            this.arrivalTimeText.AutoSize = true;
            this.arrivalTimeText.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.arrivalTimeText.Location = new System.Drawing.Point(371, 184);
            this.arrivalTimeText.Name = "arrivalTimeText";
            this.arrivalTimeText.Size = new System.Drawing.Size(62, 21);
            this.arrivalTimeText.TabIndex = 10;
            this.arrivalTimeText.Text = "도착시간";
            // 
            // burstTimeText
            // 
            this.burstTimeText.AutoSize = true;
            this.burstTimeText.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.burstTimeText.Location = new System.Drawing.Point(371, 247);
            this.burstTimeText.Name = "burstTimeText";
            this.burstTimeText.Size = new System.Drawing.Size(62, 21);
            this.burstTimeText.TabIndex = 11;
            this.burstTimeText.Text = "실행시간";
            // 
            // timeSliceText
            // 
            this.timeSliceText.AutoSize = true;
            this.timeSliceText.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeSliceText.Location = new System.Drawing.Point(371, 443);
            this.timeSliceText.Name = "timeSliceText";
            this.timeSliceText.Size = new System.Drawing.Size(75, 21);
            this.timeSliceText.TabIndex = 12;
            this.timeSliceText.Text = "시간할당량";
            // 
            // priorityText
            // 
            this.priorityText.AutoSize = true;
            this.priorityText.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priorityText.Location = new System.Drawing.Point(371, 313);
            this.priorityText.Name = "priorityText";
            this.priorityText.Size = new System.Drawing.Size(62, 21);
            this.priorityText.TabIndex = 13;
            this.priorityText.Text = "우선순위";
            // 
            // scheduleText
            // 
            this.scheduleText.AutoSize = true;
            this.scheduleText.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scheduleText.Location = new System.Drawing.Point(516, 81);
            this.scheduleText.Name = "scheduleText";
            this.scheduleText.Size = new System.Drawing.Size(118, 21);
            this.scheduleText.TabIndex = 15;
            this.scheduleText.Text = "스케줄링 알고리즘";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(520, 125);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 16);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FCFS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(520, 166);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 16);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "비선점 Priority";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(520, 204);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 16);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "선점 Priority";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(519, 334);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 16);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Round Robin";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(520, 295);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "SRT";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(520, 248);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(44, 16);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "SJF";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(519, 378);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(48, 16);
            this.radioButton7.TabIndex = 22;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "HRN";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.ProcessList);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 56);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "프로세스 목록";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(360, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 334);
            this.panel2.TabIndex = 24;
            // 
            // processInfo
            // 
            this.processInfo.AutoSize = true;
            this.processInfo.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo.Location = new System.Drawing.Point(372, 81);
            this.processInfo.Name = "processInfo";
            this.processInfo.Size = new System.Drawing.Size(92, 21);
            this.processInfo.TabIndex = 25;
            this.processInfo.Text = "프로세스 정보";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 334);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(509, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 334);
            this.panel4.TabIndex = 25;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 507);
            this.Controls.Add(this.scheduleText);
            this.Controls.Add(this.processInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.priorityText);
            this.Controls.Add(this.timeSliceText);
            this.Controls.Add(this.burstTimeText);
            this.Controls.Add(this.arrivalTimeText);
            this.Controls.Add(this.processNameText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.timeSlice);
            this.Controls.Add(this.burstTime);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.processName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ProcessList;
        private System.Windows.Forms.TextBox processName;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.TextBox burstTime;
        private System.Windows.Forms.TextBox timeSlice;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label processNameText;
        private System.Windows.Forms.Label arrivalTimeText;
        private System.Windows.Forms.Label burstTimeText;
        private System.Windows.Forms.Label timeSliceText;
        private System.Windows.Forms.Label priorityText;
        private System.Windows.Forms.Label scheduleText;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label processInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;


    }
}

