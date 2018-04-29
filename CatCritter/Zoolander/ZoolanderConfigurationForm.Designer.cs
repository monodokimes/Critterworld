namespace CatCritter
{
    partial class ZoolanderConfigurationForm
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
            this.startDirectionUpDown = new System.Windows.Forms.NumericUpDown();
            this.angularFudgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.turnAngleUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startDirectionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angularFudgeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnAngleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(125, 85);
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
            // startDirectionUpDown
            // 
            this.startDirectionUpDown.Location = new System.Drawing.Point(125, 59);
            this.startDirectionUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.startDirectionUpDown.Name = "startDirectionUpDown";
            this.startDirectionUpDown.Size = new System.Drawing.Size(101, 20);
            this.startDirectionUpDown.TabIndex = 24;
            // 
            // angularFudgeUpDown
            // 
            this.angularFudgeUpDown.Location = new System.Drawing.Point(125, 33);
            this.angularFudgeUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.angularFudgeUpDown.Name = "angularFudgeUpDown";
            this.angularFudgeUpDown.Size = new System.Drawing.Size(101, 20);
            this.angularFudgeUpDown.TabIndex = 23;
            // 
            // turnAngleUpDown
            // 
            this.turnAngleUpDown.Location = new System.Drawing.Point(125, 7);
            this.turnAngleUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.turnAngleUpDown.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.turnAngleUpDown.Name = "turnAngleUpDown";
            this.turnAngleUpDown.Size = new System.Drawing.Size(101, 20);
            this.turnAngleUpDown.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Start Direction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "AngularFudge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Turn Angle";
            // 
            // ZoolanderConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 122);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.startDirectionUpDown);
            this.Controls.Add(this.angularFudgeUpDown);
            this.Controls.Add(this.turnAngleUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ZoolanderConfigurationForm";
            this.Text = "Zoolander";
            ((System.ComponentModel.ISupportInitialize)(this.startDirectionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angularFudgeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnAngleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.NumericUpDown startDirectionUpDown;
        private System.Windows.Forms.NumericUpDown angularFudgeUpDown;
        private System.Windows.Forms.NumericUpDown turnAngleUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}