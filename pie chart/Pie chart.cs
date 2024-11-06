using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pie_chart {
    public partial class Pie_chart : UserControl {
        public Pie_chart() {
            InitializeComponent();
            //inputs_TextChanged(null, null);
        }
        private List<float> nums = new List<float>();
        private bool isChanged = false;

        private void inputs_TextChanged(object sender, EventArgs e) {
            nums.Clear();
            foreach (var i in inputs.Text.Split('\n')) {
                i.Trim();
                i.Replace(" ", "");
                if (i == "") { continue; }
                try {
                    nums.Add(float.Parse(i));
                    isChanged = true;
                } catch {
                    if (inputs.Text == "") { //unset error text if the input is just empty
                        statusLabel.Text = "";
                    } else {
                        statusLabel.Text = $"{i} is not a valid number\nPlease enter numbers separated by new lines";
                    }
                    return;
                }
                statusLabel.Text = ""; //unset error text if all goes well
            }
            Invalidate();
        }

        private List<float> calculateSlices() {
            var ret = new List<float>(); //ie 10, 10, 10 -> 33, 33, 33
            float total = 0;             //i / total = percent of total
            foreach (var i in nums) {
                total += i;
            }
            foreach (var i in nums) {
                ret.Add(i/total);
            }
            return ret;
        }

        protected override void OnPaint(PaintEventArgs e) {
            var g = e.Graphics;
            if (isChanged) { //prevent running when not necessary
                var slices = calculateSlices();
                displayText.Text = "";
                foreach (var i in slices) {
                    displayText.Text += i + "\n";
                }
                isChanged = false;
            }
        }
    }
}
