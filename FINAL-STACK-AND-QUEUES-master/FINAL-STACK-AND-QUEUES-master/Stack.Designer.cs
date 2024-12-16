namespace FINAL_STACK_AND_QUEUES
{
    partial class Stack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stack));
            txtFname = new TextBox();
            txtLname = new TextBox();
            btnPush = new Button();
            btnPeek = new Button();
            btnPop = new Button();
            dgvStack = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            dgvQueue = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).BeginInit();
            SuspendLayout();
            // 
            // txtFname
            // 
            txtFname.BorderStyle = BorderStyle.None;
            txtFname.Location = new Point(96, 136);
            txtFname.Margin = new Padding(2, 2, 2, 2);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(95, 16);
            txtFname.TabIndex = 6;
            txtFname.TextAlign = HorizontalAlignment.Center;
            txtFname.TextChanged += textBox1_TextChanged;
            // 
            // txtLname
            // 
            txtLname.BorderStyle = BorderStyle.None;
            txtLname.Location = new Point(94, 200);
            txtLname.Margin = new Padding(2, 2, 2, 2);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(95, 16);
            txtLname.TabIndex = 7;
            txtLname.TextAlign = HorizontalAlignment.Center;
            txtLname.TextChanged += textBox2_TextChanged;
            // 
            // btnPush
            // 
            btnPush.BackColor = Color.Goldenrod;
            btnPush.FlatStyle = FlatStyle.Flat;
            btnPush.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPush.Location = new Point(57, 280);
            btnPush.Margin = new Padding(2, 2, 2, 2);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(83, 36);
            btnPush.TabIndex = 8;
            btnPush.Text = "PUSH";
            btnPush.UseVisualStyleBackColor = false;
            btnPush.Click += btnQue_Click;
            // 
            // btnPeek
            // 
            btnPeek.BackColor = Color.Goldenrod;
            btnPeek.FlatStyle = FlatStyle.Flat;
            btnPeek.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPeek.Location = new Point(108, 332);
            btnPeek.Margin = new Padding(2, 2, 2, 2);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(83, 32);
            btnPeek.TabIndex = 9;
            btnPeek.Text = "peek";
            btnPeek.UseVisualStyleBackColor = false;
            btnPeek.Click += button1_Click;
            // 
            // btnPop
            // 
            btnPop.BackColor = Color.Goldenrod;
            btnPop.FlatStyle = FlatStyle.Flat;
            btnPop.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPop.Location = new Point(159, 280);
            btnPop.Margin = new Padding(2, 2, 2, 2);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(85, 36);
            btnPop.TabIndex = 10;
            btnPop.Text = "pop";
            btnPop.UseVisualStyleBackColor = false;
            btnPop.Click += button2_Click;
            // 
            // dgvStack
            // 
            dgvStack.BackgroundColor = Color.Goldenrod;
            dgvStack.BorderStyle = BorderStyle.Fixed3D;
            dgvStack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStack.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvStack.GridColor = Color.Khaki;
            dgvStack.Location = new Point(709, 173);
            dgvStack.Name = "dgvStack";
            dgvStack.RowHeadersWidth = 62;
            dgvStack.Size = new Size(347, 300);
            dgvStack.TabIndex = 11;
            dgvStack.CellContentClick += dgvQueue_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Last Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(446, 13);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 28);
            button1.TabIndex = 12;
            button1.Text = "menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dgvQueue
            // 
            dgvQueue.BackgroundColor = Color.Goldenrod;
            dgvQueue.BorderStyle = BorderStyle.Fixed3D;
            dgvQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueue.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column3 });
            dgvQueue.GridColor = Color.Khaki;
            dgvQueue.Location = new Point(271, 149);
            dgvQueue.Margin = new Padding(2, 2, 2, 2);
            dgvQueue.Name = "dgvQueue";
            dgvQueue.RowHeadersWidth = 62;
            dgvQueue.Size = new Size(216, 161);
            dgvQueue.TabIndex = 13;
            dgvQueue.CellContentClick += dgvQueue_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn1.HeaderText = "First Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 89;
            // 
            // Column3
            // 
            Column3.HeaderText = "Last Name";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 97);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 14;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 166);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 15;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // Stack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(526, 397);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvQueue);
            Controls.Add(button1);
            Controls.Add(btnPop);
            Controls.Add(btnPeek);
            Controls.Add(btnPush);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Stack";
            Text = "Stack";
            Load += Stack_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvStack).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFname;
        private TextBox txtLname;
        private Button btnPush;
        private Button btnPeek;
        private Button btnPop;
        private DataGridView dgvStack;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button1;
        private DataGridView dgvQueue;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column3;
        private Label label1;
        private Label label2;
    }
}