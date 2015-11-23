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
            this.titlebar = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.TextBox();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.burstTime = new System.Windows.Forms.TextBox();
            this.priority = new System.Windows.Forms.TextBox();
            this.processNameText = new System.Windows.Forms.Label();
            this.arrivalTimeText = new System.Windows.Forms.Label();
            this.burstTimeText = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.processListText = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.DEV2 = new System.Windows.Forms.Button();
            this.DEV1 = new System.Windows.Forms.Button();
            this.timeSliceText = new System.Windows.Forms.Label();
            this.processInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Dev3 = new System.Windows.Forms.Button();
            this.processList = new System.Windows.Forms.DataGridView();
            this.processNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processArrivedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processBurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSlice = new System.Windows.Forms.TextBox();
            this.addProcess = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(509, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "스케줄링 시작";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titlebar
            // 
            this.titlebar.AutoSize = true;
            this.titlebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titlebar.ForeColor = System.Drawing.Color.White;
            this.titlebar.Location = new System.Drawing.Point(13, 26);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(155, 26);
            this.titlebar.TabIndex = 2;
            this.titlebar.Text = "스케줄러 프로그램";
            this.titlebar.Click += new System.EventHandler(this.titlebar_Click);
            // 
            // processName
            // 
            this.processName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processName.Location = new System.Drawing.Point(381, 148);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(106, 21);
            this.processName.TabIndex = 3;
            this.processName.TextChanged += new System.EventHandler(this.processName_TextChanged);
            // 
            // arrivalTime
            // 
            this.arrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.arrivalTime.Location = new System.Drawing.Point(381, 208);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(106, 21);
            this.arrivalTime.TabIndex = 4;
            this.arrivalTime.TextChanged += new System.EventHandler(this.arrivalTime_TextChanged);
            this.arrivalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arrivalTime_KeyPress);
            // 
            // burstTime
            // 
            this.burstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.burstTime.Location = new System.Drawing.Point(381, 268);
            this.burstTime.Name = "burstTime";
            this.burstTime.Size = new System.Drawing.Size(106, 21);
            this.burstTime.TabIndex = 5;
            this.burstTime.TextChanged += new System.EventHandler(this.burstTime_TextChanged);
            this.burstTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.burstTime_KeyPress);
            // 
            // priority
            // 
            this.priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priority.Location = new System.Drawing.Point(381, 328);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(106, 21);
            this.priority.TabIndex = 7;
            this.priority.TextChanged += new System.EventHandler(this.priority_TextChanged);
            this.priority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priority_KeyPress);
            // 
            // processNameText
            // 
            this.processNameText.AutoSize = true;
            this.processNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processNameText.Location = new System.Drawing.Point(378, 124);
            this.processNameText.Name = "processNameText";
            this.processNameText.Size = new System.Drawing.Size(76, 17);
            this.processNameText.TabIndex = 9;
            this.processNameText.Text = "프로세스 ID";
            this.processNameText.Click += new System.EventHandler(this.processNameText_Click);
            // 
            // arrivalTimeText
            // 
            this.arrivalTimeText.AutoSize = true;
            this.arrivalTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.arrivalTimeText.Location = new System.Drawing.Point(377, 184);
            this.arrivalTimeText.Name = "arrivalTimeText";
            this.arrivalTimeText.Size = new System.Drawing.Size(56, 17);
            this.arrivalTimeText.TabIndex = 10;
            this.arrivalTimeText.Text = "도착시간";
            this.arrivalTimeText.Click += new System.EventHandler(this.arrivalTimeText_Click);
            // 
            // burstTimeText
            // 
            this.burstTimeText.AutoSize = true;
            this.burstTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.burstTimeText.ForeColor = System.Drawing.Color.Black;
            this.burstTimeText.Location = new System.Drawing.Point(11, 155);
            this.burstTimeText.Name = "burstTimeText";
            this.burstTimeText.Size = new System.Drawing.Size(56, 17);
            this.burstTimeText.TabIndex = 11;
            this.burstTimeText.Text = "실행시간";
            // 
            // priorityText
            // 
            this.priorityText.AutoSize = true;
            this.priorityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priorityText.ForeColor = System.Drawing.Color.Black;
            this.priorityText.Location = new System.Drawing.Point(10, 215);
            this.priorityText.Name = "priorityText";
            this.priorityText.Size = new System.Drawing.Size(56, 17);
            this.priorityText.TabIndex = 13;
            this.priorityText.Text = "우선순위";
            // 
            // scheduleText
            // 
            this.scheduleText.AutoSize = true;
            this.scheduleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scheduleText.Location = new System.Drawing.Point(506, 72);
            this.scheduleText.Name = "scheduleText";
            this.scheduleText.Size = new System.Drawing.Size(109, 17);
            this.scheduleText.TabIndex = 15;
            this.scheduleText.Text = "스케줄링 알고리즘";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
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
            this.radioButton2.Location = new System.Drawing.Point(520, 165);
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
            this.radioButton3.Location = new System.Drawing.Point(520, 205);
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
            this.radioButton4.Location = new System.Drawing.Point(519, 325);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 16);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Round Robin";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(520, 285);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "SRT";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(520, 245);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(44, 16);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "SJF";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(519, 365);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(48, 16);
            this.radioButton7.TabIndex = 22;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "HRN";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 61);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Noto Sans CJK KR Bold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(608, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(667, 18);
            this.panel5.TabIndex = 24;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // processListText
            // 
            this.processListText.AutoSize = true;
            this.processListText.BackColor = System.Drawing.Color.Transparent;
            this.processListText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processListText.ForeColor = System.Drawing.Color.Black;
            this.processListText.Location = new System.Drawing.Point(14, 72);
            this.processListText.Name = "processListText";
            this.processListText.Size = new System.Drawing.Size(85, 17);
            this.processListText.TabIndex = 3;
            this.processListText.Text = "프로세스 목록";
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
            this.panel2.Controls.Add(this.DEV2);
            this.panel2.Controls.Add(this.DEV1);
            this.panel2.Controls.Add(this.timeSliceText);
            this.panel2.Controls.Add(this.burstTimeText);
            this.panel2.Controls.Add(this.priorityText);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(366, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 331);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DEV2
            // 
            this.DEV2.ForeColor = System.Drawing.Color.Black;
            this.DEV2.Location = new System.Drawing.Point(68, 4);
            this.DEV2.Name = "DEV2";
            this.DEV2.Size = new System.Drawing.Size(52, 23);
            this.DEV2.TabIndex = 15;
            this.DEV2.Text = "DEV2";
            this.DEV2.UseVisualStyleBackColor = true;
            this.DEV2.Click += new System.EventHandler(this.DEV2_Click);
            // 
            // DEV1
            // 
            this.DEV1.ForeColor = System.Drawing.Color.Black;
            this.DEV1.Location = new System.Drawing.Point(13, 4);
            this.DEV1.Name = "DEV1";
            this.DEV1.Size = new System.Drawing.Size(49, 23);
            this.DEV1.TabIndex = 14;
            this.DEV1.Text = "DEV1";
            this.DEV1.UseVisualStyleBackColor = true;
            this.DEV1.Click += new System.EventHandler(this.button5_Click);
            // 
            // timeSliceText
            // 
            this.timeSliceText.AutoSize = true;
            this.timeSliceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeSliceText.ForeColor = System.Drawing.Color.Black;
            this.timeSliceText.Location = new System.Drawing.Point(10, 275);
            this.timeSliceText.Name = "timeSliceText";
            this.timeSliceText.Size = new System.Drawing.Size(68, 17);
            this.timeSliceText.TabIndex = 12;
            this.timeSliceText.Text = "시간할당량";
            // 
            // processInfo
            // 
            this.processInfo.AutoSize = true;
            this.processInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo.Location = new System.Drawing.Point(363, 72);
            this.processInfo.Name = "processInfo";
            this.processInfo.Size = new System.Drawing.Size(85, 17);
            this.processInfo.TabIndex = 25;
            this.processInfo.Text = "프로세스 정보";
            this.processInfo.Click += new System.EventHandler(this.processInfo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Dev3);
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(509, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 331);
            this.panel4.TabIndex = 25;
            // 
            // Dev3
            // 
            this.Dev3.ForeColor = System.Drawing.Color.Black;
            this.Dev3.Location = new System.Drawing.Point(10, 292);
            this.Dev3.Name = "Dev3";
            this.Dev3.Size = new System.Drawing.Size(102, 31);
            this.Dev3.TabIndex = 0;
            this.Dev3.Text = "DEV3";
            this.Dev3.UseVisualStyleBackColor = true;
            this.Dev3.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // processList
            // 
            this.processList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.processList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.processList.ColumnHeadersHeight = 20;
            this.processList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.processList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processNameColumn,
            this.processArrivedTime,
            this.processBurstTime,
            this.processPriority});
            this.processList.Location = new System.Drawing.Point(17, 92);
            this.processList.Name = "processList";
            this.processList.RowHeadersWidth = 20;
            this.processList.RowTemplate.Height = 20;
            this.processList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.processList.Size = new System.Drawing.Size(338, 331);
            this.processList.TabIndex = 23;
            this.processList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processList_CellContentClick);
            // 
            // processNameColumn
            // 
            this.processNameColumn.HeaderText = "프로세스 이름";
            this.processNameColumn.Name = "processNameColumn";
            this.processNameColumn.ReadOnly = true;
            this.processNameColumn.Width = 90;
            // 
            // processArrivedTime
            // 
            this.processArrivedTime.HeaderText = "도착시간";
            this.processArrivedTime.Name = "processArrivedTime";
            this.processArrivedTime.ReadOnly = true;
            this.processArrivedTime.Width = 80;
            // 
            // processBurstTime
            // 
            this.processBurstTime.HeaderText = "실행시간";
            this.processBurstTime.Name = "processBurstTime";
            this.processBurstTime.ReadOnly = true;
            this.processBurstTime.Width = 80;
            // 
            // processPriority
            // 
            this.processPriority.HeaderText = "우선순위";
            this.processPriority.Name = "processPriority";
            this.processPriority.ReadOnly = true;
            this.processPriority.Width = 80;
            // 
            // timeSlice
            // 
            this.timeSlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeSlice.ForeColor = System.Drawing.Color.Black;
            this.timeSlice.Location = new System.Drawing.Point(381, 388);
            this.timeSlice.Name = "timeSlice";
            this.timeSlice.Size = new System.Drawing.Size(106, 21);
            this.timeSlice.TabIndex = 6;
            this.timeSlice.TextChanged += new System.EventHandler(this.timeSlice_TextChanged);
            this.timeSlice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeSlice_KeyPress);
            // 
            // addProcess
            // 
            this.addProcess.BackColor = System.Drawing.Color.DimGray;
            this.addProcess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.addProcess.FlatAppearance.BorderSize = 0;
            this.addProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProcess.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addProcess.ForeColor = System.Drawing.Color.White;
            this.addProcess.Location = new System.Drawing.Point(269, 6);
            this.addProcess.Name = "addProcess";
            this.addProcess.Size = new System.Drawing.Size(68, 56);
            this.addProcess.TabIndex = 8;
            this.addProcess.Text = "프로세스 추가";
            this.addProcess.UseVisualStyleBackColor = false;
            this.addProcess.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(417, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 56);
            this.button3.TabIndex = 9;
            this.button3.Text = "프로세스 랜덤 추가";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(343, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 56);
            this.button4.TabIndex = 26;
            this.button4.Text = "프로세스 제거";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.addProcess);
            this.panel3.Location = new System.Drawing.Point(17, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 70);
            this.panel3.TabIndex = 27;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 64);
            this.listBox1.TabIndex = 27;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 507);
            this.Controls.Add(this.timeSlice);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.scheduleText);
            this.Controls.Add(this.processInfo);
            this.Controls.Add(this.processListText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.arrivalTimeText);
            this.Controls.Add(this.processNameText);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.burstTime);
            this.Controls.Add(this.arrivalTime);
            this.Controls.Add(this.processName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titlebar;
        private System.Windows.Forms.TextBox processName;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.TextBox burstTime;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.Label processNameText;
        private System.Windows.Forms.Label arrivalTimeText;
        private System.Windows.Forms.Label burstTimeText;
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
        private System.Windows.Forms.Label processListText;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label processInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView processList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox timeSlice;
        private System.Windows.Forms.Label timeSliceText;
        private System.Windows.Forms.DataGridViewTextBoxColumn processNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processArrivedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn processBurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn processPriority;
        private System.Windows.Forms.Button addProcess;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DEV1;
        private System.Windows.Forms.Button DEV2;
        private System.Windows.Forms.Button Dev3;


    }
}

