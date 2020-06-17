namespace TaskWithComponents
{
    partial class Lesson14_16Form
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.addNodeTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.findNodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(205, 221);
            this.treeView1.TabIndex = 0;
            // 
            // addNodeTextBox
            // 
            this.addNodeTextBox.Location = new System.Drawing.Point(342, 29);
            this.addNodeTextBox.Name = "addNodeTextBox";
            this.addNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.addNodeTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(244, 27);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(244, 210);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(91, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Удалить узел";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(367, 210);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(75, 23);
            this.removeAllButton.TabIndex = 4;
            this.removeAllButton.Text = "Очистить";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(244, 67);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findNodeTextBox
            // 
            this.findNodeTextBox.Location = new System.Drawing.Point(342, 69);
            this.findNodeTextBox.Name = "findNodeTextBox";
            this.findNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.findNodeTextBox.TabIndex = 6;
            // 
            // Lesson14_16Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 248);
            this.Controls.Add(this.findNodeTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addNodeTextBox);
            this.Controls.Add(this.treeView1);
            this.Name = "Lesson14_16Form";
            this.Text = "Уроки 14-16";
            this.Click += new System.EventHandler(this.Lesson14_16Form_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox addNodeTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox findNodeTextBox;
    }
}