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

namespace Simple_NList_Combinator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string[] nlist = { "a" , "b", "c", "d", "e", "d", "e"};
        int n = 8;
        double currentProgress = 0;
        static string folder = @"C:\Export";
        static string file = folder + @"\1.txt";

        private void btnGenerate_Click(object sender, EventArgs e) {
            lblTotal.Text = Math.Pow(nlist.Count(), n).ToString();
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            backgroundWorker.RunWorkerAsync(2000);
        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            //create file
            //StreamWriter file = new StreamWriter(@"C:\設計書\lines.txt");
            //create list with given digit n
            List<int> digit = new List<int>(n);
            for (int i = 0; i < n; i++) {
                digit.Add(0);
            }

            // calculate possible combination
            double posCOM = Math.Pow(nlist.Count(), n);
            
            for (double line = 0; line < posCOM; line++) {
                if (!backgroundWorker.CancellationPending) {
                    currentProgress = line + 1;
                    backgroundWorker.ReportProgress((int)((currentProgress * 100) / posCOM));
                
                    string tempLine = "";
                    //write combination
                    for (int wpointer = 0; wpointer < n; wpointer++) {
                        tempLine += nlist[digit[wpointer]];
                    }
                   
                    //file.WriteLineAsync(tempLine);
                    WriteCharacters(tempLine);

                        //check digit form the latest
                        for (int cpointer = n - 1; cpointer >= 0; cpointer--) {

                            //if same to no. of nlist count
                            if (digit[cpointer] == nlist.Count() - 1) {
                                // reset digit at cpointer to 0
                                digit[cpointer] = 0;
                            } else {
                                //increase 1 to [latest room] -1
                                digit[cpointer]++;
                                break;
                            }
                        }
                }
            }
            //file.Close();
        }
        
        
        
        static async void WriteCharacters(string word) {
            using (StreamWriter writer = File.Exists(file) ? File.AppendText(file) : File.CreateText(file)) {
                await writer.WriteLineAsync(word);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            pbar.Value = 100;
            pbar.Update();
            MessageBox.Show("Done!");
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            lblCurrent.Text = currentProgress.ToString();
            pbar.Value = e.ProgressPercentage;
            pbar.Update();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            
            if (backgroundWorker.IsBusy)
                backgroundWorker.CancelAsync();
        }
    }
}
