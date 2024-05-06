using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerTools
{
    public partial class HandleLogExceptions : Form
    {
        public HandleLogExceptions()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string filePath = tbPath.Text;
            slicedLog(filePath);

        }
        public void slicedLog(string inputFilePath)
        { 
            // Specify the path for the output text file
            string outputFilePath = @"c:\outLog2.txt";

            // Check if the input file exists
            if (File.Exists(inputFilePath))
            {
                // Read the entire input file as one string
                string fileContent = File.ReadAllText(inputFilePath);

                // Split the file content by the delimiter
                string[] sections = fileContent.Split(new string[] { "**********************************" }, StringSplitOptions.RemoveEmptyEntries);

                // Create a StreamWriter to write to the output file
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string spcefiedContent = "";
                    // Iterate through the sections and write the filtered ones to the output file
                    foreach (string section in sections)
                    {
                        spcefiedContent += section;
                        if (!section.Contains("WebAPI"))
                        {
                            writer.WriteLine("Section:");
                            spcefiedContent += section;
                            writer.WriteLine(section);
                            writer.WriteLine("End of Section\n");
                        }
                    }
                    writer.Write(spcefiedContent);
                }

                Console.WriteLine("Filtered sections have been written to the output file.");
            }
            else
            {
                Console.WriteLine("Input file not found!");
            }
        }
    }
}
