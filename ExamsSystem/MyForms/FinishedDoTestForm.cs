using ExamsSystem.MyObjects;
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
    public partial class FinishedDoTestForm : Form
    {
        private StudentsTests studentTest;
        public FinishedDoTestForm()
        {
            InitializeComponent();
        }
        public FinishedDoTestForm(object data)
        {
            InitializeComponent();
            studentTest = (StudentsTests)data;
        }

        private void FinishedDoTestForm_Load(object sender, EventArgs e)
        {
            
            txt_testid.Text = studentTest.Testid;
            txt_startdotime.Text = studentTest.Startdotime;
            txt_submittime.Text = studentTest.Submittime;
            //tính thời gian làm bài (theo phút)
            DateTime startDoTime = DateTime.ParseExact(studentTest.Startdotime, "dd/MM/yyyy HH:mm:ss",null);
            DateTime submittime = DateTime.ParseExact(studentTest.Submittime, "dd/MM/yyyy HH:mm:ss", null);
            TimeSpan timeSpan = submittime - startDoTime;
            //và đổi sang phút
            double totalMinutes = Math.Ceiling(timeSpan.TotalMinutes); //làm tròn đến cận trên (max)
            txt_dotime.Text = totalMinutes.ToString() +" phút";
        }

        private void btn_create_test_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinishedDoTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            goToHomeForm();
        }
        private void goToHomeForm()
        {
            // tạo một HomeForm
            Form homeForm = FormFactory.getInstance().getForm("Home");
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }
    }
}
