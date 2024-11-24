namespace GW2_Wallet_Snapshots
{
    partial class CreateSnapshotWindow
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
            label1 = new Label();
            SnapshotDescriptionTextBox = new TextBox();
            CreateSnapshotButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Description:";
            // 
            // SnapshotDescriptionTextBox
            // 
            SnapshotDescriptionTextBox.Location = new Point(12, 51);
            SnapshotDescriptionTextBox.Name = "SnapshotDescriptionTextBox";
            SnapshotDescriptionTextBox.Size = new Size(551, 23);
            SnapshotDescriptionTextBox.TabIndex = 1;
            // 
            // CreateSnapshotButton
            // 
            CreateSnapshotButton.Font = new Font("Segoe UI", 14F);
            CreateSnapshotButton.Location = new Point(82, 105);
            CreateSnapshotButton.Name = "CreateSnapshotButton";
            CreateSnapshotButton.Size = new Size(402, 109);
            CreateSnapshotButton.TabIndex = 2;
            CreateSnapshotButton.Text = "Create Snapshot";
            CreateSnapshotButton.UseVisualStyleBackColor = true;
            CreateSnapshotButton.Click += CreateSnapshotButton_Click;
            // 
            // CreateSnapshotWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 248);
            Controls.Add(CreateSnapshotButton);
            Controls.Add(SnapshotDescriptionTextBox);
            Controls.Add(label1);
            Name = "CreateSnapshotWindow";
            Text = "CreateSnapshotWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SnapshotDescriptionTextBox;
        private Button CreateSnapshotButton;
    }
}