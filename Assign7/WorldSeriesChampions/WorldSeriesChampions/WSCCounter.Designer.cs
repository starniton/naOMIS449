namespace WorldSeriesChampions
{
    partial class WSCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSCForm));
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.winsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.teamLabelStatic = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.teamListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 16;
            this.teamsListBox.Location = new System.Drawing.Point(12, 28);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(120, 196);
            this.teamsListBox.TabIndex = 0;
            this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.teamsListBox_SelectedIndexChanged);
            // 
            // winsTextBox
            // 
            this.winsTextBox.Location = new System.Drawing.Point(184, 124);
            this.winsTextBox.Name = "winsTextBox";
            this.winsTextBox.Size = new System.Drawing.Size(250, 22);
            this.winsTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wins:";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(138, 182);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 43);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // teamLabelStatic
            // 
            this.teamLabelStatic.AutoSize = true;
            this.teamLabelStatic.Location = new System.Drawing.Point(138, 68);
            this.teamLabelStatic.Name = "teamLabelStatic";
            this.teamLabelStatic.Size = new System.Drawing.Size(87, 17);
            this.teamLabelStatic.TabIndex = 5;
            this.teamLabelStatic.Text = "Team name:";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(231, 68);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(176, 17);
            this.teamLabel.TabIndex = 6;
            this.teamLabel.Text = "[Select a team to continue]";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(341, 182);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 43);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // teamListLabel
            // 
            this.teamListLabel.AutoSize = true;
            this.teamListLabel.Location = new System.Drawing.Point(32, 8);
            this.teamListLabel.Name = "teamListLabel";
            this.teamListLabel.Size = new System.Drawing.Size(77, 17);
            this.teamListLabel.TabIndex = 8;
            this.teamListLabel.Text = "Teams List";
            // 
            // WSCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(446, 237);
            this.Controls.Add(this.teamListLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.teamLabelStatic);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.winsTextBox);
            this.Controls.Add(this.teamsListBox);
            this.Name = "WSCForm";
            this.Text = "World Series Champions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.TextBox winsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label teamLabelStatic;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label teamListLabel;
    }
}

