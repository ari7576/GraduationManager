using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AnalysisForm : Form
    {
        private readonly List<Form1.AnalysisItem> items;
        private readonly string studentInfo;
        private readonly string missingRequiredText;
        private int currentStep = 0;

        private readonly string[] stepTitles =
        {
            "1/4 전체 요약",
            "2/4 부족 영역 집중",
            "3/4 영역별 진행률",
            "4/4 미이수 과목 안내"
        };

        private readonly Color navy = Color.FromArgb(16, 42, 76);
        private readonly Color blue = Color.FromArgb(47, 111, 228);
        private readonly Color green = Color.FromArgb(36, 155, 69);
        private readonly Color red = Color.FromArgb(229, 57, 53);
        private readonly Color orange = Color.FromArgb(245, 130, 32);
        private readonly Color grayText = Color.FromArgb(70, 80, 95);
        private readonly Color lightBg = Color.FromArgb(245, 247, 250);

        public AnalysisForm()
        {
            items = CreatePreviewItems();
            studentInfo = "디자인 미리보기";
            missingRequiredText = "미이수 필수과목: 운영체제, 컴파일러";
            InitializeComponent();

            if (!IsDesignMode())
            {
                RenderStep();
            }
        }

        public AnalysisForm(List<Form1.AnalysisItem> analysisItems, string studentInfoText)
        {
            items = analysisItems ?? new List<Form1.AnalysisItem>();
            studentInfo = studentInfoText ?? "학생 정보 없음";
            missingRequiredText = "미이수 필수과목: 정보 없음";
            InitializeComponent();
            RenderStep();
        }

        public AnalysisForm(List<Form1.AnalysisItem> analysisItems, string studentInfoText, string missingRequiredTextValue)
        {
            items = analysisItems ?? new List<Form1.AnalysisItem>();
            studentInfo = studentInfoText ?? "학생 정보 없음";
            missingRequiredText = string.IsNullOrWhiteSpace(missingRequiredTextValue) ? "미이수 필수과목: 정보 없음" : missingRequiredTextValue;
            InitializeComponent();
            RenderStep();
        }

        private bool IsDesignMode()
        {
            return DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        private List<Form1.AnalysisItem> CreatePreviewItems()
        {
            return new List<Form1.AnalysisItem>
            {
                new Form1.AnalysisItem { Area = "총 이수학점", Required = "135", Completed = "132", Status = "부족 3학점" },
                new Form1.AnalysisItem { Area = "교양기초", Required = "22", Completed = "19", Status = "부족 3학점" },
                new Form1.AnalysisItem { Area = "대학교양 필수", Required = "-", Completed = "5", Status = "이수 5학점" },
                new Form1.AnalysisItem { Area = "대학교양 선택", Required = "-", Completed = "15", Status = "이수 15학점" },
                new Form1.AnalysisItem { Area = "전공탐색 소계", Required = "21", Completed = "21", Status = "충족" },
                new Form1.AnalysisItem { Area = "제1전공 소계", Required = "36", Completed = "36", Status = "충족" },
                new Form1.AnalysisItem { Area = "제2전공 소계", Required = "36", Completed = "36", Status = "충족" }
            };
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                RenderStep();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentStep < 3)
            {
                currentStep++;
                RenderStep();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RenderStep()
        {
            contentPanel.SuspendLayout();
            contentPanel.Controls.Clear();

            lblStepBadge.Text = stepTitles[currentStep];
            btnPrev.Enabled = currentStep > 0;
            btnNext.Enabled = currentStep < 3;
            lblStepGuide.Text = "";

            if (currentStep == 0) RenderSummaryStep();
            else if (currentStep == 1) RenderShortageStep();
            else if (currentStep == 2) RenderProgressStep();
            else RenderActionStep();

            contentPanel.ResumeLayout();
        }

        private void RenderSummaryStep()
        {
            TableLayoutPanel root = CreateRootLayout(1, 2);
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentPanel.Controls.Add(root);

            Label intro = new Label
            {
                Dock = DockStyle.Fill,
                Text = "영역별 소계",
                Font = new Font("맑은 고딕", 10.5F, FontStyle.Bold),
                ForeColor = navy,
                BackColor = Color.White,
                Padding = new Padding(18, 10, 18, 8),
                TextAlign = ContentAlignment.MiddleLeft
            };
            root.Controls.Add(intro, 0, 0);

            TableLayoutPanel cards = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                BackColor = lightBg,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };
            cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            cards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cards.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            root.Controls.Add(cards, 0, 1);

            cards.Controls.Add(CreateSummaryAreaCard("교양 소계", GetItemByArea("교양 소계"), "교양기초 + 대학교양 필수/선택"), 0, 0);
            cards.Controls.Add(CreateSummaryAreaCard("전공탐색 소계", GetItemByArea("전공탐색 소계"), "전공탐색 필수 + 선택"), 1, 0);
            cards.Controls.Add(CreateSummaryAreaCard("제1전공 소계", GetItemByArea("제1전공 소계"), "제1전공 필수 + 선택"), 0, 1);
            cards.Controls.Add(CreateSummaryAreaCard("제2전공 소계", GetItemByArea("제2전공 소계"), "제2전공 필수 + 선택"), 1, 1);
        }

        private void RenderShortageStep()
        {
            TableLayoutPanel root = CreateRootLayout(2, 1);
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentPanel.Controls.Add(root);

            List<Form1.AnalysisItem> shortage = items.Where(i => i.IsShortage).OrderByDescending(GetShortageValue).ToList();

            Panel chartCard = CreateCard();
            root.Controls.Add(chartCard, 0, 0);
            AddSectionTitle(chartCard, "부족 학점");
            chartCard.Controls.Add(CreateShortageBarChart(shortage));

            Panel guide = CreateCard();
            root.Controls.Add(guide, 1, 0);
            AddSectionTitle(guide, "우선순위 안내");
            FlowLayoutPanel list = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(18, 52, 18, 12)
            };
            guide.Controls.Add(list);

            if (shortage.Count == 0)
            {
                list.Controls.Add(CreateMessageCard("부족 영역 없음", "현재 부족한 영역이 없습니다.", green));
            }
            else
            {
                int rank = 1;
                foreach (Form1.AnalysisItem item in shortage.Take(6))
                {
                    list.Controls.Add(CreatePriorityCard(rank++, item));
                }
            }
        }

        private void RenderProgressStep()
        {
            TableLayoutPanel root = CreateRootLayout(2, 1);
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentPanel.Controls.Add(root);

            Form1.AnalysisItem total = GetTotalItem();
            double required = ToNumber(total == null ? "0" : total.Required);
            double completed = ToNumber(total == null ? "0" : total.Completed);
            double percent = required > 0 ? Math.Min(100, completed * 100.0 / required) : CalculateAverageCorePercent();
            bool shortage = items.Any(i => i.IsShortage);

            Panel donutCard = CreateCard();
            root.Controls.Add(donutCard, 0, 0);
            AddSectionTitle(donutCard, "전체 진행률");
            donutCard.Controls.Add(CreateDonutPanel(percent, shortage ? orange : green, Math.Round(percent, 1) + "%", total == null ? "총 이수학점" : total.Completed + " / " + total.Required));

            Panel right = CreateCard();
            root.Controls.Add(right, 1, 0);
            AddSectionTitle(right, "세부 이수구분 진행률");
            FlowLayoutPanel rows = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(18, 52, 18, 12)
            };
            right.Controls.Add(rows);

            foreach (Form1.AnalysisItem item in items.Where(i => !i.Area.Contains("총") && IsCoreArea(i.Area)))
            {
                rows.Controls.Add(CreateProgressRow(item, 610));
            }
        }

        private void RenderActionStep()
        {
            TableLayoutPanel root = CreateRootLayout(2, 1);
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentPanel.Controls.Add(root);

            Panel missing = CreateCard();
            root.Controls.Add(missing, 0, 0);
            AddSectionTitle(missing, "미이수 필수 과목");
            AddTextBlock(missing, BuildMissingRequiredGuide());

            Panel recommend = CreateCard();
            root.Controls.Add(recommend, 1, 0);
            AddSectionTitle(recommend, "추천 확인 과목");
            AddTextBlock(recommend, BuildRecommendationGuide());
        }

        private TableLayoutPanel CreateRootLayout(int columns, int rows)
        {
            return new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = columns,
                RowCount = rows,
                BackColor = lightBg,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };
        }

        private Panel CreateCard()
        {
            return new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(8),
                Padding = new Padding(12)
            };
        }

        private Label CreateTopLabel(string text, Color color)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Top,
                Height = 54,
                Font = new Font("맑은 고딕", 16F, FontStyle.Bold),
                ForeColor = color,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        private void AddSectionTitle(Control parent, string title)
        {
            Label label = new Label
            {
                Text = title,
                Dock = DockStyle.Top,
                Height = 38,
                Font = new Font("맑은 고딕", 12F, FontStyle.Bold),
                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(8, 4, 8, 0)
            };
            parent.Controls.Add(label);
            label.BringToFront();
        }

        private Panel CreateSummaryAreaCard(string title, Form1.AnalysisItem item, string description)
        {
            Panel card = CreateCard();
            Color accent = item != null && item.IsShortage ? red : green;
            if (item == null || ToNumber(item.Required) <= 0) accent = blue;

            Label titleLabel = new Label
            {
                Text = title,
                Dock = DockStyle.Top,
                Height = 42,
                Font = new Font("맑은 고딕", 15F, FontStyle.Bold),
                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(12, 4, 12, 0)
            };
            card.Controls.Add(titleLabel);

            Label valueLabel = new Label
            {
                Text = item == null ? "데이터 없음" : item.Completed + " / " + item.Required,
                Dock = DockStyle.Top,
                Height = 52,
                Font = new Font("맑은 고딕", 22F, FontStyle.Bold),
                ForeColor = accent,
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(valueLabel);

            Label statusLabel = new Label
            {
                Text = item == null ? "해당 영역 데이터가 없습니다." : item.Status,
                Dock = DockStyle.Top,
                Height = 32,
                Font = new Font("맑은 고딕", 11F, FontStyle.Bold),
                ForeColor = accent,
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(statusLabel);

            Panel bar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 18,
                Margin = new Padding(18, 0, 18, 0),
                BackColor = Color.FromArgb(232, 236, 242)
            };
            card.Controls.Add(bar);
            bar.Paint += delegate (object sender, PaintEventArgs e)
            {
                double required = item == null ? 0 : ToNumber(item.Required);
                double completed = item == null ? 0 : ToNumber(item.Completed);
                double percent = required > 0 ? Math.Min(100, completed * 100.0 / required) : 0;
                int fill = (int)Math.Round(bar.Width * percent / 100.0);
                using (Brush brush = new SolidBrush(accent))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, fill, bar.Height);
                }
            };

            Label descLabel = new Label
            {
                Text = description,
                Dock = DockStyle.Fill,
                Font = new Font("맑은 고딕", 9.5F, FontStyle.Bold),
                ForeColor = grayText,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(12)
            };
            card.Controls.Add(descLabel);
            descLabel.BringToFront();
            return card;
        }

        private Form1.AnalysisItem GetItemByArea(string area)
        {
            return items.FirstOrDefault(i => i.Area.Replace(" ", "").Contains(area.Replace(" ", "")));
        }

        private double CalculateAverageCorePercent()
        {
            List<Form1.AnalysisItem> core = items.Where(i => ToNumber(i.Required) > 0 && IsCoreArea(i.Area)).ToList();
            if (core.Count == 0) return 0;
            return core.Average(i => Math.Min(100, ToNumber(i.Completed) * 100.0 / Math.Max(1, ToNumber(i.Required))));
        }

        private string BuildMissingRequiredGuide()
        {
            if (missingRequiredText.Contains("없음"))
            {
                return "미이수 필수과목: 없음";
            }
            return missingRequiredText;
        }

        private string BuildRecommendationGuide()
        {
            List<Form1.AnalysisItem> shortage = items.Where(i => i.IsShortage).OrderByDescending(GetShortageValue).ToList();
            List<string> lines = new List<string>();

            if (shortage.Count == 0)
            {
                lines.Add("부족 학점 영역은 없습니다.");
                lines.Add("추천 과목이 없습니다.");
                return string.Join("\r\n", lines.ToArray());
            }

            foreach (Form1.AnalysisItem item in shortage.Take(6))
            {
                string area = item.Area;
                if (area.Contains("교양")) lines.Add("• " + area + ": 교양기초/대학교양 영역 과목 우선 확인");
                else if (area.Contains("전공탐색")) lines.Add("• " + area + ": 전공탐색 필수/선택 과목 우선 확인");
                else if (area.Contains("제1전공")) lines.Add("• " + area + ": 제1전공 전필/전선 과목 우선 확인");
                else if (area.Contains("제2전공")) lines.Add("• " + area + ": 제2전공 전필/전선 과목 우선 확인");
                else lines.Add("• " + area + ": 부족 학점 " + GetShortageValue(item) + "학점 확인");
            }

            lines.Add("\r\n추천 과목은 학과별 개설 과목 데이터가 연결되면 자동 표시하도록 확장 가능합니다.");
            return string.Join("\r\n", lines.ToArray());
        }

        private Panel CreateKpiCard(string title, string value, Color accent)
        {
            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(8),
                Padding = new Padding(12)
            };

            Label titleLabel = new Label
            {
                Text = title,
                Dock = DockStyle.Top,
                Height = 28,
                Font = new Font("맑은 고딕", 9.5F, FontStyle.Bold),
                ForeColor = grayText,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label valueLabel = new Label
            {
                Text = value,
                Dock = DockStyle.Fill,
                Font = new Font("맑은 고딕", 17F, FontStyle.Bold),
                ForeColor = accent,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Panel accentBar = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 6,
                BackColor = accent
            };

            card.Controls.Add(valueLabel);
            card.Controls.Add(titleLabel);
            card.Controls.Add(accentBar);
            return card;
        }

        private Panel CreateDonutPanel(double percent, Color color, string centerText, string subText)
        {
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(8)
            };
            panel.Paint += delegate (object sender, PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                int size = Math.Min(panel.Width, panel.Height) - 70;
                if (size < 80) size = 80;
                Rectangle rect = new Rectangle((panel.Width - size) / 2, 72, size, size);
                using (Pen basePen = new Pen(Color.FromArgb(232, 236, 242), 18))
                using (Pen valuePen = new Pen(color, 18))
                using (Font mainFont = new Font("맑은 고딕", 16F, FontStyle.Bold))
                using (Font subFont = new Font("맑은 고딕", 10F, FontStyle.Bold))
                using (Brush colorBrush = new SolidBrush(color))
                using (Brush textBrush = new SolidBrush(navy))
                {
                    basePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    basePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    valuePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    valuePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    e.Graphics.DrawArc(basePen, rect, -90, 360);
                    e.Graphics.DrawArc(valuePen, rect, -90, (float)(360 * Math.Min(100, percent) / 100.0));

                    DrawCenteredText(e.Graphics, centerText, mainFont, colorBrush, rect.X, rect.Y + size / 2 - 22, size, 28);
                    DrawCenteredText(e.Graphics, subText, subFont, textBrush, rect.X, rect.Y + size / 2 + 8, size, 24);
                    DrawCenteredText(e.Graphics, Math.Round(percent, 1) + "%", subFont, colorBrush, rect.X, rect.Y + size + 20, size, 24);
                }
            };
            return panel;
        }

        private Control CreateProgressRow(Form1.AnalysisItem item, int width)
        {
            Panel row = new Panel
            {
                Width = width,
                Height = 48,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 10)
            };

            double required = ToNumber(item.Required);
            double completed = ToNumber(item.Completed);
            double percent = required > 0 ? Math.Min(100, completed * 100.0 / required) : 0;
            bool shortage = item.IsShortage;
            Color accent = shortage ? red : green;
            if (required <= 0) accent = blue;

            Label left = new Label
            {
                Text = item.Area,
                Location = new Point(0, 0),
                Size = new Size(145, 42),
                Font = new Font("맑은 고딕", 9F, FontStyle.Bold),
                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft
            };
            row.Controls.Add(left);

            Label right = new Label
            {
                Text = required > 0 ? item.Completed + " / " + item.Required + "  " + item.Status : item.Completed + "학점",
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(width - 190, 0),
                Size = new Size(180, 22),
                Font = new Font("맑은 고딕", 8.5F, FontStyle.Bold),
                ForeColor = accent,
                TextAlign = ContentAlignment.MiddleRight
            };
            row.Controls.Add(right);

            Panel bar = new Panel
            {
                Location = new Point(150, 25),
                Size = new Size(width - 170, 14),
                BackColor = Color.FromArgb(232, 236, 242),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            };
            row.Controls.Add(bar);
            bar.Paint += delegate (object sender, PaintEventArgs e)
            {
                int fill = required > 0 ? (int)Math.Round(bar.Width * Math.Min(100, percent) / 100.0) : Math.Min(bar.Width, Math.Max(4, (int)Math.Round(bar.Width * 0.35)));
                using (Brush brush = new SolidBrush(accent))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, fill, bar.Height);
                }
            };

            return row;
        }

        private Control CreateShortageBarChart(List<Form1.AnalysisItem> shortageItems)
        {
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(18, 54, 18, 18)
            };

            if (shortageItems.Count == 0)
            {
                panel.Controls.Add(CreateMessageLabel("현재 부족한 영역이 없습니다.", green));
                return panel;
            }

            panel.Paint += delegate (object sender, PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                int left = 170;
                int top = 60;
                int rowH = 46;
                int maxBarWidth = Math.Max(120, panel.Width - left - 90);
                double maxShortage = Math.Max(1, shortageItems.Max(GetShortageValue));

                using (Font labelFont = new Font("맑은 고딕", 9F, FontStyle.Bold))
                using (Font valueFont = new Font("맑은 고딕", 9F, FontStyle.Bold))
                using (Brush labelBrush = new SolidBrush(navy))
                using (Brush valueBrush = new SolidBrush(red))
                using (Brush barBrush = new SolidBrush(red))
                using (Brush bgBrush = new SolidBrush(Color.FromArgb(232, 236, 242)))
                {
                    int i = 0;
                    foreach (Form1.AnalysisItem item in shortageItems.Take(8))
                    {
                        int y = top + i * rowH;
                        double shortage = GetShortageValue(item);
                        int barWidth = (int)Math.Round(maxBarWidth * shortage / maxShortage);
                        e.Graphics.DrawString(item.Area, labelFont, labelBrush, new RectangleF(20, y - 2, left - 30, 25));
                        e.Graphics.FillRectangle(bgBrush, left, y, maxBarWidth, 18);
                        e.Graphics.FillRectangle(barBrush, left, y, barWidth, 18);
                        e.Graphics.DrawString("부족 " + shortage + "학점", valueFont, valueBrush, new RectangleF(left + maxBarWidth + 10, y - 2, 80, 25));
                        i++;
                    }
                }
            };
            return panel;
        }

        private Control CreateStackedSummaryPanel()
        {
            Panel panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(18, 58, 18, 18)
            };

            panel.Paint += delegate (object sender, PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                List<Form1.AnalysisItem> displayItems = items.Where(i => IsCoreArea(i.Area) && ToNumber(i.Required) > 0).Take(6).ToList();
                if (displayItems.Count == 0) return;

                int chartX = 45;
                int chartY = 70;
                int chartW = panel.Width - 90;
                int chartH = 34;
                int legendY = chartY + 70;
                double totalRequired = Math.Max(1, displayItems.Sum(i => ToNumber(i.Required)));
                int currentX = chartX;
                Color[] colors = { blue, green, orange, Color.FromArgb(125, 91, 236), Color.FromArgb(0, 150, 180), Color.FromArgb(90, 100, 115) };

                using (Font font = new Font("맑은 고딕", 9F, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(navy))
                {
                    for (int i = 0; i < displayItems.Count; i++)
                    {
                        Form1.AnalysisItem item = displayItems[i];
                        int w = (int)Math.Round(chartW * ToNumber(item.Required) / totalRequired);
                        if (i == displayItems.Count - 1) w = chartX + chartW - currentX;
                        using (Brush b = new SolidBrush(colors[i % colors.Length]))
                        {
                            e.Graphics.FillRectangle(b, currentX, chartY, w, chartH);
                            e.Graphics.FillRectangle(b, chartX + (i % 2) * (chartW / 2), legendY + (i / 2) * 42, 14, 14);
                        }
                        e.Graphics.DrawString(item.Area + "  " + item.Completed + "/" + item.Required, font, textBrush,
                            chartX + (i % 2) * (chartW / 2) + 20, legendY + (i / 2) * 42 - 3);
                        currentX += w;
                    }
                }
            };
            return panel;
        }

        private Panel CreatePriorityCard(int rank, Form1.AnalysisItem item)
        {
            Panel card = new Panel
            {
                Width = 360,
                Height = 76,
                BackColor = Color.FromArgb(255, 247, 247),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 10)
            };
            Label rankLabel = new Label
            {
                Text = rank.ToString(),
                Location = new Point(12, 14),
                Size = new Size(40, 40),
                BackColor = red,
                ForeColor = Color.White,
                Font = new Font("맑은 고딕", 14F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label text = new Label
            {
                Text = item.Area + "\r\n" + item.Status,
                Location = new Point(65, 12),
                Size = new Size(280, 50),
                Font = new Font("맑은 고딕", 10F, FontStyle.Bold),
                ForeColor = navy,
                TextAlign = ContentAlignment.MiddleLeft
            };
            card.Controls.Add(rankLabel);
            card.Controls.Add(text);
            return card;
        }

        private Panel CreateMessageCard(string title, string body, Color accent)
        {
            Panel card = new Panel
            {
                Width = 360,
                Height = 120,
                BackColor = Color.FromArgb(247, 255, 250),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 10)
            };
            Label label = new Label
            {
                Text = title + "\r\n" + body,
                Dock = DockStyle.Fill,
                Padding = new Padding(14),
                Font = new Font("맑은 고딕", 10F, FontStyle.Bold),
                ForeColor = accent,
                TextAlign = ContentAlignment.MiddleLeft
            };
            card.Controls.Add(label);
            return card;
        }

        private Label CreateMessageLabel(string text, Color color)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                Font = new Font("맑은 고딕", 15F, FontStyle.Bold),
                ForeColor = color,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        private void AddTextBlock(Control parent, string text)
        {
            Label label = new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                Padding = new Padding(18, 58, 18, 18),
                Font = new Font("맑은 고딕", 11F, FontStyle.Bold),
                ForeColor = grayText,
                TextAlign = ContentAlignment.TopLeft
            };
            parent.Controls.Add(label);
        }

        private string CreateStudentGuideText(List<Form1.AnalysisItem> shortage)
        {
            if (shortage.Count == 0)
            {
                return "현재 입력된 이수내역 기준으로 부족 영역은 없습니다.";
            }

            Form1.AnalysisItem first = shortage.First();
            return "우선 확인 영역: " + first.Area + "\r\n" +
                   "상태: " + first.Status + "\r\n" +
                   "부족 영역: " + string.Join(", ", shortage.Select(i => i.Area).ToArray());
        }

        private Form1.AnalysisItem GetTotalItem()
        {
            return items.FirstOrDefault(i => i.Area.Contains("총"));
        }

        private bool IsCoreArea(string area)
        {
            return area.Contains("총") || area.Contains("교양") || area.Contains("전공탐색") || area.Contains("제1전공") || area.Contains("제2전공");
        }

        private string GetWorstShortageText()
        {
            Form1.AnalysisItem worst = items.Where(i => i.IsShortage).OrderByDescending(GetShortageValue).FirstOrDefault();
            return worst == null ? "없음" : worst.Area + " " + GetShortageValue(worst) + "학점";
        }

        private double GetShortageValue(Form1.AnalysisItem item)
        {
            double required = ToNumber(item.Required);
            double completed = ToNumber(item.Completed);
            return Math.Max(0, required - completed);
        }

        private double ToNumber(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;
            string cleaned = new string(text.Where(c => char.IsDigit(c) || c == '.' || c == '-').ToArray());
            double value;
            if (double.TryParse(cleaned, out value)) return value;
            return 0;
        }

        private void DrawCenteredText(Graphics g, string text, Font font, Brush brush, int x, int y, int w, int h)
        {
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                g.DrawString(text, font, brush, new RectangleF(x, y, w, h), format);
            }
        }
    }
}
