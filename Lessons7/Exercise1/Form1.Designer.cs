namespace Exercise1
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
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelMyCommand = new System.Windows.Forms.Label();
            this.Ко = new System.Windows.Forms.Label();
            this.labelMyNum = new System.Windows.Forms.Label();
            this.butBack = new System.Windows.Forms.Button();
            this.butMenu = new System.Windows.Forms.Button();
            this.butSum1 = new System.Windows.Forms.Button();
            this.butMult2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.butPlay = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackgroundImage = global::Exercise1.Properties.Resources.maxresdefault__3_;
            this.panelGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelGame.Controls.Add(this.labelMyCommand);
            this.panelGame.Controls.Add(this.Ко);
            this.panelGame.Controls.Add(this.labelMyNum);
            this.panelGame.Controls.Add(this.butBack);
            this.panelGame.Controls.Add(this.butMenu);
            this.panelGame.Controls.Add(this.butSum1);
            this.panelGame.Controls.Add(this.butMult2);
            this.panelGame.Controls.Add(this.groupBox1);
            this.panelGame.Location = new System.Drawing.Point(390, 2);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(382, 423);
            this.panelGame.TabIndex = 1;
            // 
            // labelMyCommand
            // 
            this.labelMyCommand.BackColor = System.Drawing.Color.Transparent;
            this.labelMyCommand.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.labelMyCommand.Location = new System.Drawing.Point(110, 327);
            this.labelMyCommand.Name = "labelMyCommand";
            this.labelMyCommand.Size = new System.Drawing.Size(132, 27);
            this.labelMyCommand.TabIndex = 8;
            this.labelMyCommand.Text = "0";
            this.labelMyCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMyCommand.Click += new System.EventHandler(this.labelMyCommand_Click);
            // 
            // Ко
            // 
            this.Ко.BackColor = System.Drawing.Color.Transparent;
            this.Ко.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ко.Location = new System.Drawing.Point(106, 310);
            this.Ко.Name = "Ко";
            this.Ко.Size = new System.Drawing.Size(136, 17);
            this.Ко.TabIndex = 7;
            this.Ко.Text = "Количество команд";
            this.Ко.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMyNum
            // 
            this.labelMyNum.BackColor = System.Drawing.Color.Transparent;
            this.labelMyNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMyNum.Font = new System.Drawing.Font("Segoe Print", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMyNum.Location = new System.Drawing.Point(100, 240);
            this.labelMyNum.Name = "labelMyNum";
            this.labelMyNum.Size = new System.Drawing.Size(133, 44);
            this.labelMyNum.TabIndex = 6;
            this.labelMyNum.Text = "1";
            this.labelMyNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMyNum.Click += new System.EventHandler(this.labelMyNum_Click);
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.Transparent;
            this.butBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.butBack.FlatAppearance.BorderSize = 2;
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.butBack.ForeColor = System.Drawing.Color.Black;
            this.butBack.Location = new System.Drawing.Point(19, 379);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(132, 41);
            this.butBack.TabIndex = 5;
            this.butBack.Text = "Отмена";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butMenu
            // 
            this.butMenu.BackColor = System.Drawing.Color.Transparent;
            this.butMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.butMenu.FlatAppearance.BorderSize = 2;
            this.butMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMenu.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMenu.Location = new System.Drawing.Point(246, 379);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(117, 41);
            this.butMenu.TabIndex = 4;
            this.butMenu.Text = "В меню";
            this.butMenu.UseVisualStyleBackColor = false;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // butSum1
            // 
            this.butSum1.BackColor = System.Drawing.Color.Transparent;
            this.butSum1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.butSum1.FlatAppearance.BorderSize = 2;
            this.butSum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSum1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSum1.Location = new System.Drawing.Point(255, 245);
            this.butSum1.Name = "butSum1";
            this.butSum1.Size = new System.Drawing.Size(75, 44);
            this.butSum1.TabIndex = 3;
            this.butSum1.Text = "+1";
            this.butSum1.UseVisualStyleBackColor = false;
            this.butSum1.Click += new System.EventHandler(this.butSum1_Click);
            // 
            // butMult2
            // 
            this.butMult2.BackColor = System.Drawing.Color.Transparent;
            this.butMult2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.butMult2.FlatAppearance.BorderSize = 2;
            this.butMult2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMult2.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butMult2.Location = new System.Drawing.Point(255, 310);
            this.butMult2.Name = "butMult2";
            this.butMult2.Size = new System.Drawing.Size(75, 42);
            this.butMult2.TabIndex = 2;
            this.butMult2.Text = "*2";
            this.butMult2.UseVisualStyleBackColor = false;
            this.butMult2.Click += new System.EventHandler(this.butMult2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelCommand);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(55, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задание";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.labelCommand.Location = new System.Drawing.Point(107, 46);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(30, 35);
            this.labelCommand.TabIndex = 4;
            this.labelCommand.Text = "0";
            this.labelCommand.Click += new System.EventHandler(this.labelCommand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ходов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "За";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold);
            this.labelNum.Location = new System.Drawing.Point(157, 17);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(30, 35);
            this.labelNum.TabIndex = 1;
            this.labelNum.Text = "0";
            this.labelNum.Click += new System.EventHandler(this.labelNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наберите число:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = global::Exercise1.Properties.Resources._1621333255_19_phonoteka_org_p_krasivii_fon_dlya_menyu_igri_19__2_;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMenu.Controls.Add(this.butPlay);
            this.panelMenu.Controls.Add(this.butExit);
            this.panelMenu.Location = new System.Drawing.Point(2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(391, 423);
            this.panelMenu.TabIndex = 0;
            // 
            // butPlay
            // 
            this.butPlay.BackColor = System.Drawing.Color.Transparent;
            this.butPlay.FlatAppearance.BorderSize = 0;
            this.butPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPlay.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPlay.Location = new System.Drawing.Point(126, 90);
            this.butPlay.Name = "butPlay";
            this.butPlay.Size = new System.Drawing.Size(124, 47);
            this.butPlay.TabIndex = 3;
            this.butPlay.Text = "Play";
            this.butPlay.UseVisualStyleBackColor = false;
            this.butPlay.Click += new System.EventHandler(this.butPlay_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Transparent;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.Location = new System.Drawing.Point(143, 159);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(89, 46);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 424);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Игры в набор числа";
            this.panelGame.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butMenu;
        private System.Windows.Forms.Button butSum1;
        private System.Windows.Forms.Button butMult2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butPlay;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMyCommand;
        private System.Windows.Forms.Label Ко;
        private System.Windows.Forms.Label labelMyNum;
    }
}

