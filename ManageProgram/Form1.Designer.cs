namespace ManageProgram
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lBMemberList = new System.Windows.Forms.ListBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(293, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "성명: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(293, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "직책: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(293, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "생년월일: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(293, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "연락처: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(293, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "이메일: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(293, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "표시순번: ";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbxName.Location = new System.Drawing.Point(428, 25);
            this.tbxName.MaxLength = 10;
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(262, 30);
            this.tbxName.TabIndex = 7;
            // 
            // tbxPosition
            // 
            this.tbxPosition.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxPosition.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbxPosition.Location = new System.Drawing.Point(428, 86);
            this.tbxPosition.MaxLength = 10;
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.ReadOnly = true;
            this.tbxPosition.Size = new System.Drawing.Size(262, 30);
            this.tbxPosition.TabIndex = 8;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpBirthday.Enabled = false;
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(428, 147);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(262, 25);
            this.dtpBirthday.TabIndex = 9;
            this.dtpBirthday.Value = new System.DateTime(2024, 3, 20, 16, 18, 4, 0);
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxPhoneNumber.Location = new System.Drawing.Point(428, 204);
            this.tbxPhoneNumber.MaxLength = 13;
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.ReadOnly = true;
            this.tbxPhoneNumber.Size = new System.Drawing.Size(262, 30);
            this.tbxPhoneNumber.TabIndex = 10;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxEmail.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbxEmail.Location = new System.Drawing.Point(428, 262);
            this.tbxEmail.MaxLength = 100;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(262, 30);
            this.tbxEmail.TabIndex = 11;
            // 
            // tbxNum
            // 
            this.tbxNum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxNum.Location = new System.Drawing.Point(428, 322);
            this.tbxNum.MaxLength = 11;
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.ReadOnly = true;
            this.tbxNum.Size = new System.Drawing.Size(262, 30);
            this.tbxNum.TabIndex = 12;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(382, 436);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(73, 41);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "등록";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModi
            // 
            this.btnModi.Location = new System.Drawing.Point(461, 436);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(73, 41);
            this.btnModi.TabIndex = 14;
            this.btnModi.Text = "수정";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(540, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 41);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(619, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 41);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lBMemberList
            // 
            this.lBMemberList.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lBMemberList.ItemHeight = 20;
            this.lBMemberList.Location = new System.Drawing.Point(12, 17);
            this.lBMemberList.Name = "lBMemberList";
            this.lBMemberList.ScrollAlwaysVisible = true;
            this.lBMemberList.Size = new System.Drawing.Size(261, 444);
            this.lBMemberList.TabIndex = 19;
            this.lBMemberList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBMemberList_MouseDoubleClick);
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbxId.Location = new System.Drawing.Point(428, 384);
            this.tbxId.MaxLength = 50;
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(262, 30);
            this.tbxId.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(293, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "사용자 ID: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 495);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lBMemberList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.tbxPosition);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxPosition;
        public System.Windows.Forms.TextBox tbxPhoneNumber;
        public System.Windows.Forms.TextBox tbxEmail;
        public System.Windows.Forms.TextBox tbxNum;
        public System.Windows.Forms.DateTimePicker dtpBirthday;
        public System.Windows.Forms.ListBox lBMemberList;
        public System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label7;
    }
}

