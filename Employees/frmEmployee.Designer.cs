namespace Employees
{
    partial class frmEmployee
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
            this.mainLbl = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtL_Name = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtE_Mail = new System.Windows.Forms.TextBox();
            this.txtF_Name = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAddressNum = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.pStatus = new System.Windows.Forms.Panel();
            this.radiowidower = new System.Windows.Forms.RadioButton();
            this.radioDevorsed = new System.Windows.Forms.RadioButton();
            this.radioMerried = new System.Windows.Forms.RadioButton();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.pGender = new System.Windows.Forms.Panel();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNxt = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSrchByCode = new System.Windows.Forms.Button();
            this.btnSrchByID = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_InvalidID = new System.Windows.Forms.Label();
            this.pStatus.SuspendLayout();
            this.pGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLbl.Location = new System.Drawing.Point(473, 26);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(84, 29);
            this.mainLbl.TabIndex = 0;
            this.mainLbl.Text = "עובדים";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(841, 101);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(27, 16);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "קוד";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(693, 101);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "תעודת זהות";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(565, 101);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(54, 16);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "שם פרטי";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(444, 101);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(67, 16);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "שם משפחה";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(284, 101);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(76, 16);
            this.lblBirthday.TabIndex = 5;
            this.lblBirthday.Text = "תאריך לידה";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(834, 415);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "אימייל";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(724, 415);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(30, 16);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "נייד";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(584, 415);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(35, 16);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "רחוב";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(444, 415);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(37, 16);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "מספר";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(304, 415);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 16);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "עיר";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(823, 139);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(54, 22);
            this.txtCode.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(684, 139);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 22);
            this.txtID.TabIndex = 12;
            this.txtID.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // txtL_Name
            // 
            this.txtL_Name.Location = new System.Drawing.Point(425, 139);
            this.txtL_Name.Name = "txtL_Name";
            this.txtL_Name.Size = new System.Drawing.Size(100, 22);
            this.txtL_Name.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(684, 463);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 15;
            // 
            // txtE_Mail
            // 
            this.txtE_Mail.Location = new System.Drawing.Point(801, 463);
            this.txtE_Mail.Name = "txtE_Mail";
            this.txtE_Mail.Size = new System.Drawing.Size(100, 22);
            this.txtE_Mail.TabIndex = 16;
            // 
            // txtF_Name
            // 
            this.txtF_Name.Location = new System.Drawing.Point(545, 139);
            this.txtF_Name.Name = "txtF_Name";
            this.txtF_Name.Size = new System.Drawing.Size(100, 22);
            this.txtF_Name.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(529, 463);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(127, 22);
            this.txtAddress.TabIndex = 18;
            // 
            // txtAddressNum
            // 
            this.txtAddressNum.Location = new System.Drawing.Point(408, 463);
            this.txtAddressNum.Name = "txtAddressNum";
            this.txtAddressNum.Size = new System.Drawing.Size(100, 22);
            this.txtAddressNum.TabIndex = 19;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(266, 463);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 20;
            // 
            // pStatus
            // 
            this.pStatus.Controls.Add(this.radiowidower);
            this.pStatus.Controls.Add(this.radioDevorsed);
            this.pStatus.Controls.Add(this.radioMerried);
            this.pStatus.Controls.Add(this.radioSingle);
            this.pStatus.Location = new System.Drawing.Point(610, 207);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(119, 130);
            this.pStatus.TabIndex = 0;
            // 
            // radiowidower
            // 
            this.radiowidower.AutoSize = true;
            this.radiowidower.Location = new System.Drawing.Point(46, 88);
            this.radiowidower.Name = "radiowidower";
            this.radiowidower.Size = new System.Drawing.Size(57, 20);
            this.radiowidower.TabIndex = 27;
            this.radiowidower.TabStop = true;
            this.radiowidower.Text = "אלמן";
            this.radiowidower.UseVisualStyleBackColor = true;
            // 
            // radioDevorsed
            // 
            this.radioDevorsed.AutoSize = true;
            this.radioDevorsed.Location = new System.Drawing.Point(48, 62);
            this.radioDevorsed.Name = "radioDevorsed";
            this.radioDevorsed.Size = new System.Drawing.Size(55, 20);
            this.radioDevorsed.TabIndex = 26;
            this.radioDevorsed.TabStop = true;
            this.radioDevorsed.Text = "גרוש";
            this.radioDevorsed.UseVisualStyleBackColor = true;
            // 
            // radioMerried
            // 
            this.radioMerried.AutoSize = true;
            this.radioMerried.Location = new System.Drawing.Point(51, 36);
            this.radioMerried.Name = "radioMerried";
            this.radioMerried.Size = new System.Drawing.Size(52, 20);
            this.radioMerried.TabIndex = 25;
            this.radioMerried.TabStop = true;
            this.radioMerried.Text = "נשוי";
            this.radioMerried.UseVisualStyleBackColor = true;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(51, 10);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(52, 20);
            this.radioSingle.TabIndex = 24;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "רווק";
            this.radioSingle.UseVisualStyleBackColor = true;
            // 
            // pGender
            // 
            this.pGender.Controls.Add(this.radioFemale);
            this.pGender.Controls.Add(this.radioMale);
            this.pGender.Location = new System.Drawing.Point(759, 217);
            this.pGender.Name = "pGender";
            this.pGender.Size = new System.Drawing.Size(125, 100);
            this.pGender.TabIndex = 0;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(62, 52);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(56, 20);
            this.radioFemale.TabIndex = 24;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "נקבה";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(71, 18);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(47, 20);
            this.radioMale.TabIndex = 23;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "זכר";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(172, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 121);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(189, 248);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(103, 25);
            this.lblImg.TabIndex = 22;
            this.lblImg.Text = "בחר תמונה";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(140, 101);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 16);
            this.lblAge.TabIndex = 23;
            this.lblAge.Text = "גיל";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(120, 139);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(72, 22);
            this.txtAge.TabIndex = 24;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(389, 355);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(99, 39);
            this.btnPrev.TabIndex = 25;
            this.btnPrev.Text = ">>";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNxt
            // 
            this.btnNxt.Location = new System.Drawing.Point(610, 355);
            this.btnNxt.Name = "btnNxt";
            this.btnNxt.Size = new System.Drawing.Size(103, 39);
            this.btnNxt.TabIndex = 26;
            this.btnNxt.Text = "<<";
            this.btnNxt.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(640, 539);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 39);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(496, 539);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "הוספת עובד";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(357, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 39);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(212, 539);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(99, 39);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "מחיקה";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnSrchByCode
            // 
            this.btnSrchByCode.Location = new System.Drawing.Point(621, 637);
            this.btnSrchByCode.Name = "btnSrchByCode";
            this.btnSrchByCode.Size = new System.Drawing.Size(159, 52);
            this.btnSrchByCode.TabIndex = 31;
            this.btnSrchByCode.Text = "חיפוש עובד לפי קוד";
            this.btnSrchByCode.UseVisualStyleBackColor = true;
            // 
            // btnSrchByID
            // 
            this.btnSrchByID.Location = new System.Drawing.Point(311, 637);
            this.btnSrchByID.Name = "btnSrchByID";
            this.btnSrchByID.Size = new System.Drawing.Size(211, 52);
            this.btnSrchByID.TabIndex = 32;
            this.btnSrchByID.Text = "חיפוש עובד לפי תעודת זהות";
            this.btnSrchByID.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 139);
            this.dateTimePicker1.MaxDate = new System.DateTime(2004, 12, 21, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1955, 12, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.Value = new System.DateTime(2004, 12, 21, 0, 0, 0, 0);
            // 
            // lbl_InvalidID
            // 
            this.lbl_InvalidID.AutoSize = true;
            this.lbl_InvalidID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_InvalidID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InvalidID.ForeColor = System.Drawing.Color.Red;
            this.lbl_InvalidID.Location = new System.Drawing.Point(648, 175);
            this.lbl_InvalidID.Name = "lbl_InvalidID";
            this.lbl_InvalidID.Size = new System.Drawing.Size(139, 18);
            this.lbl_InvalidID.TabIndex = 34;
            this.lbl_InvalidID.Text = "מספר זהות לא תקין :(";
            this.lbl_InvalidID.Visible = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 723);
            this.Controls.Add(this.lbl_InvalidID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSrchByID);
            this.Controls.Add(this.btnSrchByCode);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNxt);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.pGender);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddressNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtF_Name);
            this.Controls.Add(this.txtE_Mail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtL_Name);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.mainLbl);
            this.Name = "frmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.pStatus.ResumeLayout(false);
            this.pStatus.PerformLayout();
            this.pGender.ResumeLayout(false);
            this.pGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtL_Name;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtE_Mail;
        private System.Windows.Forms.TextBox txtF_Name;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAddressNum;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Panel pStatus;
        private System.Windows.Forms.RadioButton radiowidower;
        private System.Windows.Forms.RadioButton radioDevorsed;
        private System.Windows.Forms.RadioButton radioMerried;
        private System.Windows.Forms.RadioButton radioSingle;
        private System.Windows.Forms.Panel pGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNxt;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSrchByCode;
        private System.Windows.Forms.Button btnSrchByID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_InvalidID;
    }
}

