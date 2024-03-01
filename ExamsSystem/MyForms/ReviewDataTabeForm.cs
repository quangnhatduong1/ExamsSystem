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
    public partial class ReviewDataTabeForm : Form
    {
        private DataTable dataList;
        public ReviewDataTabeForm()
        {
            InitializeComponent();
        }
        public ReviewDataTabeForm(object data)
        {
            InitializeComponent();
            dataList = (DataTable) data;
            
        }

        private void ReviewDataTabeForm_Load(object sender, EventArgs e)
        {
            data_list.DataSource = dataList;
        }
    }
}
