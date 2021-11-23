
namespace ThreadsAndTasks_Q5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diskDriveCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.canlebtn = new System.Windows.Forms.Button();
            this.filesNamesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // diskDriveCmb
            // 
            this.diskDriveCmb.FormattingEnabled = true;
            this.diskDriveCmb.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.diskDriveCmb.Location = new System.Drawing.Point(145, 55);
            this.diskDriveCmb.Name = "diskDriveCmb";
            this.diskDriveCmb.Size = new System.Drawing.Size(182, 33);
            this.diskDriveCmb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disk Drive:";
            // 
            // fileNametxt
            // 
            this.fileNametxt.Location = new System.Drawing.Point(145, 124);
            this.fileNametxt.Name = "fileNametxt";
            this.fileNametxt.Size = new System.Drawing.Size(150, 31);
            this.fileNametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Name:";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(93, 194);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(154, 84);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // canlebtn
            // 
            this.canlebtn.Location = new System.Drawing.Point(93, 306);
            this.canlebtn.Name = "canlebtn";
            this.canlebtn.Size = new System.Drawing.Size(154, 84);
            this.canlebtn.TabIndex = 5;
            this.canlebtn.Text = "Cancle";
            this.canlebtn.UseVisualStyleBackColor = true;
            // 
            // filesNamesListBox
            // 
            this.filesNamesListBox.FormattingEnabled = true;
            this.filesNamesListBox.ItemHeight = 25;
            this.filesNamesListBox.Location = new System.Drawing.Point(450, 65);
            this.filesNamesListBox.Name = "filesNamesListBox";
            this.filesNamesListBox.Size = new System.Drawing.Size(257, 329);
            this.filesNamesListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.filesNamesListBox);
            this.Controls.Add(this.canlebtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diskDriveCmb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox diskDriveCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button canlebtn;
        private System.Windows.Forms.ListBox filesNamesListBox;
    }
}

