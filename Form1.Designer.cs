namespace WriteArrayForms
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
            this.WriteToFile = new System.Windows.Forms.Button();
            this.ReadFromArray = new System.Windows.Forms.Button();
            this.ReadFromtxtShow = new System.Windows.Forms.Button();
            this.FillWithEmptyStrings = new System.Windows.Forms.Button();
            this.EmptyTxtshow = new System.Windows.Forms.Button();
            this.ShowArrayintxtshow = new System.Windows.Forms.Button();
            this.FillWithNames = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WriteToFile
            // 
            this.WriteToFile.Location = new System.Drawing.Point(69, 53);
            this.WriteToFile.Name = "WriteToFile";
            this.WriteToFile.Size = new System.Drawing.Size(137, 29);
            this.WriteToFile.TabIndex = 0;
            this.WriteToFile.Text = "Skriv Array til fil";
            this.WriteToFile.UseVisualStyleBackColor = true;
            this.WriteToFile.Click += new System.EventHandler(this.WriteToFile_Click);
            // 
            // ReadFromArray
            // 
            this.ReadFromArray.Location = new System.Drawing.Point(69, 117);
            this.ReadFromArray.Name = "ReadFromArray";
            this.ReadFromArray.Size = new System.Drawing.Size(137, 29);
            this.ReadFromArray.TabIndex = 1;
            this.ReadFromArray.Text = "Les fra fil Array";
            this.ReadFromArray.UseVisualStyleBackColor = true;
            this.ReadFromArray.Click += new System.EventHandler(this.ReadFromArray_Click);
            // 
            // ReadFromtxtShow
            // 
            this.ReadFromtxtShow.Location = new System.Drawing.Point(69, 177);
            this.ReadFromtxtShow.Name = "ReadFromtxtShow";
            this.ReadFromtxtShow.Size = new System.Drawing.Size(137, 29);
            this.ReadFromtxtShow.TabIndex = 2;
            this.ReadFromtxtShow.Text = "Les fil fra txtShow";
            this.ReadFromtxtShow.UseVisualStyleBackColor = true;
            this.ReadFromtxtShow.Click += new System.EventHandler(this.ReadFromtxtShow_Click);
            // 
            // FillWithEmptyStrings
            // 
            this.FillWithEmptyStrings.Location = new System.Drawing.Point(69, 227);
            this.FillWithEmptyStrings.Name = "FillWithEmptyStrings";
            this.FillWithEmptyStrings.Size = new System.Drawing.Size(137, 65);
            this.FillWithEmptyStrings.TabIndex = 3;
            this.FillWithEmptyStrings.Text = "Fyll array med tomme strenger";
            this.FillWithEmptyStrings.UseVisualStyleBackColor = true;
            this.FillWithEmptyStrings.Click += new System.EventHandler(this.FillWithEmptyStrings_Click);
            // 
            // EmptyTxtshow
            // 
            this.EmptyTxtshow.Location = new System.Drawing.Point(339, 263);
            this.EmptyTxtshow.Name = "EmptyTxtshow";
            this.EmptyTxtshow.Size = new System.Drawing.Size(128, 29);
            this.EmptyTxtshow.TabIndex = 4;
            this.EmptyTxtshow.Text = "Tøm txtShow";
            this.EmptyTxtshow.UseVisualStyleBackColor = true;
            this.EmptyTxtshow.Click += new System.EventHandler(this.EmptyTxtshow_Click);
            // 
            // ShowArrayintxtshow
            // 
            this.ShowArrayintxtshow.Location = new System.Drawing.Point(339, 298);
            this.ShowArrayintxtshow.Name = "ShowArrayintxtshow";
            this.ShowArrayintxtshow.Size = new System.Drawing.Size(128, 29);
            this.ShowArrayintxtshow.TabIndex = 5;
            this.ShowArrayintxtshow.Text = "Vis array i txtShow";
            this.ShowArrayintxtshow.UseVisualStyleBackColor = true;
            this.ShowArrayintxtshow.Click += new System.EventHandler(this.ShowArrayintxtshow_Click);
            // 
            // FillWithNames
            // 
            this.FillWithNames.Location = new System.Drawing.Point(587, 263);
            this.FillWithNames.Name = "FillWithNames";
            this.FillWithNames.Size = new System.Drawing.Size(159, 29);
            this.FillWithNames.TabIndex = 6;
            this.FillWithNames.Text = "Fyll array med navn";
            this.FillWithNames.UseVisualStyleBackColor = true;
            this.FillWithNames.Click += new System.EventHandler(this.FillWithNames_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(288, 53);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(237, 194);
            this.txtShow.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.FillWithNames);
            this.Controls.Add(this.ShowArrayintxtshow);
            this.Controls.Add(this.EmptyTxtshow);
            this.Controls.Add(this.FillWithEmptyStrings);
            this.Controls.Add(this.ReadFromtxtShow);
            this.Controls.Add(this.ReadFromArray);
            this.Controls.Add(this.WriteToFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WriteToFile;
        private System.Windows.Forms.Button ReadFromArray;
        private System.Windows.Forms.Button ReadFromtxtShow;
        private System.Windows.Forms.Button FillWithEmptyStrings;
        private System.Windows.Forms.Button EmptyTxtshow;
        private System.Windows.Forms.Button ShowArrayintxtshow;
        private System.Windows.Forms.Button FillWithNames;
        private System.Windows.Forms.TextBox txtShow;
    }
}
