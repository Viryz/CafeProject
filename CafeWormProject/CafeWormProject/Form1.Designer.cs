namespace CafeWormProject
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
            this.groupBoxMoney = new System.Windows.Forms.GroupBox();
            this.labelCurrentMoney = new System.Windows.Forms.Label();
            this.labelRequest = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.pictureBoxClient = new System.Windows.Forms.PictureBox();
            this.pictureBoxCofe = new System.Windows.Forms.PictureBox();
            this.pictureBoxTea = new System.Windows.Forms.PictureBox();
            this.pictureBoxIceCream = new System.Windows.Forms.PictureBox();
            this.radioButtonCofe = new System.Windows.Forms.RadioButton();
            this.radioButtonTea = new System.Windows.Forms.RadioButton();
            this.radioButtonIceCream = new System.Windows.Forms.RadioButton();
            this.buttonSendAnswer = new System.Windows.Forms.Button();
            this.labelNewClient = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNeedMoney = new System.Windows.Forms.Label();
            this.groupBoxMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCofe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIceCream)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMoney
            // 
            this.groupBoxMoney.Controls.Add(this.labelNeedMoney);
            this.groupBoxMoney.Controls.Add(this.labelCurrentMoney);
            this.groupBoxMoney.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMoney.Name = "groupBoxMoney";
            this.groupBoxMoney.Size = new System.Drawing.Size(129, 89);
            this.groupBoxMoney.TabIndex = 1;
            this.groupBoxMoney.TabStop = false;
            this.groupBoxMoney.Text = "Money:";
            // 
            // labelCurrentMoney
            // 
            this.labelCurrentMoney.AutoSize = true;
            this.labelCurrentMoney.Location = new System.Drawing.Point(6, 30);
            this.labelCurrentMoney.Name = "labelCurrentMoney";
            this.labelCurrentMoney.Size = new System.Drawing.Size(81, 13);
            this.labelCurrentMoney.TabIndex = 1;
            this.labelCurrentMoney.Text = "Current money: ";
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Location = new System.Drawing.Point(335, 108);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(42, 13);
            this.labelRequest.TabIndex = 2;
            this.labelRequest.Text = "request";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(231, 221);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(41, 13);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "answer";
            // 
            // pictureBoxClient
            // 
            this.pictureBoxClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxClient.Location = new System.Drawing.Point(611, 55);
            this.pictureBoxClient.Name = "pictureBoxClient";
            this.pictureBoxClient.Size = new System.Drawing.Size(330, 205);
            this.pictureBoxClient.TabIndex = 4;
            this.pictureBoxClient.TabStop = false;
            // 
            // pictureBoxCofe
            // 
            this.pictureBoxCofe.BackgroundImage = global::CafeWormProject.Properties.Resources.food_02;
            this.pictureBoxCofe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCofe.Location = new System.Drawing.Point(25, 48);
            this.pictureBoxCofe.Name = "pictureBoxCofe";
            this.pictureBoxCofe.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxCofe.TabIndex = 5;
            this.pictureBoxCofe.TabStop = false;
            // 
            // pictureBoxTea
            // 
            this.pictureBoxTea.BackgroundImage = global::CafeWormProject.Properties.Resources.food_03;
            this.pictureBoxTea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxTea.Location = new System.Drawing.Point(273, 48);
            this.pictureBoxTea.Name = "pictureBoxTea";
            this.pictureBoxTea.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxTea.TabIndex = 6;
            this.pictureBoxTea.TabStop = false;
            // 
            // pictureBoxIceCream
            // 
            this.pictureBoxIceCream.BackgroundImage = global::CafeWormProject.Properties.Resources.food_01;
            this.pictureBoxIceCream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIceCream.Location = new System.Drawing.Point(524, 48);
            this.pictureBoxIceCream.Name = "pictureBoxIceCream";
            this.pictureBoxIceCream.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxIceCream.TabIndex = 7;
            this.pictureBoxIceCream.TabStop = false;
            // 
            // radioButtonCofe
            // 
            this.radioButtonCofe.AutoSize = true;
            this.radioButtonCofe.Location = new System.Drawing.Point(25, 154);
            this.radioButtonCofe.Name = "radioButtonCofe";
            this.radioButtonCofe.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCofe.TabIndex = 8;
            this.radioButtonCofe.TabStop = true;
            this.radioButtonCofe.Text = "Coffee";
            this.radioButtonCofe.UseVisualStyleBackColor = true;
            // 
            // radioButtonTea
            // 
            this.radioButtonTea.AutoSize = true;
            this.radioButtonTea.Location = new System.Drawing.Point(273, 154);
            this.radioButtonTea.Name = "radioButtonTea";
            this.radioButtonTea.Size = new System.Drawing.Size(44, 17);
            this.radioButtonTea.TabIndex = 9;
            this.radioButtonTea.TabStop = true;
            this.radioButtonTea.Text = "Tea";
            this.radioButtonTea.UseVisualStyleBackColor = true;
            // 
            // radioButtonIceCream
            // 
            this.radioButtonIceCream.AutoSize = true;
            this.radioButtonIceCream.Location = new System.Drawing.Point(524, 154);
            this.radioButtonIceCream.Name = "radioButtonIceCream";
            this.radioButtonIceCream.Size = new System.Drawing.Size(72, 17);
            this.radioButtonIceCream.TabIndex = 10;
            this.radioButtonIceCream.TabStop = true;
            this.radioButtonIceCream.Text = "Ice cream";
            this.radioButtonIceCream.UseVisualStyleBackColor = true;
            // 
            // buttonSendAnswer
            // 
            this.buttonSendAnswer.Location = new System.Drawing.Point(825, 425);
            this.buttonSendAnswer.Name = "buttonSendAnswer";
            this.buttonSendAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonSendAnswer.TabIndex = 11;
            this.buttonSendAnswer.Text = "OK";
            this.buttonSendAnswer.UseVisualStyleBackColor = true;
            this.buttonSendAnswer.Click += new System.EventHandler(this.buttonSendAnswer_Click);
            // 
            // labelNewClient
            // 
            this.labelNewClient.AutoSize = true;
            this.labelNewClient.Location = new System.Drawing.Point(753, 281);
            this.labelNewClient.Name = "labelNewClient";
            this.labelNewClient.Size = new System.Drawing.Size(55, 13);
            this.labelNewClient.TabIndex = 12;
            this.labelNewClient.Text = "new client";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxCofe);
            this.groupBox2.Controls.Add(this.pictureBoxTea);
            this.groupBox2.Controls.Add(this.pictureBoxIceCream);
            this.groupBox2.Controls.Add(this.radioButtonIceCream);
            this.groupBox2.Controls.Add(this.radioButtonCofe);
            this.groupBox2.Controls.Add(this.radioButtonTea);
            this.groupBox2.Location = new System.Drawing.Point(60, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 195);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // labelNeedMoney
            // 
            this.labelNeedMoney.AutoSize = true;
            this.labelNeedMoney.Location = new System.Drawing.Point(6, 57);
            this.labelNeedMoney.Name = "labelNeedMoney";
            this.labelNeedMoney.Size = new System.Drawing.Size(73, 13);
            this.labelNeedMoney.TabIndex = 2;
            this.labelNeedMoney.Text = "Need money: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelNewClient);
            this.Controls.Add(this.buttonSendAnswer);
            this.Controls.Add(this.pictureBoxClient);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.groupBoxMoney);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxMoney.ResumeLayout(false);
            this.groupBoxMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCofe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIceCream)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMoney;
        private System.Windows.Forms.Label labelCurrentMoney;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.PictureBox pictureBoxClient;
        private System.Windows.Forms.PictureBox pictureBoxCofe;
        private System.Windows.Forms.PictureBox pictureBoxTea;
        private System.Windows.Forms.PictureBox pictureBoxIceCream;
        private System.Windows.Forms.RadioButton radioButtonCofe;
        private System.Windows.Forms.RadioButton radioButtonTea;
        private System.Windows.Forms.RadioButton radioButtonIceCream;
        private System.Windows.Forms.Button buttonSendAnswer;
        private System.Windows.Forms.Label labelNewClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNeedMoney;
    }
}

