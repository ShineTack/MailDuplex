
namespace MailClient
{
    partial class Login
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.usernameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextBox = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.registrationButton = new DevExpress.XtraEditors.SimpleButton();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.passwordTextBox);
            this.tablePanel1.Controls.Add(this.usernameTextBox);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F)});
            this.tablePanel1.Size = new System.Drawing.Size(457, 141);
            this.tablePanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.tablePanel1.SetColumn(this.usernameTextBox, 1);
            this.usernameTextBox.Location = new System.Drawing.Point(94, 12);
            this.usernameTextBox.Name = "usernameTextBox";
            this.tablePanel1.SetRow(this.usernameTextBox, 0);
            this.usernameTextBox.Size = new System.Drawing.Size(360, 22);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.tablePanel1.SetColumn(this.passwordTextBox, 1);
            this.passwordTextBox.Location = new System.Drawing.Point(94, 59);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Properties.PasswordChar = '*';
            this.tablePanel1.SetRow(this.passwordTextBox, 1);
            this.passwordTextBox.Size = new System.Drawing.Size(360, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.loginButton);
            this.tablePanel2.Controls.Add(this.registrationButton);
            this.tablePanel2.Location = new System.Drawing.Point(94, 97);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 2);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(360, 41);
            this.tablePanel2.TabIndex = 4;
            // 
            // registrationButton
            // 
            this.tablePanel2.SetColumn(this.registrationButton, 0);
            this.registrationButton.Location = new System.Drawing.Point(3, 6);
            this.registrationButton.Name = "registrationButton";
            this.tablePanel2.SetRow(this.registrationButton, 0);
            this.registrationButton.Size = new System.Drawing.Size(174, 29);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Registration";
            // 
            // loginButton
            // 
            this.tablePanel2.SetColumn(this.loginButton, 1);
            this.loginButton.Location = new System.Drawing.Point(183, 6);
            this.loginButton.Name = "loginButton";
            this.tablePanel2.SetRow(this.loginButton, 0);
            this.loginButton.Size = new System.Drawing.Size(174, 29);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 141);
            this.Controls.Add(this.tablePanel1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.SimpleButton registrationButton;
        private DevExpress.XtraEditors.TextEdit passwordTextBox;
        private DevExpress.XtraEditors.TextEdit usernameTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}