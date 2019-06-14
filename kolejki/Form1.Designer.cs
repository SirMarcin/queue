namespace kolejki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.makeTaskButton = new System.Windows.Forms.Button();
            this.currentTaskTextBox = new System.Windows.Forms.TextBox();
            this.highPriorityList = new System.Windows.Forms.TextBox();
            this.lowPriorityList = new System.Windows.Forms.TextBox();
            this.highPriorityLabel = new System.Windows.Forms.Label();
            this.lowPriorityLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.finishedTasksList = new System.Windows.Forms.TextBox();
            this.finishedTasksLLabel = new System.Windows.Forms.Label();
            this.currentTaskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeTaskButton
            // 
            this.makeTaskButton.Location = new System.Drawing.Point(15, 334);
            this.makeTaskButton.Name = "makeTaskButton";
            this.makeTaskButton.Size = new System.Drawing.Size(206, 29);
            this.makeTaskButton.TabIndex = 0;
            this.makeTaskButton.Text = "Make new task";
            this.makeTaskButton.UseVisualStyleBackColor = true;
            this.makeTaskButton.Click += new System.EventHandler(this.makeTaskButton_Click);
            // 
            // currentTaskTextBox
            // 
            this.currentTaskTextBox.Location = new System.Drawing.Point(15, 144);
            this.currentTaskTextBox.Name = "currentTaskTextBox";
            this.currentTaskTextBox.Size = new System.Drawing.Size(205, 20);
            this.currentTaskTextBox.TabIndex = 1;
            // 
            // highPriorityList
            // 
            this.highPriorityList.Location = new System.Drawing.Point(15, 212);
            this.highPriorityList.Multiline = true;
            this.highPriorityList.Name = "highPriorityList";
            this.highPriorityList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.highPriorityList.Size = new System.Drawing.Size(100, 116);
            this.highPriorityList.TabIndex = 2;
            // 
            // lowPriorityList
            // 
            this.lowPriorityList.Location = new System.Drawing.Point(121, 212);
            this.lowPriorityList.Multiline = true;
            this.lowPriorityList.Name = "lowPriorityList";
            this.lowPriorityList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lowPriorityList.Size = new System.Drawing.Size(100, 116);
            this.lowPriorityList.TabIndex = 3;
            // 
            // highPriorityLabel
            // 
            this.highPriorityLabel.AutoSize = true;
            this.highPriorityLabel.Location = new System.Drawing.Point(12, 196);
            this.highPriorityLabel.Name = "highPriorityLabel";
            this.highPriorityLabel.Size = new System.Drawing.Size(62, 13);
            this.highPriorityLabel.TabIndex = 4;
            this.highPriorityLabel.Text = "High priority";
            // 
            // lowPriorityLabel
            // 
            this.lowPriorityLabel.AutoSize = true;
            this.lowPriorityLabel.Location = new System.Drawing.Point(118, 196);
            this.lowPriorityLabel.Name = "lowPriorityLabel";
            this.lowPriorityLabel.Size = new System.Drawing.Size(60, 13);
            this.lowPriorityLabel.TabIndex = 5;
            this.lowPriorityLabel.Text = "Low priority";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 170);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(205, 23);
            this.progressBar.TabIndex = 6;
            // 
            // finishedTasksList
            // 
            this.finishedTasksList.Location = new System.Drawing.Point(15, 25);
            this.finishedTasksList.Multiline = true;
            this.finishedTasksList.Name = "finishedTasksList";
            this.finishedTasksList.Size = new System.Drawing.Size(205, 96);
            this.finishedTasksList.TabIndex = 7;
            // 
            // finishedTasksLLabel
            // 
            this.finishedTasksLLabel.AutoSize = true;
            this.finishedTasksLLabel.Location = new System.Drawing.Point(12, 9);
            this.finishedTasksLLabel.Name = "finishedTasksLLabel";
            this.finishedTasksLLabel.Size = new System.Drawing.Size(74, 13);
            this.finishedTasksLLabel.TabIndex = 8;
            this.finishedTasksLLabel.Text = "Finished tasks";
            // 
            // currentTaskLabel
            // 
            this.currentTaskLabel.AutoSize = true;
            this.currentTaskLabel.Location = new System.Drawing.Point(12, 128);
            this.currentTaskLabel.Name = "currentTaskLabel";
            this.currentTaskLabel.Size = new System.Drawing.Size(64, 13);
            this.currentTaskLabel.TabIndex = 9;
            this.currentTaskLabel.Text = "Current task";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 379);
            this.Controls.Add(this.currentTaskLabel);
            this.Controls.Add(this.finishedTasksLLabel);
            this.Controls.Add(this.finishedTasksList);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lowPriorityLabel);
            this.Controls.Add(this.highPriorityLabel);
            this.Controls.Add(this.lowPriorityList);
            this.Controls.Add(this.highPriorityList);
            this.Controls.Add(this.currentTaskTextBox);
            this.Controls.Add(this.makeTaskButton);
            this.Name = "Form1";
            this.Text = "Dwukolejka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeTaskButton;
        private System.Windows.Forms.TextBox currentTaskTextBox;
        private System.Windows.Forms.TextBox highPriorityList;
        private System.Windows.Forms.TextBox lowPriorityList;
        private System.Windows.Forms.Label highPriorityLabel;
        private System.Windows.Forms.Label lowPriorityLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox finishedTasksList;
        private System.Windows.Forms.Label finishedTasksLLabel;
        private System.Windows.Forms.Label currentTaskLabel;
    }
}

