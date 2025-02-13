namespace Presentation_Layer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {
            label1.Text = Business_Layer.Class1.Test();
        }
    }
}
