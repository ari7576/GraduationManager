using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AdminForm : Form
    {
        private List<GraduationRequirement> requirements = new List<GraduationRequirement>();

        public AdminForm()
        {
            InitializeComponent();
            LoadSavedData();
        }
        private void LoadSavedData()
        {
            try
            {
                string filePath = "졸업요건.json";
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    var data = JsonConvert.DeserializeObject<dynamic>(json);
                    requirements = JsonConvert.DeserializeObject<List<GraduationRequirement>>(data["졸업요건"].ToString());
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장된 데이터를 불러오는 중 오류: " + ex.Message);
            }
        }

        public class TrackInfo
        {
            public string TrackName { get; set; }
            public List<string> TrackRequiredSubjects { get; set; } = new List<string>();
        }

        public class Subject
        {
            public string 이수구분 { get; set; }
            public string 과목명 { get; set; }
            public int 학점 { get; set; }
        }

        public class GraduationRequirement
        {
            public string 학과 { get; set; }
            public int 입학년도 { get; set; }
            public int 총학점기준 { get; set; }

            public int 전공필수 { get; set; }
            public int 전공선택 { get; set; }
            public int 교양기초 { get; set; }
            public int 전공탐색 { get; set; }


            // 💡 [추가] 누락되었던 4가지 요건 변수
            public int 대학교양필수 { get; set; }
            public int 대학교양선택 { get; set; }
            public int 전공탐색필수 { get; set; }
            public int 전공탐색선택 { get; set; }

            public int 교양소계 { get; set; }
            public int 제2전공필수 { get; set; }
            public int 제2전공선택 { get; set; }

            public List<string> 필수과목목록 { get; set; } = new List<string>();
            public List<string> 전탐필코드목록 { get; set; } = new List<string>();
            public bool 제2전공필수여부 { get; set; } = false;
            public bool 트랙존재여부 { get; set; } = false;
            public List<TrackInfo> 트랙목록 { get; set; } = new List<TrackInfo>();
            public Dictionary<string, string> 코드매핑 { get; set; } = new Dictionary<string, string>();

            // 💡 수동 추가용 리스트 (관리자 페이지에서 나중에 추가 가능하게)
            public List<ManualMapping> 수동매핑리스트 { get; set; } = new List<ManualMapping>();
        }
        public class ManualMapping { public string 코드 { get; set; } public string 이수구분 { get; set; } }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON 파일|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(ofd.FileName);
                var subjects = JsonConvert.DeserializeObject<List<Subject>>(json);
                MessageBox.Show($"과목 {subjects.Count}개 불러왔습니다!");
            }
        }

        private void RefreshGrid()
        {
            dgvRequirements.DataSource = null;
            dgvRequirements.DataSource = requirements;
        }

        public class Requirement
        {
            public int TotalCredit { get; set; }
            public int MajorRequired { get; set; }
            public int MajorElective { get; set; }
            public int GeneralRequired { get; set; }
            public int GeneralElective { get; set; }
            public int MajorExploration { get; set; }

            // 💡 [추가] 파서 임시 저장용 변수
            public int UnivRequired { get; set; }
            public int UnivElective { get; set; }
            public int ExploreRequired { get; set; }
            public int ExploreElective { get; set; }
            public int GenTotal { get; set; }
            public int SecondMajorReq { get; set; }
            public int SecondMajorElec { get; set; }

            public List<string> RequiredSubjects { get; set; } = new List<string>();
            public List<TrackInfo> Tracks { get; set; } = new List<TrackInfo>();
            public Dictionary<string, string> SubjectMapping { get; set; } = new Dictionary<string, string>();
        }

        public class RequirementParser
        {
            public static Requirement ParseText(string rawText)
            {
                Requirement req = new Requirement();

                // 1. 학점 요건 숫자 파싱 (기존과 동일, 정상 작동 확인됨)          

                string[] lines = rawText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                bool mainParsed = false; // 메인 전공을 찾았는지 여부

                foreach (string line in lines)
                {
                    MatchCollection numMatches = Regex.Matches(line, @"\d+");
                    List<int> nums = new List<int>();
                    foreach (Match m in numMatches) nums.Add(int.Parse(m.Value));

                    // 메인 전공 줄 파싱 (숫자가 11~12개)
                    if (!mainParsed && nums.Count >= 11)
                    {
                        req.TotalCredit = nums[nums.Count - 1];
                        req.MajorElective = nums[nums.Count - 3];
                        req.MajorRequired = nums[nums.Count - 4];
                        req.MajorExploration = nums[nums.Count - 6];
                        req.GeneralRequired = nums[0];
                        req.UnivRequired = nums[1];
                        req.UnivElective = nums[2];

                        // 💡 교양소계 캐치!
                        req.GenTotal = nums[3];

                        if (nums.Count == 11)
                        {
                            req.ExploreRequired = 0;
                            req.ExploreElective = req.MajorExploration;
                        }
                        else
                        {
                            req.ExploreRequired = nums[4];
                            req.ExploreElective = nums[5];
                        }
                        mainParsed = true;
                    }
                    // 💡 메인 전공 바로 밑에 있는 "심화" 줄 파싱 (제2전공)
                    else if (mainParsed && line.Contains("심화") && nums.Count >= 3)
                    {
                        // 심화 줄은 숫자가 적으므로 뒤에서부터 가져옵니다.
                        req.SecondMajorElec = nums[nums.Count - 3]; // 전선

                        // 전필은 공백 처리되어 생략될 수도 있으므로 방어적 처리
                        if (nums.Count >= 4)
                            req.SecondMajorReq = nums[nums.Count - 4];
                        else
                            req.SecondMajorReq = 0;

                        break; // 심화까지 찾았으면 파싱 완전 종료!
                    }
                }

                // 2. 필수 과목 추출 로직 보강


                Regex subjectRegex = new Regex(@"[A-Z]{3,4}\d{4,6}\s+(?:\d{4}\s+)?(?<SubjName>[가-힣a-zA-Z0-9\(\)Ⅰ-Ⅹ]+)", RegexOptions.Compiled);
                Regex trackRegex = new Regex(@"([①-⑩]|\d+\.)\s*(?<TrackName>[가-힣a-zA-Z0-9]+)\s*트랙", RegexOptions.Compiled);

                TrackInfo currentTrack = null;
                string currentContext = ""; // 💡 현재 읽고 있는 줄이 무슨 영역인지 기억

                foreach (string line in lines)
                {
                    // 영역 키워드를 발견하면 컨텍스트 업데이트
                    if (line.Contains("전공탐색") || line.Contains("전탐")) currentContext = "전공탐색";
                    else if (line.Contains("전공필수") || line.Contains("전필")) currentContext = "전필";
                    else if (line.Contains("전공선택") || line.Contains("전선")) currentContext = "전선";
                    else if (line.Contains("교양기초")) currentContext = "교양기초";
                    else if (line.Contains("대학교양")) currentContext = "대교";

                    Match trackMatch = trackRegex.Match(line);
                    if (trackMatch.Success)
                    {
                        currentTrack = new TrackInfo { TrackName = trackMatch.Groups["TrackName"].Value };
                        req.Tracks.Add(currentTrack);
                        continue;
                    }

                    // 과목을 발견하면 맵핑 사전에 등록!
                    Match m = subjectRegex.Match(line);
                    if (m.Success)
                    {
                        string subjName = m.Groups["SubjName"].Value.Trim();

                        // 필수 과목 목록에도 일단 추가
                        if ((line.Contains("전필") || line.Contains("필수")) && !line.Contains("트랙"))
                        {
                            if (!req.RequiredSubjects.Contains(subjName)) req.RequiredSubjects.Add(subjName);
                        }
                        if (line.Contains("트랙") && line.Contains("전필") && currentTrack != null)
                        {
                            if (!currentTrack.TrackRequiredSubjects.Contains(subjName)) currentTrack.TrackRequiredSubjects.Add(subjName);
                        }

                        // 💡 성적표 오작동 방지용 맵핑 저장 (예: "자바프로그래밍" -> "전공탐색")
                        if (!string.IsNullOrEmpty(currentContext))
                        {
                            req.SubjectMapping[subjName] = currentContext;
                        }
                    }
                }

                // 3. 띄어쓰기 함정을 피하기 위한 '교양기초' 완벽 캡처 로직
                // 원본 텍스트의 모든 띄어쓰기를 없앤 문자열을 하나 만듭니다.
                string noSpaceText = rawText.Replace(" ", "");

                string[] hardcodedMustHaves = {
        "채플", "글쓰기", "교양영어Ⅰ", "교양영어Ⅱ",
        "리더십개발", "리더십실습", "대학학문의세계", "컴퓨팅사고"
    };

                foreach (var must in hardcodedMustHaves)
                {
                    // 띄어쓰기가 없는 상태에서 단어를 검색하여 안전하게 추가
                    if (noSpaceText.Contains(must) && !req.RequiredSubjects.Contains(must))
                    {
                        req.RequiredSubjects.Add(must);
                    }
                }

                return req;
            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            // 1. 텍스트 붙여넣기 팝업 띄우기
            using (TextPasteForm pasteForm = new TextPasteForm())
            {
                if (pasteForm.ShowDialog() == DialogResult.OK)
                {
                    string rawText = pasteForm.GetPastedText();
                    if (string.IsNullOrWhiteSpace(rawText))
                    {
                        MessageBox.Show("입력된 텍스트가 없습니다.");
                        return;
                    }

                    try
                    {
                        // 2. 이전에 만든 파서를 이용해 텍스트 분석
                        // (이전에 만든 RequirementParser 클래스가 같은 프로젝트 내에 있어야 합니다)
                        Requirement parsedData = RequirementParser.ParseText(rawText);

                        // 3. 규정집 텍스트에는 '입학년도'가 안 적혀 있으므로 학번과 학과만 따로 물어봅니다.
                        string 학과 = Microsoft.VisualBasic.Interaction.InputBox("학과를 입력하세요", "학과 입력", "소프트웨어학부");
                        string 년도str = Microsoft.VisualBasic.Interaction.InputBox("적용할 입학년도(학번)를 입력하세요", "학번 입력", "2024");



                        if (!int.TryParse(년도str, out int year))
                        {
                            MessageBox.Show("입학년도는 숫자로 입력해야 합니다. 추가가 취소되었습니다.");
                            return;
                        }

                        DialogResult isDoubleMajor = MessageBox.Show($"[{학과}]는 제2전공(복수/심화) 이수가 필수입니까?", "제2전공 필수 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        DialogResult hasTrack = MessageBox.Show($"[{학과}]는 트랙(Track) 제도를 운영합니까?", "트랙 제도 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // 4. 파싱된 데이터를 관리자용 객체에 매핑
                        GraduationRequirement newReq = new GraduationRequirement
                        {
                            학과 = 학과,
                            입학년도 = year,
                            총학점기준 = parsedData.TotalCredit,
                            전공필수 = parsedData.MajorRequired,
                            전공선택 = parsedData.MajorElective,
                            교양기초 = parsedData.GeneralRequired,
                            전공탐색 = parsedData.MajorExploration,
                            대학교양필수 = parsedData.UnivRequired,
                            대학교양선택 = parsedData.UnivElective,
                            전공탐색필수 = parsedData.ExploreRequired,
                            전공탐색선택 = parsedData.ExploreElective,
                            필수과목목록 = parsedData.RequiredSubjects,
                            교양소계 = parsedData.GenTotal,
                            제2전공필수 = parsedData.SecondMajorReq,
                            제2전공선택 = parsedData.SecondMajorElec,

                            // 💡 [복구 부분] 팝업 응답 결과 저장
                            제2전공필수여부 = (isDoubleMajor == DialogResult.Yes),
                            트랙존재여부 = (hasTrack == DialogResult.Yes),
                            트랙목록 = parsedData.Tracks,
                            코드매핑 = parsedData.SubjectMapping
                        }; 
                        // 5. 리스트에 추가하고 그리드 새로고침
                        requirements.Add(newReq);
                        RefreshGrid();

                        MessageBox.Show($"성공적으로 파싱되어 추가되었습니다!\n(총학점: {newReq.총학점기준}, 인식된 필수과목: {newReq.필수과목목록.Count}개)");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("텍스트를 분석하는 중 오류가 발생했습니다. 양식이 맞는지 확인해주세요.\n\n에러: " + ex.Message);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string 학과 = Microsoft.VisualBasic.Interaction.InputBox("학과를 입력하세요", "학과 입력");
            string 년도str = Microsoft.VisualBasic.Interaction.InputBox("입학년도를 입력하세요", "입학년도 입력");
            string 학점str = Microsoft.VisualBasic.Interaction.InputBox("총학점기준을 입력하세요", "총학점기준 입력");

            if (string.IsNullOrEmpty(학과) || string.IsNullOrEmpty(년도str) || string.IsNullOrEmpty(학점str))
                return;

            GraduationRequirement req = new GraduationRequirement
            {
                학과 = 학과,
                입학년도 = int.Parse(년도str),
                총학점기준 = int.Parse(학점str)
            };

            requirements.Add(req);
            RefreshGrid();
            MessageBox.Show("추가되었습니다!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRequirements.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요!");
                return;
            }

            int index = dgvRequirements.SelectedRows[0].Index;
            requirements.RemoveAt(index);
            RefreshGrid();
            MessageBox.Show("삭제되었습니다!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRequirements.SelectedRows.Count == 0)
            {
                MessageBox.Show("수정할 항목을 선택하세요!");
                return;
            }

            int index = dgvRequirements.SelectedRows[0].Index;
            GraduationRequirement req = requirements[index];

            string 학과 = Microsoft.VisualBasic.Interaction.InputBox("학과를 입력하세요", "학과 수정", req.학과);
            string 년도str = Microsoft.VisualBasic.Interaction.InputBox("입학년도를 입력하세요", "입학년도 수정", req.입학년도.ToString());
            string 학점str = Microsoft.VisualBasic.Interaction.InputBox("총학점기준을 입력하세요", "총학점기준 수정", req.총학점기준.ToString());

            if (string.IsNullOrEmpty(학과) || string.IsNullOrEmpty(년도str) || string.IsNullOrEmpty(학점str))
                return;

            req.학과 = 학과;
            req.입학년도 = int.Parse(년도str);
            req.총학점기준 = int.Parse(학점str);

            RefreshGrid();
            MessageBox.Show("수정되었습니다!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // SaveFileDialog 없이 프로그램 실행 폴더에 고정적으로 저장합니다.
                string filePath = "졸업요건.json";

                var data = new { 졸업요건 = requirements };
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);

                // System.IO.File을 이용해 바로 덮어쓰기 저장
                System.IO.File.WriteAllText(filePath, json);

                MessageBox.Show("프로그램 폴더에 성공적으로 저장되었습니다!\n이제 학점 계산기에서 불러올 수 있습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장 중 오류가 발생했습니다: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 그리드뷰에서 선택된 항목이 있는지 확인
            if (dgvRequirements.SelectedRows.Count == 0)
            {
                MessageBox.Show("확인할 졸업요건을 목록에서 먼저 선택하세요!");
                return;
            }

            // 2. 선택된 항목 가져오기
            int index = dgvRequirements.SelectedRows[0].Index;
            GraduationRequirement req = requirements[index];

            // 3. 객체를 들여쓰기가 적용된(예쁜) JSON 형식의 문자열로 직렬화
            string jsonOutput = JsonConvert.SerializeObject(req, Formatting.Indented);

            // 4. JSON 결과를 보여줄 새 창을 코드로 생성
            using (Form jsonForm = new Form())
            {
                jsonForm.Text = $"{req.입학년도}학년도 {req.학과} 파싱 데이터 확인";
                jsonForm.Size = new System.Drawing.Size(450, 600);
                jsonForm.StartPosition = FormStartPosition.CenterParent;

                // 텍스트 박스 설정 (수정 불가, 스크롤 가능, 등폭 글꼴)
                TextBox txtJson = new TextBox
                {
                    Text = jsonOutput,
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical,
                    ReadOnly = true, // 보기 전용이므로 수정 방지
                    Dock = DockStyle.Fill,
                    BackColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Consolas", 10F) // 코드가 예쁘게 보이도록 폰트 설정
                };

                jsonForm.Controls.Add(txtJson);

                // 팝업 띄우기
                jsonForm.ShowDialog();
            }
        }

        private void btnEditExploreReq_Click(object sender, EventArgs e)
        {
            if (dgvRequirements.SelectedRows.Count == 0)
            {
                MessageBox.Show("전탐필 코드를 관리할 졸업요건을 먼저 선택하세요!");
                return;
            }

            int index = dgvRequirements.SelectedRows[0].Index;
            GraduationRequirement req = requirements[index];

            string current = string.Join(", ", req.전탐필코드목록);
            string input = Interaction.InputBox(
                "전탐필 과목코드를 쉼표로 구분해서 입력하세요\n예: YHL1007, YHL1008, YHV1001",
                "전탐필 코드 관리",
                current);

            if (string.IsNullOrEmpty(input)) return;

            req.전탐필코드목록 = new List<string>(
                input.Split(',')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList()
            );

            MessageBox.Show($"전탐필 코드 {req.전탐필코드목록.Count}개 저장되었습니다!");
        }
    }
    public class TextPasteForm : Form
    {
        public TextBox txtInput;
        public Button btnOk;
        public Button btnCancel;

        public TextPasteForm()
        {
            this.Text = "졸업요건 규정 텍스트 붙여넣기";
            this.Size = new System.Drawing.Size(500, 400);
            this.StartPosition = FormStartPosition.CenterParent;

            txtInput = new TextBox()
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Top,
                Height = 300,
                Font = new System.Drawing.Font("맑은 고딕", 10F)
            };

            btnOk = new Button() { Text = "파싱 시작", Left = 150, Top = 315, Width = 80, DialogResult = DialogResult.OK };
            btnCancel = new Button() { Text = "취소", Left = 250, Top = 315, Width = 80, DialogResult = DialogResult.Cancel };

            this.Controls.Add(txtInput);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);
            this.AcceptButton = btnOk; // 엔터 키 누르면 확인
        }

        public string GetPastedText()
        {
            return txtInput.Text;
        }
    }
}