using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using SeparatorTransformer.Winform.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeparatorTransformer.Winform
{
    public partial class Form1 : Form
    {

        public string filePath { get; set; }
        public string outputPath { get; set; }
        public string outputFileName { get; set; }

        public string OldSeparator { get; set; }
        public string NewSeparator { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);


            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;

            OldSeparator = "\t";
            textBox5.Text = "\\t";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Event handler for drag enter
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // Event handler for drag drop
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                filePath = files[0];
                outputFileName = Path.GetFileNameWithoutExtension(filePath);

                textBox1.Text = filePath;
            }
        }
        private void DosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                outputFileName = Path.GetFileNameWithoutExtension(filePath);

                textBox1.Text = filePath;
            }
        }

        private void KonumSec_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Oluşturalacak Dosya İçin Hedef Konumu Seçin";
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    outputPath = folderBrowserDialog.SelectedPath;
                    // Do something with the selected path
                    textBox2.Text = outputPath;
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            OldSeparator = InterpretEscapeSequences.Interpret(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            NewSeparator = InterpretEscapeSequences.Interpret(textBox6.Text);
        }

        private void Donustur_Click(object sender, EventArgs e)
        {

            if (outputPath == null)
            {
                string directoryPath = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                outputPath = $"{directoryPath}\\{fileName}_New.txt";
            }
            else
            {
                outputPath += "\\" + outputFileName+ "_New" + ".txt";
            }

            SeparatorTransformerHelper.Transform(filePath, outputPath, OldSeparator, NewSeparator, backgroundWorker1);

            if (File.Exists(outputPath))
            {
                MessageBox.Show($"Dosya Oluşturuldu. Txt dosyası: {outputPath}");
                progressBar1.Value = 0;
                textBox1.Text = "";
                textBox2.Text = "";
                filePath = null;
                outputPath = null;
            }
            else
            {
                MessageBox.Show($"Dosya Oluşturulamadı. {outputPath}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filePath = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            outputPath = textBox2.Text;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
