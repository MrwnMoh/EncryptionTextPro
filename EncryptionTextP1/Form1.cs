using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionTextP1
{
    public partial class Form1 : Form
    {
        byte shiftKey = 1;
        string EncryptionText = "";

        string AddRandomPadding(string text)
        {
            Random rand = new Random();
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char padding = (char)rand.Next(50, 256);
                result += text[i].ToString() + padding;
            }
            return result;
        }
        string EncryptText(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                result += (char)(text[i] + shiftKey);
            }

            if(RandomPaddingCheckBox.Checked)
            {
               result = AddRandomPadding(result);
            }

            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(shiftKey < 255)
            {shiftKey++;
                ShiftKeyTextBox.Text = shiftKey.ToString();
            }
        }

        private void IncreaseKeyButton_MouseHover(object sender, EventArgs e)
        {
            IncreaseKeyButton.Size = new Size(50, 50);
        }

        private void IncreaseKeyButton_MouseLeave(object sender, EventArgs e)
        {
            IncreaseKeyButton.Size = new Size(40, 40);

        }

        private void DecreaseKeyButton_MouseHover(object sender, EventArgs e)
        {
            DecreaseKeyButton.Size = new Size(50, 50);

        }

        private void DecreaseKeyButton_MouseLeave(object sender, EventArgs e)
        {
            DecreaseKeyButton.Size = new Size(40, 40);

        }

        private void DecreaseKeyButton_Click(object sender, EventArgs e)
        {
            if (shiftKey > 1)
            {
                shiftKey--;
                ShiftKeyTextBox.Text = shiftKey.ToString();
            }
        }

        private void EncryptTextBox_TextChanged(object sender, EventArgs e)
        {
            EncryptionText = EncryptTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EncryptTextButton_Click(object sender, EventArgs e)
        {
            EncryotedTextBox.Text = EncryptText(EncryptionText);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EncryptionText = "";
            EncryptTextBox.Text = EncryptionText;
            EncryotedTextBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(EncryotedTextBox.Text != "")
            Clipboard.SetText(EncryotedTextBox.Text);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
