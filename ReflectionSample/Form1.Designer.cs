namespace ReflectionSample
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
            this.btnGetClassListWithReflection = new System.Windows.Forms.Button();
            this.lstClassList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetClassListWithReflection
            // 
            this.btnGetClassListWithReflection.Location = new System.Drawing.Point(12, 21);
            this.btnGetClassListWithReflection.Name = "btnGetClassListWithReflection";
            this.btnGetClassListWithReflection.Size = new System.Drawing.Size(205, 32);
            this.btnGetClassListWithReflection.TabIndex = 0;
            this.btnGetClassListWithReflection.Text = "Get Class List With Reflection";
            this.btnGetClassListWithReflection.UseVisualStyleBackColor = true;
            this.btnGetClassListWithReflection.Click += new System.EventHandler(this.btnGetClassListWithReflection_Click);
            // 
            // lstClassList
            // 
            this.lstClassList.FormattingEnabled = true;
            this.lstClassList.Location = new System.Drawing.Point(12, 59);
            this.lstClassList.Name = "lstClassList";
            this.lstClassList.Size = new System.Drawing.Size(205, 368);
            this.lstClassList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstClassList);
            this.Controls.Add(this.btnGetClassListWithReflection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetClassListWithReflection;
        private System.Windows.Forms.ListBox lstClassList;
    }
}

