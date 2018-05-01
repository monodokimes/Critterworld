namespace CatCritter
{
    partial class GoodBoiConfigurationForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.changeDirDelayUpDown = new System.Windows.Forms.NumericUpDown();
            this.runSpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.wanderSpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.changeDirDelayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runSpeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderSpeedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(135, 85);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 23);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 85);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 23);
            this.okButton.TabIndex = 27;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // changeDirDelayUpDown
            // 
            this.changeDirDelayUpDown.Location = new System.Drawing.Point(135, 59);
            this.changeDirDelayUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.changeDirDelayUpDown.Name = "changeDirDelayUpDown";
            this.changeDirDelayUpDown.Size = new System.Drawing.Size(101, 20);
            this.changeDirDelayUpDown.TabIndex = 24;
            // 
            // runSpeedUpDown
            // 
            this.runSpeedUpDown.Location = new System.Drawing.Point(135, 33);
            this.runSpeedUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.runSpeedUpDown.Name = "runSpeedUpDown";
            this.runSpeedUpDown.Size = new System.Drawing.Size(101, 20);
            this.runSpeedUpDown.TabIndex = 23;
            // 
            // wanderSpeedUpDown
            // 
            this.wanderSpeedUpDown.Location = new System.Drawing.Point(135, 7);
            this.wanderSpeedUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wanderSpeedUpDown.Name = "wanderSpeedUpDown";
            this.wanderSpeedUpDown.Size = new System.Drawing.Size(101, 20);
            this.wanderSpeedUpDown.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Change Direction Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Run Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Wander Speed";
            // 
            // GoodBoiConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 118);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.changeDirDelayUpDown);
            this.Controls.Add(this.runSpeedUpDown);
            this.Controls.Add(this.wanderSpeedUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GoodBoiConfigurationForm";
            this.Text = "GoodBoi";
            ((System.ComponentModel.ISupportInitialize)(this.changeDirDelayUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runSpeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wanderSpeedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown changeDirDelayUpDown;
        private System.Windows.Forms.NumericUpDown runSpeedUpDown;
        private System.Windows.Forms.NumericUpDown wanderSpeedUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}