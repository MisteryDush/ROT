namespace ROT13
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.RadioButton();
            this.decodeButton = new System.Windows.Forms.RadioButton();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.steps = new System.Windows.Forms.NumericUpDown();
            this.stepsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.steps)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(55, 76);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(174, 119);
            this.inputBox.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(55, 58);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(174, 15);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Your phrase: ";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button.Location = new System.Drawing.Point(55, 228);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(178, 74);
            this.button.TabIndex = 2;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.Checked = true;
            this.encodeButton.Location = new System.Drawing.Point(397, 76);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(104, 24);
            this.encodeButton.TabIndex = 3;
            this.encodeButton.TabStop = true;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseCompatibleTextRendering = true;
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.CheckedChanged += new System.EventHandler(this.encodeButton_CheckedChanged);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(397, 106);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(104, 24);
            this.decodeButton.TabIndex = 4;
            this.decodeButton.TabStop = true;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.CheckedChanged += new System.EventHandler(this.decodeButton_CheckedChanged);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(349, 228);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(196, 74);
            this.outputBox.TabIndex = 5;
            // 
            // steps
            // 
            this.steps.Location = new System.Drawing.Point(397, 175);
            this.steps.Maximum = new decimal(new int[] {25, 0, 0, 0});
            this.steps.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(49, 20);
            this.steps.TabIndex = 6;
            this.steps.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // stepsLabel
            // 
            this.stepsLabel.Location = new System.Drawing.Point(395, 157);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(86, 15);
            this.stepsLabel.TabIndex = 7;
            this.stepsLabel.Text = "Number of steps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 361);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "ROT";
            ((System.ComponentModel.ISupportInitialize) (this.steps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown steps;
        private System.Windows.Forms.Label stepsLabel;

        private System.Windows.Forms.TextBox outputBox;

        private System.Windows.Forms.RadioButton encodeButton;

        private System.Windows.Forms.RadioButton decodeButton;

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button;

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label labelInfo;

        #endregion
    }
}