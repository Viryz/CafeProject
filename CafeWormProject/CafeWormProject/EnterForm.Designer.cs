﻿namespace CafeWormProject
{
    partial class EnterForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrentMoney = new System.Windows.Forms.TextBox();
            this.textBoxNeedMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current money: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Need money: ";
            // 
            // textBoxCurrentMoney
            // 
            this.textBoxCurrentMoney.Location = new System.Drawing.Point(21, 34);
            this.textBoxCurrentMoney.Name = "textBoxCurrentMoney";
            this.textBoxCurrentMoney.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentMoney.TabIndex = 3;
            this.textBoxCurrentMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCurrentMoney_KeyPress);
            // 
            // textBoxNeedMoney
            // 
            this.textBoxNeedMoney.Location = new System.Drawing.Point(21, 77);
            this.textBoxNeedMoney.Name = "textBoxNeedMoney";
            this.textBoxNeedMoney.Size = new System.Drawing.Size(100, 20);
            this.textBoxNeedMoney.TabIndex = 4;
            this.textBoxNeedMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCurrentMoney_KeyPress);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 122);
            this.Controls.Add(this.textBoxNeedMoney);
            this.Controls.Add(this.textBoxCurrentMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "EnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrentMoney;
        private System.Windows.Forms.TextBox textBoxNeedMoney;
    }
}