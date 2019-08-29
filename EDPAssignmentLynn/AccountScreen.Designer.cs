namespace EDPAssignmentLynn
{
    partial class AccountScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtBoxDeposit = new System.Windows.Forms.TextBox();
            this.txtBoxWithdraw = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.toolTipBalance = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDeposit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDepositBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipWithdraw = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipWithdrawBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogout = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(241, 94);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(70, 21);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance";
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.Location = new System.Drawing.Point(340, 91);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(182, 20);
            this.txtBoxBalance.TabIndex = 1;
            this.toolTipBalance.SetToolTip(this.txtBoxBalance, "Displays your current balance. ");
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(225, 180);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(99, 34);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.toolTipDeposit.SetToolTip(this.btnDeposit, "Click here to deposit money into your account.\r\n");
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.OnDepositClicked);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(222, 233);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(102, 32);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.toolTipWithdraw.SetToolTip(this.btnWithdraw, "Click here to withdraw an amount");
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.OnWithdrawClicked);
            // 
            // txtBoxDeposit
            // 
            this.txtBoxDeposit.Location = new System.Drawing.Point(340, 180);
            this.txtBoxDeposit.Name = "txtBoxDeposit";
            this.txtBoxDeposit.Size = new System.Drawing.Size(182, 20);
            this.txtBoxDeposit.TabIndex = 4;
            this.toolTipDepositBox.SetToolTip(this.txtBoxDeposit, "Enter the amount you\'d like to deposit here.\r\n");
            // 
            // txtBoxWithdraw
            // 
            this.txtBoxWithdraw.Location = new System.Drawing.Point(340, 242);
            this.txtBoxWithdraw.Name = "txtBoxWithdraw";
            this.txtBoxWithdraw.Size = new System.Drawing.Size(182, 20);
            this.txtBoxWithdraw.TabIndex = 5;
            this.toolTipWithdrawBox.SetToolTip(this.txtBoxWithdraw, "Enter amount you\'d like to withdraw here.");
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(57, 387);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 34);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.toolTipLogout.SetToolTip(this.btnLogout, "Click here to logout user account.");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.OnLogoutClicked);
            // 
            // AccountScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtBoxWithdraw);
            this.Controls.Add(this.txtBoxDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtBoxBalance);
            this.Controls.Add(this.lblBalance);
            this.Name = "AccountScreen";
            this.Size = new System.Drawing.Size(1000, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBoxBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtBoxDeposit;
        private System.Windows.Forms.TextBox txtBoxWithdraw;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolTip toolTipBalance;
        private System.Windows.Forms.ToolTip toolTipDeposit;
        private System.Windows.Forms.ToolTip toolTipWithdraw;
        private System.Windows.Forms.ToolTip toolTipDepositBox;
        private System.Windows.Forms.ToolTip toolTipWithdrawBox;
        private System.Windows.Forms.ToolTip toolTipLogout;
    }
}
