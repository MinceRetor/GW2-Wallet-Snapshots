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
            this.components = new System.ComponentModel.Container();
            this.api_key_textbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.APIKeyLabel = new System.Windows.Forms.Label();
            this.EditConfigSaveButton = new System.Windows.Forms.Button();
            this.SavedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // api_key_textbox
            // 
            this.api_key_textbox.Location = new System.Drawing.Point(61, 27);
            this.api_key_textbox.Name = "api_key_textbox";
            this.api_key_textbox.Size = new System.Drawing.Size(447, 20);
            this.api_key_textbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // APIKeyLabel
            // 
            this.APIKeyLabel.AutoSize = true;
            this.APIKeyLabel.Location = new System.Drawing.Point(10, 27);
            this.APIKeyLabel.Name = "APIKeyLabel";
            this.APIKeyLabel.Size = new System.Drawing.Size(45, 13);
            this.APIKeyLabel.TabIndex = 3;
            this.APIKeyLabel.Text = "API Key";
            // 
            // EditConfigSaveButton
            // 
            this.EditConfigSaveButton.Location = new System.Drawing.Point(61, 87);
            this.EditConfigSaveButton.Name = "EditConfigSaveButton";
            this.EditConfigSaveButton.Size = new System.Drawing.Size(369, 73);
            this.EditConfigSaveButton.TabIndex = 4;
            this.EditConfigSaveButton.Text = "Save";
            this.EditConfigSaveButton.UseVisualStyleBackColor = true;
            this.EditConfigSaveButton.Click += new System.EventHandler(this.EditConfigSaveButton_Click);
            // 
            // SavedLabel
            // 
            this.SavedLabel.AutoSize = true;
            this.SavedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SavedLabel.Location = new System.Drawing.Point(198, 198);
            this.SavedLabel.Name = "SavedLabel";
            this.SavedLabel.Size = new System.Drawing.Size(91, 31);
            this.SavedLabel.TabIndex = 5;
            this.SavedLabel.Text = "Saved";
            // 
            // EditConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 264);
            this.Controls.Add(this.SavedLabel);
            this.Controls.Add(this.EditConfigSaveButton);
            this.Controls.Add(this.APIKeyLabel);
            this.Controls.Add(this.api_key_textbox);
            this.Name = "EditConfigWindow";
            this.Text = "EditConfigWindow";
            this.Load += new System.EventHandler(this.EditConfigWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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