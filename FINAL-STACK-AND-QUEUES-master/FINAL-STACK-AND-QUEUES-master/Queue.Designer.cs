namespace FINAL_STACK_AND_QUEUES
{
    partial class Queue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Queue));
            btnQue = new Button();
            btnDeq = new Button();
            btnPeek = new Button();
            textBox1 = new TextBox();
            dgvQueue = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvQueue).BeginInit();
            SuspendLayout();
            // 
            // btnQue
            // 
            btnQue.BackColor = Color.Goldenrod;
            btnQue.FlatStyle = FlatStyle.Flat;
            btnQue.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQue.Location = new Point(56, 282);
            btnQue.Margin = new Padding(2, 2, 2, 2);
            btnQue.Name = "btnQue";
            btnQue.Size = new Size(83, 31);
            btnQue.TabIndex = 2;
            btnQue.Text = "Queue";
            btnQue.UseVisualStyleBackColor = false;
            btnQue.Click += button2_Click;
            // 
            // btnDeq
            // 
            btnDeq.BackColor = Color.Goldenrod;
            btnDeq.FlatStyle = FlatStyle.Flat;
            btnDeq.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeq.Location = new Point(160, 282);
            btnDeq.Margin = new Padding(2, 2, 2, 2);
            btnDeq.Name = "btnDeq";
            btnDeq.Size = new Size(83, 31);
            btnDeq.TabIndex = 3;
            btnDeq.Text = "dequeue";
            btnDeq.UseVisualStyleBackColor = false;
            btnDeq.Click += button1_Click_1;
            // 
            // btnPeek
            // 
            btnPeek.BackColor = Color.Goldenrod;
            btnPeek.FlatStyle = FlatStyle.Flat;
            btnPeek.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPeek.Location = new Point(106, 331);
            btnPeek.Margin = new Padding(2, 2, 2, 2);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(84, 33);
            btnPeek.TabIndex = 4;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = false;
            btnPeek.Click += btnPeek_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(100, 181);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvQueue
            // 
            dgvQueue.BackgroundColor = Color.Goldenrod;
            dgvQueue.BorderStyle = BorderStyle.Fixed3D;
            dgvQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueue.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgvQueue.GridColor = Color.Khaki;
            dgvQueue.Location = new Point(270, 149);
            dgvQueue.Margin = new Padding(2, 2, 2, 2);
            dgvQueue.Name = "dgvQueue";
            dgvQueue.RowHeadersWidth = 62;
            dgvQueue.Size = new Size(182, 162);
            dgvQueue.TabIndex = 6;
            dgvQueue.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Queue";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 67;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(401, 11);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 28);
            button1.TabIndex = 13;
            button1.Text = "menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 140);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 15;
            label1.Text = "QUEUE";
            // 
            // Queue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(473, 387);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dgvQueue);
            Controls.Add(textBox1);
            Controls.Add(btnPeek);
            Controls.Add(btnDeq);
            Controls.Add(btnQue);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Queue";
            Text = "Queue";
            Load += Queue_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQueue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQue;
        private Button btnDeq;
        private Button btnPeek;
        private TextBox textBox1;
        private DataGridView dgvQueue;
        private DataGridViewTextBoxColumn Column1;
        private Button button1;
        private Label label1;
    }
}