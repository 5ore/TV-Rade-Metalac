using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVRadeMetalac
{
    public static class UserInputDialog
    {
        public static string ShowDialog(string text, string caption)
        {
            Form userInputDialog = new Form()
            {
                Width = 1500,
                Height = 1000,
                FormBorderStyle = FormBorderStyle.Sizable,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { userInputDialog.Close(); };
            userInputDialog.Controls.Add(textBox);
            userInputDialog.Controls.Add(confirmation);
            userInputDialog.Controls.Add(textLabel);
            userInputDialog.AcceptButton = confirmation;

            return userInputDialog.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public static Message ShowDialog(string label1, string label2, string label3, string caption)
        {
            Form userInputDialog = new Form()
            {
                Width = 950,
                Height = 600,
                FormBorderStyle = FormBorderStyle.Sizable,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel1 = new Label() { Left = 50, Top = 40, Text = label1 };
            RichTextBox textBox1 = new RichTextBox() { Left = 50, Top = 65, Width = 850, Height = 300 };

            Label textLabel2 = new Label() { Left = 220, Top = 400, Text = label2 };
            DateTimePicker dtp1 = new DateTimePicker() { Left = 220, Top = 425, Width = 200 };
            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.CustomFormat = "d/MM/yyyy HH:mm";

            Label textLabel3 = new Label() { Left = 580, Top = 400, Text = label3 };
            DateTimePicker dtp2 = new DateTimePicker() { Left = 580, Top = 425, Width = 200 };
            dtp2.Format = DateTimePickerFormat.Custom;
            dtp2.CustomFormat = "d/MM/yyyy HH:mm";

            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 500, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Poništi", Left = 750, Width = 100, Top = 500, DialogResult = DialogResult.Cancel };

            Control[] controlsToBeAdded = new Control[]
            {
                textLabel1, textBox1, textLabel2, dtp1, textLabel3, dtp2, confirmation, cancel
            };

            confirmation.Click += (sender, e) => { userInputDialog.Close(); };
            cancel.Click += (sender, e) => { userInputDialog.Close(); };
            userInputDialog.AcceptButton = confirmation;
            userInputDialog.Controls.AddRange(controlsToBeAdded);

            return userInputDialog.ShowDialog() == DialogResult.OK ? 
                new Message(textBox1.Text, dtp1.Value, dtp2.Value) : null;
        }
    }
}
