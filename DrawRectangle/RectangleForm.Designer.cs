namespace DrawRectangle
{
    partial class RectangleForm
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
            this.gbRectangle = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDrawRectangle = new System.Windows.Forms.Button();
            this.gbCoordinates = new System.Windows.Forms.GroupBox();
            this.txtYCoord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXCoord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCoordinates = new System.Windows.Forms.RadioButton();
            this.rbPickPoint = new System.Windows.Forms.RadioButton();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbRectangle.SuspendLayout();
            this.gbCoordinates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRectangle
            // 
            this.gbRectangle.Controls.Add(this.lblInfo);
            this.gbRectangle.Controls.Add(this.btnDrawRectangle);
            this.gbRectangle.Controls.Add(this.gbCoordinates);
            this.gbRectangle.Controls.Add(this.rbCoordinates);
            this.gbRectangle.Controls.Add(this.rbPickPoint);
            this.gbRectangle.Controls.Add(this.txtHeight);
            this.gbRectangle.Controls.Add(this.label2);
            this.gbRectangle.Controls.Add(this.txtWidth);
            this.gbRectangle.Controls.Add(this.label1);
            this.gbRectangle.Location = new System.Drawing.Point(28, 22);
            this.gbRectangle.Name = "gbRectangle";
            this.gbRectangle.Size = new System.Drawing.Size(296, 356);
            this.gbRectangle.TabIndex = 0;
            this.gbRectangle.TabStop = false;
            this.gbRectangle.Text = "Enter Rectangle Parameters";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 326);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(16, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "...";
            // 
            // btnDrawRectangle
            // 
            this.btnDrawRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDrawRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawRectangle.Location = new System.Drawing.Point(32, 273);
            this.btnDrawRectangle.Name = "btnDrawRectangle";
            this.btnDrawRectangle.Size = new System.Drawing.Size(232, 31);
            this.btnDrawRectangle.TabIndex = 7;
            this.btnDrawRectangle.Text = "Draw Rectangle";
            this.toolTip1.SetToolTip(this.btnDrawRectangle, "This will draw rectangle in AutoCAD");
            this.btnDrawRectangle.UseVisualStyleBackColor = false;
            this.btnDrawRectangle.Click += new System.EventHandler(this.BtnDrawRectangle_Click);
            // 
            // gbCoordinates
            // 
            this.gbCoordinates.Controls.Add(this.txtYCoord);
            this.gbCoordinates.Controls.Add(this.label4);
            this.gbCoordinates.Controls.Add(this.txtXCoord);
            this.gbCoordinates.Controls.Add(this.label3);
            this.gbCoordinates.Location = new System.Drawing.Point(32, 167);
            this.gbCoordinates.Name = "gbCoordinates";
            this.gbCoordinates.Size = new System.Drawing.Size(232, 100);
            this.gbCoordinates.TabIndex = 6;
            this.gbCoordinates.TabStop = false;
            this.gbCoordinates.Text = "Enter Coordinates";
            // 
            // txtYCoord
            // 
            this.txtYCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtYCoord.Location = new System.Drawing.Point(80, 56);
            this.txtYCoord.Name = "txtYCoord";
            this.txtYCoord.Size = new System.Drawing.Size(100, 20);
            this.txtYCoord.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y-Coordinate:";
            // 
            // txtXCoord
            // 
            this.txtXCoord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtXCoord.Location = new System.Drawing.Point(80, 29);
            this.txtXCoord.Name = "txtXCoord";
            this.txtXCoord.Size = new System.Drawing.Size(100, 20);
            this.txtXCoord.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X-Coordinate:";
            // 
            // rbCoordinates
            // 
            this.rbCoordinates.AutoSize = true;
            this.rbCoordinates.Checked = true;
            this.rbCoordinates.Location = new System.Drawing.Point(32, 127);
            this.rbCoordinates.Name = "rbCoordinates";
            this.rbCoordinates.Size = new System.Drawing.Size(109, 17);
            this.rbCoordinates.TabIndex = 5;
            this.rbCoordinates.TabStop = true;
            this.rbCoordinates.Text = "Enter Coordinates";
            this.toolTip1.SetToolTip(this.rbCoordinates, "Specify the coordinates manually");
            this.rbCoordinates.UseVisualStyleBackColor = true;
            this.rbCoordinates.CheckedChanged += new System.EventHandler(this.RbCoordinates_CheckedChanged);
            // 
            // rbPickPoint
            // 
            this.rbPickPoint.AutoSize = true;
            this.rbPickPoint.Location = new System.Drawing.Point(156, 127);
            this.rbPickPoint.Name = "rbPickPoint";
            this.rbPickPoint.Size = new System.Drawing.Size(97, 17);
            this.rbPickPoint.TabIndex = 4;
            this.rbPickPoint.Text = "Pick OnScreen";
            this.toolTip1.SetToolTip(this.rbPickPoint, "Insertion Point will be based on the selected point onscreen");
            this.rbPickPoint.UseVisualStyleBackColor = true;
            this.rbPickPoint.CheckedChanged += new System.EventHandler(this.RbPickPoint_CheckedChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtHeight.Location = new System.Drawing.Point(112, 76);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtHeight, "Valid values are numbers only");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Height:";
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtWidth.Location = new System.Drawing.Point(112, 42);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtWidth, "Valid values are numbers only");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Width:";
            // 
            // RectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 390);
            this.Controls.Add(this.gbRectangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RectangleForm";
            this.Text = "RectangleForm";
            this.gbRectangle.ResumeLayout(false);
            this.gbRectangle.PerformLayout();
            this.gbCoordinates.ResumeLayout(false);
            this.gbCoordinates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRectangle;
        private System.Windows.Forms.Button btnDrawRectangle;
        private System.Windows.Forms.GroupBox gbCoordinates;
        private System.Windows.Forms.TextBox txtYCoord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXCoord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCoordinates;
        private System.Windows.Forms.RadioButton rbPickPoint;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblInfo;
    }
}