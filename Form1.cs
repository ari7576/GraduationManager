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

        public class AnalysisItem
        {
            public string Area { get; set; }
            public string Required { get; set; }
            public string Completed { get; set; }
            public string Status { get; set; }

            public bool IsShortage
            {
                get { return Status != null && Status.Contains("부족"); }
            }
        }

        private void InitializeCardReferences()
        {
            cards["total"] = new SummaryCard { Panel = pnlTotal, Title = lblTotalTitle, Value = lblTotalValue, Status = lblTotalStatus, Progress = prgTotal };

            cards["liberalBasic"] = new SummaryCard { Panel = pnlLiberalBasic, Title = lblLiberalBasicTitle, Value = lblLiberalBasicValue, Status = lblLiberalBasicStatus, Progress = prgLiberalBasic };
            cards["univReq"] = new SummaryCard { Panel = pnlUnivReq, Title = lblUnivReqTitle, Value = lblUnivReqValue, Status = lblUnivReqStatus, Progress = prgUnivReq };
            cards["univElec"] = new SummaryCard { Panel = pnlUnivElec, Title = lblUnivElecTitle, Value = lblUnivElecValue, Status = lblUnivElecStatus, Progress = prgUnivElec };
            cards["liberalTotal"] = new SummaryCard { Panel = pnlLiberalTotal, Title = lblLiberalTotalTitle, Value = lblLiberalTotalValue, Status = lblLiberalTotalStatus, Progress = prgLiberalTotal };

            cards["exploreReq"] = new SummaryCard { Panel = pnlExploreReq, Title = lblExploreReqTitle, Value = lblExploreReqValue, Status = lblExploreReqStatus, Progress = prgExploreReq };
            cards["exploreElec"] = new SummaryCard { Panel = pnlExploreElec, Title = lblExploreElecTitle, Value = lblExploreElecValue, Status = lblExploreElecStatus, Progress = prgExploreElec };
            cards["exploreTotal"] = new SummaryCard { Panel = pnlExploreTotal, Title = lblExploreTotalTitle, Value = lblExploreTotalValue, Status = lblExploreTotalStatus, Progress = prgExploreTotal };

            cards["firstMajorReq"] = new SummaryCard { Panel = pnlFirstMajorReq, Title = lblFirstMajorReqTitle, Value = lblFirstMajorReqValue, Status = lblFirstMajorReqStatus, Progress = prgFirstMajorReq };
            cards["firstMajorElec"] = new SummaryCard { Panel = pnlFirstMajorElec, Title = lblFirstMajorElecTitle, Value = lblFirstMajorElecValue, Status = lblFirstMajorElecStatus, Progress = prgFirstMajorElec };
            cards["firstMajorTotal"] = new SummaryCard { Panel = pnlFirstMajorTotal, Title = lblFirstMajorTotalTitle, Value = lblFirstMajorTotalValue, Status = lblFirstMajorTotalStatus, Progress = prgFirstMajorTotal };

            cards["secondMajorReq"] = new SummaryCard { Panel = pnlSecondMajorReq, Title = lblSecondMajorReqTitle, Value = lblSecondMajorReqValue, Status = lblSecondMajorReqStatus, Progress = prgSecondMajorReq };
            cards["secondMajorElec"] = new SummaryCard { Panel = pnlSecondMajorElec, Title = lblSecondMajorElecTitle, Value = lblSecondMajorElecValue, Status = lblSecondMajorElecStatus, Progress = prgSecondMajorElec };
            cards["secondMajorTotal"] = new SummaryCard { Panel = pnlSecondMajorTotal, Title = lblSecondMajorTotalTitle, Value = lblSecondMajorTotalValue, Status = lblSecondMajorTotalStatus, Progress = prgSecondMajorTotal };

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

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            // 현재 화면의 계산 결과를 기반으로 별도 분석 창을 엽니다.
            // 메인 화면을 갈아엎지 않고, 사용자가 단계별로 결과를 이해하도록 돕는 CCC용 보조 화면입니다.
            CalculateAndRender();

            List<AnalysisItem> items = BuildAnalysisItemsFromGrid();
            if (items.Count == 0)
            {
                MessageBox.Show("분석할 결과가 없습니다. 이수내역과 졸업요건을 확인한 뒤 다시 계산해주세요.");
                return;
            }

            string studentInfo = txtDepartment.Text + " / " + cboYear.Text + "학번 / " + txtStudentName.Text;
            using (AnalysisForm form = new AnalysisForm(items, studentInfo, lblMissingRequired.Text))
            {
                form.ShowDialog(this);
            }
        }

        private List<AnalysisItem> BuildAnalysisItemsFromGrid()
        {
            List<AnalysisItem> items = new List<AnalysisItem>();
            foreach (DataGridViewRow row in dgvAreaStatus.Rows)
            {
                if (row.IsNewRow) continue;

                string area = Convert.ToString(row.Cells[0].Value);
                string required = Convert.ToString(row.Cells[1].Value);
                string completed = Convert.ToString(row.Cells[2].Value);
                string status = Convert.ToString(row.Cells[3].Value);

                if (string.IsNullOrWhiteSpace(area)) continue;

                items.Add(new AnalysisItem
                {
                    Area = area,
                    Required = string.IsNullOrWhiteSpace(required) ? "-" : required,
                    Completed = string.IsNullOrWhiteSpace(completed) ? "0" : completed,
                    Status = string.IsNullOrWhiteSpace(status) ? "확인 필요" : status
                });
            }
            return items;
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
                "필교 GEN1001 01 대학영어 한교수 2 A 93 4.00\r\n" +
                "교선 GEN2001 01 심리학개론 윤교수 3 B 82 3.00\r\n" +
                "대교 YHX1004 01 자바프로그래밍 김교수 3 A 92 4.00\r\n" +
                "전탐필 YHF1001 01 문학입문 이교수 3 A 91 4.00\r\n" +
                "전탐선 YHG1001 01 역사학입문 박교수 3 B+ 88 3.50\r\n" +
                "전필 SWE2001 01 자료구조 김교수 3 A+ 95 4.50\r\n" +
                "전선 SWE3001 01 컴퓨터네트워크 최교수 3 A 92 4.00\r\n" +
                "2전필 SWE2002 01 알고리즘 이교수 3 A 91 4.00\r\n" +
                "2전선 SWE3002 01 데이터베이스 정교수 3 B+ 87 3.50";
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
                @"(?<Type>[가-힣0-9]{2,5})\s+" +
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

            // 수정 - 입학년도 + 학과 고려
            string selectedDept = txtDepartment.Text.Trim();

            AdminForm.GraduationRequirement req = data.졸업요건
                .FirstOrDefault(r => r.입학년도 == selectedYear && r.학과 == selectedDept);

            if (req == null)
            {
                List<string> registeredDepts = data.졸업요건.Select(r => r.학과).Distinct().ToList();
                if (!registeredDepts.Contains(selectedDept))
                {
                    MessageBox.Show($"'{selectedDept}' 학과는 관리자 페이지에 등록되지 않은 학과입니다.\n\n등록된 학과: {string.Join(", ", registeredDepts)}");
                }
                else
                {
                    MessageBox.Show($"{selectedYear}학년도 '{selectedDept}' 졸업 요건 데이터가 등록되지 않았습니다.");
                }
                return;
            }

            // 4. 성적표 텍스트 파싱 (내 이수 내역)
            List<Subject> subjects = ParseSubjects(txtRawInput.Text);

            // 5. 실제 데이터 명칭에 맞춘 학점 계산 로직 (LINQ)
            double total = subjects.Sum(s => s.Credit);

            double liberalBasic = subjects.Where(s => IsType(s.Type, "공기", "교기", "필교", "교필")).Sum(s => s.Credit);
            double universityRequired = subjects.Where(s => IsType(s.Type, "대필", "대교필")).Sum(s => s.Credit);
            double universityElective = subjects.Where(s => IsType(s.Type, "대교", "대선", "교선")).Sum(s => s.Credit);
            double liberalTotal = liberalBasic + universityRequired + universityElective;

            double exploreRequired = subjects.Where(s => IsType(s.Type, "탐필", "전탐필")).Sum(s => s.Credit);
            double exploreElective = subjects.Where(s => IsType(s.Type, "탐선", "전탐", "전탐선")).Sum(s => s.Credit);
            double exploreTotal = exploreRequired + exploreElective;

            double firstMajorRequired = subjects.Where(s => IsType(s.Type, "전필", "1전필", "제1전필")).Sum(s => s.Credit);
            double firstMajorElective = subjects.Where(s => IsType(s.Type, "전선", "1전선", "제1전선")).Sum(s => s.Credit);
            double firstMajorTotal = firstMajorRequired + firstMajorElective;

            double secondMajorRequired = subjects.Where(s => IsType(s.Type, "복필", "2전필", "제2전필")).Sum(s => s.Credit);
            double secondMajorElective = subjects.Where(s => IsType(s.Type, "복선", "2전선", "제2전선")).Sum(s => s.Credit);
            double secondMajorTotal = secondMajorRequired + secondMajorElective;

            // 6. 데이터그리드뷰 업데이트
            dgvSubjects.Rows.Clear();
            foreach (Subject s in subjects)
            {
                dgvSubjects.Rows.Add(s.Type, s.Code, s.Name, s.Credit, s.Grade);
            }

            dgvAreaStatus.Rows.Clear();
            AddStatusRow("총 이수학점", req.총학점기준, total);

            AddStatusRow("교양기초", req.교양기초, liberalBasic);
            AddStatusRowDisplayOnly("대학교양 필수", universityRequired);
            AddStatusRowDisplayOnly("대학교양 선택", universityElective);
            AddStatusRowDisplayOnly("교양 소계", liberalTotal);

            AddStatusRowDisplayOnly("전공탐색 필수", exploreRequired);
            AddStatusRowDisplayOnly("전공탐색 선택", exploreElective);
            AddStatusRow("전공탐색 소계", req.전공탐색, exploreTotal);

            AddStatusRow("제1전공 필수", req.전공필수, firstMajorRequired);
            AddStatusRow("제1전공 선택", req.전공선택, firstMajorElective);
            AddStatusRow("제1전공 소계", req.전공필수 + req.전공선택, firstMajorTotal);

            AddStatusRow("제2전공 필수", req.전공필수, secondMajorRequired);
            AddStatusRow("제2전공 선택", req.전공선택, secondMajorElective);
            AddStatusRow("제2전공 소계", req.전공필수 + req.전공선택, secondMajorTotal);

            // 7. 요약 카드 UI 업데이트
            SetCard("total", total, req.총학점기준);

            SetCard("liberalBasic", liberalBasic, req.교양기초);
            SetCardDisplayOnly("univReq", universityRequired);
            SetCardDisplayOnly("univElec", universityElective);
            SetCardDisplayOnly("liberalTotal", liberalTotal);

            SetCardDisplayOnly("exploreReq", exploreRequired);
            SetCardDisplayOnly("exploreElec", exploreElective);
            SetCard("exploreTotal", exploreTotal, req.전공탐색);

            SetCard("firstMajorReq", firstMajorRequired, req.전공필수);
            SetCard("firstMajorElec", firstMajorElective, req.전공선택);
            SetCard("firstMajorTotal", firstMajorTotal, req.전공필수 + req.전공선택);

            SetCard("secondMajorReq", secondMajorRequired, req.전공필수);
            SetCard("secondMajorElec", secondMajorElective, req.전공선택);
            SetCard("secondMajorTotal", secondMajorTotal, req.전공필수 + req.전공선택);

            // 8. 필수 과목 미이수 검사
            List<string> completedNames = subjects.Select(s => s.Name).ToList();
            // JSON의 필수과목목록 중, 내가 들은 과목 이름에 포함되지 않은 것들만 뽑아냅니다.
            List<string> missingRequired = req.필수과목목록.Where(name => !completedNames.Contains(name)).ToList();

            // 모든 조건을 만족했는지 체크
            bool creditsOk = total >= req.총학점기준
                && liberalBasic >= req.교양기초
                && exploreTotal >= req.전공탐색
                && firstMajorRequired >= req.전공필수
                && firstMajorElective >= req.전공선택
                && secondMajorRequired >= req.전공필수
                && secondMajorElective >= req.전공선택;
            bool overall = creditsOk && missingRequired.Count == 0;
            SetOverallCard(overall);

            // 9. 하단 텍스트 업데이트
            lblShortage.Text = BuildShortageText(req, total, liberalBasic, exploreTotal, firstMajorRequired, firstMajorElective, secondMajorRequired, secondMajorElective);
            lblMissingRequired.Text = missingRequired.Count == 0
                ? "미이수 필수과목: 없음"
                : "미이수 필수과목: " + string.Join(", ", missingRequired.ToArray());
        }

        // Requirement 타입 대신 AdminForm.GraduationRequirement를 받도록 수정된 BuildShortageText
        private string BuildShortageText(AdminForm.GraduationRequirement req, double total, double liberalBasic, double exploreTotal, double firstMajorReq, double firstMajorElec, double secondMajorReq, double secondMajorElec)
        {
            List<string> parts = new List<string>();
            AddShortage(parts, "총 이수학점", req.총학점기준, total);
            AddShortage(parts, "교양기초", req.교양기초, liberalBasic);
            AddShortage(parts, "전공탐색 소계", req.전공탐색, exploreTotal);
            AddShortage(parts, "제1전공 필수", req.전공필수, firstMajorReq);
            AddShortage(parts, "제1전공 선택", req.전공선택, firstMajorElec);
            AddShortage(parts, "제2전공 필수", req.전공필수, secondMajorReq);
            AddShortage(parts, "제2전공 선택", req.전공선택, secondMajorElec);
            if (parts.Count == 0) return "부족 학점: 없음";
            return "부족 학점: " + string.Join(" / ", parts.ToArray());
        }

        private bool IsType(string value, params string[] targets)
        {
            return targets.Contains(value);
        }

        private void AddStatusRowDisplayOnly(string area, double completed)
        {
            int idx = dgvAreaStatus.Rows.Add(area, "-", completed, "이수 " + completed + "학점");
            DataGridViewRow row = dgvAreaStatus.Rows[idx];
            row.Cells[3].Style.ForeColor = Color.FromArgb(Navy);
            row.Cells[3].Style.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
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

        private void SetCardDisplayOnly(string key, double completed)
        {
            SummaryCard card = cards[key];
            card.Value.Text = completed + " / -";
            card.Status.Text = "이수 " + completed + "학점";
            card.Status.ForeColor = Color.FromArgb(Navy);
            card.Panel.BackColor = Color.FromArgb(248, 251, 255);
            card.Progress.Value = 0;
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
