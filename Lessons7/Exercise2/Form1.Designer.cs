namespace Exercise2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxMyNumber = new System.Windows.Forms.TextBox();
            this.butTry = new System.Windows.Forms.Button();
            this.butPlayRestart = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountTry = new System.Windows.Forms.Label();
            this.labelMoreLess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загаданно число от 0 до 100. Угадайте его!!";
            // 
            // tBoxMyNumber
            // 
            this.tBoxMyNumber.Enabled = false;
            this.tBoxMyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxMyNumber.Location = new System.Drawing.Point(19, 74);
            this.tBoxMyNumber.MaxLength = 10;
            this.tBoxMyNumber.Name = "tBoxMyNumber";
            this.tBoxMyNumber.Size = new System.Drawing.Size(100, 26);
            this.tBoxMyNumber.TabIndex = 4;
            this.tBoxMyNumber.TextChanged += new System.EventHandler(this.tBoxMyNumber_TextChanged);
            this.tBoxMyNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxMyNumber_KeyPress);
            // 
            // butTry
            // 
            this.butTry.Enabled = false;
            this.butTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTry.Location = new System.Drawing.Point(31, 109);
            this.butTry.Name = "butTry";
            this.butTry.Size = new System.Drawing.Size(75, 23);
            this.butTry.TabIndex = 2;
            this.butTry.Text = "Проверить";
            this.butTry.UseVisualStyleBackColor = true;
            this.butTry.Click += new System.EventHandler(this.butTry_Click);
            // 
            // butPlayRestart
            // 
            this.butPlayRestart.Location = new System.Drawing.Point(218, 71);
            this.butPlayRestart.Name = "butPlayRestart";
            this.butPlayRestart.Size = new System.Drawing.Size(75, 23);
            this.butPlayRestart.TabIndex = 3;
            this.butPlayRestart.Text = "Играть";
            this.butPlayRestart.UseVisualStyleBackColor = true;
            this.butPlayRestart.Click += new System.EventHandler(this.butPlayRestart_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(218, 100);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "Выход";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сделано попыток:";
            // 
            // labelCountTry
            // 
            this.labelCountTry.AutoSize = true;
            this.labelCountTry.BackColor = System.Drawing.Color.Transparent;
            this.labelCountTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCountTry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCountTry.Location = new System.Drawing.Point(152, 164);
            this.labelCountTry.Name = "labelCountTry";
            this.labelCountTry.Size = new System.Drawing.Size(16, 17);
            this.labelCountTry.TabIndex = 6;
            this.labelCountTry.Text = "0";
            // 
            // labelMoreLess
            // 
            this.labelMoreLess.BackColor = System.Drawing.Color.Transparent;
            this.labelMoreLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMoreLess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMoreLess.Location = new System.Drawing.Point(19, 35);
            this.labelMoreLess.Name = "labelMoreLess";
            this.labelMoreLess.Size = new System.Drawing.Size(300, 23);
            this.labelMoreLess.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exercise2.Properties.Resources._1613566936_136_p_fon_dlya_prezentatsii_po_informatike_157;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(331, 205);
            this.Controls.Add(this.labelMoreLess);
            this.Controls.Add(this.labelCountTry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butPlayRestart);
            this.Controls.Add(this.butTry);
            this.Controls.Add(this.tBoxMyNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMyNumber;
        private System.Windows.Forms.Button butTry;
        private System.Windows.Forms.Button butPlayRestart;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountTry;
        private System.Windows.Forms.Label labelMoreLess;
    }
}

