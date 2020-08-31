using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class EditJMForm : Form
    {
        private SampleDBOperations db = SampleDBOperations.GetInstace();
        JM theUnit;
        public EditJMForm(JM unit = null)
        {
            InitializeComponent();
            if (unit == null)
            {
                theUnit = new JM();
            }
            else
            {
                theUnit = unit;
            }
            PrecisionComboBox.Items.Add("1");
            PrecisionComboBox.Items.Add("0,1");
            PrecisionComboBox.Items.Add("0,01");
            PrecisionComboBox.Items.Add("0,001");
            NameUnitTextBox.Text = theUnit.Name;
            PrecisionComboBox.SelectedIndex = theUnit.Precision;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            theUnit.Name = NameUnitTextBox.Text;
            theUnit.Precision = PrecisionComboBox.SelectedIndex;
            db.JMPutItem(theUnit);
            Close();
        }
    }
}
