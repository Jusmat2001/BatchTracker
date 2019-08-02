namespace BatchTracker
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GetQueuedBatchBtn = new System.Windows.Forms.Button();
            this.BatchNumberSearchBox = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelBox = new System.Windows.Forms.Label();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bBatchRangeBtn = new System.Windows.Forms.RadioButton();
            this.bBatchNumberBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bDateRangeBtn = new System.Windows.Forms.RadioButton();
            this.lbPracticeListbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(190, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 651);
            this.dataGridView1.TabIndex = 0;
            // 
            // GetQueuedBatchBtn
            // 
            this.GetQueuedBatchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetQueuedBatchBtn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetQueuedBatchBtn.Location = new System.Drawing.Point(190, 666);
            this.GetQueuedBatchBtn.Name = "GetQueuedBatchBtn";
            this.GetQueuedBatchBtn.Size = new System.Drawing.Size(161, 27);
            this.GetQueuedBatchBtn.TabIndex = 1;
            this.GetQueuedBatchBtn.Text = " Get All Queued Batches";
            this.GetQueuedBatchBtn.UseVisualStyleBackColor = true;
            this.GetQueuedBatchBtn.Click += new System.EventHandler(this.Populate_btn_Click);
            // 
            // BatchNumberSearchBox
            // 
            this.BatchNumberSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BatchNumberSearchBox.Location = new System.Drawing.Point(10, 162);
            this.BatchNumberSearchBox.Name = "BatchNumberSearchBox";
            this.BatchNumberSearchBox.Size = new System.Drawing.Size(158, 27);
            this.BatchNumberSearchBox.TabIndex = 2;
            // 
            // Search_btn
            // 
            this.Search_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Search_btn.Location = new System.Drawing.Point(10, 337);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(168, 32);
            this.Search_btn.TabIndex = 3;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Active Practices:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBox
            // 
            this.LabelBox.AutoSize = true;
            this.LabelBox.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBox.ForeColor = System.Drawing.Color.Black;
            this.LabelBox.Location = new System.Drawing.Point(704, 676);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Size = new System.Drawing.Size(0, 17);
            this.LabelBox.TabIndex = 6;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchGroupBox.BackColor = System.Drawing.Color.SteelBlue;
            this.SearchGroupBox.Controls.Add(this.label5);
            this.SearchGroupBox.Controls.Add(this.label6);
            this.SearchGroupBox.Controls.Add(this.label4);
            this.SearchGroupBox.Controls.Add(this.textBox2);
            this.SearchGroupBox.Controls.Add(this.textBox1);
            this.SearchGroupBox.Controls.Add(this.bBatchRangeBtn);
            this.SearchGroupBox.Controls.Add(this.bBatchNumberBtn);
            this.SearchGroupBox.Controls.Add(this.label3);
            this.SearchGroupBox.Controls.Add(this.label2);
            this.SearchGroupBox.Controls.Add(this.endDateTimePicker);
            this.SearchGroupBox.Controls.Add(this.BatchNumberSearchBox);
            this.SearchGroupBox.Controls.Add(this.startDateTimePicker);
            this.SearchGroupBox.Controls.Add(this.bDateRangeBtn);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.ForeColor = System.Drawing.Color.Black;
            this.SearchGroupBox.Location = new System.Drawing.Point(4, 9);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(180, 322);
            this.SearchGroupBox.TabIndex = 7;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search by : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "to";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Location = new System.Drawing.Point(10, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 27);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(10, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 27);
            this.textBox1.TabIndex = 7;
            // 
            // bBatchRangeBtn
            // 
            this.bBatchRangeBtn.AutoSize = true;
            this.bBatchRangeBtn.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBatchRangeBtn.Location = new System.Drawing.Point(6, 215);
            this.bBatchRangeBtn.Name = "bBatchRangeBtn";
            this.bBatchRangeBtn.Size = new System.Drawing.Size(125, 21);
            this.bBatchRangeBtn.TabIndex = 6;
            this.bBatchRangeBtn.TabStop = true;
            this.bBatchRangeBtn.Text = "Batch # Range";
            this.bBatchRangeBtn.UseVisualStyleBackColor = true;
            // 
            // bBatchNumberBtn
            // 
            this.bBatchNumberBtn.AutoSize = true;
            this.bBatchNumberBtn.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBatchNumberBtn.Location = new System.Drawing.Point(6, 135);
            this.bBatchNumberBtn.Name = "bBatchNumberBtn";
            this.bBatchNumberBtn.Size = new System.Drawing.Size(124, 21);
            this.bBatchNumberBtn.TabIndex = 5;
            this.bBatchNumberBtn.TabStop = true;
            this.bBatchNumberBtn.Text = "Batch Number";
            this.bBatchNumberBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(59, 84);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.endDateTimePicker.TabIndex = 2;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(59, 56);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // bDateRangeBtn
            // 
            this.bDateRangeBtn.AutoSize = true;
            this.bDateRangeBtn.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDateRangeBtn.Location = new System.Drawing.Point(6, 26);
            this.bDateRangeBtn.Name = "bDateRangeBtn";
            this.bDateRangeBtn.Size = new System.Drawing.Size(171, 21);
            this.bDateRangeBtn.TabIndex = 0;
            this.bDateRangeBtn.TabStop = true;
            this.bDateRangeBtn.Text = "Date range (1 yr max)";
            this.bDateRangeBtn.UseVisualStyleBackColor = true;
            // 
            // lbPracticeListbox
            // 
            this.lbPracticeListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPracticeListbox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPracticeListbox.FormattingEnabled = true;
            this.lbPracticeListbox.ItemHeight = 17;
            this.lbPracticeListbox.Location = new System.Drawing.Point(4, 401);
            this.lbPracticeListbox.MultiColumn = true;
            this.lbPracticeListbox.Name = "lbPracticeListbox";
            this.lbPracticeListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPracticeListbox.Size = new System.Drawing.Size(180, 259);
            this.lbPracticeListbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(0, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 2);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(0, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 2);
            this.label6.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(962, 698);
            this.Controls.Add(this.lbPracticeListbox);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.LabelBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.GetQueuedBatchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Batch Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetQueuedBatchBtn;
        private System.Windows.Forms.TextBox BatchNumberSearchBox;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.RadioButton bBatchRangeBtn;
        private System.Windows.Forms.RadioButton bBatchNumberBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.RadioButton bDateRangeBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbPracticeListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

