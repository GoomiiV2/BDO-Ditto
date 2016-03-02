namespace BDO_Ditto
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Gb_Source = new System.Windows.Forms.GroupBox();
            this.Btt_SourceBrowse = new System.Windows.Forms.Button();
            this.Tb_SourcePath = new System.Windows.Forms.TextBox();
            this.Sections = new System.Windows.Forms.GroupBox();
            this.Cb_Voice = new System.Windows.Forms.CheckBox();
            this.Cb_StandbyExpression = new System.Windows.Forms.CheckBox();
            this.Cb_HairColor = new System.Windows.Forms.CheckBox();
            this.Cb_BodyShape = new System.Windows.Forms.CheckBox();
            this.Cb_HairAndFace = new System.Windows.Forms.CheckBox();
            this.Cb_FaceShape = new System.Windows.Forms.CheckBox();
            this.Cb_EyeMakeup = new System.Windows.Forms.CheckBox();
            this.Cb_EyeLine = new System.Windows.Forms.CheckBox();
            this.Cb_Eyes = new System.Windows.Forms.CheckBox();
            this.Cb_Skin = new System.Windows.Forms.CheckBox();
            this.Gb_Target = new System.Windows.Forms.GroupBox();
            this.Btt_TargetBrowse = new System.Windows.Forms.Button();
            this.Tb_TargetPath = new System.Windows.Forms.TextBox();
            this.Btt_CopySections = new System.Windows.Forms.Button();
            this.Gb_Source.SuspendLayout();
            this.Sections.SuspendLayout();
            this.Gb_Target.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Source
            // 
            this.Gb_Source.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_Source.Controls.Add(this.Btt_SourceBrowse);
            this.Gb_Source.Controls.Add(this.Tb_SourcePath);
            this.Gb_Source.Location = new System.Drawing.Point(0, 2);
            this.Gb_Source.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Gb_Source.Name = "Gb_Source";
            this.Gb_Source.Size = new System.Drawing.Size(404, 47);
            this.Gb_Source.TabIndex = 0;
            this.Gb_Source.TabStop = false;
            this.Gb_Source.Text = "Source Template";
            // 
            // Btt_SourceBrowse
            // 
            this.Btt_SourceBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btt_SourceBrowse.Location = new System.Drawing.Point(271, 18);
            this.Btt_SourceBrowse.Name = "Btt_SourceBrowse";
            this.Btt_SourceBrowse.Size = new System.Drawing.Size(127, 23);
            this.Btt_SourceBrowse.TabIndex = 1;
            this.Btt_SourceBrowse.Text = "Select";
            this.Btt_SourceBrowse.UseVisualStyleBackColor = true;
            this.Btt_SourceBrowse.Click += new System.EventHandler(this.Btt_SourceBrowse_Click);
            // 
            // Tb_SourcePath
            // 
            this.Tb_SourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_SourcePath.Location = new System.Drawing.Point(6, 19);
            this.Tb_SourcePath.Name = "Tb_SourcePath";
            this.Tb_SourcePath.Size = new System.Drawing.Size(258, 20);
            this.Tb_SourcePath.TabIndex = 0;
            this.Tb_SourcePath.WordWrap = false;
            // 
            // Sections
            // 
            this.Sections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sections.Controls.Add(this.Cb_Voice);
            this.Sections.Controls.Add(this.Cb_StandbyExpression);
            this.Sections.Controls.Add(this.Cb_HairColor);
            this.Sections.Controls.Add(this.Cb_BodyShape);
            this.Sections.Controls.Add(this.Cb_HairAndFace);
            this.Sections.Controls.Add(this.Cb_FaceShape);
            this.Sections.Controls.Add(this.Cb_EyeMakeup);
            this.Sections.Controls.Add(this.Cb_EyeLine);
            this.Sections.Controls.Add(this.Cb_Eyes);
            this.Sections.Controls.Add(this.Cb_Skin);
            this.Sections.Location = new System.Drawing.Point(0, 55);
            this.Sections.Name = "Sections";
            this.Sections.Size = new System.Drawing.Size(404, 135);
            this.Sections.TabIndex = 1;
            this.Sections.TabStop = false;
            this.Sections.Text = "Sections";
            // 
            // Cb_Voice
            // 
            this.Cb_Voice.AutoSize = true;
            this.Cb_Voice.Location = new System.Drawing.Point(240, 111);
            this.Cb_Voice.Name = "Cb_Voice";
            this.Cb_Voice.Size = new System.Drawing.Size(53, 17);
            this.Cb_Voice.TabIndex = 9;
            this.Cb_Voice.Text = "Voice";
            this.Cb_Voice.UseVisualStyleBackColor = true;
            // 
            // Cb_StandbyExpression
            // 
            this.Cb_StandbyExpression.AutoSize = true;
            this.Cb_StandbyExpression.Location = new System.Drawing.Point(12, 111);
            this.Cb_StandbyExpression.Name = "Cb_StandbyExpression";
            this.Cb_StandbyExpression.Size = new System.Drawing.Size(119, 17);
            this.Cb_StandbyExpression.TabIndex = 8;
            this.Cb_StandbyExpression.Text = "Standby Expression";
            this.Cb_StandbyExpression.UseVisualStyleBackColor = true;
            // 
            // Cb_HairColor
            // 
            this.Cb_HairColor.AutoSize = true;
            this.Cb_HairColor.Location = new System.Drawing.Point(12, 42);
            this.Cb_HairColor.Name = "Cb_HairColor";
            this.Cb_HairColor.Size = new System.Drawing.Size(72, 17);
            this.Cb_HairColor.TabIndex = 1;
            this.Cb_HairColor.Text = "Hair Color";
            this.Cb_HairColor.UseVisualStyleBackColor = true;
            // 
            // Cb_BodyShape
            // 
            this.Cb_BodyShape.AutoSize = true;
            this.Cb_BodyShape.Location = new System.Drawing.Point(240, 88);
            this.Cb_BodyShape.Name = "Cb_BodyShape";
            this.Cb_BodyShape.Size = new System.Drawing.Size(84, 17);
            this.Cb_BodyShape.TabIndex = 7;
            this.Cb_BodyShape.Text = "Body Shape";
            this.Cb_BodyShape.UseVisualStyleBackColor = true;
            // 
            // Cb_HairAndFace
            // 
            this.Cb_HairAndFace.AutoSize = true;
            this.Cb_HairAndFace.Location = new System.Drawing.Point(12, 19);
            this.Cb_HairAndFace.Name = "Cb_HairAndFace";
            this.Cb_HairAndFace.Size = new System.Drawing.Size(120, 17);
            this.Cb_HairAndFace.TabIndex = 0;
            this.Cb_HairAndFace.Text = "Hair and Face Type";
            this.Cb_HairAndFace.UseVisualStyleBackColor = true;
            // 
            // Cb_FaceShape
            // 
            this.Cb_FaceShape.AutoSize = true;
            this.Cb_FaceShape.Location = new System.Drawing.Point(12, 88);
            this.Cb_FaceShape.Name = "Cb_FaceShape";
            this.Cb_FaceShape.Size = new System.Drawing.Size(84, 17);
            this.Cb_FaceShape.TabIndex = 6;
            this.Cb_FaceShape.Text = "Face Shape";
            this.Cb_FaceShape.UseVisualStyleBackColor = true;
            // 
            // Cb_EyeMakeup
            // 
            this.Cb_EyeMakeup.AutoSize = true;
            this.Cb_EyeMakeup.Location = new System.Drawing.Point(240, 42);
            this.Cb_EyeMakeup.Name = "Cb_EyeMakeup";
            this.Cb_EyeMakeup.Size = new System.Drawing.Size(86, 17);
            this.Cb_EyeMakeup.TabIndex = 2;
            this.Cb_EyeMakeup.Text = "Eye Makeup";
            this.Cb_EyeMakeup.UseVisualStyleBackColor = true;
            // 
            // Cb_EyeLine
            // 
            this.Cb_EyeLine.AutoSize = true;
            this.Cb_EyeLine.Location = new System.Drawing.Point(240, 65);
            this.Cb_EyeLine.Name = "Cb_EyeLine";
            this.Cb_EyeLine.Size = new System.Drawing.Size(67, 17);
            this.Cb_EyeLine.TabIndex = 5;
            this.Cb_EyeLine.Text = "Eye Line";
            this.Cb_EyeLine.UseVisualStyleBackColor = true;
            // 
            // Cb_Eyes
            // 
            this.Cb_Eyes.AutoSize = true;
            this.Cb_Eyes.Location = new System.Drawing.Point(240, 19);
            this.Cb_Eyes.Name = "Cb_Eyes";
            this.Cb_Eyes.Size = new System.Drawing.Size(49, 17);
            this.Cb_Eyes.TabIndex = 3;
            this.Cb_Eyes.Text = "Eyes";
            this.Cb_Eyes.UseVisualStyleBackColor = true;
            // 
            // Cb_Skin
            // 
            this.Cb_Skin.AutoSize = true;
            this.Cb_Skin.Location = new System.Drawing.Point(12, 65);
            this.Cb_Skin.Name = "Cb_Skin";
            this.Cb_Skin.Size = new System.Drawing.Size(47, 17);
            this.Cb_Skin.TabIndex = 4;
            this.Cb_Skin.Text = "Skin";
            this.Cb_Skin.UseVisualStyleBackColor = true;
            // 
            // Gb_Target
            // 
            this.Gb_Target.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_Target.Controls.Add(this.Btt_TargetBrowse);
            this.Gb_Target.Controls.Add(this.Tb_TargetPath);
            this.Gb_Target.Location = new System.Drawing.Point(0, 196);
            this.Gb_Target.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Gb_Target.Name = "Gb_Target";
            this.Gb_Target.Size = new System.Drawing.Size(404, 47);
            this.Gb_Target.TabIndex = 2;
            this.Gb_Target.TabStop = false;
            this.Gb_Target.Text = "Target Template";
            // 
            // Btt_TargetBrowse
            // 
            this.Btt_TargetBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btt_TargetBrowse.Location = new System.Drawing.Point(271, 18);
            this.Btt_TargetBrowse.Name = "Btt_TargetBrowse";
            this.Btt_TargetBrowse.Size = new System.Drawing.Size(127, 23);
            this.Btt_TargetBrowse.TabIndex = 1;
            this.Btt_TargetBrowse.Text = "Select";
            this.Btt_TargetBrowse.UseVisualStyleBackColor = true;
            this.Btt_TargetBrowse.Click += new System.EventHandler(this.Btt_TargetBrowse_Click);
            // 
            // Tb_TargetPath
            // 
            this.Tb_TargetPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_TargetPath.Location = new System.Drawing.Point(6, 19);
            this.Tb_TargetPath.Name = "Tb_TargetPath";
            this.Tb_TargetPath.Size = new System.Drawing.Size(258, 20);
            this.Tb_TargetPath.TabIndex = 0;
            // 
            // Btt_CopySections
            // 
            this.Btt_CopySections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btt_CopySections.Enabled = false;
            this.Btt_CopySections.Location = new System.Drawing.Point(0, 250);
            this.Btt_CopySections.Name = "Btt_CopySections";
            this.Btt_CopySections.Size = new System.Drawing.Size(404, 23);
            this.Btt_CopySections.TabIndex = 3;
            this.Btt_CopySections.Text = "> Copy Sections to Target <";
            this.Btt_CopySections.UseVisualStyleBackColor = true;
            this.Btt_CopySections.Click += new System.EventHandler(this.Btt_CopySections_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(406, 279);
            this.Controls.Add(this.Btt_CopySections);
            this.Controls.Add(this.Gb_Target);
            this.Controls.Add(this.Sections);
            this.Controls.Add(this.Gb_Source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ditto";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.Gb_Source.ResumeLayout(false);
            this.Gb_Source.PerformLayout();
            this.Sections.ResumeLayout(false);
            this.Sections.PerformLayout();
            this.Gb_Target.ResumeLayout(false);
            this.Gb_Target.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Source;
        private System.Windows.Forms.Button Btt_SourceBrowse;
        private System.Windows.Forms.TextBox Tb_SourcePath;
        private System.Windows.Forms.GroupBox Sections;
        private System.Windows.Forms.GroupBox Gb_Target;
        private System.Windows.Forms.Button Btt_TargetBrowse;
        private System.Windows.Forms.TextBox Tb_TargetPath;
        private System.Windows.Forms.Button Btt_CopySections;
        private System.Windows.Forms.CheckBox Cb_Voice;
        private System.Windows.Forms.CheckBox Cb_StandbyExpression;
        private System.Windows.Forms.CheckBox Cb_BodyShape;
        private System.Windows.Forms.CheckBox Cb_FaceShape;
        private System.Windows.Forms.CheckBox Cb_EyeLine;
        private System.Windows.Forms.CheckBox Cb_Skin;
        private System.Windows.Forms.CheckBox Cb_Eyes;
        private System.Windows.Forms.CheckBox Cb_EyeMakeup;
        private System.Windows.Forms.CheckBox Cb_HairColor;
        private System.Windows.Forms.CheckBox Cb_HairAndFace;
    }
}

