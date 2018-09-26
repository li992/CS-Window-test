namespace CS_Window_test
{
    partial class FrontEnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginID = new System.Windows.Forms.TextBox();
            this.LoginPWD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataReturn = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name: Regwcorpdb02v";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginID
            // 
            this.LoginID.Location = new System.Drawing.Point(194, 84);
            this.LoginID.Name = "LoginID";
            this.LoginID.Size = new System.Drawing.Size(100, 20);
            this.LoginID.TabIndex = 2;
            // 
            // LoginPWD
            // 
            this.LoginPWD.Location = new System.Drawing.Point(194, 110);
            this.LoginPWD.Name = "LoginPWD";
            this.LoginPWD.Size = new System.Drawing.Size(100, 20);
            this.LoginPWD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "USER ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "USER PASSWORD:";
            // 
            // DataReturn
            // 
            this.DataReturn.Location = new System.Drawing.Point(34, 217);
            this.DataReturn.Name = "DataReturn";
            this.DataReturn.Size = new System.Drawing.Size(415, 280);
            this.DataReturn.TabIndex = 6;
            this.DataReturn.Text = "";
            // 
            // FrontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 563);
            this.Controls.Add(this.DataReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginPWD);
            this.Controls.Add(this.LoginID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FrontEnd";
            this.Text = "FrontEnd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LoginID;
        private System.Windows.Forms.TextBox LoginPWD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DataReturn;
    }
}