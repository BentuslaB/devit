using System.IO;
using System.Windows.Forms;
namespace devit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep(270, 500);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep(290, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep(300, 500);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep(320, 500);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep(340, 500);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.Beep(360, 500);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep(380, 500);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.Beep(410, 500);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.Beep(430, 500);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Console.Beep(460, 500);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Console.Beep(490, 500);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Console.Beep(510, 500);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Console.Beep(550, 500);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Console.Beep(580, 500);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Console.Beep(610, 500);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Console.Beep(650, 500);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Сохр дан";
            saveFileDialog1.FileName = "text.txt";
            saveFileDialog1.Filter = "TXT FILES|*.txt|ALL FILES|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(file);
                    try
                    {
                        writer.WriteLine(textBox1.Text);
                        MessageBox.Show("Сохранено");
                    }

                    catch
                    {
                        MessageBox.Show("не Сохранено");
                    }
                    writer.Close();
                    file.Close();
                }
                catch
                {
                    MessageBox.Show("jfdbgidfgid");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Сохр дан";
            openFileDialog1.FileName = "text.txt";
            openFileDialog1.Filter = "TXT FILES|*.txt|ALL FILES|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamWriter reader = new StreamWriter(file);
                    try
                    {
                        while (!reader.EndOfStream)
                        {
                            textBox1.Text = reader.Readline();
                        }
                    }

                    catch
                    {
                        MessageBox.Show("не Сохранено");
                    }
                    reader.Close();
                    file.Close();
                }
                catch
                {
                    MessageBox.Show("jfdbgidfgid");
                }
            }
        }
    }
}
