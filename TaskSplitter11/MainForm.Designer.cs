namespace TaskSplitter11
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numSeparatorCount = new System.Windows.Forms.NumericUpDown();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(243, 44);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 46);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Separator";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the number of separators,\nthen click on 'Create'.\nA list of instructions will be displayed.";
            // 
            // numSeparatorCount
            // 
            this.numSeparatorCount.Location = new System.Drawing.Point(243, 12);
            this.numSeparatorCount.Name = "numSeparatorCount";
            this.numSeparatorCount.Size = new System.Drawing.Size(120, 23);
            this.numSeparatorCount.TabIndex = 1;
            this.numSeparatorCount.Minimum = 1;
            this.numSeparatorCount.Maximum = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 102);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskSeparator11Pro";
            this.ResumeLayout(false);
            //
            // Controls
            //
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.numSeparatorCount);
        }

        #endregion

        private Button btnCreate;
        private Label label1;
        private NumericUpDown numSeparatorCount;
    }
}