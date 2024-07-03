namespace ADO_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lbl_crsid = new Label();
            lbl_crsname = new Label();
            lb_crsduration = new Label();
            lbl_topid = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 262);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // lbl_crsid
            // 
            lbl_crsid.AutoSize = true;
            lbl_crsid.Location = new Point(60, 26);
            lbl_crsid.MinimumSize = new Size(100, 25);
            lbl_crsid.Name = "lbl_crsid";
            lbl_crsid.Size = new Size(100, 25);
            lbl_crsid.TabIndex = 1;
            lbl_crsid.Text = "crs_id";
            // 
            // lbl_crsname
            // 
            lbl_crsname.AutoSize = true;
            lbl_crsname.Location = new Point(60, 66);
            lbl_crsname.MinimumSize = new Size(100, 25);
            lbl_crsname.Name = "lbl_crsname";
            lbl_crsname.Size = new Size(100, 25);
            lbl_crsname.TabIndex = 2;
            lbl_crsname.Text = "crs_name";
            // 
            // lb_crsduration
            // 
            lb_crsduration.AutoSize = true;
            lb_crsduration.Location = new Point(60, 108);
            lb_crsduration.MinimumSize = new Size(100, 25);
            lb_crsduration.Name = "lb_crsduration";
            lb_crsduration.Size = new Size(100, 25);
            lb_crsduration.TabIndex = 3;
            lb_crsduration.Text = "crsduration";
            // 
            // lbl_topid
            // 
            lbl_topid.AutoSize = true;
            lbl_topid.Location = new Point(60, 155);
            lbl_topid.MinimumSize = new Size(100, 25);
            lbl_topid.Name = "lbl_topid";
            lbl_topid.Size = new Size(100, 25);
            lbl_topid.TabIndex = 4;
            lbl_topid.Text = "top_id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(527, 26);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(170, 23);
            btn_add.TabIndex = 9;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(527, 66);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(170, 23);
            btn_edit.TabIndex = 10;
            btn_edit.Text = "edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(527, 108);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(170, 23);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_topid);
            Controls.Add(lb_crsduration);
            Controls.Add(lbl_crsname);
            Controls.Add(lbl_crsid);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_crsid;
        private Label lbl_crsname;
        private Label lb_crsduration;
        private Label lbl_topid;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
    }
}
