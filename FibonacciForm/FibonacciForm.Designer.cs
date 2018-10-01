namespace FibonacciTest {
    partial class FibonacciForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.asyncResultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nextNumberButton = new System.Windows.Forms.Button();
            this.syncResultLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.asyncResultLabel);
            this.groupBox1.Controls.Add(this.calculateButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputTextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Asynchronously";
            // 
            // asyncResultLabel
            // 
            this.asyncResultLabel.AutoSize = true;
            this.asyncResultLabel.Location = new System.Drawing.Point(122, 74);
            this.asyncResultLabel.Name = "asyncResultLabel";
            this.asyncResultLabel.Size = new System.Drawing.Size(0, 13);
            this.asyncResultLabel.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(21, 69);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Fibonacci of:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(125, 34);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nextNumberButton);
            this.groupBox2.Controls.Add(this.syncResultLabel);
            this.groupBox2.Controls.Add(this.displayLabel);
            this.groupBox2.Location = new System.Drawing.Point(22, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate Synchronously";
            // 
            // nextNumberButton
            // 
            this.nextNumberButton.Location = new System.Drawing.Point(21, 65);
            this.nextNumberButton.Name = "nextNumberButton";
            this.nextNumberButton.Size = new System.Drawing.Size(85, 23);
            this.nextNumberButton.TabIndex = 2;
            this.nextNumberButton.Text = "Next Number";
            this.nextNumberButton.UseVisualStyleBackColor = true;
            this.nextNumberButton.Click += new System.EventHandler(this.nextNumberButton_Click);
            // 
            // syncResultLabel
            // 
            this.syncResultLabel.AutoSize = true;
            this.syncResultLabel.Location = new System.Drawing.Point(112, 32);
            this.syncResultLabel.Name = "syncResultLabel";
            this.syncResultLabel.Size = new System.Drawing.Size(0, 13);
            this.syncResultLabel.TabIndex = 1;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(21, 32);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 13);
            this.displayLabel.TabIndex = 0;
            // 
            // FibonacciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 277);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FibonacciForm";
            this.Text = "Fibonacci Numbers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label asyncResultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button nextNumberButton;
        private System.Windows.Forms.Label syncResultLabel;
        private System.Windows.Forms.Label displayLabel;
    }
}

