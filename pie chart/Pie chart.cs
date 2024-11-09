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
        System.Windows.Forms.Timer renderOnceTimer = new();
        public Pie_chart() {
            InitializeComponent();
            renderOnceTimer.Tick += inputs_TextChanged;
            renderOnceTimer.Interval = 100; //need to set a timer to render the default state, since it doesnt seem to work when running immediately
            renderOnceTimer.Start();
            DoubleBuffered = true;
        }
        private List<float> nums = new List<float>();
        private bool isChanged = false;

        ErrorProvider errorProvider = new ErrorProvider();
        private void inputs_TextChanged(object sender, EventArgs e) {
            nums.Clear();
            foreach (var i in inputs.Text.Split(' ')) {
                i.Trim();
                i.Replace(" ", "");
                if (i == "") { continue; }
                try {
                    nums.Add(float.Parse(i));
                    isChanged = true;
                } catch {
                    errorProvider.SetError(inputs, "Invalid input");
                    return;
                }
            }
            errorProvider.Clear();
            renderOnceTimer.Stop();
            Invalidate();
        }

        private List<float> calculateSlices() {
            var ret = new List<float>(); //ie 10, 10, 10 -> 33, 33, 33
            float total = 0;             //i / total = percent of total
            foreach (var i in nums) {
                total += i;
            }
            labelPies.Text = "";
            for (int i = 0; i < nums.Count; i++) { 
                var num = nums[i];
                var val = num / total;
                ret.Add(val);
                var colorIdx = Convert.ToInt32(i % colors.Length);
                labelPies.Text += $"Pie {i+1} ({ colorNames[colorIdx] }) is {(val*100).ToString("F2")}% of the whole\n";
            }
            return ret;
        }
        String[] colorNames = { "blue", "orange", "green", "red", "purple", "brown", "pink", "grey", "yellow", "cream", "dark purple", "cyan", "lobster" };
        Color[] colors = { Color.FromArgb(55, 126, 184), Color.FromArgb(255, 127, 0), Color.FromArgb(44, 160, 44), Color.FromArgb(214, 39, 40), Color.FromArgb(148, 103, 189), Color.FromArgb(140, 86, 75), Color.FromArgb(227, 119, 194), Color.FromArgb(128, 128, 128), Color.FromArgb(255, 255, 51), Color.FromArgb(253, 180, 98), Color.FromArgb(75, 0, 130), Color.FromArgb(0, 255, 255), Color.FromArgb(255, 99, 71) };
        protected override void OnPaint(PaintEventArgs e) {
            var g = e.Graphics;
            if (isChanged) { //prevent running when not necessary
                var slices = calculateSlices();
                var rect = new Rectangle(350,75,300,300);
                var position = 0f;
                for (int i = 0; i < slices.Count; i++) {
                    var slice = slices[i];
                    var degrees = 360f * slice;
                    var colorIdx = Convert.ToInt32(i % colors.Length);
                    g.FillPie(new SolidBrush(colors[colorIdx]), rect, position, degrees);
                    position += degrees;
                }
                isChanged = false;
            }
        }
    }
}
