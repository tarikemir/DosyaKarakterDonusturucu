using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SeparatorTransformer.Winform.Helper
{
    public static class SeparatorTransformerHelper
    {

        public static void Transform(string filePath, string outputPath, string oldSeparator, string newSeparator, BackgroundWorker backgroundWorker1)
        {
            try
            {
                int totalLines = File.ReadLines(filePath).Count();
                int processedLines = 0;

                using (StreamReader reader = new StreamReader(filePath))
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string transformedLine = line.Replace(oldSeparator, newSeparator);
                        writer.WriteLine(transformedLine);

                        processedLines++;
                        if( (processedLines %10 == 0) || (processedLines == totalLines))
                        {
                            int progressPercentage = (int)((float)processedLines / totalLines * 100);
                            backgroundWorker1.ReportProgress(progressPercentage);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata Ortaya Çıktı: {ex.Message}");
            }
        }
    }
}
