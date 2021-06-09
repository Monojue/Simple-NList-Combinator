namespace Simple_NList_Combinator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDigit = new System.Windows.Forms.NumericUpDown();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbDigit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(419, 77);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pbar
            // 
            this.pbar.Location = new System.Drawing.Point(12, 186);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(482, 23);
            this.pbar.TabIndex = 1;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(67, 138);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 12);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(67, 110);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(11, 12);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(419, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbList
            // 
            this.tbList.Location = new System.Drawing.Point(69, 12);
            this.tbList.Name = "tbList";
            this.tbList.Size = new System.Drawing.Size(425, 56);
            this.tbList.TabIndex = 7;
            this.tbList.Tag = "";
            this.tbList.Text = "abc123-#";
            this.tbList.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "List";
            // 
            // tbDigit
            // 
            this.tbDigit.Location = new System.Drawing.Point(69, 74);
            this.tbDigit.Name = "tbDigit";
            this.tbDigit.Size = new System.Drawing.Size(113, 19);
            this.tbDigit.TabIndex = 11;
            this.tbDigit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(419, 139);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "OpenFolder";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 221);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbDigit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pbar);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbDigit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ProgressBar pbar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox tbList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tbDigit;
        private System.Windows.Forms.Button btnOpen;
    }
}

