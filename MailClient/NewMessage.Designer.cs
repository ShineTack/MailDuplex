
namespace MailClient
{
    partial class NewMessage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.messageHeaderTextBox = new System.Windows.Forms.TextBox();
            this.messageBodyTextBox = new System.Windows.Forms.RichTextBox();
            this.sendMessage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.usersComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.messageHeaderTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.messageBodyTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sendMessage, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usersComboBox
            // 
            this.usersComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.usersComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.usersComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(3, 3);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(794, 24);
            this.usersComboBox.TabIndex = 0;
            // 
            // messageHeaderTextBox
            // 
            this.messageHeaderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageHeaderTextBox.Location = new System.Drawing.Point(3, 48);
            this.messageHeaderTextBox.Name = "messageHeaderTextBox";
            this.messageHeaderTextBox.Size = new System.Drawing.Size(794, 22);
            this.messageHeaderTextBox.TabIndex = 1;
            // 
            // messageBodyTextBox
            // 
            this.messageBodyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageBodyTextBox.Location = new System.Drawing.Point(3, 93);
            this.messageBodyTextBox.Name = "messageBodyTextBox";
            this.messageBodyTextBox.Size = new System.Drawing.Size(794, 309);
            this.messageBodyTextBox.TabIndex = 2;
            this.messageBodyTextBox.Text = "";
            // 
            // sendMessage
            // 
            this.sendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendMessage.Location = new System.Drawing.Point(3, 408);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(794, 39);
            this.sendMessage.TabIndex = 3;
            this.sendMessage.Text = "Send";
            this.sendMessage.UseVisualStyleBackColor = true;
            // 
            // NewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewMessage";
            this.Text = "NewMessage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.TextBox messageHeaderTextBox;
        private System.Windows.Forms.RichTextBox messageBodyTextBox;
        private System.Windows.Forms.Button sendMessage;
    }
}