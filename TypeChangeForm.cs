using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TypeChangeForm : Form
    {
        public string SelectedType { get; private set; }
        public TypeChangeForm(string currentType)
        {
            InitializeComponent();

            cboType.Items.AddRange(new string[] { "전공필수", "전공선택", "전공탐색", "대학교양", "교양기초" });
            cboType.SelectedItem = currentType;
        }
        

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            SelectedType = cboType.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    
}
