namespace Vip
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MemberView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.None = new System.Windows.Forms.RadioButton();
            this.VIP = new System.Windows.Forms.RadioButton();
            this.VVIP = new System.Windows.Forms.RadioButton();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.JuminBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Del_JuminBox = new System.Windows.Forms.TextBox();
            this.Del_NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Delbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Find_Phonenum_Box = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.Look_log = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Log = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MemberView);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(845, 619);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "회원 리스트";
            // 
            // MemberView
            // 
            this.MemberView.AllowUserToAddRows = false;
            this.MemberView.AllowUserToDeleteRows = false;
            this.MemberView.AutoGenerateColumns = false;
            this.MemberView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MemberView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.juminDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.addTimeDataGridViewTextBoxColumn});
            this.MemberView.DataSource = this.memberBindingSource;
            this.MemberView.GridColor = System.Drawing.Color.Black;
            this.MemberView.Location = new System.Drawing.Point(6, 20);
            this.MemberView.Name = "MemberView";
            this.MemberView.ReadOnly = true;
            this.MemberView.RowTemplate.Height = 23;
            this.MemberView.Size = new System.Drawing.Size(833, 593);
            this.MemberView.TabIndex = 0;
            this.MemberView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberView_CellClick);
            this.MemberView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MemberView_CellFormatting);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // juminDataGridViewTextBoxColumn
            // 
            this.juminDataGridViewTextBoxColumn.DataPropertyName = "Jumin";
            this.juminDataGridViewTextBoxColumn.HeaderText = "Jumin";
            this.juminDataGridViewTextBoxColumn.Name = "juminDataGridViewTextBoxColumn";
            this.juminDataGridViewTextBoxColumn.ReadOnly = true;
            this.juminDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            this.phoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // addTimeDataGridViewTextBoxColumn
            // 
            this.addTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.addTimeDataGridViewTextBoxColumn.DataPropertyName = "AddTime";
            this.addTimeDataGridViewTextBoxColumn.HeaderText = "AddTime";
            this.addTimeDataGridViewTextBoxColumn.Name = "addTimeDataGridViewTextBoxColumn";
            this.addTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.addTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addTimeDataGridViewTextBoxColumn.Width = 81;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(Vip.Member);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Updatebtn);
            this.groupBox1.Controls.Add(this.Addbtn);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.PhoneBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.JuminBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(27, 645);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 186);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원 추가";
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(23, 139);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(142, 23);
            this.Updatebtn.TabIndex = 5;
            this.Updatebtn.Text = "회원 수정";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(23, 108);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(142, 23);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "회원 추가";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.None);
            this.groupBox4.Controls.Add(this.VIP);
            this.groupBox4.Controls.Add(this.VVIP);
            this.groupBox4.Location = new System.Drawing.Point(187, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(157, 90);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "회원 등급";
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Location = new System.Drawing.Point(7, 65);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(47, 16);
            this.None.TabIndex = 8;
            this.None.TabStop = true;
            this.None.Text = "일반";
            this.None.UseVisualStyleBackColor = true;
            // 
            // VIP
            // 
            this.VIP.AutoSize = true;
            this.VIP.Location = new System.Drawing.Point(7, 43);
            this.VIP.Name = "VIP";
            this.VIP.Size = new System.Drawing.Size(42, 16);
            this.VIP.TabIndex = 7;
            this.VIP.TabStop = true;
            this.VIP.Text = "VIP";
            this.VIP.UseVisualStyleBackColor = true;
            // 
            // VVIP
            // 
            this.VVIP.AutoSize = true;
            this.VVIP.Location = new System.Drawing.Point(7, 21);
            this.VVIP.Name = "VVIP";
            this.VVIP.Size = new System.Drawing.Size(50, 16);
            this.VVIP.TabIndex = 6;
            this.VVIP.TabStop = true;
            this.VVIP.Text = "VVIP";
            this.VVIP.UseVisualStyleBackColor = true;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(65, 69);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 21);
            this.PhoneBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "전화번호";
            // 
            // JuminBox
            // 
            this.JuminBox.Location = new System.Drawing.Point(244, 29);
            this.JuminBox.Name = "JuminBox";
            this.JuminBox.Size = new System.Drawing.Size(100, 21);
            this.JuminBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "주민번호";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(65, 29);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 21);
            this.NameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Del_JuminBox);
            this.groupBox2.Controls.Add(this.Del_NameBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Delbtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(788, 661);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 151);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회원 제거";
            // 
            // Del_JuminBox
            // 
            this.Del_JuminBox.Location = new System.Drawing.Point(141, 73);
            this.Del_JuminBox.Name = "Del_JuminBox";
            this.Del_JuminBox.Size = new System.Drawing.Size(100, 21);
            this.Del_JuminBox.TabIndex = 12;
            // 
            // Del_NameBox
            // 
            this.Del_NameBox.Location = new System.Drawing.Point(141, 32);
            this.Del_NameBox.Name = "Del_NameBox";
            this.Del_NameBox.Size = new System.Drawing.Size(100, 21);
            this.Del_NameBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "주민번호";
            // 
            // Delbtn
            // 
            this.Delbtn.Location = new System.Drawing.Point(117, 109);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(75, 23);
            this.Delbtn.TabIndex = 13;
            this.Delbtn.Text = "제거";
            this.Delbtn.UseVisualStyleBackColor = true;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "이름";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(10, 868);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(11, 12);
            this.Time.TabIndex = 12;
            this.Time.Text = "-";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.Find_Phonenum_Box);
            this.groupBox5.Controls.Add(this.Find);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(426, 661);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 151);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "회원 조회";
            // 
            // Find_Phonenum_Box
            // 
            this.Find_Phonenum_Box.Location = new System.Drawing.Point(129, 61);
            this.Find_Phonenum_Box.Name = "Find_Phonenum_Box";
            this.Find_Phonenum_Box.Size = new System.Drawing.Size(100, 21);
            this.Find_Phonenum_Box.TabIndex = 9;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(117, 109);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 10;
            this.Find.Text = "조회";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "전화번호";
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(1165, 753);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(125, 50);
            this.quit.TabIndex = 14;
            this.quit.Text = "종료";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Look_log
            // 
            this.Look_log.Location = new System.Drawing.Point(1165, 674);
            this.Look_log.Name = "Look_log";
            this.Look_log.Size = new System.Drawing.Size(125, 50);
            this.Look_log.TabIndex = 15;
            this.Look_log.Text = "기록 조회하기";
            this.Look_log.UseVisualStyleBackColor = true;
            this.Look_log.Click += new System.EventHandler(this.What_If_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDX,
            this.Log});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(905, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 568);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // IDX
            // 
            this.IDX.Text = "No.";
            this.IDX.Width = 40;
            // 
            // Log
            // 
            this.Log.Text = "기록";
            this.Log.Width = 360;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1344, 889);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Look_log);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView MemberView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton None;
        private System.Windows.Forms.RadioButton VIP;
        private System.Windows.Forms.RadioButton VVIP;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox JuminBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.TextBox Del_JuminBox;
        private System.Windows.Forms.TextBox Del_NameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Find_Phonenum_Box;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button Look_log;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDX;
        private System.Windows.Forms.ColumnHeader Log;
    }
}

