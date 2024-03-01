using ExamsSystem.Patterns.FactoryMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.MyForms
{
    public partial class ReportManagerForm : Form
    {
        public ReportManagerForm()
        {
            InitializeComponent();
        }

        private void btn_test_result_report_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //lấy ra tên của loại báo cáo muốn lập (đồng thời là tên để tạo form)
            Form form = FormFactory.getInstance().getForm(button.Tag.ToString());
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void ReportManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
        private void goToHomeForm()
        {
            // tạo một HomeForm
            Form homeForm = FormFactory.getInstance().getForm("Home");
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goToHomeForm();
        }
    }
}
