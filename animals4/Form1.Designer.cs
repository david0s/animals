namespace animals4
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
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.AnimalsPicture = new System.Windows.Forms.PictureBox();
            this.buttonQuestion2 = new System.Windows.Forms.Button();
            this.buttonQuestion1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(293, 117);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(73, 23);
            this.buttonTrain.TabIndex = 0;
            this.buttonTrain.Text = "Обучение";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest.Location = new System.Drawing.Point(451, 117);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(86, 23);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = " Тест";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.Location = new System.Drawing.Point(287, 44);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(250, 33);
            this.labelMode.TabIndex = 2;
            this.labelMode.Text = "Выберите Режим";
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.Location = new System.Drawing.Point(50, 38);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(36, 39);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = "?";
            this.labelWord.Visible = false;
            this.labelWord.Click += new System.EventHandler(this.labelWord_Click);
            // 
            // AnimalsPicture
            // 
            this.AnimalsPicture.Image = ((System.Drawing.Image)(resources.GetObject("AnimalsPicture.Image")));
            this.AnimalsPicture.Location = new System.Drawing.Point(213, 81);
            this.AnimalsPicture.Name = "AnimalsPicture";
            this.AnimalsPicture.Size = new System.Drawing.Size(348, 217);
            this.AnimalsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimalsPicture.TabIndex = 4;
            this.AnimalsPicture.TabStop = false;
            this.AnimalsPicture.Visible = false;
            this.AnimalsPicture.Click += new System.EventHandler(this.AnimalsPicture_Click);
            // 
            // buttonQuestion2
            // 
            this.buttonQuestion2.Location = new System.Drawing.Point(630, 107);
            this.buttonQuestion2.Name = "buttonQuestion2";
            this.buttonQuestion2.Size = new System.Drawing.Size(75, 23);
            this.buttonQuestion2.TabIndex = 5;
            this.buttonQuestion2.UseVisualStyleBackColor = true;
            this.buttonQuestion2.Visible = false;
            this.buttonQuestion2.Click += new System.EventHandler(this.buttonQuestion2_Click);
            // 
            // buttonQuestion1
            // 
            this.buttonQuestion1.Location = new System.Drawing.Point(630, 81);
            this.buttonQuestion1.Name = "buttonQuestion1";
            this.buttonQuestion1.Size = new System.Drawing.Size(75, 23);
            this.buttonQuestion1.TabIndex = 6;
            this.buttonQuestion1.UseVisualStyleBackColor = true;
            this.buttonQuestion1.Visible = false;
            this.buttonQuestion1.Click += new System.EventHandler(this.buttonQuestion1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuestion1);
            this.Controls.Add(this.buttonQuestion2);
            this.Controls.Add(this.AnimalsPicture);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.PictureBox AnimalsPicture;
        private System.Windows.Forms.Button buttonQuestion2;
        private System.Windows.Forms.Button buttonQuestion1;
    }
}

