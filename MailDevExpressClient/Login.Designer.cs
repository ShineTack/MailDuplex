
namespace MailDevExpressClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.Ussd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.usernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.registrationButton = new DevExpress.XtraEditors.SimpleButton();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F)});
            this.tablePanel1.Controls.Add(this.passwordTextEdit);
            this.tablePanel1.Controls.Add(this.usernameTextEdit);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.Ussd);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F)});
            this.tablePanel1.Size = new System.Drawing.Size(520, 242);
            this.tablePanel1.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 1);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.loginButton);
            this.tablePanel2.Controls.Add(this.registrationButton);
            this.tablePanel2.Location = new System.Drawing.Point(107, 165);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 2);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(410, 74);
            this.tablePanel2.TabIndex = 0;
            // 
            // Ussd
            // 
            this.tablePanel1.SetColumn(this.Ussd, 0);
            this.Ussd.Location = new System.Drawing.Point(3, 32);
            this.Ussd.Name = "Ussd";
            this.tablePanel1.SetRow(this.Ussd, 0);
            this.Ussd.Size = new System.Drawing.Size(58, 16);
            this.Ussd.TabIndex = 1;
            this.Ussd.Text = "Username";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 113);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Password";
            // 
            // usernameTextEdit
            // 
            this.tablePanel1.SetColumn(this.usernameTextEdit, 1);
            this.usernameTextEdit.Location = new System.Drawing.Point(107, 29);
            this.usernameTextEdit.Name = "usernameTextEdit";
            this.tablePanel1.SetRow(this.usernameTextEdit, 0);
            this.usernameTextEdit.Size = new System.Drawing.Size(410, 22);
            this.usernameTextEdit.TabIndex = 3;
            // 
            // passwordTextEdit
            // 
            this.tablePanel1.SetColumn(this.passwordTextEdit, 1);
            this.passwordTextEdit.Location = new System.Drawing.Point(107, 110);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.tablePanel1.SetRow(this.passwordTextEdit, 1);
            this.passwordTextEdit.Size = new System.Drawing.Size(410, 22);
            this.passwordTextEdit.TabIndex = 4;
            // 
            // registrationButton
            // 
            this.tablePanel2.SetColumn(this.registrationButton, 0);
            this.registrationButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.registrationButton.Location = new System.Drawing.Point(3, 3);
            this.registrationButton.Name = "registrationButton";
            this.tablePanel2.SetRow(this.registrationButton, 0);
            this.registrationButton.Size = new System.Drawing.Size(199, 68);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Registration";
            // 
            // loginButton
            // 
            this.tablePanel2.SetColumn(this.loginButton, 1);
            this.loginButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.loginButton.Location = new System.Drawing.Point(208, 3);
            this.loginButton.Name = "loginButton";
            this.tablePanel2.SetRow(this.loginButton, 0);
            this.loginButton.Size = new System.Drawing.Size(199, 68);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 242);
            this.Controls.Add(this.tablePanel1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit usernameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl Ussd;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.SimpleButton registrationButton;
    }
}