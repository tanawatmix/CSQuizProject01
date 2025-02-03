namespace CSQuizProject01
{
    partial class FrmInternetCafe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInternetCafe));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.MonthCalendar();
            this.rbNoneMember = new System.Windows.Forms.RadioButton();
            this.rbStu = new System.Windows.Forms.RadioButton();
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.mtbIDcard = new System.Windows.Forms.MaskedTextBox();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbIDcard = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.lbUserType = new System.Windows.Forms.Label();
            this.lbServiceType = new System.Windows.Forms.Label();
            this.lbPayTotal = new System.Windows.Forms.Label();
            this.lbServiceTime = new System.Windows.Forms.Label();
            this.lbDateuse = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTimeUse = new System.Windows.Forms.TextBox();
            this.cbbUseType = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbPay = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(257, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรม Internet Café";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.rbNoneMember);
            this.groupBox1.Controls.Add(this.rbStu);
            this.groupBox1.Controls.Add(this.rbMember);
            this.groupBox1.Controls.Add(this.mtbIDcard);
            this.groupBox1.Controls.Add(this.tbFullname);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(41, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(45, 82);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.TabIndex = 24;
            // 
            // rbNoneMember
            // 
            this.rbNoneMember.AutoSize = true;
            this.rbNoneMember.Location = new System.Drawing.Point(348, 270);
            this.rbNoneMember.Name = "rbNoneMember";
            this.rbNoneMember.Size = new System.Drawing.Size(134, 19);
            this.rbNoneMember.TabIndex = 23;
            this.rbNoneMember.Text = "บุคคลทั่วไปไม่มีส่วนลด";
            this.rbNoneMember.UseVisualStyleBackColor = true;
            // 
            // rbStu
            // 
            this.rbStu.AutoSize = true;
            this.rbStu.Location = new System.Drawing.Point(348, 239);
            this.rbStu.Name = "rbStu";
            this.rbStu.Size = new System.Drawing.Size(149, 19);
            this.rbStu.TabIndex = 22;
            this.rbStu.Text = "นักเรียน/นักศึกษาลด 5%";
            this.rbStu.UseVisualStyleBackColor = true;
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Checked = true;
            this.rbMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMember.Location = new System.Drawing.Point(348, 208);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(98, 19);
            this.rbMember.TabIndex = 21;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "สมาชิกลด10%";
            this.rbMember.UseVisualStyleBackColor = true;
            // 
            // mtbIDcard
            // 
            this.mtbIDcard.Location = new System.Drawing.Point(462, 75);
            this.mtbIDcard.Name = "mtbIDcard";
            this.mtbIDcard.Size = new System.Drawing.Size(151, 20);
            this.mtbIDcard.TabIndex = 20;
            this.mtbIDcard.Text = "__.______._____.___.___";
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(412, 123);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(204, 20);
            this.tbFullname.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Location = new System.Drawing.Point(348, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 24);
            this.label19.TabIndex = 18;
            this.label19.Text = "ชื่อ-สกุล";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Location = new System.Drawing.Point(345, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 24);
            this.label17.TabIndex = 10;
            this.label17.Text = "ประเภทผู้ใช้บริการ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(348, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 24);
            this.label18.TabIndex = 9;
            this.label18.Text = "รหัสบัตรประชาชน";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(32, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 24);
            this.label16.TabIndex = 6;
            this.label16.Text = "วันที่ใช้บริการ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.lbIDcard);
            this.groupBox2.Controls.Add(this.lbFullname);
            this.groupBox2.Controls.Add(this.lbUserType);
            this.groupBox2.Controls.Add(this.lbServiceType);
            this.groupBox2.Controls.Add(this.lbPayTotal);
            this.groupBox2.Controls.Add(this.lbServiceTime);
            this.groupBox2.Controls.Add(this.lbDateuse);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(677, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 517);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::CSQuizProject01.Properties.Resources.Twice_homescreen__3;
            this.groupBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox4.Location = new System.Drawing.Point(142, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 111);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // lbIDcard
            // 
            this.lbIDcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbIDcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDcard.ForeColor = System.Drawing.Color.Red;
            this.lbIDcard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbIDcard.Location = new System.Drawing.Point(163, 124);
            this.lbIDcard.Name = "lbIDcard";
            this.lbIDcard.Size = new System.Drawing.Size(175, 24);
            this.lbIDcard.TabIndex = 17;
            this.lbIDcard.Text = "-";
            this.lbIDcard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFullname
            // 
            this.lbFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.ForeColor = System.Drawing.Color.Red;
            this.lbFullname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbFullname.Location = new System.Drawing.Point(163, 157);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(175, 24);
            this.lbFullname.TabIndex = 16;
            this.lbFullname.Text = "-";
            this.lbFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserType
            // 
            this.lbUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.ForeColor = System.Drawing.Color.Red;
            this.lbUserType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUserType.Location = new System.Drawing.Point(163, 190);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(175, 24);
            this.lbUserType.TabIndex = 15;
            this.lbUserType.Text = "-";
            this.lbUserType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbServiceType
            // 
            this.lbServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceType.ForeColor = System.Drawing.Color.Red;
            this.lbServiceType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbServiceType.Location = new System.Drawing.Point(163, 223);
            this.lbServiceType.Name = "lbServiceType";
            this.lbServiceType.Size = new System.Drawing.Size(175, 24);
            this.lbServiceType.TabIndex = 14;
            this.lbServiceType.Text = "-";
            this.lbServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPayTotal
            // 
            this.lbPayTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbPayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayTotal.ForeColor = System.Drawing.Color.Red;
            this.lbPayTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbPayTotal.Location = new System.Drawing.Point(32, 413);
            this.lbPayTotal.Name = "lbPayTotal";
            this.lbPayTotal.Size = new System.Drawing.Size(306, 74);
            this.lbPayTotal.TabIndex = 13;
            this.lbPayTotal.Text = "00.00";
            this.lbPayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbServiceTime
            // 
            this.lbServiceTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbServiceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServiceTime.ForeColor = System.Drawing.Color.Red;
            this.lbServiceTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbServiceTime.Location = new System.Drawing.Point(163, 256);
            this.lbServiceTime.Name = "lbServiceTime";
            this.lbServiceTime.Size = new System.Drawing.Size(175, 24);
            this.lbServiceTime.TabIndex = 12;
            this.lbServiceTime.Text = "-";
            this.lbServiceTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDateuse
            // 
            this.lbDateuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbDateuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateuse.ForeColor = System.Drawing.Color.Red;
            this.lbDateuse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDateuse.Location = new System.Drawing.Point(163, 91);
            this.lbDateuse.Name = "lbDateuse";
            this.lbDateuse.Size = new System.Drawing.Size(175, 24);
            this.lbDateuse.TabIndex = 11;
            this.lbDateuse.Text = "-";
            this.lbDateuse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(12, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "จำนวนการใช้บริการ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(18, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "ประเภทการใช้บริการ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(29, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "ประเภทผู้ใช้บริการ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(29, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "ชื่อ-สกุล";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(29, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "รหัสบัตรประชาชน";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "วันที่ใช้บริการ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(58, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "ข้อมูลการชำระเงิน";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTimeUse);
            this.groupBox3.Controls.Add(this.cbbUseType);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(41, 431);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 142);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลการใช้บริการ";
            // 
            // tbTimeUse
            // 
            this.tbTimeUse.Location = new System.Drawing.Point(166, 86);
            this.tbTimeUse.Name = "tbTimeUse";
            this.tbTimeUse.Size = new System.Drawing.Size(159, 20);
            this.tbTimeUse.TabIndex = 31;
            // 
            // cbbUseType
            // 
            this.cbbUseType.FormattingEnabled = true;
            this.cbbUseType.Items.AddRange(new object[] {
            "อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท",
            "พิมพ์งาน ชั่วโมงละ 10.50 บาท",
            "เล่นเกมส์ Offline ชั่วโมงละ 15.50 บาท",
            "เล่นเกมส์ Online  ชั่วโมงละ 25.50 บาท"});
            this.cbbUseType.Location = new System.Drawing.Point(166, 45);
            this.cbbUseType.Name = "cbbUseType";
            this.cbbUseType.Size = new System.Drawing.Size(220, 21);
            this.cbbUseType.TabIndex = 30;
            this.cbbUseType.Text = "อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label22.Location = new System.Drawing.Point(338, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 27);
            this.label22.TabIndex = 27;
            this.label22.Text = "ชั่วโมง";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Location = new System.Drawing.Point(32, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 24);
            this.label20.TabIndex = 25;
            this.label20.Text = "ประเภทการใช้บริการ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label21.Location = new System.Drawing.Point(32, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 21);
            this.label21.TabIndex = 26;
            this.label21.Text = "จำนวนการใช้บริการ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btNew.Location = new System.Drawing.Point(482, 446);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(178, 32);
            this.btNew.TabIndex = 4;
            this.btNew.Text = "เริ่มใหม่";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.Location = new System.Drawing.Point(585, 487);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(75, 32);
            this.btCal.TabIndex = 5;
            this.btCal.Text = "คำนวณ";
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btExit.Location = new System.Drawing.Point(482, 528);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(178, 32);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "จบโปรแกรม";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbPay
            // 
            this.cbPay.AutoSize = true;
            this.cbPay.Location = new System.Drawing.Point(482, 496);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(100, 19);
            this.cbPay.TabIndex = 7;
            this.cbPay.Text = "ยืนยันชำระเงิน";
            this.cbPay.UseVisualStyleBackColor = true;
            // 
            // FrmInternetCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 597);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInternetCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรม Quiz1";
            this.Load += new System.EventHandler(this.FrmInternetCafe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.CheckBox cbPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIDcard;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Label lbServiceType;
        private System.Windows.Forms.Label lbPayTotal;
        private System.Windows.Forms.Label lbServiceTime;
        private System.Windows.Forms.Label lbDateuse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbNoneMember;
        private System.Windows.Forms.RadioButton rbStu;
        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.MaskedTextBox mtbIDcard;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MonthCalendar dtpDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbbUseType;
        private System.Windows.Forms.TextBox tbTimeUse;
    }
}

