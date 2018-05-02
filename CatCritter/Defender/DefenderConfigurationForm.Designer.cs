namespace _100458008
{
    partial class DefenderConfigurationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sprintSpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.normalSpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.sprintSecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.waitSecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.findTargetSecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sprintSpeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalSpeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintSecondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitSecondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTargetSecondsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprint Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Normal Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sprint Seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wait Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Find Target Seconds";
            // 
            // sprintSpeedUpDown
            // 
            this.sprintSpeedUpDown.Location = new System.Drawing.Point(125, 7);
            this.sprintSpeedUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sprintSpeedUpDown.Name = "sprintSpeedUpDown";
            this.sprintSpeedUpDown.Size = new System.Drawing.Size(101, 20);
            this.sprintSpeedUpDown.TabIndex = 10;
            // 
            // normalSpeedUpDown
            // 
            this.normalSpeedUpDown.Location = new System.Drawing.Point(125, 33);
            this.normalSpeedUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.normalSpeedUpDown.Name = "normalSpeedUpDown";
            this.normalSpeedUpDown.Size = new System.Drawing.Size(101, 20);
            this.normalSpeedUpDown.TabIndex = 11;
            // 
            // sprintSecondsUpDown
            // 
            this.sprintSecondsUpDown.Location = new System.Drawing.Point(125, 59);
            this.sprintSecondsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sprintSecondsUpDown.Name = "sprintSecondsUpDown";
            this.sprintSecondsUpDown.Size = new System.Drawing.Size(101, 20);
            this.sprintSecondsUpDown.TabIndex = 12;
            // 
            // waitSecondsUpDown
            // 
            this.waitSecondsUpDown.Location = new System.Drawing.Point(125, 85);
            this.waitSecondsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.waitSecondsUpDown.Name = "waitSecondsUpDown";
            this.waitSecondsUpDown.Size = new System.Drawing.Size(101, 20);
            this.waitSecondsUpDown.TabIndex = 13;
            // 
            // findTargetSecondsUpDown
            // 
            this.findTargetSecondsUpDown.Location = new System.Drawing.Point(125, 111);
            this.findTargetSecondsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.findTargetSecondsUpDown.Name = "findTargetSecondsUpDown";
            this.findTargetSecondsUpDown.Size = new System.Drawing.Size(101, 20);
            this.findTargetSecondsUpDown.TabIndex = 14;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 137);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(125, 137);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DefenderConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 173);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.findTargetSecondsUpDown);
            this.Controls.Add(this.waitSecondsUpDown);
            this.Controls.Add(this.sprintSecondsUpDown);
            this.Controls.Add(this.normalSpeedUpDown);
            this.Controls.Add(this.sprintSpeedUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DefenderConfigurationForm";
            this.Text = "Defender";
            ((System.ComponentModel.ISupportInitialize)(this.sprintSpeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalSpeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprintSecondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitSecondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findTargetSecondsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sprintSpeedUpDown;
        private System.Windows.Forms.NumericUpDown normalSpeedUpDown;
        private System.Windows.Forms.NumericUpDown sprintSecondsUpDown;
        private System.Windows.Forms.NumericUpDown waitSecondsUpDown;
        private System.Windows.Forms.NumericUpDown findTargetSecondsUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}