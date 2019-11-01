using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact
{
    public partial class frmContact : Form
    {
     

        #region Path data file

        string pathContactDataFile;
        #endregion

        public frmContact()
        {
            InitializeComponent();
          
           
            pathContactDataFile = Application.StartupPath + @"\Data\dataContact.txt";
            if (File.Exists(pathContactDataFile))
            {
                var listLines = File.ReadAllLines(pathContactDataFile);
                foreach (var line in listLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    dtgContact.Rows.Add(rs[0], rs[1], rs[2],rs[3]);

                }
            }

           
        }

        private void dtgContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
