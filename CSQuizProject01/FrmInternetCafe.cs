using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmInternetCafe : Form
    {
        public FrmInternetCafe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void FrmInternetCafe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mtbIDcard.Clear();
            tbFullname.Clear();

            lbDateuse.Text = "-";
            lbFullname.Text = "-";
            lbIDcard.Text = "-";
            lbServiceTime.Text = "-";
            lbServiceType.Text = "-";
            lbUserType.Text = "-";
            lbPayTotal.Text = "00.00";
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            // Validate
            if (!mtbIDcard.MaskCompleted)
            {
                ShareData.showWarningMSG("ป้อนเลขประจำตัวประชาชนด้วย");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbFullname.Text))
            {
                ShareData.showWarningMSG("ป้อนเลขชื่อ-สกุลด้วย");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbTimeUse.Text))
            {
                ShareData.showWarningMSG("ป้อนจำนวนการใช้บริการด้วย");
                return;
            }
            if (!cbPay.Checked)
            {
                ShareData.showWarningMSG("ยีนยันการชำระเงินด้วย");
                return;
            }

            string selectedType = cbbUseType.SelectedItem?.ToString();
            DateTime selectedDate = dtpDate.SelectionStart;
            int buddhistYear = selectedDate.Year;
            string Date = selectedDate.ToString("วันที่ d MMMM ", new CultureInfo("th-TH")) + buddhistYear.ToString();
            double pricePerHour = 0;

            switch (cbbUseType.SelectedIndex)
            {
                case 0:
                    pricePerHour = 20.5;
                    lbServiceType.Text = "อินเตอร์เน็ต";
                    break;
                case 1:
                    pricePerHour = 10.5;
                    lbServiceType.Text = "พิมพ์งาน";
                    break;
                case 2:
                    pricePerHour = 15.5;
                    lbServiceType.Text = "เล่นเกมส์ Offline";
                    break;
                case 3:
                    pricePerHour = 25.5;
                    lbServiceType.Text = "เล่นเกมส์ Online";
                    break;
            }

            if (rbMember.Checked)
            {
                lbUserType.Text = "สมาชิก";
            }
            else if (rbStu.Checked)
            {
                lbUserType.Text = "นักเรียน/นักศึกษา";
            }
            else
            {
                lbUserType.Text = "บุคคลทั่วไป";
            }

            double TotalPay = double.Parse(tbTimeUse.Text) * pricePerHour;

            if (lbUserType.Text == "สมาชิก")
            {
                TotalPay -= TotalPay * 0.10;
            }
            else if (lbUserType.Text == "นักเรียน/นักศึกษา")
            {
                TotalPay -= TotalPay * 0.05;
            }

            lbPayTotal.Text = TotalPay.ToString("#,###,##0.00");

            lbDateuse.Text = Date;
            lbIDcard.Text = mtbIDcard.Text;
            lbFullname.Text = tbFullname.Text;
            lbServiceTime.Text = tbTimeUse.Text;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("คุณต้องการปิดโปรแกรมหรือไม่?", "ยืนยันการปิด", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
