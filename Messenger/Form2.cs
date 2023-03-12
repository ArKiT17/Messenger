using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger {
	public partial class Form2 : Form {
		public Form2() {
			InitializeComponent();
		}

		private void button12_Click(object sender, EventArgs e) {
			openFileDialog1 = new OpenFileDialog();
			openFileDialog1.ShowDialog();
			photo.Load(openFileDialog1.FileName);
		}
	}
}
