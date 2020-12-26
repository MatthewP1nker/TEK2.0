namespace TEK_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSMS = new System.Windows.Forms.Label();
            this.labelEnternet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.ForeColor = System.Drawing.Color.Teal;
            this.labelBalance.Location = new System.Drawing.Point(200, 214);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(36, 39);
            this.labelBalance.TabIndex = 1;
            this.labelBalance.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(44, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Баланс:";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMin.ForeColor = System.Drawing.Color.Teal;
            this.labelMin.Location = new System.Drawing.Point(26, 344);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(26, 29);
            this.labelMin.TabIndex = 3;
            this.labelMin.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(12, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Минут:";
            // 
            // labelSMS
            // 
            this.labelSMS.AutoSize = true;
            this.labelSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSMS.ForeColor = System.Drawing.Color.Teal;
            this.labelSMS.Location = new System.Drawing.Point(301, 344);
            this.labelSMS.Name = "labelSMS";
            this.labelSMS.Size = new System.Drawing.Size(26, 29);
            this.labelSMS.TabIndex = 5;
            this.labelSMS.Text = "0";
            // 
            // labelEnternet
            // 
            this.labelEnternet.AutoSize = true;
            this.labelEnternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnternet.ForeColor = System.Drawing.Color.Teal;
            this.labelEnternet.Location = new System.Drawing.Point(153, 344);
            this.labelEnternet.Name = "labelEnternet";
            this.labelEnternet.Size = new System.Drawing.Size(26, 29);
            this.labelEnternet.TabIndex = 6;
            this.labelEnternet.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(299, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "SMS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(111, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "ГБ интернета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(10, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "anon";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(397, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 76);
            this.button2.TabIndex = 11;
            this.button2.Text = "Пополнить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(353, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 107);
            this.button1.TabIndex = 10;
            this.button1.Text = "Изменить тариф";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Teal;
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Тариф абсолютный",
            "Эко-тариф",
            "Тариф от Кодзимы"});
            this.comboBox3.Location = new System.Drawing.Point(174, 452);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(33, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Тариф:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Teal;
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(694, 233);
            this.maskedTextBox1.Mask = "999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(237, 20);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.Font = new System.Drawing.Font("BRUSHSTRIKE", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.Location = new System.Drawing.Point(694, 408);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(221, 93);
            this.buttonInfo.TabIndex = 15;
            this.buttonInfo.Text = "Инфо";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(623, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(378, 31);
            this.label14.TabIndex = 14;
            this.label14.Text = "Пополнить баланс на сумму:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "TEK";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(452, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(66, 26);
            this.labelDate.TabIndex = 17;
            this.labelDate.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 72);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1036, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSMS);
            this.Controls.Add(this.labelEnternet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSMS;
        private System.Windows.Forms.Label labelEnternet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerDate;
    }
}

