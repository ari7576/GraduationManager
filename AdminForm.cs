using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class AdminForm : Form
    {
        private List<GraduationRequirement> requirements = new List<GraduationRequirement>();

        public AdminForm()
        {
            InitializeComponent();
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
            public List<Subject> 과목목록 { get; set; } = new List<Subject>();
        }

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

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON 파일|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (dgvRequirements.SelectedRows.Count == 0)
                {
                    MessageBox.Show("과목을 추가할 졸업요건을 먼저 선택하세요!");
                    return;
                }

                string json = File.ReadAllText(ofd.FileName);
                var subjects = JsonConvert.DeserializeObject<List<Subject>>(json);

                int index = dgvRequirements.SelectedRows[0].Index;
                requirements[index].과목목록 = subjects;

                RefreshGrid();
                MessageBox.Show($"과목 {subjects.Count}개 불러왔습니다!");
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON 파일|*.json";
            sfd.FileName = "졸업요건.json";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var data = new { 졸업요건 = requirements };
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(sfd.FileName, json);
                MessageBox.Show("저장되었습니다!");
            }
        }
    }
}