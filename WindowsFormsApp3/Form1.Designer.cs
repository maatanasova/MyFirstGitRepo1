namespace WindowsFormsApp3
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
            this.lblMainCurrency = new System.Windows.Forms.Label();
            this.cmbMainCurrency = new System.Windows.Forms.ComboBox();
            this.lblTargetCurrency = new System.Windows.Forms.Label();
            this.cmbTargetCurrency = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainCurrency
            // 
            this.lblMainCurrency.AutoSize = true;
            this.lblMainCurrency.Location = new System.Drawing.Point(55, 72);
            this.lblMainCurrency.Name = "lblMainCurrency";
            this.lblMainCurrency.Size = new System.Drawing.Size(93, 13);
            this.lblMainCurrency.TabIndex = 0;
            this.lblMainCurrency.Text = "Изберете валута";
            this.lblMainCurrency.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbMainCurrency
            // 
            this.cmbMainCurrency.FormattingEnabled = true;
            this.cmbMainCurrency.Location = new System.Drawing.Point(58, 88);
            this.cmbMainCurrency.Name = "cmbMainCurrency";
            this.cmbMainCurrency.Size = new System.Drawing.Size(121, 21);
            this.cmbMainCurrency.TabIndex = 1;
            this.cmbMainCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTargetCurrency
            // 
            this.lblTargetCurrency.AutoSize = true;
            this.lblTargetCurrency.Location = new System.Drawing.Point(561, 71);
            this.lblTargetCurrency.Name = "lblTargetCurrency";
            this.lblTargetCurrency.Size = new System.Drawing.Size(93, 13);
            this.lblTargetCurrency.TabIndex = 2;
            this.lblTargetCurrency.Text = "Изберете валута";
            // 
            // cmbTargetCurrency
            // 
            this.cmbTargetCurrency.FormattingEnabled = true;
            this.cmbTargetCurrency.Location = new System.Drawing.Point(564, 87);
            this.cmbTargetCurrency.Name = "cmbTargetCurrency";
            this.cmbTargetCurrency.Size = new System.Drawing.Size(121, 21);
            this.cmbTargetCurrency.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(55, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(234, 88);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(262, 20);
            this.txtCommand.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Въведете сума";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Пресметни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbTargetCurrency);
            this.Controls.Add(this.lblTargetCurrency);
            this.Controls.Add(this.cmbMainCurrency);
            this.Controls.Add(this.lblMainCurrency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainCurrency;
        private System.Windows.Forms.ComboBox cmbMainCurrency;
        private System.Windows.Forms.Label lblTargetCurrency;
        private System.Windows.Forms.ComboBox cmbTargetCurrency;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

