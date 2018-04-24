﻿namespace ARKBreedingStats
{
    partial class MultiSetter
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonSex = new System.Windows.Forms.Button();
            this.checkBoxOwner = new System.Windows.Forms.CheckBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxSex = new System.Windows.Forms.CheckBox();
            this.checkBoxIsBred = new System.Windows.Forms.CheckBox();
            this.checkBoxBred = new System.Windows.Forms.CheckBox();
            this.checkBoxMother = new System.Windows.Forms.CheckBox();
            this.checkBoxFather = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxNote = new System.Windows.Forms.CheckBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonColor6 = new System.Windows.Forms.Button();
            this.buttonColor5 = new System.Windows.Forms.Button();
            this.buttonColor4 = new System.Windows.Forms.Button();
            this.buttonColor3 = new System.Windows.Forms.Button();
            this.buttonColor2 = new System.Windows.Forms.Button();
            this.buttonColor1 = new System.Windows.Forms.Button();
            this.checkBoxColor1 = new System.Windows.Forms.CheckBox();
            this.checkBoxColor2 = new System.Windows.Forms.CheckBox();
            this.checkBoxColor3 = new System.Windows.Forms.CheckBox();
            this.checkBoxColor4 = new System.Windows.Forms.CheckBox();
            this.checkBoxColor5 = new System.Windows.Forms.CheckBox();
            this.checkBoxColor6 = new System.Windows.Forms.CheckBox();
            this.groupBoxTags = new System.Windows.Forms.GroupBox();
            this.panelTags = new System.Windows.Forms.Panel();
            this.lbTagSettingInfo = new System.Windows.Forms.Label();
            this.tbNewTag = new System.Windows.Forms.TextBox();
            this.bAddTag = new System.Windows.Forms.Button();
            this.cbServer = new System.Windows.Forms.CheckBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.cbbSpecies = new System.Windows.Forms.ComboBox();
            this.checkBoxSpecies = new System.Windows.Forms.CheckBox();
            this.parentComboBoxFather = new ARKBreedingStats.ParentComboBox();
            this.parentComboBoxMother = new ARKBreedingStats.ParentComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Checked properties will overwrite the current ones of all selected Creatures.";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(15, 51);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(121, 20);
            this.textBoxOwner.TabIndex = 0;
            this.textBoxOwner.TextChanged += new System.EventHandler(this.textBoxOwner_TextChanged);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(105, 77);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(31, 23);
            this.buttonStatus.TabIndex = 1;
            this.buttonStatus.Text = "?";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonSex
            // 
            this.buttonSex.Location = new System.Drawing.Point(105, 106);
            this.buttonSex.Name = "buttonSex";
            this.buttonSex.Size = new System.Drawing.Size(31, 23);
            this.buttonSex.TabIndex = 2;
            this.buttonSex.Text = "?";
            this.buttonSex.UseVisualStyleBackColor = true;
            this.buttonSex.Click += new System.EventHandler(this.buttonSex_Click);
            // 
            // checkBoxOwner
            // 
            this.checkBoxOwner.AutoSize = true;
            this.checkBoxOwner.Location = new System.Drawing.Point(142, 53);
            this.checkBoxOwner.Name = "checkBoxOwner";
            this.checkBoxOwner.Size = new System.Drawing.Size(57, 17);
            this.checkBoxOwner.TabIndex = 15;
            this.checkBoxOwner.Text = "Owner";
            this.checkBoxOwner.UseVisualStyleBackColor = true;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(142, 81);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(56, 17);
            this.checkBoxStatus.TabIndex = 16;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // checkBoxSex
            // 
            this.checkBoxSex.AutoSize = true;
            this.checkBoxSex.Location = new System.Drawing.Point(142, 110);
            this.checkBoxSex.Name = "checkBoxSex";
            this.checkBoxSex.Size = new System.Drawing.Size(44, 17);
            this.checkBoxSex.TabIndex = 17;
            this.checkBoxSex.Text = "Sex";
            this.checkBoxSex.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsBred
            // 
            this.checkBoxIsBred.AutoSize = true;
            this.checkBoxIsBred.Location = new System.Drawing.Point(121, 138);
            this.checkBoxIsBred.Name = "checkBoxIsBred";
            this.checkBoxIsBred.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsBred.TabIndex = 3;
            this.checkBoxIsBred.UseVisualStyleBackColor = true;
            this.checkBoxIsBred.CheckedChanged += new System.EventHandler(this.checkBoxIsBred_CheckedChanged);
            // 
            // checkBoxBred
            // 
            this.checkBoxBred.AutoSize = true;
            this.checkBoxBred.Location = new System.Drawing.Point(142, 137);
            this.checkBoxBred.Name = "checkBoxBred";
            this.checkBoxBred.Size = new System.Drawing.Size(48, 17);
            this.checkBoxBred.TabIndex = 18;
            this.checkBoxBred.Text = "Bred";
            this.checkBoxBred.UseVisualStyleBackColor = true;
            // 
            // checkBoxMother
            // 
            this.checkBoxMother.AutoSize = true;
            this.checkBoxMother.Location = new System.Drawing.Point(142, 163);
            this.checkBoxMother.Name = "checkBoxMother";
            this.checkBoxMother.Size = new System.Drawing.Size(59, 17);
            this.checkBoxMother.TabIndex = 19;
            this.checkBoxMother.Text = "Mother";
            this.checkBoxMother.UseVisualStyleBackColor = true;
            // 
            // checkBoxFather
            // 
            this.checkBoxFather.AutoSize = true;
            this.checkBoxFather.Location = new System.Drawing.Point(142, 190);
            this.checkBoxFather.Name = "checkBoxFather";
            this.checkBoxFather.Size = new System.Drawing.Size(56, 17);
            this.checkBoxFather.TabIndex = 20;
            this.checkBoxFather.Text = "Father";
            this.checkBoxFather.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonApply.Location = new System.Drawing.Point(589, 297);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 13;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(508, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxNote
            // 
            this.checkBoxNote.AutoSize = true;
            this.checkBoxNote.Location = new System.Drawing.Point(142, 243);
            this.checkBoxNote.Name = "checkBoxNote";
            this.checkBoxNote.Size = new System.Drawing.Size(49, 17);
            this.checkBoxNote.TabIndex = 21;
            this.checkBoxNote.Text = "Note";
            this.checkBoxNote.UseVisualStyleBackColor = true;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(15, 241);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(121, 43);
            this.textBoxNote.TabIndex = 6;
            this.textBoxNote.TextChanged += new System.EventHandler(this.textBoxNote_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(225, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // buttonColor6
            // 
            this.buttonColor6.Location = new System.Drawing.Point(359, 179);
            this.buttonColor6.Name = "buttonColor6";
            this.buttonColor6.Size = new System.Drawing.Size(23, 23);
            this.buttonColor6.TabIndex = 12;
            this.buttonColor6.Text = "5";
            this.buttonColor6.UseVisualStyleBackColor = true;
            this.buttonColor6.Click += new System.EventHandler(this.buttonColor6_Click);
            // 
            // buttonColor5
            // 
            this.buttonColor5.Location = new System.Drawing.Point(359, 153);
            this.buttonColor5.Name = "buttonColor5";
            this.buttonColor5.Size = new System.Drawing.Size(23, 23);
            this.buttonColor5.TabIndex = 11;
            this.buttonColor5.Text = "4";
            this.buttonColor5.UseVisualStyleBackColor = true;
            this.buttonColor5.Click += new System.EventHandler(this.buttonColor5_Click);
            // 
            // buttonColor4
            // 
            this.buttonColor4.Location = new System.Drawing.Point(359, 127);
            this.buttonColor4.Name = "buttonColor4";
            this.buttonColor4.Size = new System.Drawing.Size(23, 23);
            this.buttonColor4.TabIndex = 10;
            this.buttonColor4.Text = "3";
            this.buttonColor4.UseVisualStyleBackColor = true;
            this.buttonColor4.Click += new System.EventHandler(this.buttonColor4_Click);
            // 
            // buttonColor3
            // 
            this.buttonColor3.Location = new System.Drawing.Point(359, 101);
            this.buttonColor3.Name = "buttonColor3";
            this.buttonColor3.Size = new System.Drawing.Size(23, 23);
            this.buttonColor3.TabIndex = 9;
            this.buttonColor3.Text = "2";
            this.buttonColor3.UseVisualStyleBackColor = true;
            this.buttonColor3.Click += new System.EventHandler(this.buttonColor3_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.Location = new System.Drawing.Point(359, 75);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(23, 23);
            this.buttonColor2.TabIndex = 8;
            this.buttonColor2.Text = "1";
            this.buttonColor2.UseVisualStyleBackColor = true;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // buttonColor1
            // 
            this.buttonColor1.Location = new System.Drawing.Point(359, 49);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(23, 23);
            this.buttonColor1.TabIndex = 7;
            this.buttonColor1.Text = "0";
            this.buttonColor1.UseVisualStyleBackColor = true;
            this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
            // 
            // checkBoxColor1
            // 
            this.checkBoxColor1.AutoSize = true;
            this.checkBoxColor1.Location = new System.Drawing.Point(388, 54);
            this.checkBoxColor1.Name = "checkBoxColor1";
            this.checkBoxColor1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColor1.TabIndex = 22;
            this.checkBoxColor1.UseVisualStyleBackColor = true;
            // 
            // checkBoxColor2
            // 
            this.checkBoxColor2.AutoSize = true;
            this.checkBoxColor2.Location = new System.Drawing.Point(388, 80);
            this.checkBoxColor2.Name = "checkBoxColor2";
            this.checkBoxColor2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColor2.TabIndex = 23;
            this.checkBoxColor2.UseVisualStyleBackColor = true;
            // 
            // checkBoxColor3
            // 
            this.checkBoxColor3.AutoSize = true;
            this.checkBoxColor3.Location = new System.Drawing.Point(388, 106);
            this.checkBoxColor3.Name = "checkBoxColor3";
            this.checkBoxColor3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColor3.TabIndex = 24;
            this.checkBoxColor3.UseVisualStyleBackColor = true;
            // 
            // checkBoxColor4
            // 
            this.checkBoxColor4.AutoSize = true;
            this.checkBoxColor4.Location = new System.Drawing.Point(388, 132);
            this.checkBoxColor4.Name = "checkBoxColor4";
            this.checkBoxColor4.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColor4.TabIndex = 25;
            this.checkBoxColor4.UseVisualStyleBackColor = true;
            // 
            // checkBoxColor5
            // 
            this.checkBoxColor5.AutoSize = true;
            this.checkBoxColor5.Location = new System.Drawing.Point(388, 158);
            this.checkBoxColor5.Name = "checkBoxColor5";
            this.checkBoxColor5.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColor5.TabIndex = 26;
            this.checkBoxColor5.UseVisualStyleBackColor = true;
            // 
            // checkBoxColor6
            // 
            this.checkBoxColor6.AutoSize = true;
            this.checkBoxColor6.Location = new System.Drawing.Point(388, 184);
            this.checkBoxColor6.Name = "checkBoxColor6";
            this.checkBoxColor6.Size = new System.Drawing.Size(15, 14);
            this.checkBoxColor6.TabIndex = 27;
            this.checkBoxColor6.UseVisualStyleBackColor = true;
            // 
            // groupBoxTags
            // 
            this.groupBoxTags.Controls.Add(this.panelTags);
            this.groupBoxTags.Controls.Add(this.lbTagSettingInfo);
            this.groupBoxTags.Location = new System.Drawing.Point(428, 12);
            this.groupBoxTags.Name = "groupBoxTags";
            this.groupBoxTags.Size = new System.Drawing.Size(236, 209);
            this.groupBoxTags.TabIndex = 29;
            this.groupBoxTags.TabStop = false;
            this.groupBoxTags.Text = "Tags";
            // 
            // panelTags
            // 
            this.panelTags.AutoScroll = true;
            this.panelTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTags.Location = new System.Drawing.Point(3, 29);
            this.panelTags.Name = "panelTags";
            this.panelTags.Size = new System.Drawing.Size(230, 177);
            this.panelTags.TabIndex = 0;
            // 
            // lbTagSettingInfo
            // 
            this.lbTagSettingInfo.AutoSize = true;
            this.lbTagSettingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTagSettingInfo.Location = new System.Drawing.Point(3, 16);
            this.lbTagSettingInfo.Name = "lbTagSettingInfo";
            this.lbTagSettingInfo.Size = new System.Drawing.Size(137, 13);
            this.lbTagSettingInfo.TabIndex = 1;
            this.lbTagSettingInfo.Text = "Apply Tag Setting | Set Tag";
            // 
            // tbNewTag
            // 
            this.tbNewTag.Location = new System.Drawing.Point(428, 227);
            this.tbNewTag.Name = "tbNewTag";
            this.tbNewTag.Size = new System.Drawing.Size(199, 20);
            this.tbNewTag.TabIndex = 30;
            // 
            // bAddTag
            // 
            this.bAddTag.Location = new System.Drawing.Point(633, 225);
            this.bAddTag.Name = "bAddTag";
            this.bAddTag.Size = new System.Drawing.Size(31, 23);
            this.bAddTag.TabIndex = 31;
            this.bAddTag.Text = "+";
            this.bAddTag.UseVisualStyleBackColor = true;
            this.bAddTag.Click += new System.EventHandler(this.bAddTag_Click);
            // 
            // cbServer
            // 
            this.cbServer.AutoSize = true;
            this.cbServer.Location = new System.Drawing.Point(142, 217);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(57, 17);
            this.cbServer.TabIndex = 33;
            this.cbServer.Text = "Server";
            this.cbServer.UseVisualStyleBackColor = true;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(15, 215);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(121, 20);
            this.tbServer.TabIndex = 32;
            this.tbServer.TextChanged += new System.EventHandler(this.tbServer_TextChanged);
            // 
            // cbbSpecies
            // 
            this.cbbSpecies.FormattingEnabled = true;
            this.cbbSpecies.Location = new System.Drawing.Point(15, 290);
            this.cbbSpecies.Name = "cbbSpecies";
            this.cbbSpecies.Size = new System.Drawing.Size(121, 21);
            this.cbbSpecies.TabIndex = 35;
            this.cbbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbbSpecies_SelectedIndexChanged);
            // 
            // checkBoxSpecies
            // 
            this.checkBoxSpecies.AutoSize = true;
            this.checkBoxSpecies.Location = new System.Drawing.Point(142, 292);
            this.checkBoxSpecies.Name = "checkBoxSpecies";
            this.checkBoxSpecies.Size = new System.Drawing.Size(64, 17);
            this.checkBoxSpecies.TabIndex = 36;
            this.checkBoxSpecies.Text = "Species";
            this.checkBoxSpecies.UseVisualStyleBackColor = true;
            this.checkBoxSpecies.CheckedChanged += new System.EventHandler(this.checkBoxSpecies_CheckedChanged);
            // 
            // parentComboBoxFather
            // 
            this.parentComboBoxFather.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.parentComboBoxFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentComboBoxFather.FormattingEnabled = true;
            this.parentComboBoxFather.Location = new System.Drawing.Point(15, 188);
            this.parentComboBoxFather.Name = "parentComboBoxFather";
            this.parentComboBoxFather.Size = new System.Drawing.Size(121, 21);
            this.parentComboBoxFather.TabIndex = 5;
            this.parentComboBoxFather.SelectedIndexChanged += new System.EventHandler(this.parentComboBoxFather_SelectedIndexChanged);
            // 
            // parentComboBoxMother
            // 
            this.parentComboBoxMother.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.parentComboBoxMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentComboBoxMother.FormattingEnabled = true;
            this.parentComboBoxMother.Location = new System.Drawing.Point(15, 161);
            this.parentComboBoxMother.Name = "parentComboBoxMother";
            this.parentComboBoxMother.Size = new System.Drawing.Size(121, 21);
            this.parentComboBoxMother.TabIndex = 4;
            this.parentComboBoxMother.SelectedIndexChanged += new System.EventHandler(this.parentComboBoxMother_SelectedIndexChanged);
            // 
            // MultiSetter
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(676, 332);
            this.Controls.Add(this.checkBoxSpecies);
            this.Controls.Add(this.cbbSpecies);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.bAddTag);
            this.Controls.Add(this.tbNewTag);
            this.Controls.Add(this.groupBoxTags);
            this.Controls.Add(this.checkBoxColor6);
            this.Controls.Add(this.checkBoxColor5);
            this.Controls.Add(this.checkBoxColor4);
            this.Controls.Add(this.checkBoxColor3);
            this.Controls.Add(this.checkBoxColor2);
            this.Controls.Add(this.checkBoxColor1);
            this.Controls.Add(this.buttonColor6);
            this.Controls.Add(this.buttonColor5);
            this.Controls.Add(this.buttonColor4);
            this.Controls.Add(this.buttonColor3);
            this.Controls.Add(this.buttonColor2);
            this.Controls.Add(this.buttonColor1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.checkBoxNote);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.parentComboBoxFather);
            this.Controls.Add(this.parentComboBoxMother);
            this.Controls.Add(this.checkBoxFather);
            this.Controls.Add(this.checkBoxMother);
            this.Controls.Add(this.checkBoxBred);
            this.Controls.Add(this.checkBoxIsBred);
            this.Controls.Add(this.checkBoxSex);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.checkBoxOwner);
            this.Controls.Add(this.buttonSex);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MultiSetter";
            this.ShowInTaskbar = false;
            this.Text = "MultiSetter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxTags.ResumeLayout(false);
            this.groupBoxTags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonSex;
        private System.Windows.Forms.CheckBox checkBoxOwner;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxSex;
        private System.Windows.Forms.CheckBox checkBoxIsBred;
        private System.Windows.Forms.CheckBox checkBoxBred;
        private System.Windows.Forms.CheckBox checkBoxMother;
        private System.Windows.Forms.CheckBox checkBoxFather;
        private ParentComboBox parentComboBoxMother;
        private ParentComboBox parentComboBoxFather;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonColor6;
        private System.Windows.Forms.Button buttonColor5;
        private System.Windows.Forms.Button buttonColor4;
        private System.Windows.Forms.Button buttonColor3;
        private System.Windows.Forms.Button buttonColor2;
        private System.Windows.Forms.Button buttonColor1;
        private System.Windows.Forms.CheckBox checkBoxColor1;
        private System.Windows.Forms.CheckBox checkBoxColor2;
        private System.Windows.Forms.CheckBox checkBoxColor3;
        private System.Windows.Forms.CheckBox checkBoxColor4;
        private System.Windows.Forms.CheckBox checkBoxColor5;
        private System.Windows.Forms.CheckBox checkBoxColor6;
        private System.Windows.Forms.GroupBox groupBoxTags;
        private System.Windows.Forms.Panel panelTags;
        private System.Windows.Forms.TextBox tbNewTag;
        private System.Windows.Forms.Button bAddTag;
        private System.Windows.Forms.CheckBox cbServer;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label lbTagSettingInfo;
        private System.Windows.Forms.ComboBox cbbSpecies;
        private System.Windows.Forms.CheckBox checkBoxSpecies;
    }
}