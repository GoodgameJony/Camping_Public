namespace Database
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("회원번호");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("이름");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("전화번호");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("생년월일");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("주소");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("노드25");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("회원", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("창고번호");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("회원번호");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("기간");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("세척여부");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("노드26");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("창고", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("노드4");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("테이블", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("회원 삽입");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("창고 삽입");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("삽입", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("회원 수정");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("창고 수정");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("수정", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("프로시저", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode21});
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_play = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_command = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            treeNode1.Name = "user_number";
            treeNode1.Text = "회원번호";
            treeNode2.Name = "user_name";
            treeNode2.Text = "이름";
            treeNode3.Name = "user_phone";
            treeNode3.Text = "전화번호";
            treeNode4.Name = "user_birth";
            treeNode4.Text = "생년월일";
            treeNode5.Name = "user_ads";
            treeNode5.Text = "주소";
            treeNode6.Name = "노드25";
            treeNode6.Text = "노드25";
            treeNode7.Name = "T_user";
            treeNode7.Text = "회원";
            treeNode8.Name = "storage_number";
            treeNode8.Text = "창고번호";
            treeNode9.Name = "user_number2";
            treeNode9.Text = "회원번호";
            treeNode10.Name = "storage_day";
            treeNode10.Text = "기간";
            treeNode11.Name = "storage_clean";
            treeNode11.Text = "세척여부";
            treeNode12.Name = "노드26";
            treeNode12.Text = "노드26";
            treeNode13.Name = "T_storage";
            treeNode13.Text = "창고";
            treeNode14.Name = "노드4";
            treeNode14.Text = "노드4";
            treeNode15.Name = "Node_table";
            treeNode15.Text = "테이블";
            treeNode16.Name = "insert_user";
            treeNode16.Text = "회원 삽입";
            treeNode17.Name = "insert_storage";
            treeNode17.Text = "창고 삽입";
            treeNode18.Name = "Pro_insert";
            treeNode18.Text = "삽입";
            treeNode19.Name = "update_user";
            treeNode19.Text = "회원 수정";
            treeNode20.Name = "update_storage";
            treeNode20.Text = "창고 수정";
            treeNode21.Name = "Pro_update";
            treeNode21.Text = "수정";
            treeNode22.Name = "Node_procedure";
            treeNode22.Text = "프로시저";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode22});
            this.treeView.Size = new System.Drawing.Size(169, 440);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 440);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_play);
            this.panel2.Controls.Add(this.textBox_result);
            this.panel2.Controls.Add(this.textBox_command);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(743, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 440);
            this.panel2.TabIndex = 2;
            // 
            // button_play
            // 
            this.button_play.Font = new System.Drawing.Font("한컴 윤고딕 230", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_play.Location = new System.Drawing.Point(6, 293);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(191, 57);
            this.button_play.TabIndex = 0;
            this.button_play.Text = "실행";
            this.button_play.UseVisualStyleBackColor = true;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(6, 356);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(191, 81);
            this.textBox_result.TabIndex = 1;
            // 
            // textBox_command
            // 
            this.textBox_command.Location = new System.Drawing.Point(6, 3);
            this.textBox_command.Multiline = true;
            this.textBox_command.Name = "textBox_command";
            this.textBox_command.Size = new System.Drawing.Size(191, 284);
            this.textBox_command.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(174, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(569, 440);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(557, 434);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "창고관리 프로그램";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_command;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

