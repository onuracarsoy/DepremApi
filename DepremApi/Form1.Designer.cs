namespace DepremApi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mag1Txt = new System.Windows.Forms.Label();
            this.mag2Txt = new System.Windows.Forms.Label();
            this.mag3Txt = new System.Windows.Forms.Label();
            this.mag4Txt = new System.Windows.Forms.Label();
            this.mag5Txt = new System.Windows.Forms.Label();
            this.mag6Txt = new System.Windows.Forms.Label();
            this.mag7Txt = new System.Windows.Forms.Label();
            this.mag8Txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1123, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tarih";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Şehir";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Büyüklük";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Derinlik";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Koordinatlar";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mag1Txt
            // 
            this.mag1Txt.AutoSize = true;
            this.mag1Txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag1Txt.Location = new System.Drawing.Point(41, 142);
            this.mag1Txt.Name = "mag1Txt";
            this.mag1Txt.Size = new System.Drawing.Size(44, 32);
            this.mag1Txt.TabIndex = 1;
            this.mag1Txt.Text = "10";

            // 
            // mag2Txt
            // 
            this.mag2Txt.AutoSize = true;
            this.mag2Txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag2Txt.Location = new System.Drawing.Point(170, 142);
            this.mag2Txt.Name = "mag2Txt";
            this.mag2Txt.Size = new System.Drawing.Size(44, 32);
            this.mag2Txt.TabIndex = 2;
            this.mag2Txt.Text = "10";
            // 
            // mag3Txt
            // 
            this.mag3Txt.AutoSize = true;
            this.mag3Txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag3Txt.Location = new System.Drawing.Point(314, 142);
            this.mag3Txt.Name = "mag3Txt";
            this.mag3Txt.Size = new System.Drawing.Size(44, 32);
            this.mag3Txt.TabIndex = 3;
            this.mag3Txt.Text = "10";
            // 
            // mag4Txt
            // 
            this.mag4Txt.AutoSize = true;
            this.mag4Txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag4Txt.Location = new System.Drawing.Point(462, 142);
            this.mag4Txt.Name = "mag4Txt";
            this.mag4Txt.Size = new System.Drawing.Size(44, 32);
            this.mag4Txt.TabIndex = 4;
            this.mag4Txt.Text = "10";
            // 
            // mag5Txt
            // 
            this.mag5Txt.AutoSize = true;
            this.mag5Txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag5Txt.Location = new System.Drawing.Point(595, 142);
            this.mag5Txt.Name = "mag5Txt";
            this.mag5Txt.Size = new System.Drawing.Size(44, 32);
            this.mag5Txt.TabIndex = 5;
            this.mag5Txt.Text = "10";
            // 
            // mag6Txt
            // 
            this.mag6Txt.AutoSize = true;
            this.mag6Txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag6Txt.Location = new System.Drawing.Point(745, 142);
            this.mag6Txt.Name = "mag6Txt";
            this.mag6Txt.Size = new System.Drawing.Size(44, 32);
            this.mag6Txt.TabIndex = 6;
            this.mag6Txt.Text = "10";
            // 
            // mag7Txt
            // 
            this.mag7Txt.AutoSize = true;
            this.mag7Txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag7Txt.Location = new System.Drawing.Point(900, 142);
            this.mag7Txt.Name = "mag7Txt";
            this.mag7Txt.Size = new System.Drawing.Size(44, 32);
            this.mag7Txt.TabIndex = 7;
            this.mag7Txt.Text = "10";
            // 
            // mag8Txt
            // 
            this.mag8Txt.AutoSize = true;
            this.mag8Txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mag8Txt.Location = new System.Drawing.Point(1031, 142);
            this.mag8Txt.Name = "mag8Txt";
            this.mag8Txt.Size = new System.Drawing.Size(44, 32);
            this.mag8Txt.TabIndex = 8;
            this.mag8Txt.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "1<=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "2<=";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "3<=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "5<=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "6<=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "4<=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(888, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "7<=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1019, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 34);
            this.label8.TabIndex = 17;
            this.label8.Text = "8<=";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.totalTxt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mag1Txt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.mag2Txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mag3Txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mag4Txt);
            this.panel1.Controls.Add(this.mag5Txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mag6Txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mag7Txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mag8Txt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 270);
            this.panel1.TabIndex = 18;

            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(592, 41);
            this.label9.TabIndex = 18;
            this.label9.Text = "Büyüklük Sayısına Göre Depremler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Toplam = ";
            // 
            // totalTxt
            // 
            this.totalTxt.AutoSize = true;
            this.totalTxt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.Location = new System.Drawing.Point(149, 227);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(44, 32);
            this.totalTxt.TabIndex = 20;
            this.totalTxt.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1147, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earthquake";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label mag1Txt;
        private System.Windows.Forms.Label mag2Txt;
        private System.Windows.Forms.Label mag3Txt;
        private System.Windows.Forms.Label mag4Txt;
        private System.Windows.Forms.Label mag5Txt;
        private System.Windows.Forms.Label mag6Txt;
        private System.Windows.Forms.Label mag7Txt;
        private System.Windows.Forms.Label mag8Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalTxt;
    }
}

