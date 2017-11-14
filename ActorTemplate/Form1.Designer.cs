namespace ActorTemplate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txb_ActorName = new System.Windows.Forms.TextBox();
            this.cmb_ActorType = new System.Windows.Forms.ComboBox();
            this.txb_ProjectPath = new System.Windows.Forms.TextBox();
            this.btn_SelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_PackageVersionUpdate = new System.Windows.Forms.Button();
            this.txb_SFLoggingEmail = new System.Windows.Forms.TextBox();
            this.txb_SFLoggingDatabase = new System.Windows.Forms.TextBox();
            this.txb_SFLoggingAI = new System.Windows.Forms.TextBox();
            this.txb_SFLogging = new System.Windows.Forms.TextBox();
            this.txb_SFAI = new System.Windows.Forms.TextBox();
            this.txb_SFAction = new System.Windows.Forms.TextBox();
            this.txb_SF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Submit.Location = new System.Drawing.Point(129, 227);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(244, 34);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txb_ActorName
            // 
            this.txb_ActorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_ActorName.Location = new System.Drawing.Point(135, 95);
            this.txb_ActorName.Name = "txb_ActorName";
            this.txb_ActorName.Size = new System.Drawing.Size(238, 23);
            this.txb_ActorName.TabIndex = 1;
            // 
            // cmb_ActorType
            // 
            this.cmb_ActorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ActorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_ActorType.FormattingEnabled = true;
            this.cmb_ActorType.Location = new System.Drawing.Point(136, 50);
            this.cmb_ActorType.Name = "cmb_ActorType";
            this.cmb_ActorType.Size = new System.Drawing.Size(237, 24);
            this.cmb_ActorType.TabIndex = 2;
            // 
            // txb_ProjectPath
            // 
            this.txb_ProjectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_ProjectPath.Location = new System.Drawing.Point(135, 139);
            this.txb_ProjectPath.Name = "txb_ProjectPath";
            this.txb_ProjectPath.ReadOnly = true;
            this.txb_ProjectPath.Size = new System.Drawing.Size(238, 23);
            this.txb_ProjectPath.TabIndex = 1;
            // 
            // btn_SelectFolder
            // 
            this.btn_SelectFolder.Location = new System.Drawing.Point(283, 183);
            this.btn_SelectFolder.Name = "btn_SelectFolder";
            this.btn_SelectFolder.Size = new System.Drawing.Size(90, 23);
            this.btn_SelectFolder.TabIndex = 3;
            this.btn_SelectFolder.Text = "Select Folder";
            this.btn_SelectFolder.UseVisualStyleBackColor = true;
            this.btn_SelectFolder.Click += new System.EventHandler(this.btn_SelectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Actor Type：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Actor Name：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Project Path：";
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 344);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_Submit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txb_ActorName);
            this.tabPage1.Controls.Add(this.txb_ProjectPath);
            this.tabPage1.Controls.Add(this.btn_SelectFolder);
            this.tabPage1.Controls.Add(this.cmb_ActorType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_PackageVersionUpdate);
            this.tabPage2.Controls.Add(this.txb_SFLoggingEmail);
            this.tabPage2.Controls.Add(this.txb_SFLoggingDatabase);
            this.tabPage2.Controls.Add(this.txb_SFLoggingAI);
            this.tabPage2.Controls.Add(this.txb_SFLogging);
            this.tabPage2.Controls.Add(this.txb_SFAI);
            this.tabPage2.Controls.Add(this.txb_SFAction);
            this.tabPage2.Controls.Add(this.txb_SF);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_PackageVersionUpdate
            // 
            this.btn_PackageVersionUpdate.Location = new System.Drawing.Point(155, 277);
            this.btn_PackageVersionUpdate.Name = "btn_PackageVersionUpdate";
            this.btn_PackageVersionUpdate.Size = new System.Drawing.Size(129, 28);
            this.btn_PackageVersionUpdate.TabIndex = 2;
            this.btn_PackageVersionUpdate.Text = "Update";
            this.btn_PackageVersionUpdate.UseVisualStyleBackColor = true;
            this.btn_PackageVersionUpdate.Click += new System.EventHandler(this.btn_PackageVersionUpdate_Click);
            // 
            // txb_SFLoggingEmail
            // 
            this.txb_SFLoggingEmail.Location = new System.Drawing.Point(232, 236);
            this.txb_SFLoggingEmail.Name = "txb_SFLoggingEmail";
            this.txb_SFLoggingEmail.Size = new System.Drawing.Size(100, 20);
            this.txb_SFLoggingEmail.TabIndex = 1;
            // 
            // txb_SFLoggingDatabase
            // 
            this.txb_SFLoggingDatabase.Location = new System.Drawing.Point(232, 205);
            this.txb_SFLoggingDatabase.Name = "txb_SFLoggingDatabase";
            this.txb_SFLoggingDatabase.Size = new System.Drawing.Size(100, 20);
            this.txb_SFLoggingDatabase.TabIndex = 1;
            // 
            // txb_SFLoggingAI
            // 
            this.txb_SFLoggingAI.Location = new System.Drawing.Point(232, 174);
            this.txb_SFLoggingAI.Name = "txb_SFLoggingAI";
            this.txb_SFLoggingAI.Size = new System.Drawing.Size(100, 20);
            this.txb_SFLoggingAI.TabIndex = 1;
            // 
            // txb_SFLogging
            // 
            this.txb_SFLogging.Location = new System.Drawing.Point(232, 143);
            this.txb_SFLogging.Name = "txb_SFLogging";
            this.txb_SFLogging.Size = new System.Drawing.Size(100, 20);
            this.txb_SFLogging.TabIndex = 1;
            // 
            // txb_SFAI
            // 
            this.txb_SFAI.Location = new System.Drawing.Point(232, 112);
            this.txb_SFAI.Name = "txb_SFAI";
            this.txb_SFAI.Size = new System.Drawing.Size(100, 20);
            this.txb_SFAI.TabIndex = 1;
            // 
            // txb_SFAction
            // 
            this.txb_SFAction.Location = new System.Drawing.Point(232, 81);
            this.txb_SFAction.Name = "txb_SFAction";
            this.txb_SFAction.Size = new System.Drawing.Size(100, 20);
            this.txb_SFAction.TabIndex = 1;
            // 
            // txb_SF
            // 
            this.txb_SF.Location = new System.Drawing.Point(232, 50);
            this.txb_SF.Name = "txb_SF";
            this.txb_SF.Size = new System.Drawing.Size(100, 20);
            this.txb_SF.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "KC.Foundation.SF.Logging.Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "KC.Foundation.SF.Logging.Database";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "KC.Foundation.SF.Logging.AI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "KC.Foundation.SF.Logging";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "KC.Foundation.SF.AI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "KC.Foundation.SF.Action";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(229, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Version";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(87, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "NuGet Package Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "KC.Foundation.SF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 344);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Fabric Actor Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txb_ActorName;
        private System.Windows.Forms.ComboBox cmb_ActorType;
        private System.Windows.Forms.TextBox txb_ProjectPath;
        private System.Windows.Forms.Button btn_SelectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txb_SF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_SFLoggingEmail;
        private System.Windows.Forms.TextBox txb_SFLoggingDatabase;
        private System.Windows.Forms.TextBox txb_SFLoggingAI;
        private System.Windows.Forms.TextBox txb_SFLogging;
        private System.Windows.Forms.TextBox txb_SFAI;
        private System.Windows.Forms.TextBox txb_SFAction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_PackageVersionUpdate;
    }
}

