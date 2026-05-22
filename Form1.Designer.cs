namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rootPanel = new System.Windows.Forms.Panel();
            this.guideBox = new System.Windows.Forms.GroupBox();
            this.lblMissingRequired = new System.Windows.Forms.Label();
            this.lblShortage = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.dgvAreaStatus = new System.Windows.Forms.DataGridView();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBox = new System.Windows.Forms.GroupBox();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalStatus = new System.Windows.Forms.Label();
            this.prgTotal = new System.Windows.Forms.ProgressBar();
            this.pnlLiberalBasic = new System.Windows.Forms.Panel();
            this.lblLiberalBasicTitle = new System.Windows.Forms.Label();
            this.lblLiberalBasicValue = new System.Windows.Forms.Label();
            this.lblLiberalBasicStatus = new System.Windows.Forms.Label();
            this.prgLiberalBasic = new System.Windows.Forms.ProgressBar();
            this.pnlUnivReq = new System.Windows.Forms.Panel();
            this.lblUnivReqTitle = new System.Windows.Forms.Label();
            this.lblUnivReqValue = new System.Windows.Forms.Label();
            this.lblUnivReqStatus = new System.Windows.Forms.Label();
            this.prgUnivReq = new System.Windows.Forms.ProgressBar();
            this.pnlUnivElec = new System.Windows.Forms.Panel();
            this.lblUnivElecTitle = new System.Windows.Forms.Label();
            this.lblUnivElecValue = new System.Windows.Forms.Label();
            this.lblUnivElecStatus = new System.Windows.Forms.Label();
            this.prgUnivElec = new System.Windows.Forms.ProgressBar();
            this.pnlLiberalTotal = new System.Windows.Forms.Panel();
            this.lblLiberalTotalTitle = new System.Windows.Forms.Label();
            this.lblLiberalTotalValue = new System.Windows.Forms.Label();
            this.lblLiberalTotalStatus = new System.Windows.Forms.Label();
            this.prgLiberalTotal = new System.Windows.Forms.ProgressBar();
            this.pnlExploreReq = new System.Windows.Forms.Panel();
            this.lblExploreReqTitle = new System.Windows.Forms.Label();
            this.lblExploreReqValue = new System.Windows.Forms.Label();
            this.lblExploreReqStatus = new System.Windows.Forms.Label();
            this.prgExploreReq = new System.Windows.Forms.ProgressBar();
            this.pnlExploreElec = new System.Windows.Forms.Panel();
            this.lblExploreElecTitle = new System.Windows.Forms.Label();
            this.lblExploreElecValue = new System.Windows.Forms.Label();
            this.lblExploreElecStatus = new System.Windows.Forms.Label();
            this.prgExploreElec = new System.Windows.Forms.ProgressBar();
            this.pnlExploreTotal = new System.Windows.Forms.Panel();
            this.lblExploreTotalTitle = new System.Windows.Forms.Label();
            this.lblExploreTotalValue = new System.Windows.Forms.Label();
            this.lblExploreTotalStatus = new System.Windows.Forms.Label();
            this.prgExploreTotal = new System.Windows.Forms.ProgressBar();
            this.pnlFirstMajorReq = new System.Windows.Forms.Panel();
            this.lblFirstMajorReqTitle = new System.Windows.Forms.Label();
            this.lblFirstMajorReqValue = new System.Windows.Forms.Label();
            this.lblFirstMajorReqStatus = new System.Windows.Forms.Label();
            this.prgFirstMajorReq = new System.Windows.Forms.ProgressBar();
            this.pnlFirstMajorElec = new System.Windows.Forms.Panel();
            this.lblFirstMajorElecTitle = new System.Windows.Forms.Label();
            this.lblFirstMajorElecValue = new System.Windows.Forms.Label();
            this.lblFirstMajorElecStatus = new System.Windows.Forms.Label();
            this.prgFirstMajorElec = new System.Windows.Forms.ProgressBar();
            this.pnlFirstMajorTotal = new System.Windows.Forms.Panel();
            this.lblFirstMajorTotalTitle = new System.Windows.Forms.Label();
            this.lblFirstMajorTotalValue = new System.Windows.Forms.Label();
            this.lblFirstMajorTotalStatus = new System.Windows.Forms.Label();
            this.prgFirstMajorTotal = new System.Windows.Forms.ProgressBar();
            this.pnlSecondMajorReq = new System.Windows.Forms.Panel();
            this.lblSecondMajorReqTitle = new System.Windows.Forms.Label();
            this.lblSecondMajorReqValue = new System.Windows.Forms.Label();
            this.lblSecondMajorReqStatus = new System.Windows.Forms.Label();
            this.prgSecondMajorReq = new System.Windows.Forms.ProgressBar();
            this.pnlSecondMajorElec = new System.Windows.Forms.Panel();
            this.lblSecondMajorElecTitle = new System.Windows.Forms.Label();
            this.lblSecondMajorElecValue = new System.Windows.Forms.Label();
            this.lblSecondMajorElecStatus = new System.Windows.Forms.Label();
            this.prgSecondMajorElec = new System.Windows.Forms.ProgressBar();
            this.pnlSecondMajorTotal = new System.Windows.Forms.Panel();
            this.lblSecondMajorTotalTitle = new System.Windows.Forms.Label();
            this.lblSecondMajorTotalValue = new System.Windows.Forms.Label();
            this.lblSecondMajorTotalStatus = new System.Windows.Forms.Label();
            this.prgSecondMajorTotal = new System.Windows.Forms.ProgressBar();
            this.pnlOverall = new System.Windows.Forms.Panel();
            this.lblOverallTitle = new System.Windows.Forms.Label();
            this.lblOverallValue = new System.Windows.Forms.Label();
            this.lblOverallStatus = new System.Windows.Forms.Label();
            this.prgOverall = new System.Windows.Forms.ProgressBar();
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRawInput = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rootPanel.SuspendLayout();
            this.guideBox.SuspendLayout();
            this.statusBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaStatus)).BeginInit();
            this.subjectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.summaryBox.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlLiberalBasic.SuspendLayout();
            this.pnlUnivReq.SuspendLayout();
            this.pnlUnivElec.SuspendLayout();
            this.pnlLiberalTotal.SuspendLayout();
            this.pnlExploreReq.SuspendLayout();
            this.pnlExploreElec.SuspendLayout();
            this.pnlExploreTotal.SuspendLayout();
            this.pnlFirstMajorReq.SuspendLayout();
            this.pnlFirstMajorElec.SuspendLayout();
            this.pnlFirstMajorTotal.SuspendLayout();
            this.pnlSecondMajorReq.SuspendLayout();
            this.pnlSecondMajorElec.SuspendLayout();
            this.pnlSecondMajorTotal.SuspendLayout();
            this.pnlOverall.SuspendLayout();
            this.inputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootPanel
            // 
            this.rootPanel.AutoScroll = true;
            this.rootPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.rootPanel.Controls.Add(this.guideBox);
            this.rootPanel.Controls.Add(this.statusBox);
            this.rootPanel.Controls.Add(this.subjectBox);
            this.rootPanel.Controls.Add(this.summaryBox);
            this.rootPanel.Controls.Add(this.inputBox);
            this.rootPanel.Controls.Add(this.btnAdmin);
            this.rootPanel.Controls.Add(this.btnPrint);
            this.rootPanel.Controls.Add(this.lblSubtitle);
            this.rootPanel.Controls.Add(this.lblTitle);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Padding = new System.Windows.Forms.Padding(18);
            this.rootPanel.Size = new System.Drawing.Size(1180, 835);
            this.rootPanel.TabIndex = 0;
            // 
            // guideBox
            // 
            this.guideBox.BackColor = System.Drawing.Color.White;
            this.guideBox.Controls.Add(this.lblMissingRequired);
            this.guideBox.Controls.Add(this.lblShortage);
            this.guideBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.guideBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.guideBox.Location = new System.Drawing.Point(20, 735);
            this.guideBox.Name = "guideBox";
            this.guideBox.Size = new System.Drawing.Size(1110, 80);
            this.guideBox.TabIndex = 7;
            this.guideBox.TabStop = false;
            this.guideBox.Text = "부족 학점 및 미이수 필수과목 안내";
            // 
            // lblMissingRequired
            // 
            this.lblMissingRequired.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblMissingRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblMissingRequired.Location = new System.Drawing.Point(560, 28);
            this.lblMissingRequired.Name = "lblMissingRequired";
            this.lblMissingRequired.Size = new System.Drawing.Size(520, 38);
            this.lblMissingRequired.TabIndex = 1;
            // 
            // lblShortage
            // 
            this.lblShortage.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblShortage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblShortage.Location = new System.Drawing.Point(22, 28);
            this.lblShortage.Name = "lblShortage";
            this.lblShortage.Size = new System.Drawing.Size(520, 38);
            this.lblShortage.TabIndex = 0;
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.White;
            this.statusBox.Controls.Add(this.dgvAreaStatus);
            this.statusBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.statusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.statusBox.Location = new System.Drawing.Point(650, 455);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(480, 260);
            this.statusBox.TabIndex = 6;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "영역별 학점 현황";
            // 
            // dgvAreaStatus
            // 
            this.dgvAreaStatus.AllowUserToAddRows = false;
            this.dgvAreaStatus.AllowUserToDeleteRows = false;
            this.dgvAreaStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAreaStatus.BackgroundColor = System.Drawing.Color.White;
            this.dgvAreaStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.dgvAreaStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAreaStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreaStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colArea, this.colRequired, this.colCompleted, this.colStatus });
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.dgvAreaStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAreaStatus.EnableHeadersVisualStyles = false;
            this.dgvAreaStatus.Location = new System.Drawing.Point(18, 30);
            this.dgvAreaStatus.Name = "dgvAreaStatus";
            this.dgvAreaStatus.ReadOnly = true;
            this.dgvAreaStatus.RowHeadersVisible = false;
            this.dgvAreaStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreaStatus.Size = new System.Drawing.Size(444, 212);
            this.dgvAreaStatus.TabIndex = 0;
            // 
            // colArea
            // 
            this.colArea.HeaderText = "영역";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colRequired
            // 
            this.colRequired.HeaderText = "기준학점";
            this.colRequired.Name = "colRequired";
            this.colRequired.ReadOnly = true;
            // 
            // colCompleted
            // 
            this.colCompleted.HeaderText = "이수학점";
            this.colCompleted.Name = "colCompleted";
            this.colCompleted.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "충족여부";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // subjectBox
            // 
            this.subjectBox.BackColor = System.Drawing.Color.White;
            this.subjectBox.Controls.Add(this.dgvSubjects);
            this.subjectBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.subjectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.subjectBox.Location = new System.Drawing.Point(20, 455);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(610, 260);
            this.subjectBox.TabIndex = 5;
            this.subjectBox.TabStop = false;
            this.subjectBox.Text = "과목 이수 내역";
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colType, this.colCode, this.colName, this.colCredit, this.colGrade });
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.dgvSubjects.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubjects.EnableHeadersVisualStyles = false;
            this.dgvSubjects.Location = new System.Drawing.Point(18, 30);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(574, 212);
            this.dgvSubjects.TabIndex = 0;
            // 
            // colType
            // 
            this.colType.HeaderText = "이수구분";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "과목코드";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "과목명";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCredit
            // 
            this.colCredit.HeaderText = "학점";
            this.colCredit.Name = "colCredit";
            this.colCredit.ReadOnly = true;
            // 
            // colGrade
            // 
            this.colGrade.HeaderText = "성적";
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            // 
            // summaryBox
            // 
            this.summaryBox.BackColor = System.Drawing.Color.White;
            this.summaryBox.Controls.Add(this.pnlTotal);
            this.summaryBox.Controls.Add(this.pnlLiberalBasic);
            this.summaryBox.Controls.Add(this.pnlUnivReq);
            this.summaryBox.Controls.Add(this.pnlUnivElec);
            this.summaryBox.Controls.Add(this.pnlLiberalTotal);
            this.summaryBox.Controls.Add(this.pnlExploreReq);
            this.summaryBox.Controls.Add(this.pnlExploreElec);
            this.summaryBox.Controls.Add(this.pnlExploreTotal);
            this.summaryBox.Controls.Add(this.pnlFirstMajorReq);
            this.summaryBox.Controls.Add(this.pnlFirstMajorElec);
            this.summaryBox.Controls.Add(this.pnlFirstMajorTotal);
            this.summaryBox.Controls.Add(this.pnlSecondMajorReq);
            this.summaryBox.Controls.Add(this.pnlSecondMajorElec);
            this.summaryBox.Controls.Add(this.pnlSecondMajorTotal);
            this.summaryBox.Controls.Add(this.pnlOverall);
            this.summaryBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.summaryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.summaryBox.Location = new System.Drawing.Point(460, 95);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(670, 330);
            this.summaryBox.TabIndex = 4;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "요약 현황";

            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.prgTotal);
            this.pnlTotal.Controls.Add(this.lblTotalStatus);
            this.pnlTotal.Controls.Add(this.lblTotalValue);
            this.pnlTotal.Controls.Add(this.lblTotalTitle);
            this.pnlTotal.Location = new System.Drawing.Point(20, 38);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(116, 74);
            this.pnlTotal.TabIndex = 0;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblTotalTitle.Location = new System.Drawing.Point(0, 5);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(116, 18);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "총 이수학점";
            this.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblTotalValue.Location = new System.Drawing.Point(0, 23);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(116, 21);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "0 / 0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalStatus
            // 
            this.lblTotalStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblTotalStatus.Location = new System.Drawing.Point(0, 43);
            this.lblTotalStatus.Name = "lblTotalStatus";
            this.lblTotalStatus.Size = new System.Drawing.Size(116, 18);
            this.lblTotalStatus.TabIndex = 2;
            this.lblTotalStatus.Text = "대기";
            this.lblTotalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgTotal
            // 
            this.prgTotal.Location = new System.Drawing.Point(10, 62);
            this.prgTotal.Name = "prgTotal";
            this.prgTotal.Size = new System.Drawing.Size(96, 8);
            this.prgTotal.TabIndex = 3;

            // 
            // pnlLiberalBasic
            // 
            this.pnlLiberalBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlLiberalBasic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLiberalBasic.Controls.Add(this.prgLiberalBasic);
            this.pnlLiberalBasic.Controls.Add(this.lblLiberalBasicStatus);
            this.pnlLiberalBasic.Controls.Add(this.lblLiberalBasicValue);
            this.pnlLiberalBasic.Controls.Add(this.lblLiberalBasicTitle);
            this.pnlLiberalBasic.Location = new System.Drawing.Point(146, 38);
            this.pnlLiberalBasic.Name = "pnlLiberalBasic";
            this.pnlLiberalBasic.Size = new System.Drawing.Size(116, 74);
            this.pnlLiberalBasic.TabIndex = 0;
            // 
            // lblLiberalBasicTitle
            // 
            this.lblLiberalBasicTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblLiberalBasicTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblLiberalBasicTitle.Location = new System.Drawing.Point(0, 5);
            this.lblLiberalBasicTitle.Name = "lblLiberalBasicTitle";
            this.lblLiberalBasicTitle.Size = new System.Drawing.Size(116, 18);
            this.lblLiberalBasicTitle.TabIndex = 0;
            this.lblLiberalBasicTitle.Text = "교양기초";
            this.lblLiberalBasicTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLiberalBasicValue
            // 
            this.lblLiberalBasicValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblLiberalBasicValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblLiberalBasicValue.Location = new System.Drawing.Point(0, 23);
            this.lblLiberalBasicValue.Name = "lblLiberalBasicValue";
            this.lblLiberalBasicValue.Size = new System.Drawing.Size(116, 21);
            this.lblLiberalBasicValue.TabIndex = 1;
            this.lblLiberalBasicValue.Text = "0 / 0";
            this.lblLiberalBasicValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLiberalBasicStatus
            // 
            this.lblLiberalBasicStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblLiberalBasicStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblLiberalBasicStatus.Location = new System.Drawing.Point(0, 43);
            this.lblLiberalBasicStatus.Name = "lblLiberalBasicStatus";
            this.lblLiberalBasicStatus.Size = new System.Drawing.Size(116, 18);
            this.lblLiberalBasicStatus.TabIndex = 2;
            this.lblLiberalBasicStatus.Text = "대기";
            this.lblLiberalBasicStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgLiberalBasic
            // 
            this.prgLiberalBasic.Location = new System.Drawing.Point(10, 62);
            this.prgLiberalBasic.Name = "prgLiberalBasic";
            this.prgLiberalBasic.Size = new System.Drawing.Size(96, 8);
            this.prgLiberalBasic.TabIndex = 3;

            // 
            // pnlUnivReq
            // 
            this.pnlUnivReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlUnivReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnivReq.Controls.Add(this.prgUnivReq);
            this.pnlUnivReq.Controls.Add(this.lblUnivReqStatus);
            this.pnlUnivReq.Controls.Add(this.lblUnivReqValue);
            this.pnlUnivReq.Controls.Add(this.lblUnivReqTitle);
            this.pnlUnivReq.Location = new System.Drawing.Point(272, 38);
            this.pnlUnivReq.Name = "pnlUnivReq";
            this.pnlUnivReq.Size = new System.Drawing.Size(116, 74);
            this.pnlUnivReq.TabIndex = 0;
            // 
            // lblUnivReqTitle
            // 
            this.lblUnivReqTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblUnivReqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblUnivReqTitle.Location = new System.Drawing.Point(0, 5);
            this.lblUnivReqTitle.Name = "lblUnivReqTitle";
            this.lblUnivReqTitle.Size = new System.Drawing.Size(116, 18);
            this.lblUnivReqTitle.TabIndex = 0;
            this.lblUnivReqTitle.Text = "대학교양 필수";
            this.lblUnivReqTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnivReqValue
            // 
            this.lblUnivReqValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnivReqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblUnivReqValue.Location = new System.Drawing.Point(0, 23);
            this.lblUnivReqValue.Name = "lblUnivReqValue";
            this.lblUnivReqValue.Size = new System.Drawing.Size(116, 21);
            this.lblUnivReqValue.TabIndex = 1;
            this.lblUnivReqValue.Text = "0 / 0";
            this.lblUnivReqValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnivReqStatus
            // 
            this.lblUnivReqStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblUnivReqStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblUnivReqStatus.Location = new System.Drawing.Point(0, 43);
            this.lblUnivReqStatus.Name = "lblUnivReqStatus";
            this.lblUnivReqStatus.Size = new System.Drawing.Size(116, 18);
            this.lblUnivReqStatus.TabIndex = 2;
            this.lblUnivReqStatus.Text = "대기";
            this.lblUnivReqStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgUnivReq
            // 
            this.prgUnivReq.Location = new System.Drawing.Point(10, 62);
            this.prgUnivReq.Name = "prgUnivReq";
            this.prgUnivReq.Size = new System.Drawing.Size(96, 8);
            this.prgUnivReq.TabIndex = 3;

            // 
            // pnlUnivElec
            // 
            this.pnlUnivElec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlUnivElec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnivElec.Controls.Add(this.prgUnivElec);
            this.pnlUnivElec.Controls.Add(this.lblUnivElecStatus);
            this.pnlUnivElec.Controls.Add(this.lblUnivElecValue);
            this.pnlUnivElec.Controls.Add(this.lblUnivElecTitle);
            this.pnlUnivElec.Location = new System.Drawing.Point(398, 38);
            this.pnlUnivElec.Name = "pnlUnivElec";
            this.pnlUnivElec.Size = new System.Drawing.Size(116, 74);
            this.pnlUnivElec.TabIndex = 0;
            // 
            // lblUnivElecTitle
            // 
            this.lblUnivElecTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblUnivElecTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblUnivElecTitle.Location = new System.Drawing.Point(0, 5);
            this.lblUnivElecTitle.Name = "lblUnivElecTitle";
            this.lblUnivElecTitle.Size = new System.Drawing.Size(116, 18);
            this.lblUnivElecTitle.TabIndex = 0;
            this.lblUnivElecTitle.Text = "대학교양 선택";
            this.lblUnivElecTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnivElecValue
            // 
            this.lblUnivElecValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnivElecValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblUnivElecValue.Location = new System.Drawing.Point(0, 23);
            this.lblUnivElecValue.Name = "lblUnivElecValue";
            this.lblUnivElecValue.Size = new System.Drawing.Size(116, 21);
            this.lblUnivElecValue.TabIndex = 1;
            this.lblUnivElecValue.Text = "0 / 0";
            this.lblUnivElecValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnivElecStatus
            // 
            this.lblUnivElecStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblUnivElecStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblUnivElecStatus.Location = new System.Drawing.Point(0, 43);
            this.lblUnivElecStatus.Name = "lblUnivElecStatus";
            this.lblUnivElecStatus.Size = new System.Drawing.Size(116, 18);
            this.lblUnivElecStatus.TabIndex = 2;
            this.lblUnivElecStatus.Text = "대기";
            this.lblUnivElecStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgUnivElec
            // 
            this.prgUnivElec.Location = new System.Drawing.Point(10, 62);
            this.prgUnivElec.Name = "prgUnivElec";
            this.prgUnivElec.Size = new System.Drawing.Size(96, 8);
            this.prgUnivElec.TabIndex = 3;

            // 
            // pnlLiberalTotal
            // 
            this.pnlLiberalTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlLiberalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLiberalTotal.Controls.Add(this.prgLiberalTotal);
            this.pnlLiberalTotal.Controls.Add(this.lblLiberalTotalStatus);
            this.pnlLiberalTotal.Controls.Add(this.lblLiberalTotalValue);
            this.pnlLiberalTotal.Controls.Add(this.lblLiberalTotalTitle);
            this.pnlLiberalTotal.Location = new System.Drawing.Point(524, 38);
            this.pnlLiberalTotal.Name = "pnlLiberalTotal";
            this.pnlLiberalTotal.Size = new System.Drawing.Size(116, 74);
            this.pnlLiberalTotal.TabIndex = 0;
            // 
            // lblLiberalTotalTitle
            // 
            this.lblLiberalTotalTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblLiberalTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblLiberalTotalTitle.Location = new System.Drawing.Point(0, 5);
            this.lblLiberalTotalTitle.Name = "lblLiberalTotalTitle";
            this.lblLiberalTotalTitle.Size = new System.Drawing.Size(116, 18);
            this.lblLiberalTotalTitle.TabIndex = 0;
            this.lblLiberalTotalTitle.Text = "교양 소계";
            this.lblLiberalTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLiberalTotalValue
            // 
            this.lblLiberalTotalValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblLiberalTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblLiberalTotalValue.Location = new System.Drawing.Point(0, 23);
            this.lblLiberalTotalValue.Name = "lblLiberalTotalValue";
            this.lblLiberalTotalValue.Size = new System.Drawing.Size(116, 21);
            this.lblLiberalTotalValue.TabIndex = 1;
            this.lblLiberalTotalValue.Text = "0 / 0";
            this.lblLiberalTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLiberalTotalStatus
            // 
            this.lblLiberalTotalStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblLiberalTotalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblLiberalTotalStatus.Location = new System.Drawing.Point(0, 43);
            this.lblLiberalTotalStatus.Name = "lblLiberalTotalStatus";
            this.lblLiberalTotalStatus.Size = new System.Drawing.Size(116, 18);
            this.lblLiberalTotalStatus.TabIndex = 2;
            this.lblLiberalTotalStatus.Text = "대기";
            this.lblLiberalTotalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgLiberalTotal
            // 
            this.prgLiberalTotal.Location = new System.Drawing.Point(10, 62);
            this.prgLiberalTotal.Name = "prgLiberalTotal";
            this.prgLiberalTotal.Size = new System.Drawing.Size(96, 8);
            this.prgLiberalTotal.TabIndex = 3;

            // 
            // pnlExploreReq
            // 
            this.pnlExploreReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlExploreReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExploreReq.Controls.Add(this.prgExploreReq);
            this.pnlExploreReq.Controls.Add(this.lblExploreReqStatus);
            this.pnlExploreReq.Controls.Add(this.lblExploreReqValue);
            this.pnlExploreReq.Controls.Add(this.lblExploreReqTitle);
            this.pnlExploreReq.Location = new System.Drawing.Point(20, 120);
            this.pnlExploreReq.Name = "pnlExploreReq";
            this.pnlExploreReq.Size = new System.Drawing.Size(116, 74);
            this.pnlExploreReq.TabIndex = 0;
            // 
            // lblExploreReqTitle
            // 
            this.lblExploreReqTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblExploreReqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblExploreReqTitle.Location = new System.Drawing.Point(0, 5);
            this.lblExploreReqTitle.Name = "lblExploreReqTitle";
            this.lblExploreReqTitle.Size = new System.Drawing.Size(116, 18);
            this.lblExploreReqTitle.TabIndex = 0;
            this.lblExploreReqTitle.Text = "전공탐색 필수";
            this.lblExploreReqTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreReqValue
            // 
            this.lblExploreReqValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblExploreReqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblExploreReqValue.Location = new System.Drawing.Point(0, 23);
            this.lblExploreReqValue.Name = "lblExploreReqValue";
            this.lblExploreReqValue.Size = new System.Drawing.Size(116, 21);
            this.lblExploreReqValue.TabIndex = 1;
            this.lblExploreReqValue.Text = "0 / 0";
            this.lblExploreReqValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreReqStatus
            // 
            this.lblExploreReqStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblExploreReqStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblExploreReqStatus.Location = new System.Drawing.Point(0, 43);
            this.lblExploreReqStatus.Name = "lblExploreReqStatus";
            this.lblExploreReqStatus.Size = new System.Drawing.Size(116, 18);
            this.lblExploreReqStatus.TabIndex = 2;
            this.lblExploreReqStatus.Text = "대기";
            this.lblExploreReqStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgExploreReq
            // 
            this.prgExploreReq.Location = new System.Drawing.Point(10, 62);
            this.prgExploreReq.Name = "prgExploreReq";
            this.prgExploreReq.Size = new System.Drawing.Size(96, 8);
            this.prgExploreReq.TabIndex = 3;

            // 
            // pnlExploreElec
            // 
            this.pnlExploreElec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlExploreElec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExploreElec.Controls.Add(this.prgExploreElec);
            this.pnlExploreElec.Controls.Add(this.lblExploreElecStatus);
            this.pnlExploreElec.Controls.Add(this.lblExploreElecValue);
            this.pnlExploreElec.Controls.Add(this.lblExploreElecTitle);
            this.pnlExploreElec.Location = new System.Drawing.Point(146, 120);
            this.pnlExploreElec.Name = "pnlExploreElec";
            this.pnlExploreElec.Size = new System.Drawing.Size(116, 74);
            this.pnlExploreElec.TabIndex = 0;
            // 
            // lblExploreElecTitle
            // 
            this.lblExploreElecTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblExploreElecTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblExploreElecTitle.Location = new System.Drawing.Point(0, 5);
            this.lblExploreElecTitle.Name = "lblExploreElecTitle";
            this.lblExploreElecTitle.Size = new System.Drawing.Size(116, 18);
            this.lblExploreElecTitle.TabIndex = 0;
            this.lblExploreElecTitle.Text = "전공탐색 선택";
            this.lblExploreElecTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreElecValue
            // 
            this.lblExploreElecValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblExploreElecValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblExploreElecValue.Location = new System.Drawing.Point(0, 23);
            this.lblExploreElecValue.Name = "lblExploreElecValue";
            this.lblExploreElecValue.Size = new System.Drawing.Size(116, 21);
            this.lblExploreElecValue.TabIndex = 1;
            this.lblExploreElecValue.Text = "0 / 0";
            this.lblExploreElecValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreElecStatus
            // 
            this.lblExploreElecStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblExploreElecStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblExploreElecStatus.Location = new System.Drawing.Point(0, 43);
            this.lblExploreElecStatus.Name = "lblExploreElecStatus";
            this.lblExploreElecStatus.Size = new System.Drawing.Size(116, 18);
            this.lblExploreElecStatus.TabIndex = 2;
            this.lblExploreElecStatus.Text = "대기";
            this.lblExploreElecStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgExploreElec
            // 
            this.prgExploreElec.Location = new System.Drawing.Point(10, 62);
            this.prgExploreElec.Name = "prgExploreElec";
            this.prgExploreElec.Size = new System.Drawing.Size(96, 8);
            this.prgExploreElec.TabIndex = 3;

            // 
            // pnlExploreTotal
            // 
            this.pnlExploreTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlExploreTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExploreTotal.Controls.Add(this.prgExploreTotal);
            this.pnlExploreTotal.Controls.Add(this.lblExploreTotalStatus);
            this.pnlExploreTotal.Controls.Add(this.lblExploreTotalValue);
            this.pnlExploreTotal.Controls.Add(this.lblExploreTotalTitle);
            this.pnlExploreTotal.Location = new System.Drawing.Point(272, 120);
            this.pnlExploreTotal.Name = "pnlExploreTotal";
            this.pnlExploreTotal.Size = new System.Drawing.Size(116, 74);
            this.pnlExploreTotal.TabIndex = 0;
            // 
            // lblExploreTotalTitle
            // 
            this.lblExploreTotalTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblExploreTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblExploreTotalTitle.Location = new System.Drawing.Point(0, 5);
            this.lblExploreTotalTitle.Name = "lblExploreTotalTitle";
            this.lblExploreTotalTitle.Size = new System.Drawing.Size(116, 18);
            this.lblExploreTotalTitle.TabIndex = 0;
            this.lblExploreTotalTitle.Text = "전공탐색 소계";
            this.lblExploreTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreTotalValue
            // 
            this.lblExploreTotalValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblExploreTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblExploreTotalValue.Location = new System.Drawing.Point(0, 23);
            this.lblExploreTotalValue.Name = "lblExploreTotalValue";
            this.lblExploreTotalValue.Size = new System.Drawing.Size(116, 21);
            this.lblExploreTotalValue.TabIndex = 1;
            this.lblExploreTotalValue.Text = "0 / 0";
            this.lblExploreTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExploreTotalStatus
            // 
            this.lblExploreTotalStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblExploreTotalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblExploreTotalStatus.Location = new System.Drawing.Point(0, 43);
            this.lblExploreTotalStatus.Name = "lblExploreTotalStatus";
            this.lblExploreTotalStatus.Size = new System.Drawing.Size(116, 18);
            this.lblExploreTotalStatus.TabIndex = 2;
            this.lblExploreTotalStatus.Text = "대기";
            this.lblExploreTotalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgExploreTotal
            // 
            this.prgExploreTotal.Location = new System.Drawing.Point(10, 62);
            this.prgExploreTotal.Name = "prgExploreTotal";
            this.prgExploreTotal.Size = new System.Drawing.Size(96, 8);
            this.prgExploreTotal.TabIndex = 3;

            // 
            // pnlFirstMajorReq
            // 
            this.pnlFirstMajorReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlFirstMajorReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFirstMajorReq.Controls.Add(this.prgFirstMajorReq);
            this.pnlFirstMajorReq.Controls.Add(this.lblFirstMajorReqStatus);
            this.pnlFirstMajorReq.Controls.Add(this.lblFirstMajorReqValue);
            this.pnlFirstMajorReq.Controls.Add(this.lblFirstMajorReqTitle);
            this.pnlFirstMajorReq.Location = new System.Drawing.Point(398, 120);
            this.pnlFirstMajorReq.Name = "pnlFirstMajorReq";
            this.pnlFirstMajorReq.Size = new System.Drawing.Size(116, 74);
            this.pnlFirstMajorReq.TabIndex = 0;
            // 
            // lblFirstMajorReqTitle
            // 
            this.lblFirstMajorReqTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorReqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblFirstMajorReqTitle.Location = new System.Drawing.Point(0, 5);
            this.lblFirstMajorReqTitle.Name = "lblFirstMajorReqTitle";
            this.lblFirstMajorReqTitle.Size = new System.Drawing.Size(116, 18);
            this.lblFirstMajorReqTitle.TabIndex = 0;
            this.lblFirstMajorReqTitle.Text = "제1전공 필수";
            this.lblFirstMajorReqTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstMajorReqValue
            // 
            this.lblFirstMajorReqValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorReqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblFirstMajorReqValue.Location = new System.Drawing.Point(0, 23);
            this.lblFirstMajorReqValue.Name = "lblFirstMajorReqValue";
            this.lblFirstMajorReqValue.Size = new System.Drawing.Size(116, 21);
            this.lblFirstMajorReqValue.TabIndex = 1;
            this.lblFirstMajorReqValue.Text = "0 / 0";
            this.lblFirstMajorReqValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstMajorReqStatus
            // 
            this.lblFirstMajorReqStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorReqStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblFirstMajorReqStatus.Location = new System.Drawing.Point(0, 43);
            this.lblFirstMajorReqStatus.Name = "lblFirstMajorReqStatus";
            this.lblFirstMajorReqStatus.Size = new System.Drawing.Size(116, 18);
            this.lblFirstMajorReqStatus.TabIndex = 2;
            this.lblFirstMajorReqStatus.Text = "대기";
            this.lblFirstMajorReqStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgFirstMajorReq
            // 
            this.prgFirstMajorReq.Location = new System.Drawing.Point(10, 62);
            this.prgFirstMajorReq.Name = "prgFirstMajorReq";
            this.prgFirstMajorReq.Size = new System.Drawing.Size(96, 8);
            this.prgFirstMajorReq.TabIndex = 3;

            // 
            // pnlFirstMajorElec
            // 
            this.pnlFirstMajorElec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlFirstMajorElec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFirstMajorElec.Controls.Add(this.prgFirstMajorElec);
            this.pnlFirstMajorElec.Controls.Add(this.lblFirstMajorElecStatus);
            this.pnlFirstMajorElec.Controls.Add(this.lblFirstMajorElecValue);
            this.pnlFirstMajorElec.Controls.Add(this.lblFirstMajorElecTitle);
            this.pnlFirstMajorElec.Location = new System.Drawing.Point(524, 120);
            this.pnlFirstMajorElec.Name = "pnlFirstMajorElec";
            this.pnlFirstMajorElec.Size = new System.Drawing.Size(116, 74);
            this.pnlFirstMajorElec.TabIndex = 0;
            // 
            // lblFirstMajorElecTitle
            // 
            this.lblFirstMajorElecTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorElecTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblFirstMajorElecTitle.Location = new System.Drawing.Point(0, 5);
            this.lblFirstMajorElecTitle.Name = "lblFirstMajorElecTitle";
            this.lblFirstMajorElecTitle.Size = new System.Drawing.Size(116, 18);
            this.lblFirstMajorElecTitle.TabIndex = 0;
            this.lblFirstMajorElecTitle.Text = "제1전공 선택";
            this.lblFirstMajorElecTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstMajorElecValue
            // 
            this.lblFirstMajorElecValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorElecValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblFirstMajorElecValue.Location = new System.Drawing.Point(0, 23);
            this.lblFirstMajorElecValue.Name = "lblFirstMajorElecValue";
            this.lblFirstMajorElecValue.Size = new System.Drawing.Size(116, 21);
            this.lblFirstMajorElecValue.TabIndex = 1;
            this.lblFirstMajorElecValue.Text = "0 / 0";
            this.lblFirstMajorElecValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstMajorElecStatus
            // 
            this.lblFirstMajorElecStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorElecStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblFirstMajorElecStatus.Location = new System.Drawing.Point(0, 43);
            this.lblFirstMajorElecStatus.Name = "lblFirstMajorElecStatus";
            this.lblFirstMajorElecStatus.Size = new System.Drawing.Size(116, 18);
            this.lblFirstMajorElecStatus.TabIndex = 2;
            this.lblFirstMajorElecStatus.Text = "대기";
            this.lblFirstMajorElecStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgFirstMajorElec
            // 
            this.prgFirstMajorElec.Location = new System.Drawing.Point(10, 62);
            this.prgFirstMajorElec.Name = "prgFirstMajorElec";
            this.prgFirstMajorElec.Size = new System.Drawing.Size(96, 8);
            this.prgFirstMajorElec.TabIndex = 3;

            // 
            // pnlFirstMajorTotal
            // 
            this.pnlFirstMajorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlFirstMajorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFirstMajorTotal.Controls.Add(this.prgFirstMajorTotal);
            this.pnlFirstMajorTotal.Controls.Add(this.lblFirstMajorTotalStatus);
            this.pnlFirstMajorTotal.Controls.Add(this.lblFirstMajorTotalValue);
            this.pnlFirstMajorTotal.Controls.Add(this.lblFirstMajorTotalTitle);
            this.pnlFirstMajorTotal.Location = new System.Drawing.Point(20, 202);
            this.pnlFirstMajorTotal.Name = "pnlFirstMajorTotal";
            this.pnlFirstMajorTotal.Size = new System.Drawing.Size(116, 74);
            this.pnlFirstMajorTotal.TabIndex = 0;
            // 
            // lblFirstMajorTotalTitle
            // 
            this.lblFirstMajorTotalTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblFirstMajorTotalTitle.Location = new System.Drawing.Point(0, 5);
            this.lblFirstMajorTotalTitle.Name = "lblFirstMajorTotalTitle";
            this.lblFirstMajorTotalTitle.Size = new System.Drawing.Size(116, 18);
            this.lblFirstMajorTotalTitle.TabIndex = 0;
            this.lblFirstMajorTotalTitle.Text = "제1전공 소계";
            this.lblFirstMajorTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstMajorTotalValue
            // 
            this.lblFirstMajorTotalValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblFirstMajorTotalValue.Location = new System.Drawing.Point(0, 23);
            this.lblFirstMajorTotalValue.Name = "lblFirstMajorTotalValue";
            this.lblFirstMajorTotalValue.Size = new System.Drawing.Size(116, 21);
            this.lblFirstMajorTotalValue.TabIndex = 1;
            this.lblFirstMajorTotalValue.Text = "0 / 0";
            this.lblFirstMajorTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstMajorTotalStatus
            // 
            this.lblFirstMajorTotalStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblFirstMajorTotalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblFirstMajorTotalStatus.Location = new System.Drawing.Point(0, 43);
            this.lblFirstMajorTotalStatus.Name = "lblFirstMajorTotalStatus";
            this.lblFirstMajorTotalStatus.Size = new System.Drawing.Size(116, 18);
            this.lblFirstMajorTotalStatus.TabIndex = 2;
            this.lblFirstMajorTotalStatus.Text = "대기";
            this.lblFirstMajorTotalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgFirstMajorTotal
            // 
            this.prgFirstMajorTotal.Location = new System.Drawing.Point(10, 62);
            this.prgFirstMajorTotal.Name = "prgFirstMajorTotal";
            this.prgFirstMajorTotal.Size = new System.Drawing.Size(96, 8);
            this.prgFirstMajorTotal.TabIndex = 3;

            // 
            // pnlSecondMajorReq
            // 
            this.pnlSecondMajorReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlSecondMajorReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecondMajorReq.Controls.Add(this.prgSecondMajorReq);
            this.pnlSecondMajorReq.Controls.Add(this.lblSecondMajorReqStatus);
            this.pnlSecondMajorReq.Controls.Add(this.lblSecondMajorReqValue);
            this.pnlSecondMajorReq.Controls.Add(this.lblSecondMajorReqTitle);
            this.pnlSecondMajorReq.Location = new System.Drawing.Point(146, 202);
            this.pnlSecondMajorReq.Name = "pnlSecondMajorReq";
            this.pnlSecondMajorReq.Size = new System.Drawing.Size(116, 74);
            this.pnlSecondMajorReq.TabIndex = 0;
            // 
            // lblSecondMajorReqTitle
            // 
            this.lblSecondMajorReqTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorReqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblSecondMajorReqTitle.Location = new System.Drawing.Point(0, 5);
            this.lblSecondMajorReqTitle.Name = "lblSecondMajorReqTitle";
            this.lblSecondMajorReqTitle.Size = new System.Drawing.Size(116, 18);
            this.lblSecondMajorReqTitle.TabIndex = 0;
            this.lblSecondMajorReqTitle.Text = "제2전공 필수";
            this.lblSecondMajorReqTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondMajorReqValue
            // 
            this.lblSecondMajorReqValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorReqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblSecondMajorReqValue.Location = new System.Drawing.Point(0, 23);
            this.lblSecondMajorReqValue.Name = "lblSecondMajorReqValue";
            this.lblSecondMajorReqValue.Size = new System.Drawing.Size(116, 21);
            this.lblSecondMajorReqValue.TabIndex = 1;
            this.lblSecondMajorReqValue.Text = "0 / 0";
            this.lblSecondMajorReqValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondMajorReqStatus
            // 
            this.lblSecondMajorReqStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorReqStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblSecondMajorReqStatus.Location = new System.Drawing.Point(0, 43);
            this.lblSecondMajorReqStatus.Name = "lblSecondMajorReqStatus";
            this.lblSecondMajorReqStatus.Size = new System.Drawing.Size(116, 18);
            this.lblSecondMajorReqStatus.TabIndex = 2;
            this.lblSecondMajorReqStatus.Text = "대기";
            this.lblSecondMajorReqStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgSecondMajorReq
            // 
            this.prgSecondMajorReq.Location = new System.Drawing.Point(10, 62);
            this.prgSecondMajorReq.Name = "prgSecondMajorReq";
            this.prgSecondMajorReq.Size = new System.Drawing.Size(96, 8);
            this.prgSecondMajorReq.TabIndex = 3;

            // 
            // pnlSecondMajorElec
            // 
            this.pnlSecondMajorElec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlSecondMajorElec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecondMajorElec.Controls.Add(this.prgSecondMajorElec);
            this.pnlSecondMajorElec.Controls.Add(this.lblSecondMajorElecStatus);
            this.pnlSecondMajorElec.Controls.Add(this.lblSecondMajorElecValue);
            this.pnlSecondMajorElec.Controls.Add(this.lblSecondMajorElecTitle);
            this.pnlSecondMajorElec.Location = new System.Drawing.Point(272, 202);
            this.pnlSecondMajorElec.Name = "pnlSecondMajorElec";
            this.pnlSecondMajorElec.Size = new System.Drawing.Size(116, 74);
            this.pnlSecondMajorElec.TabIndex = 0;
            // 
            // lblSecondMajorElecTitle
            // 
            this.lblSecondMajorElecTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorElecTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblSecondMajorElecTitle.Location = new System.Drawing.Point(0, 5);
            this.lblSecondMajorElecTitle.Name = "lblSecondMajorElecTitle";
            this.lblSecondMajorElecTitle.Size = new System.Drawing.Size(116, 18);
            this.lblSecondMajorElecTitle.TabIndex = 0;
            this.lblSecondMajorElecTitle.Text = "제2전공 선택";
            this.lblSecondMajorElecTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondMajorElecValue
            // 
            this.lblSecondMajorElecValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorElecValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblSecondMajorElecValue.Location = new System.Drawing.Point(0, 23);
            this.lblSecondMajorElecValue.Name = "lblSecondMajorElecValue";
            this.lblSecondMajorElecValue.Size = new System.Drawing.Size(116, 21);
            this.lblSecondMajorElecValue.TabIndex = 1;
            this.lblSecondMajorElecValue.Text = "0 / 0";
            this.lblSecondMajorElecValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondMajorElecStatus
            // 
            this.lblSecondMajorElecStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorElecStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblSecondMajorElecStatus.Location = new System.Drawing.Point(0, 43);
            this.lblSecondMajorElecStatus.Name = "lblSecondMajorElecStatus";
            this.lblSecondMajorElecStatus.Size = new System.Drawing.Size(116, 18);
            this.lblSecondMajorElecStatus.TabIndex = 2;
            this.lblSecondMajorElecStatus.Text = "대기";
            this.lblSecondMajorElecStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgSecondMajorElec
            // 
            this.prgSecondMajorElec.Location = new System.Drawing.Point(10, 62);
            this.prgSecondMajorElec.Name = "prgSecondMajorElec";
            this.prgSecondMajorElec.Size = new System.Drawing.Size(96, 8);
            this.prgSecondMajorElec.TabIndex = 3;

            // 
            // pnlSecondMajorTotal
            // 
            this.pnlSecondMajorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlSecondMajorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecondMajorTotal.Controls.Add(this.prgSecondMajorTotal);
            this.pnlSecondMajorTotal.Controls.Add(this.lblSecondMajorTotalStatus);
            this.pnlSecondMajorTotal.Controls.Add(this.lblSecondMajorTotalValue);
            this.pnlSecondMajorTotal.Controls.Add(this.lblSecondMajorTotalTitle);
            this.pnlSecondMajorTotal.Location = new System.Drawing.Point(398, 202);
            this.pnlSecondMajorTotal.Name = "pnlSecondMajorTotal";
            this.pnlSecondMajorTotal.Size = new System.Drawing.Size(116, 74);
            this.pnlSecondMajorTotal.TabIndex = 0;
            // 
            // lblSecondMajorTotalTitle
            // 
            this.lblSecondMajorTotalTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblSecondMajorTotalTitle.Location = new System.Drawing.Point(0, 5);
            this.lblSecondMajorTotalTitle.Name = "lblSecondMajorTotalTitle";
            this.lblSecondMajorTotalTitle.Size = new System.Drawing.Size(116, 18);
            this.lblSecondMajorTotalTitle.TabIndex = 0;
            this.lblSecondMajorTotalTitle.Text = "제2전공 소계";
            this.lblSecondMajorTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondMajorTotalValue
            // 
            this.lblSecondMajorTotalValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblSecondMajorTotalValue.Location = new System.Drawing.Point(0, 23);
            this.lblSecondMajorTotalValue.Name = "lblSecondMajorTotalValue";
            this.lblSecondMajorTotalValue.Size = new System.Drawing.Size(116, 21);
            this.lblSecondMajorTotalValue.TabIndex = 1;
            this.lblSecondMajorTotalValue.Text = "0 / 0";
            this.lblSecondMajorTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondMajorTotalStatus
            // 
            this.lblSecondMajorTotalStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblSecondMajorTotalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblSecondMajorTotalStatus.Location = new System.Drawing.Point(0, 43);
            this.lblSecondMajorTotalStatus.Name = "lblSecondMajorTotalStatus";
            this.lblSecondMajorTotalStatus.Size = new System.Drawing.Size(116, 18);
            this.lblSecondMajorTotalStatus.TabIndex = 2;
            this.lblSecondMajorTotalStatus.Text = "대기";
            this.lblSecondMajorTotalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgSecondMajorTotal
            // 
            this.prgSecondMajorTotal.Location = new System.Drawing.Point(10, 62);
            this.prgSecondMajorTotal.Name = "prgSecondMajorTotal";
            this.prgSecondMajorTotal.Size = new System.Drawing.Size(96, 8);
            this.prgSecondMajorTotal.TabIndex = 3;

            // 
            // pnlOverall
            // 
            this.pnlOverall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlOverall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOverall.Controls.Add(this.prgOverall);
            this.pnlOverall.Controls.Add(this.lblOverallStatus);
            this.pnlOverall.Controls.Add(this.lblOverallValue);
            this.pnlOverall.Controls.Add(this.lblOverallTitle);
            this.pnlOverall.Location = new System.Drawing.Point(524, 202);
            this.pnlOverall.Name = "pnlOverall";
            this.pnlOverall.Size = new System.Drawing.Size(116, 74);
            this.pnlOverall.TabIndex = 0;
            // 
            // lblOverallTitle
            // 
            this.lblOverallTitle.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblOverallTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblOverallTitle.Location = new System.Drawing.Point(0, 5);
            this.lblOverallTitle.Name = "lblOverallTitle";
            this.lblOverallTitle.Size = new System.Drawing.Size(116, 18);
            this.lblOverallTitle.TabIndex = 0;
            this.lblOverallTitle.Text = "전체판정";
            this.lblOverallTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverallValue
            // 
            this.lblOverallValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblOverallValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblOverallValue.Location = new System.Drawing.Point(0, 23);
            this.lblOverallValue.Name = "lblOverallValue";
            this.lblOverallValue.Size = new System.Drawing.Size(116, 21);
            this.lblOverallValue.TabIndex = 1;
            this.lblOverallValue.Text = "0 / 0";
            this.lblOverallValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverallStatus
            // 
            this.lblOverallStatus.Font = new System.Drawing.Font("맑은 고딕", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblOverallStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblOverallStatus.Location = new System.Drawing.Point(0, 43);
            this.lblOverallStatus.Name = "lblOverallStatus";
            this.lblOverallStatus.Size = new System.Drawing.Size(116, 18);
            this.lblOverallStatus.TabIndex = 2;
            this.lblOverallStatus.Text = "대기";
            this.lblOverallStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgOverall
            // 
            this.prgOverall.Location = new System.Drawing.Point(10, 62);
            this.prgOverall.Name = "prgOverall";
            this.prgOverall.Size = new System.Drawing.Size(96, 8);
            this.prgOverall.TabIndex = 3;

            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.White;
            this.inputBox.Controls.Add(this.btnClear);
            this.inputBox.Controls.Add(this.btnCalculate);
            this.inputBox.Controls.Add(this.txtRawInput);
            this.inputBox.Controls.Add(this.btnLoadFile);
            this.inputBox.Controls.Add(this.lblInput);
            this.inputBox.Controls.Add(this.txtStudentName);
            this.inputBox.Controls.Add(this.lblName);
            this.inputBox.Controls.Add(this.txtStudentNo);
            this.inputBox.Controls.Add(this.lblStudentNo);
            this.inputBox.Controls.Add(this.cboYear);
            this.inputBox.Controls.Add(this.lblYear);
            this.inputBox.Controls.Add(this.txtDepartment);
            this.inputBox.Controls.Add(this.lblDepartment);
            this.inputBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.inputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.inputBox.Location = new System.Drawing.Point(20, 95);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(420, 330);
            this.inputBox.TabIndex = 3;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "학생 정보 및 이수내역 입력";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.btnClear.Location = new System.Drawing.Point(282, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(228)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(22, 282);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(245, 36);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "졸업요건 계산하기";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRawInput
            // 
            this.txtRawInput.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtRawInput.Location = new System.Drawing.Point(22, 145);
            this.txtRawInput.Multiline = true;
            this.txtRawInput.Name = "txtRawInput";
            this.txtRawInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRawInput.Size = new System.Drawing.Size(378, 122);
            this.txtRawInput.TabIndex = 10;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.White;
            this.btnLoadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFile.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.btnLoadFile.Location = new System.Drawing.Point(292, 107);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(108, 30);
            this.btnLoadFile.TabIndex = 9;
            this.btnLoadFile.Text = "파일 불러오기";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // lblInput
            // 
            this.lblInput.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblInput.Location = new System.Drawing.Point(22, 113);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(120, 22);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "이수내역 텍스트";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(310, 72);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(90, 25);
            this.txtStudentName.TabIndex = 7;
            this.txtStudentName.Text = "홍길동";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblName.Location = new System.Drawing.Point(240, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 22);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "이름";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(98, 72);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(130, 25);
            this.txtStudentNo.TabIndex = 5;
            this.txtStudentNo.Text = "202412345";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblStudentNo.Location = new System.Drawing.Point(22, 76);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(70, 22);
            this.lblStudentNo.TabIndex = 4;
            this.lblStudentNo.Text = "학번";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024" });
            this.cboYear.Location = new System.Drawing.Point(310, 34);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(90, 25);
            this.cboYear.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblYear.Location = new System.Drawing.Point(240, 38);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(70, 22);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "입학년도";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(98, 34);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(130, 25);
            this.txtDepartment.TabIndex = 1;
            this.txtDepartment.Text = "컴퓨터공학과";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.lblDepartment.Location = new System.Drawing.Point(22, 38);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(70, 22);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "학과";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(870, 25);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(126, 34);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "관리자 모드";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.btnPrint.Location = new System.Drawing.Point(1010, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 34);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "결과 인쇄";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(24, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(840, 24);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "CCC 담당: 세분화된 이수구분별 졸업요건 현황 표시 / 제1전공·제2전공 분리";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "원폼 학점 계산 프로그램 - 학생 졸업요건 판정 화면";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1180, 835);
            this.Controls.Add(this.rootPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 760);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "원폼 학점 계산 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rootPanel.ResumeLayout(false);
            this.guideBox.ResumeLayout(false);
            this.statusBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaStatus)).EndInit();
            this.subjectBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.summaryBox.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlLiberalBasic.ResumeLayout(false);
            this.pnlUnivReq.ResumeLayout(false);
            this.pnlUnivElec.ResumeLayout(false);
            this.pnlLiberalTotal.ResumeLayout(false);
            this.pnlExploreReq.ResumeLayout(false);
            this.pnlExploreElec.ResumeLayout(false);
            this.pnlExploreTotal.ResumeLayout(false);
            this.pnlFirstMajorReq.ResumeLayout(false);
            this.pnlFirstMajorElec.ResumeLayout(false);
            this.pnlFirstMajorTotal.ResumeLayout(false);
            this.pnlSecondMajorReq.ResumeLayout(false);
            this.pnlSecondMajorElec.ResumeLayout(false);
            this.pnlSecondMajorTotal.ResumeLayout(false);
            this.pnlOverall.ResumeLayout(false);
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel rootPanel;
        private System.Windows.Forms.GroupBox guideBox;
        private System.Windows.Forms.Label lblMissingRequired;
        private System.Windows.Forms.Label lblShortage;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.DataGridView dgvAreaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequired;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.GroupBox subjectBox;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalStatus;
        private System.Windows.Forms.ProgressBar prgTotal;
        private System.Windows.Forms.Panel pnlLiberalBasic;
        private System.Windows.Forms.Label lblLiberalBasicTitle;
        private System.Windows.Forms.Label lblLiberalBasicValue;
        private System.Windows.Forms.Label lblLiberalBasicStatus;
        private System.Windows.Forms.ProgressBar prgLiberalBasic;
        private System.Windows.Forms.Panel pnlUnivReq;
        private System.Windows.Forms.Label lblUnivReqTitle;
        private System.Windows.Forms.Label lblUnivReqValue;
        private System.Windows.Forms.Label lblUnivReqStatus;
        private System.Windows.Forms.ProgressBar prgUnivReq;
        private System.Windows.Forms.Panel pnlUnivElec;
        private System.Windows.Forms.Label lblUnivElecTitle;
        private System.Windows.Forms.Label lblUnivElecValue;
        private System.Windows.Forms.Label lblUnivElecStatus;
        private System.Windows.Forms.ProgressBar prgUnivElec;
        private System.Windows.Forms.Panel pnlLiberalTotal;
        private System.Windows.Forms.Label lblLiberalTotalTitle;
        private System.Windows.Forms.Label lblLiberalTotalValue;
        private System.Windows.Forms.Label lblLiberalTotalStatus;
        private System.Windows.Forms.ProgressBar prgLiberalTotal;
        private System.Windows.Forms.Panel pnlExploreReq;
        private System.Windows.Forms.Label lblExploreReqTitle;
        private System.Windows.Forms.Label lblExploreReqValue;
        private System.Windows.Forms.Label lblExploreReqStatus;
        private System.Windows.Forms.ProgressBar prgExploreReq;
        private System.Windows.Forms.Panel pnlExploreElec;
        private System.Windows.Forms.Label lblExploreElecTitle;
        private System.Windows.Forms.Label lblExploreElecValue;
        private System.Windows.Forms.Label lblExploreElecStatus;
        private System.Windows.Forms.ProgressBar prgExploreElec;
        private System.Windows.Forms.Panel pnlExploreTotal;
        private System.Windows.Forms.Label lblExploreTotalTitle;
        private System.Windows.Forms.Label lblExploreTotalValue;
        private System.Windows.Forms.Label lblExploreTotalStatus;
        private System.Windows.Forms.ProgressBar prgExploreTotal;
        private System.Windows.Forms.Panel pnlFirstMajorReq;
        private System.Windows.Forms.Label lblFirstMajorReqTitle;
        private System.Windows.Forms.Label lblFirstMajorReqValue;
        private System.Windows.Forms.Label lblFirstMajorReqStatus;
        private System.Windows.Forms.ProgressBar prgFirstMajorReq;
        private System.Windows.Forms.Panel pnlFirstMajorElec;
        private System.Windows.Forms.Label lblFirstMajorElecTitle;
        private System.Windows.Forms.Label lblFirstMajorElecValue;
        private System.Windows.Forms.Label lblFirstMajorElecStatus;
        private System.Windows.Forms.ProgressBar prgFirstMajorElec;
        private System.Windows.Forms.Panel pnlFirstMajorTotal;
        private System.Windows.Forms.Label lblFirstMajorTotalTitle;
        private System.Windows.Forms.Label lblFirstMajorTotalValue;
        private System.Windows.Forms.Label lblFirstMajorTotalStatus;
        private System.Windows.Forms.ProgressBar prgFirstMajorTotal;
        private System.Windows.Forms.Panel pnlSecondMajorReq;
        private System.Windows.Forms.Label lblSecondMajorReqTitle;
        private System.Windows.Forms.Label lblSecondMajorReqValue;
        private System.Windows.Forms.Label lblSecondMajorReqStatus;
        private System.Windows.Forms.ProgressBar prgSecondMajorReq;
        private System.Windows.Forms.Panel pnlSecondMajorElec;
        private System.Windows.Forms.Label lblSecondMajorElecTitle;
        private System.Windows.Forms.Label lblSecondMajorElecValue;
        private System.Windows.Forms.Label lblSecondMajorElecStatus;
        private System.Windows.Forms.ProgressBar prgSecondMajorElec;
        private System.Windows.Forms.Panel pnlSecondMajorTotal;
        private System.Windows.Forms.Label lblSecondMajorTotalTitle;
        private System.Windows.Forms.Label lblSecondMajorTotalValue;
        private System.Windows.Forms.Label lblSecondMajorTotalStatus;
        private System.Windows.Forms.ProgressBar prgSecondMajorTotal;
        private System.Windows.Forms.Panel pnlOverall;
        private System.Windows.Forms.Label lblOverallTitle;
        private System.Windows.Forms.Label lblOverallValue;
        private System.Windows.Forms.Label lblOverallStatus;
        private System.Windows.Forms.ProgressBar prgOverall;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtRawInput;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
    }
}
