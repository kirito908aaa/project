namespace WinFormsApp2
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.changeStatus = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(561, 394);
            this.dataGridView1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(586, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 46);
            this.label8.TabIndex = 42;
            this.label8.Text = "ราคารวม";
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalBox.Location = new System.Drawing.Point(726, 105);
            this.totalBox.Multiline = true;
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(596, 59);
            this.totalBox.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(599, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 46);
            this.label5.TabIndex = 40;
            this.label5.Text = "สถานะ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(584, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 46);
            this.label6.TabIndex = 39;
            this.label6.Text = "เงินทอน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(611, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 46);
            this.label7.TabIndex = 38;
            this.label7.Text = "ใส่เงิน";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1328, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 124);
            this.button4.TabIndex = 37;
            this.button4.Text = "Payment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // changeStatus
            // 
            this.changeStatus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeStatus.Location = new System.Drawing.Point(726, 300);
            this.changeStatus.Multiline = true;
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(596, 59);
            this.changeStatus.TabIndex = 36;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Status.Location = new System.Drawing.Point(726, 235);
            this.Status.Multiline = true;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(596, 59);
            this.Status.TabIndex = 35;
            // 
            // moneyBox
            // 
            this.moneyBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moneyBox.Location = new System.Drawing.Point(726, 170);
            this.moneyBox.Multiline = true;
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(596, 59);
            this.moneyBox.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1328, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 124);
            this.button1.TabIndex = 44;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(933, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 77);
            this.button2.TabIndex = 45;
            this.button2.Text = "โหลดสินค้า";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1517, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.changeStatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.moneyBox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label8;
        private TextBox totalBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button4;
        private TextBox changeStatus;
        private TextBox Status;
        private TextBox moneyBox;
        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}