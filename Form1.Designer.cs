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
            this.pnlOverall = new System.Windows.Forms.Panel();
            this.prgOverall = new System.Windows.Forms.ProgressBar();
            this.lblOverallStatus = new System.Windows.Forms.Label();
            this.lblOverallValue = new System.Windows.Forms.Label();
            this.lblOverallTitle = new System.Windows.Forms.Label();
            this.pnlGenElec = new System.Windows.Forms.Panel();
            this.prgGenElec = new System.Windows.Forms.ProgressBar();
            this.lblGenElecStatus = new System.Windows.Forms.Label();
            this.lblGenElecValue = new System.Windows.Forms.Label();
            this.lblGenElecTitle = new System.Windows.Forms.Label();
            this.pnlGenReq = new System.Windows.Forms.Panel();
            this.prgGenReq = new System.Windows.Forms.ProgressBar();
            this.lblGenReqStatus = new System.Windows.Forms.Label();
            this.lblGenReqValue = new System.Windows.Forms.Label();
            this.lblGenReqTitle = new System.Windows.Forms.Label();
            this.pnlMajorElec = new System.Windows.Forms.Panel();
            this.prgMajorElec = new System.Windows.Forms.ProgressBar();
            this.lblMajorElecStatus = new System.Windows.Forms.Label();
            this.lblMajorElecValue = new System.Windows.Forms.Label();
            this.lblMajorElecTitle = new System.Windows.Forms.Label();
            this.pnlMajorReq = new System.Windows.Forms.Panel();
            this.prgMajorReq = new System.Windows.Forms.ProgressBar();
            this.lblMajorReqStatus = new System.Windows.Forms.Label();
            this.lblMajorReqValue = new System.Windows.Forms.Label();
            this.lblMajorReqTitle = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.prgTotal = new System.Windows.Forms.ProgressBar();
            this.lblTotalStatus = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
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
            this.pnlOverall.SuspendLayout();
            this.pnlGenElec.SuspendLayout();
            this.pnlGenReq.SuspendLayout();
            this.pnlMajorElec.SuspendLayout();
            this.pnlMajorReq.SuspendLayout();
            this.pnlTotal.SuspendLayout();
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
            this.rootPanel.Controls.Add(this.btnPrint);
            this.rootPanel.Controls.Add(this.lblSubtitle);
            this.rootPanel.Controls.Add(this.lblTitle);
            this.rootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootPanel.Location = new System.Drawing.Point(0, 0);
            this.rootPanel.Name = "rootPanel";
            this.rootPanel.Padding = new System.Windows.Forms.Padding(18);
            this.rootPanel.Size = new System.Drawing.Size(1180, 760);
            this.rootPanel.TabIndex = 0;
            // 
            // guideBox
            // 
            this.guideBox.BackColor = System.Drawing.Color.White;
            this.guideBox.Controls.Add(this.lblMissingRequired);
            this.guideBox.Controls.Add(this.lblShortage);
            this.guideBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.guideBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.guideBox.Location = new System.Drawing.Point(20, 700);
            this.guideBox.Name = "guideBox";
            this.guideBox.Size = new System.Drawing.Size(1110, 95);
            this.guideBox.TabIndex = 7;
            this.guideBox.TabStop = false;
            this.guideBox.Text = "부족 학점 및 미이수 필수과목 안내";
            // 
            // lblMissingRequired
            // 
            this.lblMissingRequired.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblMissingRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblMissingRequired.Location = new System.Drawing.Point(560, 30);
            this.lblMissingRequired.Name = "lblMissingRequired";
            this.lblMissingRequired.Size = new System.Drawing.Size(520, 45);
            this.lblMissingRequired.TabIndex = 1;
            // 
            // lblShortage
            // 
            this.lblShortage.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblShortage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblShortage.Location = new System.Drawing.Point(22, 30);
            this.lblShortage.Name = "lblShortage";
            this.lblShortage.Size = new System.Drawing.Size(520, 45);
            this.lblShortage.TabIndex = 0;
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.White;
            this.statusBox.Controls.Add(this.dgvAreaStatus);
            this.statusBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.statusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.statusBox.Location = new System.Drawing.Point(650, 430);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(480, 250);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAreaStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAreaStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreaStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colArea,
            this.colRequired,
            this.colCompleted,
            this.colStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAreaStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAreaStatus.EnableHeadersVisualStyles = false;
            this.dgvAreaStatus.Location = new System.Drawing.Point(18, 30);
            this.dgvAreaStatus.Name = "dgvAreaStatus";
            this.dgvAreaStatus.ReadOnly = true;
            this.dgvAreaStatus.RowHeadersVisible = false;
            this.dgvAreaStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreaStatus.Size = new System.Drawing.Size(444, 202);
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
            this.subjectBox.Location = new System.Drawing.Point(20, 430);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(610, 250);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colCode,
            this.colName,
            this.colCredit,
            this.colGrade});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubjects.EnableHeadersVisualStyles = false;
            this.dgvSubjects.Location = new System.Drawing.Point(18, 30);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(574, 202);
            this.dgvSubjects.TabIndex = 0;
            // 
            // colType
            // 
            this.colType.HeaderText = "구분";
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
            this.summaryBox.Controls.Add(this.pnlOverall);
            this.summaryBox.Controls.Add(this.pnlGenElec);
            this.summaryBox.Controls.Add(this.pnlGenReq);
            this.summaryBox.Controls.Add(this.pnlMajorElec);
            this.summaryBox.Controls.Add(this.pnlMajorReq);
            this.summaryBox.Controls.Add(this.pnlTotal);
            this.summaryBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.summaryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.summaryBox.Location = new System.Drawing.Point(460, 95);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(670, 315);
            this.summaryBox.TabIndex = 4;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "요약 현황";
            // 
            // pnlOverall
            // 
            this.pnlOverall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlOverall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOverall.Controls.Add(this.prgOverall);
            this.pnlOverall.Controls.Add(this.lblOverallStatus);
            this.pnlOverall.Controls.Add(this.lblOverallValue);
            this.pnlOverall.Controls.Add(this.lblOverallTitle);
            this.pnlOverall.Location = new System.Drawing.Point(455, 168);
            this.pnlOverall.Name = "pnlOverall";
            this.pnlOverall.Size = new System.Drawing.Size(185, 96);
            this.pnlOverall.TabIndex = 0;
            // 
            // prgOverall
            // 
            this.prgOverall.Location = new System.Drawing.Point(16, 80);
            this.prgOverall.Name = "prgOverall";
            this.prgOverall.Size = new System.Drawing.Size(152, 10);
            this.prgOverall.TabIndex = 3;
            // 
            // lblOverallStatus
            // 
            this.lblOverallStatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblOverallStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblOverallStatus.Location = new System.Drawing.Point(0, 60);
            this.lblOverallStatus.Name = "lblOverallStatus";
            this.lblOverallStatus.Size = new System.Drawing.Size(185, 20);
            this.lblOverallStatus.TabIndex = 2;
            this.lblOverallStatus.Text = "대기";
            this.lblOverallStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverallValue
            // 
            this.lblOverallValue.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.lblOverallValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblOverallValue.Location = new System.Drawing.Point(0, 32);
            this.lblOverallValue.Name = "lblOverallValue";
            this.lblOverallValue.Size = new System.Drawing.Size(185, 28);
            this.lblOverallValue.TabIndex = 1;
            this.lblOverallValue.Text = "0 / 0";
            this.lblOverallValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverallTitle
            // 
            this.lblOverallTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblOverallTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblOverallTitle.Location = new System.Drawing.Point(0, 10);
            this.lblOverallTitle.Name = "lblOverallTitle";
            this.lblOverallTitle.Size = new System.Drawing.Size(185, 20);
            this.lblOverallTitle.TabIndex = 0;
            this.lblOverallTitle.Text = "전체판정";
            this.lblOverallTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGenElec
            // 
            this.pnlGenElec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlGenElec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGenElec.Controls.Add(this.prgGenElec);
            this.pnlGenElec.Controls.Add(this.lblGenElecStatus);
            this.pnlGenElec.Controls.Add(this.lblGenElecValue);
            this.pnlGenElec.Controls.Add(this.lblGenElecTitle);
            this.pnlGenElec.Location = new System.Drawing.Point(240, 168);
            this.pnlGenElec.Name = "pnlGenElec";
            this.pnlGenElec.Size = new System.Drawing.Size(185, 96);
            this.pnlGenElec.TabIndex = 0;
            // 
            // prgGenElec
            // 
            this.prgGenElec.Location = new System.Drawing.Point(16, 80);
            this.prgGenElec.Name = "prgGenElec";
            this.prgGenElec.Size = new System.Drawing.Size(152, 10);
            this.prgGenElec.TabIndex = 3;
            // 
            // lblGenElecStatus
            // 
            this.lblGenElecStatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenElecStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblGenElecStatus.Location = new System.Drawing.Point(0, 60);
            this.lblGenElecStatus.Name = "lblGenElecStatus";
            this.lblGenElecStatus.Size = new System.Drawing.Size(185, 20);
            this.lblGenElecStatus.TabIndex = 2;
            this.lblGenElecStatus.Text = "대기";
            this.lblGenElecStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenElecValue
            // 
            this.lblGenElecValue.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.lblGenElecValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblGenElecValue.Location = new System.Drawing.Point(0, 32);
            this.lblGenElecValue.Name = "lblGenElecValue";
            this.lblGenElecValue.Size = new System.Drawing.Size(185, 28);
            this.lblGenElecValue.TabIndex = 1;
            this.lblGenElecValue.Text = "0 / 0";
            this.lblGenElecValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenElecTitle
            // 
            this.lblGenElecTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenElecTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblGenElecTitle.Location = new System.Drawing.Point(0, 10);
            this.lblGenElecTitle.Name = "lblGenElecTitle";
            this.lblGenElecTitle.Size = new System.Drawing.Size(185, 20);
            this.lblGenElecTitle.TabIndex = 0;
            this.lblGenElecTitle.Text = "교양선택";
            this.lblGenElecTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGenReq
            // 
            this.pnlGenReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlGenReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGenReq.Controls.Add(this.prgGenReq);
            this.pnlGenReq.Controls.Add(this.lblGenReqStatus);
            this.pnlGenReq.Controls.Add(this.lblGenReqValue);
            this.pnlGenReq.Controls.Add(this.lblGenReqTitle);
            this.pnlGenReq.Location = new System.Drawing.Point(25, 168);
            this.pnlGenReq.Name = "pnlGenReq";
            this.pnlGenReq.Size = new System.Drawing.Size(185, 96);
            this.pnlGenReq.TabIndex = 0;
            // 
            // prgGenReq
            // 
            this.prgGenReq.Location = new System.Drawing.Point(16, 80);
            this.prgGenReq.Name = "prgGenReq";
            this.prgGenReq.Size = new System.Drawing.Size(152, 10);
            this.prgGenReq.TabIndex = 3;
            // 
            // lblGenReqStatus
            // 
            this.lblGenReqStatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenReqStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblGenReqStatus.Location = new System.Drawing.Point(0, 60);
            this.lblGenReqStatus.Name = "lblGenReqStatus";
            this.lblGenReqStatus.Size = new System.Drawing.Size(185, 20);
            this.lblGenReqStatus.TabIndex = 2;
            this.lblGenReqStatus.Text = "대기";
            this.lblGenReqStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenReqValue
            // 
            this.lblGenReqValue.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.lblGenReqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblGenReqValue.Location = new System.Drawing.Point(0, 32);
            this.lblGenReqValue.Name = "lblGenReqValue";
            this.lblGenReqValue.Size = new System.Drawing.Size(185, 28);
            this.lblGenReqValue.TabIndex = 1;
            this.lblGenReqValue.Text = "0 / 0";
            this.lblGenReqValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenReqTitle
            // 
            this.lblGenReqTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenReqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblGenReqTitle.Location = new System.Drawing.Point(0, 10);
            this.lblGenReqTitle.Name = "lblGenReqTitle";
            this.lblGenReqTitle.Size = new System.Drawing.Size(185, 20);
            this.lblGenReqTitle.TabIndex = 0;
            this.lblGenReqTitle.Text = "교양필수";
            this.lblGenReqTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMajorElec
            // 
            this.pnlMajorElec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlMajorElec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMajorElec.Controls.Add(this.prgMajorElec);
            this.pnlMajorElec.Controls.Add(this.lblMajorElecStatus);
            this.pnlMajorElec.Controls.Add(this.lblMajorElecValue);
            this.pnlMajorElec.Controls.Add(this.lblMajorElecTitle);
            this.pnlMajorElec.Location = new System.Drawing.Point(455, 42);
            this.pnlMajorElec.Name = "pnlMajorElec";
            this.pnlMajorElec.Size = new System.Drawing.Size(185, 96);
            this.pnlMajorElec.TabIndex = 0;
            // 
            // prgMajorElec
            // 
            this.prgMajorElec.Location = new System.Drawing.Point(16, 80);
            this.prgMajorElec.Name = "prgMajorElec";
            this.prgMajorElec.Size = new System.Drawing.Size(152, 10);
            this.prgMajorElec.TabIndex = 3;
            // 
            // lblMajorElecStatus
            // 
            this.lblMajorElecStatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblMajorElecStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblMajorElecStatus.Location = new System.Drawing.Point(0, 60);
            this.lblMajorElecStatus.Name = "lblMajorElecStatus";
            this.lblMajorElecStatus.Size = new System.Drawing.Size(185, 20);
            this.lblMajorElecStatus.TabIndex = 2;
            this.lblMajorElecStatus.Text = "대기";
            this.lblMajorElecStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajorElecValue
            // 
            this.lblMajorElecValue.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.lblMajorElecValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblMajorElecValue.Location = new System.Drawing.Point(0, 32);
            this.lblMajorElecValue.Name = "lblMajorElecValue";
            this.lblMajorElecValue.Size = new System.Drawing.Size(185, 28);
            this.lblMajorElecValue.TabIndex = 1;
            this.lblMajorElecValue.Text = "0 / 0";
            this.lblMajorElecValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajorElecTitle
            // 
            this.lblMajorElecTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblMajorElecTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblMajorElecTitle.Location = new System.Drawing.Point(0, 10);
            this.lblMajorElecTitle.Name = "lblMajorElecTitle";
            this.lblMajorElecTitle.Size = new System.Drawing.Size(185, 20);
            this.lblMajorElecTitle.TabIndex = 0;
            this.lblMajorElecTitle.Text = "전공선택";
            this.lblMajorElecTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMajorReq
            // 
            this.pnlMajorReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlMajorReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMajorReq.Controls.Add(this.prgMajorReq);
            this.pnlMajorReq.Controls.Add(this.lblMajorReqStatus);
            this.pnlMajorReq.Controls.Add(this.lblMajorReqValue);
            this.pnlMajorReq.Controls.Add(this.lblMajorReqTitle);
            this.pnlMajorReq.Location = new System.Drawing.Point(240, 42);
            this.pnlMajorReq.Name = "pnlMajorReq";
            this.pnlMajorReq.Size = new System.Drawing.Size(185, 96);
            this.pnlMajorReq.TabIndex = 0;
            // 
            // prgMajorReq
            // 
            this.prgMajorReq.Location = new System.Drawing.Point(16, 80);
            this.prgMajorReq.Name = "prgMajorReq";
            this.prgMajorReq.Size = new System.Drawing.Size(152, 10);
            this.prgMajorReq.TabIndex = 3;
            // 
            // lblMajorReqStatus
            // 
            this.lblMajorReqStatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblMajorReqStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblMajorReqStatus.Location = new System.Drawing.Point(0, 60);
            this.lblMajorReqStatus.Name = "lblMajorReqStatus";
            this.lblMajorReqStatus.Size = new System.Drawing.Size(185, 20);
            this.lblMajorReqStatus.TabIndex = 2;
            this.lblMajorReqStatus.Text = "대기";
            this.lblMajorReqStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajorReqValue
            // 
            this.lblMajorReqValue.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.lblMajorReqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblMajorReqValue.Location = new System.Drawing.Point(0, 32);
            this.lblMajorReqValue.Name = "lblMajorReqValue";
            this.lblMajorReqValue.Size = new System.Drawing.Size(185, 28);
            this.lblMajorReqValue.TabIndex = 1;
            this.lblMajorReqValue.Text = "0 / 0";
            this.lblMajorReqValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajorReqTitle
            // 
            this.lblMajorReqTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblMajorReqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblMajorReqTitle.Location = new System.Drawing.Point(0, 10);
            this.lblMajorReqTitle.Name = "lblMajorReqTitle";
            this.lblMajorReqTitle.Size = new System.Drawing.Size(185, 20);
            this.lblMajorReqTitle.TabIndex = 0;
            this.lblMajorReqTitle.Text = "전공필수";
            this.lblMajorReqTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.prgTotal);
            this.pnlTotal.Controls.Add(this.lblTotalStatus);
            this.pnlTotal.Controls.Add(this.lblTotalValue);
            this.pnlTotal.Controls.Add(this.lblTotalTitle);
            this.pnlTotal.Location = new System.Drawing.Point(25, 42);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(185, 96);
            this.pnlTotal.TabIndex = 0;
            // 
            // prgTotal
            // 
            this.prgTotal.Location = new System.Drawing.Point(16, 80);
            this.prgTotal.Name = "prgTotal";
            this.prgTotal.Size = new System.Drawing.Size(152, 10);
            this.prgTotal.TabIndex = 3;
            // 
            // lblTotalStatus
            // 
            this.lblTotalStatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblTotalStatus.Location = new System.Drawing.Point(0, 60);
            this.lblTotalStatus.Name = "lblTotalStatus";
            this.lblTotalStatus.Size = new System.Drawing.Size(185, 20);
            this.lblTotalStatus.TabIndex = 2;
            this.lblTotalStatus.Text = "대기";
            this.lblTotalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.lblTotalValue.Location = new System.Drawing.Point(0, 32);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(185, 28);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "0 / 0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(101)))), ((int)(((byte)(201)))));
            this.lblTotalTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(185, 20);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "총학점";
            this.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.inputBox.Size = new System.Drawing.Size(420, 315);
            this.inputBox.TabIndex = 3;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "학생 정보 및 이수내역 입력";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(225)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.btnClear.Location = new System.Drawing.Point(282, 265);
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
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(225)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(22, 265);
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
            this.txtRawInput.Size = new System.Drawing.Size(378, 105);
            this.txtRawInput.TabIndex = 10;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.Color.White;
            this.btnLoadFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(225)))));
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
            this.cboYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
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
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(225)))));
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
            this.lblSubtitle.Size = new System.Drawing.Size(700, 24);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "CCC 담당: 사용자 입력 화면 구성 / 결과 시각화 / 충족·부족 항목 구분 표시";
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
            this.ClientSize = new System.Drawing.Size(1180, 760);
            this.Controls.Add(this.rootPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
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
            this.pnlOverall.ResumeLayout(false);
            this.pnlGenElec.ResumeLayout(false);
            this.pnlGenReq.ResumeLayout(false);
            this.pnlMajorElec.ResumeLayout(false);
            this.pnlMajorReq.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlOverall;
        private System.Windows.Forms.ProgressBar prgOverall;
        private System.Windows.Forms.Label lblOverallStatus;
        private System.Windows.Forms.Label lblOverallValue;
        private System.Windows.Forms.Label lblOverallTitle;
        private System.Windows.Forms.Panel pnlGenElec;
        private System.Windows.Forms.ProgressBar prgGenElec;
        private System.Windows.Forms.Label lblGenElecStatus;
        private System.Windows.Forms.Label lblGenElecValue;
        private System.Windows.Forms.Label lblGenElecTitle;
        private System.Windows.Forms.Panel pnlGenReq;
        private System.Windows.Forms.ProgressBar prgGenReq;
        private System.Windows.Forms.Label lblGenReqStatus;
        private System.Windows.Forms.Label lblGenReqValue;
        private System.Windows.Forms.Label lblGenReqTitle;
        private System.Windows.Forms.Panel pnlMajorElec;
        private System.Windows.Forms.ProgressBar prgMajorElec;
        private System.Windows.Forms.Label lblMajorElecStatus;
        private System.Windows.Forms.Label lblMajorElecValue;
        private System.Windows.Forms.Label lblMajorElecTitle;
        private System.Windows.Forms.Panel pnlMajorReq;
        private System.Windows.Forms.ProgressBar prgMajorReq;
        private System.Windows.Forms.Label lblMajorReqStatus;
        private System.Windows.Forms.Label lblMajorReqValue;
        private System.Windows.Forms.Label lblMajorReqTitle;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.ProgressBar prgTotal;
        private System.Windows.Forms.Label lblTotalStatus;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalTitle;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
    }
}
