namespace Smash_Forge.GUI
{
    partial class RenderSettings
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.depthSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.swagViewing = new System.Windows.Forms.CheckBox();
            this.cb_normals = new System.Windows.Forms.CheckBox();
            this.renderMode = new System.Windows.Forms.ComboBox();
            this.cb_vertcolor = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.safemode = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Clearwrk = new System.Windows.Forms.CheckBox();
            this.DeleteMesh = new System.Windows.Forms.CheckBox();
            this.ClearAnims = new System.Windows.Forms.CheckBox();
            this.ClearMoves = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Render Model";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 33);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Render Bones";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(12, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(125, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Render Camera Path";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(12, 56);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(105, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Render Hitboxes";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(12, 102);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(87, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Render Floor";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(12, 125);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(85, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Render LVD";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(44, 148);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(107, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Render Collisions";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(44, 194);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(102, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Render Spawns";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(44, 217);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(114, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Render Respawns";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(44, 240);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(134, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Render Item Spawners";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Location = new System.Drawing.Point(44, 263);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(133, 17);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "Render General Points";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(73, 171);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(158, 17);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "Render Passthrough Angles";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox12);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 299);
            this.panel1.TabIndex = 12;
            // 
            // depthSlider
            // 
            this.depthSlider.Location = new System.Drawing.Point(12, 32);
            this.depthSlider.Maximum = 60000;
            this.depthSlider.Minimum = 1;
            this.depthSlider.Name = "depthSlider";
            this.depthSlider.Size = new System.Drawing.Size(265, 45);
            this.depthSlider.TabIndex = 13;
            this.depthSlider.Value = 1;
            this.depthSlider.ValueChanged += new System.EventHandler(this.depthSlider_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Depth";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.swagViewing);
            this.groupBox1.Controls.Add(this.cb_normals);
            this.groupBox1.Controls.Add(this.renderMode);
            this.groupBox1.Controls.Add(this.cb_vertcolor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.depthSlider);
            this.groupBox1.Location = new System.Drawing.Point(301, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 299);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model Render Settings";
            // 
            // swagViewing
            // 
            this.swagViewing.AutoSize = true;
            this.swagViewing.Location = new System.Drawing.Point(12, 125);
            this.swagViewing.Name = "swagViewing";
            this.swagViewing.Size = new System.Drawing.Size(109, 17);
            this.swagViewing.TabIndex = 18;
            this.swagViewing.Text = "Show Swag Data";
            this.swagViewing.UseVisualStyleBackColor = true;
            this.swagViewing.CheckedChanged += new System.EventHandler(this.swagViewing_CheckedChanged);
            // 
            // cb_normals
            // 
            this.cb_normals.AutoSize = true;
            this.cb_normals.Checked = true;
            this.cb_normals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_normals.Location = new System.Drawing.Point(12, 102);
            this.cb_normals.Name = "cb_normals";
            this.cb_normals.Size = new System.Drawing.Size(94, 17);
            this.cb_normals.TabIndex = 17;
            this.cb_normals.Text = "Show Normals";
            this.cb_normals.UseVisualStyleBackColor = true;
            // 
            // renderMode
            // 
            this.renderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renderMode.FormattingEnabled = true;
            this.renderMode.Items.AddRange(new object[] {
            "Texture",
            "Normals(Color)",
            "Normals(BnW)",
            "Vertex Color"});
            this.renderMode.Location = new System.Drawing.Point(156, 77);
            this.renderMode.Name = "renderMode";
            this.renderMode.Size = new System.Drawing.Size(121, 21);
            this.renderMode.TabIndex = 16;
            this.renderMode.SelectedIndexChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            this.renderMode.SelectionChangeCommitted += new System.EventHandler(this.renderMode_SelectionChangeCommitted);
            // 
            // cb_vertcolor
            // 
            this.cb_vertcolor.AutoSize = true;
            this.cb_vertcolor.Checked = true;
            this.cb_vertcolor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_vertcolor.Location = new System.Drawing.Point(12, 79);
            this.cb_vertcolor.Name = "cb_vertcolor";
            this.cb_vertcolor.Size = new System.Drawing.Size(118, 17);
            this.cb_vertcolor.TabIndex = 15;
            this.cb_vertcolor.Text = "Show Vertex Colors";
            this.cb_vertcolor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 326);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Render Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClearMoves);
            this.groupBox3.Controls.Add(this.ClearAnims);
            this.groupBox3.Controls.Add(this.DeleteMesh);
            this.groupBox3.Controls.Add(this.Clearwrk);
            this.groupBox3.Controls.Add(this.safemode);
            this.groupBox3.Location = new System.Drawing.Point(621, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 322);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Settings";
            // 
            // safemode
            // 
            this.safemode.AutoSize = true;
            this.safemode.Cursor = System.Windows.Forms.Cursors.Default;
            this.safemode.Location = new System.Drawing.Point(7, 26);
            this.safemode.Name = "safemode";
            this.safemode.Size = new System.Drawing.Size(77, 17);
            this.safemode.TabIndex = 0;
            this.safemode.Text = "Safe mode";
            this.toolTip1.SetToolTip(this.safemode, "Safe Mode enables verification for every (possibly) harmful tool, this is to redu" +
        "ce loss of work due to accidental clicks");
            this.safemode.UseVisualStyleBackColor = true;
            this.safemode.CheckedChanged += new System.EventHandler(this.safemode_CheckedChanged);
            // 
            // Clearwrk
            // 
            this.Clearwrk.AutoSize = true;
            this.Clearwrk.Location = new System.Drawing.Point(26, 49);
            this.Clearwrk.Name = "Clearwrk";
            this.Clearwrk.Size = new System.Drawing.Size(108, 17);
            this.Clearwrk.TabIndex = 1;
            this.Clearwrk.Text = "Clear Workspace";
            this.toolTip1.SetToolTip(this.Clearwrk, "Enables Safe Mode for the clear workspace button");
            this.Clearwrk.UseVisualStyleBackColor = true;
            this.Clearwrk.CheckedChanged += new System.EventHandler(this.Clearwrk_CheckedChanged);
            // 
            // DeleteMesh
            // 
            this.DeleteMesh.AutoSize = true;
            this.DeleteMesh.Location = new System.Drawing.Point(26, 72);
            this.DeleteMesh.Name = "DeleteMesh";
            this.DeleteMesh.Size = new System.Drawing.Size(86, 17);
            this.DeleteMesh.TabIndex = 2;
            this.DeleteMesh.Text = "Delete Mesh";
            this.toolTip1.SetToolTip(this.DeleteMesh, "Enables Safe Mode for the Delete mesh button");
            this.DeleteMesh.UseVisualStyleBackColor = true;
            this.DeleteMesh.CheckedChanged += new System.EventHandler(this.DeleteMesh_CheckedChanged);
            // 
            // ClearAnims
            // 
            this.ClearAnims.AutoSize = true;
            this.ClearAnims.Location = new System.Drawing.Point(26, 92);
            this.ClearAnims.Name = "ClearAnims";
            this.ClearAnims.Size = new System.Drawing.Size(104, 17);
            this.ClearAnims.TabIndex = 3;
            this.ClearAnims.Text = "Clear Animations";
            this.toolTip1.SetToolTip(this.ClearAnims, "Enables Safe Mode for the Clear Animations button");
            this.ClearAnims.UseVisualStyleBackColor = true;
            this.ClearAnims.CheckedChanged += new System.EventHandler(this.ClearAnims_CheckedChanged);
            // 
            // ClearMoves
            // 
            this.ClearMoves.AutoSize = true;
            this.ClearMoves.Enabled = false;
            this.ClearMoves.Location = new System.Drawing.Point(26, 115);
            this.ClearMoves.Name = "ClearMoves";
            this.ClearMoves.Size = new System.Drawing.Size(94, 17);
            this.ClearMoves.TabIndex = 4;
            this.ClearMoves.Text = "Clear Moveset";
            this.toolTip1.SetToolTip(this.ClearMoves, "Enables Safe Mode for the Clear Moveset button");
            this.ClearMoves.UseVisualStyleBackColor = true;
            this.ClearMoves.CheckedChanged += new System.EventHandler(this.ClearMoves_CheckedChanged);
            // 
            // RenderSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 346);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = global::Smash_Forge.Resources.Resources.forge2;
            this.Name = "RenderSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.RenderSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar depthSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox renderMode;
        private System.Windows.Forms.CheckBox cb_vertcolor;
        private System.Windows.Forms.CheckBox cb_normals;
        private System.Windows.Forms.CheckBox swagViewing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.CheckBox safemode;
        private System.Windows.Forms.CheckBox Clearwrk;
        private System.Windows.Forms.CheckBox DeleteMesh;
        private System.Windows.Forms.CheckBox ClearMoves;
        private System.Windows.Forms.CheckBox ClearAnims;
    }
}