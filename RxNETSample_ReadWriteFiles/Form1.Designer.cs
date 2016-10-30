namespace RxNETSample_ReadWriteFiles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridFile = new System.Windows.Forms.DataGridView();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtFileToRead = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFileToWrite = new System.Windows.Forms.TextBox();
            this.btnWriteFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFile
            // 
            this.dataGridFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Line});
            this.dataGridFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridFile.Location = new System.Drawing.Point(0, 0);
            this.dataGridFile.Name = "dataGridFile";
            this.dataGridFile.Size = new System.Drawing.Size(436, 150);
            this.dataGridFile.TabIndex = 0;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line file";
            this.Line.Name = "Line";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(349, 166);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "Read";
            this.btnReadFile.UseVisualStyleBackColor = true;
            // 
            // txtFileToRead
            // 
            this.txtFileToRead.Location = new System.Drawing.Point(12, 169);
            this.txtFileToRead.Name = "txtFileToRead";
            this.txtFileToRead.Size = new System.Drawing.Size(331, 20);
            this.txtFileToRead.TabIndex = 2;
            this.txtFileToRead.Text = "c:\\temp\\in.txt";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "Open";
            // 
            // txtFileToWrite
            // 
            this.txtFileToWrite.Location = new System.Drawing.Point(12, 220);
            this.txtFileToWrite.Name = "txtFileToWrite";
            this.txtFileToWrite.Size = new System.Drawing.Size(331, 20);
            this.txtFileToWrite.TabIndex = 3;
            this.txtFileToWrite.Text = "c:\\temp\\out.txt";
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(350, 216);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFile.TabIndex = 4;
            this.btnWriteFile.Text = "Write";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 266);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.txtFileToWrite);
            this.Controls.Add(this.txtFileToRead);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.dataGridFile);
            this.Name = "Form1";
            this.Text = "Read and write to file with Rx.NET";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtFileToRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.TextBox txtFileToWrite;
        private System.Windows.Forms.Button btnWriteFile;
    }
}

