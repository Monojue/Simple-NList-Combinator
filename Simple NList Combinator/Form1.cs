using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        // change your list in nlist
        char[] list;
        char[] nlist;
        // change your length of word in n
        int n = 2;
        // change folder directory here
        static string folder = @"C:\Export";
        // change file name here
        static string file = folder + @"\1.txt";

        double currentProgress = 0;

        private void btnGenerate_Click(object sender, EventArgs e) {
            //add input text to char array
            list = tbList.Text.ToArray();
            //Remove duplicate
            nlist = list.Distinct().ToArray();
            n = int.Parse(tbDigit.Text);
            //Display no. of possible combination
            lblTotal.Text = Math.Pow(nlist.Count(), n).ToString();
            //Create folder
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            backgroundWorker.RunWorkerAsync(2000);
        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            
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
                    WriteLine(tempLine);

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
        }
        
        static async void WriteLine(string word) {
            //write file
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

        private void btnOpen_Click(object sender, EventArgs e) {
            Process.Start(folder);
        }
    }
}
