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
            this.btnGetClassWithCustomAttributeFilterReflection = new System.Windows.Forms.Button();
            this.btnPropertyWithReflection = new System.Windows.Forms.Button();
            this.lstProperty = new System.Windows.Forms.ListBox();
            this.btnGetMethod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnGenerateTree = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnGenerateProductCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetClassListWithReflection
            // 
            this.btnGetClassListWithReflection.Location = new System.Drawing.Point(12, 21);
            this.btnGetClassListWithReflection.Name = "btnGetClassListWithReflection";
            this.btnGetClassListWithReflection.Size = new System.Drawing.Size(382, 32);
            this.btnGetClassListWithReflection.TabIndex = 0;
            this.btnGetClassListWithReflection.Text = "Get Class List With Reflection";
            this.btnGetClassListWithReflection.UseVisualStyleBackColor = true;
            this.btnGetClassListWithReflection.Click += new System.EventHandler(this.btnGetClassListWithReflection_Click);
            // 
            // lstClassList
            // 
            this.lstClassList.FormattingEnabled = true;
            this.lstClassList.Location = new System.Drawing.Point(12, 111);
            this.lstClassList.Name = "lstClassList";
            this.lstClassList.Size = new System.Drawing.Size(142, 316);
            this.lstClassList.TabIndex = 1;
            // 
            // btnGetClassWithCustomAttributeFilterReflection
            // 
            this.btnGetClassWithCustomAttributeFilterReflection.Location = new System.Drawing.Point(12, 59);
            this.btnGetClassWithCustomAttributeFilterReflection.Name = "btnGetClassWithCustomAttributeFilterReflection";
            this.btnGetClassWithCustomAttributeFilterReflection.Size = new System.Drawing.Size(382, 35);
            this.btnGetClassWithCustomAttributeFilterReflection.TabIndex = 2;
            this.btnGetClassWithCustomAttributeFilterReflection.Text = "Get Class With CustomAttribute Filter Reflection";
            this.btnGetClassWithCustomAttributeFilterReflection.UseVisualStyleBackColor = true;
            this.btnGetClassWithCustomAttributeFilterReflection.Click += new System.EventHandler(this.btnGetClassWithCustomAttributeFilterReflection_Click);
            // 
            // btnPropertyWithReflection
            // 
            this.btnPropertyWithReflection.Location = new System.Drawing.Point(160, 230);
            this.btnPropertyWithReflection.Name = "btnPropertyWithReflection";
            this.btnPropertyWithReflection.Size = new System.Drawing.Size(94, 32);
            this.btnPropertyWithReflection.TabIndex = 3;
            this.btnPropertyWithReflection.Text = ">> Get Property";
            this.btnPropertyWithReflection.UseVisualStyleBackColor = true;
            this.btnPropertyWithReflection.Click += new System.EventHandler(this.btnPropertyWithReflection_Click);
            // 
            // lstProperty
            // 
            this.lstProperty.FormattingEnabled = true;
            this.lstProperty.Location = new System.Drawing.Point(260, 111);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(134, 316);
            this.lstProperty.TabIndex = 4;
            // 
            // btnGetMethod
            // 
            this.btnGetMethod.Location = new System.Drawing.Point(160, 294);
            this.btnGetMethod.Name = "btnGetMethod";
            this.btnGetMethod.Size = new System.Drawing.Size(94, 32);
            this.btnGetMethod.TabIndex = 5;
            this.btnGetMethod.Text = ">> Get Method";
            this.btnGetMethod.UseVisualStyleBackColor = true;
            this.btnGetMethod.Click += new System.EventHandler(this.btnGetMethod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Folder Path :";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFolderPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtFolderPath.Location = new System.Drawing.Point(490, 46);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(145, 20);
            this.txtFolderPath.TabIndex = 7;
            // 
            // btnGenerateTree
            // 
            this.btnGenerateTree.Location = new System.Drawing.Point(651, 46);
            this.btnGenerateTree.Name = "btnGenerateTree";
            this.btnGenerateTree.Size = new System.Drawing.Size(175, 23);
            this.btnGenerateTree.TabIndex = 8;
            this.btnGenerateTree.Text = "Generate Tree !";
            this.btnGenerateTree.UseVisualStyleBackColor = true;
            this.btnGenerateTree.Click += new System.EventHandler(this.btnGenerateTree_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(420, 72);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(215, 355);
            this.treeView1.TabIndex = 9;
            // 
            // btnGenerateProductCategory
            // 
            this.btnGenerateProductCategory.Location = new System.Drawing.Point(651, 75);
            this.btnGenerateProductCategory.Name = "btnGenerateProductCategory";
            this.btnGenerateProductCategory.Size = new System.Drawing.Size(175, 23);
            this.btnGenerateProductCategory.TabIndex = 10;
            this.btnGenerateProductCategory.Text = "Generate Product Category Tree ! ";
            this.btnGenerateProductCategory.UseVisualStyleBackColor = true;
            this.btnGenerateProductCategory.Click += new System.EventHandler(this.btnGenerateProductCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.btnGenerateProductCategory);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnGenerateTree);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetMethod);
            this.Controls.Add(this.lstProperty);
            this.Controls.Add(this.btnPropertyWithReflection);
            this.Controls.Add(this.btnGetClassWithCustomAttributeFilterReflection);
            this.Controls.Add(this.lstClassList);
            this.Controls.Add(this.btnGetClassListWithReflection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetClassListWithReflection;
        private System.Windows.Forms.ListBox lstClassList;
        private System.Windows.Forms.Button btnGetClassWithCustomAttributeFilterReflection;
        private System.Windows.Forms.Button btnPropertyWithReflection;
        private System.Windows.Forms.ListBox lstProperty;
        private System.Windows.Forms.Button btnGetMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnGenerateTree;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnGenerateProductCategory;
    }
}

