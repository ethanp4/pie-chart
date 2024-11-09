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
            label1 = new Label();
            inputs = new TextBox();
            labelPies = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 31);
            label1.Name = "label1";
            label1.Size = new Size(301, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter a list of numbers separated by a space";
            // 
            // inputs
            // 
            inputs.Location = new Point(49, 54);
            inputs.Name = "inputs";
            inputs.Size = new Size(125, 27);
            inputs.TabIndex = 3;
            inputs.Text = "33 33 33";
            inputs.TextChanged += inputs_TextChanged;
            // 
            // labelPies
            // 
            labelPies.AutoSize = true;
            labelPies.Location = new Point(49, 104);
            labelPies.Name = "labelPies";
            labelPies.Size = new Size(57, 20);
            labelPies.TabIndex = 4;
            labelPies.Text = "no pies";
            // 
            // Pie_chart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelPies);
            Controls.Add(inputs);
            Controls.Add(label1);
            Name = "Pie_chart";
            Size = new Size(933, 511);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox inputs;
        private Label labelPies;
    }
}
