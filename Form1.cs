using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, SummaryCard> cards = new Dictionary<string, SummaryCard>();

        private const int Navy = 0x102A4C;
        private const int Green = 0x249B45;
        private const int Red = 0xE53935;

        public Form1()
        {
            InitializeComponent();
            InitializeCardReferences();
            cboYear.SelectedItem = "2024";
            LoadSampleText();
            CalculateAndRender();
        }

        private class Subject
        {
            public string Type { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public int Credit { get; set; }
            public string Grade { get; set; }
        }

        private class Requirement
        {
            public int TotalCredit = 130;
            public int MajorRequired = 28;
            public int MajorElective = 42;
            public int GeneralRequired = 12;
            public int GeneralElective = 18;
            public List<string> RequiredSubjects = new List<string> { "자료구조", "알고리즘", "운영체제", "컴파일러" };
        }

        private class SummaryCard
        {
            public Panel Panel;
            public Label Title;
            public Label Value;
            public Label Status;
            public ProgressBar Progress;
        }

        private void InitializeCardReferences()
        {
            cards["total"] = new SummaryCard { Panel = pnlTotal, Title = lblTotalTitle, Value = lblTotalValue, Status = lblTotalStatus, Progress = prgTotal };
            cards["majorReq"] = new SummaryCard { Panel = pnlMajorReq, Title = lblMajorReqTitle, Value = lblMajorReqValue, Status = lblMajorReqStatus, Progress = prgMajorReq };
            cards["majorElec"] = new SummaryCard { Panel = pnlMajorElec, Title = lblMajorElecTitle, Value = lblMajorElecValue, Status = lblMajorElecStatus, Progress = prgMajorElec };
            cards["genReq"] = new SummaryCard { Panel = pnlGenReq, Title = lblGenReqTitle, Value = lblGenReqValue, Status = lblGenReqStatus, Progress = prgGenReq };
            cards["genElec"] = new SummaryCard { Panel = pnlGenElec, Title = lblGenElecTitle, Value = lblGenElecValue, Status = lblGenElecStatus, Progress = prgGenElec };
            cards["overall"] = new SummaryCard { Panel = pnlOverall, Title = lblOverallTitle, Value = lblOverallValue, Status = lblOverallStatus, Progress = prgOverall };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateAndRender();
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "이수내역 텍스트 파일 선택";
            dialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtRawInput.Text = System.IO.File.ReadAllText(dialog.FileName);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtRawInput.Clear();
            dgvSubjects.Rows.Clear();
            dgvAreaStatus.Rows.Clear();
            lblShortage.Text = "";
            lblMissingRequired.Text = "";
            foreach (SummaryCard card in cards.Values)
            {
                card.Value.Text = "0 / 0";
                card.Status.Text = "대기";
                card.Status.ForeColor = Color.Gray;
                card.Panel.BackColor = Color.White;
                card.Progress.Value = 0;
            }
        }

        private void LoadSampleText()
        {
            txtRawInput.Text =
                "전필 SWE2001 자료구조 3 A+\r\n" +
                "전필 SWE2002 알고리즘 3 A\r\n" +
                "전필 SWE2003 운영체제 3 B+\r\n" +
                "전선 SWE3001 컴퓨터네트워크 3 A\r\n" +
                "전선 SWE3002 데이터베이스 3 B+\r\n" +
                "교필 GEN1001 대학영어 2 A\r\n" +
                "교필 GEN1002 글쓰기 2 B+\r\n" +
                "교선 GEN2001 심리학개론 3 B";
        }

        private List<Subject> ParseSubjects(string text)
        {
            List<Subject> list = new List<Subject>();
            string[] lines = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(@"(전필|전선|교필|교선)\s+([A-Za-z0-9\-]+)\s+(.+?)\s+(\d+)\s*([A-F][+0]?|P|F)?$", RegexOptions.Compiled);

            foreach (string raw in lines)
            {
                string line = raw.Trim();
                Match m = regex.Match(line);
                if (m.Success)
                {
                    Subject s = new Subject();
                    s.Type = m.Groups[1].Value;
                    s.Code = m.Groups[2].Value;
                    s.Name = m.Groups[3].Value.Trim();
                    s.Credit = int.Parse(m.Groups[4].Value);
                    s.Grade = m.Groups[5].Success ? m.Groups[5].Value : "";
                    list.Add(s);
                }
            }
            return list;
        }

        private void CalculateAndRender()
        {
            Requirement req = new Requirement();
            List<Subject> subjects = ParseSubjects(txtRawInput.Text);

            int total = subjects.Sum(s => s.Credit);
            int majorReq = subjects.Where(s => s.Type == "전필").Sum(s => s.Credit);
            int majorElec = subjects.Where(s => s.Type == "전선").Sum(s => s.Credit);
            int genReq = subjects.Where(s => s.Type == "교필").Sum(s => s.Credit);
            int genElec = subjects.Where(s => s.Type == "교선").Sum(s => s.Credit);

            dgvSubjects.Rows.Clear();
            foreach (Subject s in subjects)
            {
                dgvSubjects.Rows.Add(s.Type, s.Code, s.Name, s.Credit, s.Grade);
            }

            dgvAreaStatus.Rows.Clear();
            AddStatusRow("총학점", req.TotalCredit, total);
            AddStatusRow("전공필수", req.MajorRequired, majorReq);
            AddStatusRow("전공선택", req.MajorElective, majorElec);
            AddStatusRow("교양필수", req.GeneralRequired, genReq);
            AddStatusRow("교양선택", req.GeneralElective, genElec);

            SetCard("total", total, req.TotalCredit);
            SetCard("majorReq", majorReq, req.MajorRequired);
            SetCard("majorElec", majorElec, req.MajorElective);
            SetCard("genReq", genReq, req.GeneralRequired);
            SetCard("genElec", genElec, req.GeneralElective);

            bool creditsOk = total >= req.TotalCredit && majorReq >= req.MajorRequired && majorElec >= req.MajorElective && genReq >= req.GeneralRequired && genElec >= req.GeneralElective;
            List<string> completedNames = subjects.Select(s => s.Name).ToList();
            List<string> missingRequired = req.RequiredSubjects.Where(name => !completedNames.Contains(name)).ToList();
            bool overall = creditsOk && missingRequired.Count == 0;
            SetOverallCard(overall);

            lblShortage.Text = BuildShortageText(req, total, majorReq, majorElec, genReq, genElec);
            lblMissingRequired.Text = missingRequired.Count == 0
                ? "미이수 필수과목: 없음"
                : "미이수 필수과목: " + string.Join(", ", missingRequired.ToArray());
        }

        private void AddStatusRow(string area, int required, int completed)
        {
            int lack = Math.Max(0, required - completed);
            string status = lack == 0 ? "충족" : "부족 " + lack + "학점";
            int idx = dgvAreaStatus.Rows.Add(area, required, completed, status);
            DataGridViewRow row = dgvAreaStatus.Rows[idx];
            row.Cells[3].Style.ForeColor = lack == 0 ? Color.FromArgb(Green) : Color.FromArgb(Red);
            row.Cells[3].Style.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
        }

        private void SetCard(string key, int completed, int required)
        {
            SummaryCard card = cards[key];
            int lack = Math.Max(0, required - completed);
            int pct = required == 0 ? 0 : Math.Min(100, (int)Math.Round(completed * 100.0 / required));
            card.Value.Text = completed + " / " + required;
            card.Progress.Value = pct;
            if (lack == 0)
            {
                card.Status.Text = "충족";
                card.Status.ForeColor = Color.FromArgb(Green);
                card.Panel.BackColor = Color.FromArgb(247, 255, 250);
            }
            else
            {
                card.Status.Text = "부족 " + lack + "학점";
                card.Status.ForeColor = Color.FromArgb(Red);
                card.Panel.BackColor = Color.FromArgb(255, 247, 247);
            }
        }

        private void SetOverallCard(bool overall)
        {
            SummaryCard card = cards["overall"];
            card.Value.Text = overall ? "가능" : "불가";
            card.Status.Text = overall ? "졸업요건 충족" : "요건 부족";
            card.Status.ForeColor = overall ? Color.FromArgb(Green) : Color.FromArgb(Red);
            card.Panel.BackColor = overall ? Color.FromArgb(247, 255, 250) : Color.FromArgb(255, 247, 247);
            card.Progress.Value = overall ? 100 : 65;
        }

        private string BuildShortageText(Requirement req, int total, int majorReq, int majorElec, int genReq, int genElec)
        {
            List<string> parts = new List<string>();
            AddShortage(parts, "총학점", req.TotalCredit, total);
            AddShortage(parts, "전공필수", req.MajorRequired, majorReq);
            AddShortage(parts, "전공선택", req.MajorElective, majorElec);
            AddShortage(parts, "교양필수", req.GeneralRequired, genReq);
            AddShortage(parts, "교양선택", req.GeneralElective, genElec);
            if (parts.Count == 0) return "부족 학점: 없음";
            return "부족 학점: " + string.Join(" / ", parts.ToArray());
        }

        private void AddShortage(List<string> parts, string name, int required, int completed)
        {
            int lack = Math.Max(0, required - completed);
            if (lack > 0) parts.Add(name + " " + lack + "학점");
        }
    }
}
