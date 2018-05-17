using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberSignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void division_ScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.division_ScheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._5801DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_5801DataSet.Division_Schedule' table. You can move, or remove it, as needed.
            this.division_ScheduleTableAdapter.Fill(this._5801DataSet.Division_Schedule);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _5801DataSet.Division_ScheduleRow newDivision_ScheduleRow =
                this._5801DataSet.Division_Schedule.NewDivision_ScheduleRow();
        }
    }
}
