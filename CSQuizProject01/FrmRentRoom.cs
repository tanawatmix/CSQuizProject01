using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmRentRoom : Form
    {
        public FrmRentRoom()
        {
            InitializeComponent();
        }

        private void KeyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                //ให้ใช้แค่ตัวเลข ถ้าไม่ใช่ให้ไม่ให้พิมพ์
                e.Handled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbPhone_Click(object sender, EventArgs e)
        {
            if (cbPhone.Checked)
            {
                tbPhone.Enabled = true;
            }
            else
            {
                tbPhone.Clear();
                tbPhone.Enabled = false;
            }
        }

        private void cbNet_Click(object sender, EventArgs e)
        {
            if (cbNet.Checked)
            {
                tbNet.Enabled = true;
            }
            else
            {
                tbNet.Clear();
                tbNet.Enabled = false;
            }
        }

        private void cbWarter_Click(object sender, EventArgs e)
        {
            if (cbWarter.Checked)
            {
                tbWarter.Enabled = true;
            }
            else
            {
                tbWarter.Clear();
                tbWarter.Enabled = false;
            }
        }

        private void cbElec_Click(object sender, EventArgs e)
        {
            if (cbElec.Checked)
            {
                tbElec.Enabled = true;
            }
            else
            {
                tbElec.Clear();
                tbElec.Enabled = false;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumber(sender, e);
        }

        private void tbNet_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumber(sender, e);
        }

        private void tbWarter_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumber(sender, e);
        }

        private void tbElec_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumber(sender, e);
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            // Validate every tb data
            if (!mtbIDcard.MaskCompleted)
            {
                ShareData.showWarningMSG("ป้อนเลขประจำตัวประชาชนด้วย");
            }
            else if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                ShareData.showWarningMSG("ป้อนชื่อด้วย");
            }
            else if (string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                ShareData.showWarningMSG("ป้อนนามสกุลด้วย");
            }
            else
            {
                // Create Variable and Calculate 
                string selectedType = cbbRoomtype.SelectedItem?.ToString();
                string payDate = dtpPayDay.Value.ToString("วันที่ d MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));
                int buddhistYear = dtpPayDay.Value.Year + 543; // แปลง ค.ศ. เป็น พ.ศ.
                payDate = payDate.Replace(dtpPayDay.Value.Year.ToString(), buddhistYear.ToString());
                string prefix = "";
                if (rbMr.Checked)
                {
                    prefix = "นาย";
                }
                else if (rbMrs.Checked)
                {
                    prefix = "นาง";
                }
                else if (rbYoMrs.Checked)
                {
                    prefix = "นางสาว";
                }
                //Phone Internet Water and Electric Calculate====================================
                if (tbPhone.Text.Length > 0)
                {
                    int minutes = int.Parse(tbPhone.Text);
                    double totalPayPhone = 1.50 * minutes;
                    lbPhoneTime.Text = minutes.ToString("0");
                    lbPhonePay.Text = totalPayPhone.ToString("#,###,##0.00");
                }
                else
                {
                    lbPhoneTime.Text = "0";
                    lbPhonePay.Text = ("0.00");
                }
                if (tbNet.Text.Length > 0)
                {
                    int minutes = int.Parse(tbNet.Text);
                    double totalPayNet = 0.5 * minutes;
                    lbNettime.Text = minutes.ToString("0");
                    lbNetPay.Text = totalPayNet.ToString("#,###,##0.00");
                }
                else
                {
                    lbNettime.Text = "0";
                    lbNetPay.Text = ("0.00");
                }
                if (tbWarter.Text.Length > 0)
                {
                    int units = int.Parse(tbWarter.Text);
                    double totalPayWarter = 12.5 * units;
                    lbWarterUnits.Text = units.ToString("0");
                    lbWarterPay.Text = totalPayWarter.ToString("#,###,##0.00");
                }
                else
                {
                    lbWarterUnits.Text = "0";
                    lbWarterPay.Text = ("0.00");
                }
                if (tbElec.Text.Length > 0)
                {
                    int units = int.Parse(tbElec.Text);
                    double totalPayElec = 12.5 * units;
                    lbElecUnits.Text = units.ToString("0");
                    lbElecPay.Text = totalPayElec.ToString("#,###,##0.00");
                }
                else
                {
                    lbElecUnits.Text = "0";
                    lbElecPay.Text = ("0.00");
                }
                //Total Using Bill Display
                double totalPay =
                double.Parse(lbPhonePay.Text) +
                double.Parse(lbNetPay.Text) +
                double.Parse(lbWarterPay.Text) +
                double.Parse(lbElecPay.Text);
                // Display results

                lbPayDay.Text = payDate;
                lbIDcard.Text = mtbIDcard.Text;
                lbName.Text = $"{prefix} {tbName.Text} {tbSurname.Text}".Trim();
                lbRoomType.Text = selectedType;
                if (cbbRoomtype.SelectedIndex == 0)
                {
                    totalPay = totalPay + 4500;
                }
                else if (cbbRoomtype.SelectedIndex == 1)
                {
                    totalPay = totalPay + 4000;
                }
                else if (cbbRoomtype.SelectedIndex == 2)
                {
                    totalPay = totalPay + 3500;
                }
                else
                {
                    totalPay = totalPay + 3000;
                }
                lbTotalPay.Text = totalPay.ToString("#,###,##0.00");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            mtbIDcard.Clear();
            rbMr.Checked = true;
            tbName.Clear();
            tbSurname.Clear();
            tbPhone.Clear();
            tbNet.Clear();
            tbWarter.Clear();
            tbElec.Clear();
            tbPhone.Enabled = false;
            tbNet.Enabled = false;
            tbWarter.Enabled = false;
            tbElec.Enabled = false;
            cbbRoomtype.SelectedIndex = 0;
            cbPhone.Checked = false;
            cbNet.Checked = false;
            cbWarter.Checked = false;
            cbElec.Checked = false;
            lbPayDay.Text = "-";
            lbIDcard.Text = "-";
            lbName.Text = "-";
            lbRoomType.Text = "-";
            lbPhoneTime.Text = "0";
            lbNettime.Text = "0";
            lbWarterUnits.Text = "0";
            lbElecUnits.Text = "0";
            lbPhonePay.Text = "0.00";
            lbNetPay.Text = "0.00";
            lbWarterPay.Text = "0.00";
            lbElecPay.Text = "0.00";
            lbTotalPay.Text = "0.00";
        }

        private void mtbIDcard_Click(object sender, EventArgs e)
        {

        }

        private void mtbIDcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyNumber(sender, e);
        }
    }
}
