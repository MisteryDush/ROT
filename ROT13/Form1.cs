using System;
using System.Windows.Forms;
using static ROT13.Program;

namespace ROT13;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void button_Click(object sender, EventArgs e)
    {
        outputBox.Text = Rot(inputBox.Text, encodeButton.Checked, (int) steps.Value);
    }

    private void encodeButton_CheckedChanged(object sender, EventArgs e)
    {
        var checkBox = (RadioButton) sender;
        decodeButton.Checked = !checkBox.Checked;
    }

    private void decodeButton_CheckedChanged(object sender, EventArgs e)
    {
        var checkBox = (RadioButton) sender;
        encodeButton.Checked = !checkBox.Checked;
    }
}