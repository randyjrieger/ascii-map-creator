namespace ImageToAsciiConverter
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
            this.btnGo = new System.Windows.Forms.Button();
            this.btnShallowWater = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optCloudShaped = new System.Windows.Forms.RadioButton();
            this.optRectangularShaped = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackSpaceFromCoast = new System.Windows.Forms.TrackBar();
            this.btnLorax = new System.Windows.Forms.Button();
            this.treeSlider = new System.Windows.Forms.Label();
            this.trackTreeSpray = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTerrain = new System.Windows.Forms.ListBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSourceFile = new System.Windows.Forms.Button();
            this.btnTargetFile = new System.Windows.Forms.Button();
            this.boxMapSelection = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBR2 = new System.Windows.Forms.TextBox();
            this.txtBR1 = new System.Windows.Forms.TextBox();
            this.txtTL2 = new System.Windows.Forms.TextBox();
            this.txtTL1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.txtImgHeight = new System.Windows.Forms.TextBox();
            this.txtImgWidth = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpaceFromCoast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTreeSpray)).BeginInit();
            this.boxMapSelection.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(21, 48);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(165, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Convert Image To Text";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnShallowWater
            // 
            this.btnShallowWater.Location = new System.Drawing.Point(21, 81);
            this.btnShallowWater.Name = "btnShallowWater";
            this.btnShallowWater.Size = new System.Drawing.Size(165, 23);
            this.btnShallowWater.TabIndex = 1;
            this.btnShallowWater.Text = "Add Shallow Water Along Coastline";
            this.btnShallowWater.UseVisualStyleBackColor = true;
            this.btnShallowWater.Click += new System.EventHandler(this.btnShallowWater_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(122, 12);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(493, 20);
            this.txtSource.TabIndex = 10;
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Location = new System.Drawing.Point(122, 64);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(493, 20);
            this.txtTargetPath.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorMessage);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackSpaceFromCoast);
            this.groupBox1.Controls.Add(this.btnLorax);
            this.groupBox1.Controls.Add(this.treeSlider);
            this.groupBox1.Controls.Add(this.trackTreeSpray);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstTerrain);
            this.groupBox1.Location = new System.Drawing.Point(24, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 273);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terraform";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Purple;
            this.lblErrorMessage.Location = new System.Drawing.Point(28, 241);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.lblErrorMessage.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optCloudShaped);
            this.groupBox2.Controls.Add(this.optRectangularShaped);
            this.groupBox2.Location = new System.Drawing.Point(18, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 68);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape";
            // 
            // optCloudShaped
            // 
            this.optCloudShaped.AutoSize = true;
            this.optCloudShaped.Location = new System.Drawing.Point(37, 44);
            this.optCloudShaped.Name = "optCloudShaped";
            this.optCloudShaped.Size = new System.Drawing.Size(92, 17);
            this.optCloudShaped.TabIndex = 1;
            this.optCloudShaped.Text = "Cloud Shaped";
            this.optCloudShaped.UseVisualStyleBackColor = true;
            // 
            // optRectangularShaped
            // 
            this.optRectangularShaped.AutoSize = true;
            this.optRectangularShaped.Checked = true;
            this.optRectangularShaped.Location = new System.Drawing.Point(37, 19);
            this.optRectangularShaped.Name = "optRectangularShaped";
            this.optRectangularShaped.Size = new System.Drawing.Size(83, 17);
            this.optRectangularShaped.TabIndex = 0;
            this.optRectangularShaped.TabStop = true;
            this.optRectangularShaped.Text = "Rectangular";
            this.optRectangularShaped.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Less";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "More";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Choose Style:";
            // 
            // trackSpaceFromCoast
            // 
            this.trackSpaceFromCoast.Location = new System.Drawing.Point(330, 109);
            this.trackSpaceFromCoast.Maximum = 2;
            this.trackSpaceFromCoast.Name = "trackSpaceFromCoast";
            this.trackSpaceFromCoast.Size = new System.Drawing.Size(186, 45);
            this.trackSpaceFromCoast.TabIndex = 26;
            this.trackSpaceFromCoast.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // btnLorax
            // 
            this.btnLorax.BackColor = System.Drawing.Color.Green;
            this.btnLorax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLorax.ForeColor = System.Drawing.Color.White;
            this.btnLorax.Location = new System.Drawing.Point(465, 229);
            this.btnLorax.Name = "btnLorax";
            this.btnLorax.Size = new System.Drawing.Size(125, 38);
            this.btnLorax.TabIndex = 25;
            this.btnLorax.Text = "Terraform!";
            this.btnLorax.UseVisualStyleBackColor = false;
            this.btnLorax.Click += new System.EventHandler(this.btnLorax_Click);
            // 
            // treeSlider
            // 
            this.treeSlider.AutoSize = true;
            this.treeSlider.Location = new System.Drawing.Point(269, 33);
            this.treeSlider.Name = "treeSlider";
            this.treeSlider.Size = new System.Drawing.Size(49, 13);
            this.treeSlider.TabIndex = 24;
            this.treeSlider.Text = "Intensity:";
            // 
            // trackTreeSpray
            // 
            this.trackTreeSpray.Location = new System.Drawing.Point(324, 33);
            this.trackTreeSpray.Maximum = 25;
            this.trackTreeSpray.Minimum = 1;
            this.trackTreeSpray.Name = "trackTreeSpray";
            this.trackTreeSpray.Size = new System.Drawing.Size(195, 45);
            this.trackTreeSpray.TabIndex = 23;
            this.trackTreeSpray.Value = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Padding Between Water/Path";
            // 
            // lstTerrain
            // 
            this.lstTerrain.FormattingEnabled = true;
            this.lstTerrain.Items.AddRange(new object[] {
            "Grass",
            "Trees",
            "Sand",
            "Swamp",
            "Foothills",
            "Mountains",
            "Ice",
            "Path"});
            this.lstTerrain.Location = new System.Drawing.Point(120, 33);
            this.lstTerrain.Name = "lstTerrain";
            this.lstTerrain.Size = new System.Drawing.Size(120, 121);
            this.lstTerrain.TabIndex = 18;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // btnSourceFile
            // 
            this.btnSourceFile.BackColor = System.Drawing.Color.LightBlue;
            this.btnSourceFile.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSourceFile.Location = new System.Drawing.Point(24, 9);
            this.btnSourceFile.Name = "btnSourceFile";
            this.btnSourceFile.Size = new System.Drawing.Size(84, 23);
            this.btnSourceFile.TabIndex = 26;
            this.btnSourceFile.Text = "Source File";
            this.btnSourceFile.UseVisualStyleBackColor = false;
            this.btnSourceFile.Click += new System.EventHandler(this.btnSourceFile_Click);
            // 
            // btnTargetFile
            // 
            this.btnTargetFile.BackColor = System.Drawing.Color.LightBlue;
            this.btnTargetFile.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTargetFile.Location = new System.Drawing.Point(24, 64);
            this.btnTargetFile.Name = "btnTargetFile";
            this.btnTargetFile.Size = new System.Drawing.Size(84, 23);
            this.btnTargetFile.TabIndex = 27;
            this.btnTargetFile.Text = "Target File";
            this.btnTargetFile.UseVisualStyleBackColor = false;
            this.btnTargetFile.Click += new System.EventHandler(this.btnTargetFile_Click);
            // 
            // boxMapSelection
            // 
            this.boxMapSelection.Controls.Add(this.label7);
            this.boxMapSelection.Controls.Add(this.label5);
            this.boxMapSelection.Controls.Add(this.label6);
            this.boxMapSelection.Controls.Add(this.label4);
            this.boxMapSelection.Controls.Add(this.label2);
            this.boxMapSelection.Controls.Add(this.label1);
            this.boxMapSelection.Controls.Add(this.txtBR2);
            this.boxMapSelection.Controls.Add(this.txtBR1);
            this.boxMapSelection.Controls.Add(this.txtTL2);
            this.boxMapSelection.Controls.Add(this.txtTL1);
            this.boxMapSelection.Location = new System.Drawing.Point(24, 110);
            this.boxMapSelection.Name = "boxMapSelection";
            this.boxMapSelection.Size = new System.Drawing.Size(282, 142);
            this.boxMapSelection.TabIndex = 28;
            this.boxMapSelection.TabStop = false;
            this.boxMapSelection.Text = "Map Selection";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Bottom Right Coordinate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "x:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Top Left Coordinate:";
            // 
            // txtBR2
            // 
            this.txtBR2.Location = new System.Drawing.Point(171, 103);
            this.txtBR2.Name = "txtBR2";
            this.txtBR2.Size = new System.Drawing.Size(42, 20);
            this.txtBR2.TabIndex = 27;
            this.txtBR2.Text = "1269";
            // 
            // txtBR1
            // 
            this.txtBR1.Location = new System.Drawing.Point(90, 103);
            this.txtBR1.Name = "txtBR1";
            this.txtBR1.Size = new System.Drawing.Size(42, 20);
            this.txtBR1.TabIndex = 26;
            this.txtBR1.Text = "875";
            // 
            // txtTL2
            // 
            this.txtTL2.Location = new System.Drawing.Point(171, 45);
            this.txtTL2.Name = "txtTL2";
            this.txtTL2.Size = new System.Drawing.Size(42, 20);
            this.txtTL2.TabIndex = 25;
            this.txtTL2.Text = "1150";
            // 
            // txtTL1
            // 
            this.txtTL1.Location = new System.Drawing.Point(90, 45);
            this.txtTL1.Name = "txtTL1";
            this.txtTL1.Size = new System.Drawing.Size(42, 20);
            this.txtTL1.TabIndex = 24;
            this.txtTL1.Text = "405";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShallowWater);
            this.groupBox3.Controls.Add(this.btnGo);
            this.groupBox3.Location = new System.Drawing.Point(312, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 142);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Global Functions";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(241, 41);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(41, 13);
            this.lblCol.TabIndex = 30;
            this.lblCol.Text = "Height:";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(133, 41);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(38, 13);
            this.lblRow.TabIndex = 31;
            this.lblRow.Text = "Width:";
            // 
            // txtImgHeight
            // 
            this.txtImgHeight.Location = new System.Drawing.Point(288, 38);
            this.txtImgHeight.Name = "txtImgHeight";
            this.txtImgHeight.Size = new System.Drawing.Size(42, 20);
            this.txtImgHeight.TabIndex = 33;
            this.txtImgHeight.Text = "0";
            // 
            // txtImgWidth
            // 
            this.txtImgWidth.Location = new System.Drawing.Point(177, 38);
            this.txtImgWidth.Name = "txtImgWidth";
            this.txtImgWidth.Size = new System.Drawing.Size(42, 20);
            this.txtImgWidth.TabIndex = 32;
            this.txtImgWidth.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 543);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.txtImgHeight);
            this.Controls.Add(this.txtImgWidth);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.boxMapSelection);
            this.Controls.Add(this.btnTargetFile);
            this.Controls.Add(this.btnSourceFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTargetPath);
            this.Controls.Add(this.txtSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ascii Tile Map Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpaceFromCoast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTreeSpray)).EndInit();
            this.boxMapSelection.ResumeLayout(false);
            this.boxMapSelection.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnShallowWater;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstTerrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label treeSlider;
        private System.Windows.Forms.TrackBar trackTreeSpray;
        private System.Windows.Forms.Button btnLorax;
        private System.Windows.Forms.TrackBar trackSpaceFromCoast;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnSourceFile;
        private System.Windows.Forms.Button btnTargetFile;
        private System.Windows.Forms.GroupBox boxMapSelection;
        private System.Windows.Forms.TextBox txtBR2;
        private System.Windows.Forms.TextBox txtBR1;
        private System.Windows.Forms.TextBox txtTL2;
        private System.Windows.Forms.TextBox txtTL1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optCloudShaped;
        private System.Windows.Forms.RadioButton optRectangularShaped;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.TextBox txtImgHeight;
        private System.Windows.Forms.TextBox txtImgWidth;
    }
}

