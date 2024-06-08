using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    // best practices
    // change font first
    // when adding an item change (name) first in properties

    public partial class Dashboard : Form
    {
        // bindinglist works like a regular list except it tells when its updated
        private BindingList<string> _messages = new BindingList<string>();
        public Dashboard()
        {
            // we make the components
            InitializeComponent();

            // add the source for what will be shown
            WireUpList();
        }

        private void WireUpList()
        {
            messageListBox.DataSource = _messages;
            //if you have a list of object you need to use displayMember
            //messageListBox.DisplayMember = nameof(Object.Property);
        }

        // simple onclick
        private void AddMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MessageText.Text))
            {
                MessageBox.Show($@"please type a message",
                    $@"Blank message field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                _messages.Add(MessageText.Text);
            }
            MessageText.Text = "";
            MessageText.Focus();
        }
    }
}
