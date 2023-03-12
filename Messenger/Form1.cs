namespace Messenger {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			Form2 profile = new Form2();
			profile.Show();
		}
	}
}