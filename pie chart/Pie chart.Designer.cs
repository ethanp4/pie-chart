namespace pie_chart {
    partial class Pie_chart {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            inputs = new RichTextBox();
            statusLabel = new Label();
            displayText = new Label();
            SuspendLayout();
            // 
            // inputs
            // 
            inputs.Location = new Point(49, 54);
            inputs.Name = "inputs";
            inputs.Size = new Size(125, 120);
            inputs.TabIndex = 0;
            inputs.Text = "10\n30\n45\n45";
            inputs.TextChanged += inputs_TextChanged;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(49, 31);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(49, 20);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "Status";
            // 
            // displayText
            // 
            displayText.AutoSize = true;
            displayText.Location = new Point(46, 235);
            displayText.Name = "displayText";
            displayText.Size = new Size(50, 20);
            displayText.TabIndex = 2;
            displayText.Text = "label1";
            // 
            // Pie_chart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(displayText);
            Controls.Add(statusLabel);
            Controls.Add(inputs);
            Name = "Pie_chart";
            Size = new Size(437, 354);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox inputs;
        private Label statusLabel;
        private Label displayText;
    }
}
