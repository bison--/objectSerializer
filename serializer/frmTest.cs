using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serializer {
    public partial class frmTest : Form {

        public testObject myChar = new testObject();

        public frmTest() {
            InitializeComponent();
            myChar.addItem("hamster", 7);
            myChar.addItem("foo", 23);
        }

        private void cmdSerialise_Click(object sender, EventArgs e) {
            txtSerialised.Text = serializer.clsSerializer.SerializeToString(myChar);
        }

        private void cmdDeserialize_Click(object sender, EventArgs e) {
            myChar = serializer.clsSerializer.DeserializeFromString<testObject>(txtSerialised.Text);
            MessageBox.Show("Name: " + myChar.name);
        }
    }
}
