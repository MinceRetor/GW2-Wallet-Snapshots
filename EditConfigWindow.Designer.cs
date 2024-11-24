namespace GW2_Wallet_Snapshots
{
    partial class EditConfigWindow
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
            components = new System.ComponentModel.Container();
            api_key_textbox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            APIKeyLabel = new Label();
            EditConfigSaveButton = new Button();
            SavedLabel = new Label();
            SuspendLayout();
            // 
            // api_key_textbox
            // 
            api_key_textbox.Location = new Point(71, 31);
            api_key_textbox.Margin = new Padding(4, 3, 4, 3);
            api_key_textbox.Name = "api_key_textbox";
            api_key_textbox.Size = new Size(521, 23);
            api_key_textbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // APIKeyLabel
            // 
            APIKeyLabel.AutoSize = true;
            APIKeyLabel.Location = new Point(12, 31);
            APIKeyLabel.Margin = new Padding(4, 0, 4, 0);
            APIKeyLabel.Name = "APIKeyLabel";
            APIKeyLabel.Size = new Size(47, 15);
            APIKeyLabel.TabIndex = 3;
            APIKeyLabel.Text = "API Key";
            // 
            // EditConfigSaveButton
            // 
            EditConfigSaveButton.Location = new Point(71, 100);
            EditConfigSaveButton.Margin = new Padding(4, 3, 4, 3);
            EditConfigSaveButton.Name = "EditConfigSaveButton";
            EditConfigSaveButton.Size = new Size(430, 84);
            EditConfigSaveButton.TabIndex = 4;
            EditConfigSaveButton.Text = "Save";
            EditConfigSaveButton.UseVisualStyleBackColor = true;
            EditConfigSaveButton.Click += EditConfigSaveButton_Click;
            // 
            // SavedLabel
            // 
            SavedLabel.AutoSize = true;
            SavedLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SavedLabel.Location = new Point(231, 228);
            SavedLabel.Margin = new Padding(4, 0, 4, 0);
            SavedLabel.Name = "SavedLabel";
            SavedLabel.Size = new Size(91, 31);
            SavedLabel.TabIndex = 5;
            SavedLabel.Text = "Saved";
            // 
            // EditConfigWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 305);
            Controls.Add(SavedLabel);
            Controls.Add(EditConfigSaveButton);
            Controls.Add(APIKeyLabel);
            Controls.Add(api_key_textbox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditConfigWindow";
            Text = "Edit Config";
            Load += EditConfigWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox api_key_textbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label APIKeyLabel;
        private System.Windows.Forms.Button EditConfigSaveButton;
        private System.Windows.Forms.Label SavedLabel;
    }
}