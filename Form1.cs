using Newtonsoft.Json;
using System.IO;
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            using (AdminForm adminForm = new AdminForm())
            {
                adminForm.ShowDialog(this);
            }
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
                "전필 SWE2001 01 자료구조 김교수 3 A+ 95 4.50\r\n" +
                "전필 SWE2002 01 알고리즘 이교수 3 A 91 4.00\r\n" +
                "전필 SWE2003 01 운영체제 박교수 3 B+ 88 3.50\r\n" +
                "전선 SWE3001 01 컴퓨터네트워크 최교수 3 A 92 4.00\r\n" +
                "전선 SWE3002 01 데이터베이스 정교수 3 B+ 87 3.50\r\n" +
                "필교 GEN1001 01 대학영어 한교수 2 A 93 4.00\r\n" +
                "필교 GEN1002 01 글쓰기 오교수 2 B+ 86 3.50\r\n" +
                "교선 GEN2001 01 심리학개론 윤교수 3 B 82 3.00";
        }

        private class Subject
        {
            public string Type { get; set; }   // 이수구분 (전선, 전필, 대교 등)
            public string Code { get; set; }   // 학수번호
            public string Name { get; set; }   // 과목명
            public double Credit { get; set; } // 학점 (0.5학점짜리 채플 등이 있으므로 double이 안전합니다)
            public string Grade { get; set; }  // 성적
        }

        private List<Subject> ParseSubjects(string text)
        {
            List<Subject> list = new List<Subject>();

            // 실제 학사 포털 텍스트에 대응하는 정규식
            string pattern =
                @"(?<Type>[가-힣]{2})\s+" +
                @"(?<Code>[a-zA-Z]{3}\d{4})\s+" +
                @"(?<Section>[a-zA-Z0-9]{2})\s+" +
                @"(?<NameAndProf>[\s\S]+?)\s+" +
                @"(?<Credit>\d+(?:\.\d+)?)\s+" +
                @"(?<Grade>[A-DF][+0\-]?|P|NP|W)\s+" +
                @"(?<Score>\d+)\s+" +
                @"(?:(?<Flag>[A-Z])\s+)?" +
                @"(?<GPA>\d+\.\d{2})";

            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.Multiline);

            foreach (Match match in matches)
            {
                // 과목명 추출 (교수명 제거 로직 포함)
                string rawNameAndProf = match.Groups["NameAndProf"].Value;
                string cleanedNameAndProf = Regex.Replace(rawNameAndProf, @"\s+", " ").Trim();
                int lastSpaceIndex = cleanedNameAndProf.LastIndexOf(' ');
                string courseName = lastSpaceIndex > 0 ? cleanedNameAndProf.Substring(0, lastSpaceIndex).Trim() : cleanedNameAndProf;

                Subject s = new Subject
                {
                    Type = match.Groups["Type"].Value,
                    Code = match.Groups["Code"].Value,
                    Name = courseName,
                    Credit = double.Parse(match.Groups["Credit"].Value), // int 대신 double 사용
                    Grade = match.Groups["Grade"].Value
                };

                // F학점이나 NP, W(수강철회)는 이수 학점에서 제외하거나 따로 처리할 수 있도록 조건문 추가
                if (s.Grade != "F" && s.Grade != "NP" && s.Grade != "W")
                {
                    list.Add(s);
                }
            }
            return list;
        }

        private void CalculateAndRender()
        {
            // 1. 관리자 페이지에서 저장한 JSON 파일 불러오기
            string jsonPath = "졸업요건.json";
            if (!File.Exists(jsonPath))
            {
                MessageBox.Show("졸업요건.json 파일이 없습니다. 관리자 메뉴에서 요건을 먼저 저장해주세요.");
                return;
            }

            // 2. JSON 역직렬화 (AdminForm에서 만든 구조 그대로 덮어씌우기)
            string json = File.ReadAllText(jsonPath);
            // Newtonsoft.Json의 익명 타입을 활용해 "졸업요건" 배열을 추출합니다.
            var data = JsonConvert.DeserializeAnonymousType(json, new { 졸업요건 = new List<AdminForm.GraduationRequirement>() });

            // 3. 콤보박스에서 선택된 학번과 일치하는 요건 찾기
            if (cboYear.SelectedItem == null) return;
            int selectedYear = int.Parse(cboYear.SelectedItem.ToString());

            // 리스트 중 입학년도가 일치하는 데이터 1개만 뽑아옵니다.
            AdminForm.GraduationRequirement req = data.졸업요건.FirstOrDefault(r => r.입학년도 == selectedYear);

            if (req == null)
            {
                MessageBox.Show($"{selectedYear}학년도 졸업 요건 데이터가 관리자 페이지에 등록되지 않았습니다.");
                return;
            }

            // 4. 성적표 텍스트 파싱 (내 이수 내역)
            List<Subject> subjects = ParseSubjects(txtRawInput.Text);

            // 5. 실제 데이터 명칭에 맞춘 학점 계산 로직 (LINQ)
            double total = subjects.Sum(s => s.Credit);
            double majorReq = subjects.Where(s => s.Type == "전필").Sum(s => s.Credit);
            double majorElec = subjects.Where(s => s.Type == "전선").Sum(s => s.Credit);
            // 교양기초 역할: 공기, 교기, 필교 모두 합산
            double genReq = subjects.Where(s => s.Type == "공기" || s.Type == "교기" || s.Type == "필교").Sum(s => s.Credit);
            // 대학교양 역할: 대교
            double genElec = subjects.Where(s => s.Type == "대교").Sum(s => s.Credit);

            // 6. 데이터그리드뷰 업데이트
            dgvSubjects.Rows.Clear();
            foreach (Subject s in subjects)
            {
                dgvSubjects.Rows.Add(s.Type, s.Code, s.Name, s.Credit, s.Grade);
            }

            dgvAreaStatus.Rows.Clear();
            // 하드코딩 숫자가 아닌 JSON에서 불러온 req의 값들로 표를 채웁니다.
            AddStatusRow("총학점", req.총학점기준, total);
            AddStatusRow("전공필수", req.전공필수, majorReq);
            AddStatusRow("전공선택", req.전공선택, majorElec);
            AddStatusRow("교양기초", req.교양기초, genReq);
            // 참고: UI의 "교양선택" 패널을 임시로 "전공탐색" 기준으로 맞췄습니다. (필요 시 수정)
            AddStatusRow("전공탐색(대교)", req.전공탐색, genElec);

            // 7. 요약 카드 UI 업데이트
            SetCard("total", total, req.총학점기준);
            SetCard("majorReq", majorReq, req.전공필수);
            SetCard("majorElec", majorElec, req.전공선택);
            SetCard("genReq", genReq, req.교양기초);
            SetCard("genElec", genElec, req.전공탐색);

            // 8. 필수 과목 미이수 검사
            List<string> completedNames = subjects.Select(s => s.Name).ToList();
            // JSON의 필수과목목록 중, 내가 들은 과목 이름에 포함되지 않은 것들만 뽑아냅니다.
            List<string> missingRequired = req.필수과목목록.Where(name => !completedNames.Contains(name)).ToList();

            // 모든 조건을 만족했는지 체크
            bool creditsOk = total >= req.총학점기준 && majorReq >= req.전공필수 && majorElec >= req.전공선택 && genReq >= req.교양기초;
            bool overall = creditsOk && missingRequired.Count == 0;
            SetOverallCard(overall);

            // 9. 하단 텍스트 업데이트
            lblShortage.Text = BuildShortageText(req, total, majorReq, majorElec, genReq, genElec);
            lblMissingRequired.Text = missingRequired.Count == 0
                ? "미이수 필수과목: 없음"
                : "미이수 필수과목: " + string.Join(", ", missingRequired.ToArray());
        }

        // Requirement 타입 대신 AdminForm.GraduationRequirement를 받도록 수정된 BuildShortageText
        private string BuildShortageText(AdminForm.GraduationRequirement req, double total, double majorReq, double majorElec, double genReq, double genElec)
        {
            List<string> parts = new List<string>();
            AddShortage(parts, "총학점", req.총학점기준, total);
            AddShortage(parts, "전공필수", req.전공필수, majorReq);
            AddShortage(parts, "전공선택", req.전공선택, majorElec);
            AddShortage(parts, "교양기초", req.교양기초, genReq);
            AddShortage(parts, "전공탐색", req.전공탐색, genElec);
            if (parts.Count == 0) return "부족 학점: 없음";
            return "부족 학점: " + string.Join(" / ", parts.ToArray());
        }

        private void AddStatusRow(string area, double required, double completed)
        {
            double lack = Math.Max(0, required - completed);
            string status = lack == 0 ? "충족" : "부족 " + lack + "학점";
            int idx = dgvAreaStatus.Rows.Add(area, required, completed, status);
            DataGridViewRow row = dgvAreaStatus.Rows[idx];
            row.Cells[3].Style.ForeColor = lack == 0 ? Color.FromArgb(Green) : Color.FromArgb(Red);
            row.Cells[3].Style.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
        }

        private void SetCard(string key, double completed, double required)
        {
            SummaryCard card = cards[key];
            double lack = Math.Max(0, required - completed);
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

        private string BuildShortageText(Requirement req, double total, double majorReq, double majorElec, double genReq, double genElec)
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

        private void AddShortage(List<string> parts, string name, double required, double completed)
        {
            double lack = Math.Max(0, required - completed);
            if (lack > 0) parts.Add(name + " " + lack + "학점");
        }
    }
}
