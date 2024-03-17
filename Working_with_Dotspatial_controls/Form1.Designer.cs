
namespace Working_with_Dotspatial_controls
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbOperations = new System.Windows.Forms.GroupBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoomToExtent = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.map1 = new DotSpatial.Controls.Map();
            this.panel1.SuspendLayout();
            this.grbOperations.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbOperations);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 108);
            this.panel1.TabIndex = 0;
            // 
            // grbOperations
            // 
            this.grbOperations.Controls.Add(this.btnNone);
            this.grbOperations.Controls.Add(this.btnSelect);
            this.grbOperations.Controls.Add(this.btnInfo);
            this.grbOperations.Controls.Add(this.btnPan);
            this.grbOperations.Controls.Add(this.btnZoomToExtent);
            this.grbOperations.Controls.Add(this.btnZoomOut);
            this.grbOperations.Controls.Add(this.btnZoomIn);
            this.grbOperations.Controls.Add(this.btnClear);
            this.grbOperations.Controls.Add(this.btnLoad);
            this.grbOperations.Location = new System.Drawing.Point(3, 41);
            this.grbOperations.Name = "grbOperations";
            this.grbOperations.Size = new System.Drawing.Size(770, 64);
            this.grbOperations.TabIndex = 1;
            this.grbOperations.TabStop = false;
            this.grbOperations.Text = "Operations";
            this.grbOperations.Enter += new System.EventHandler(this.grbOperations_Enter);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(307, 35);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(75, 23);
            this.btnNone.TabIndex = 9;
            this.btnNone.Text = "&None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(226, 35);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "&Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(550, 6);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "In&fo";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnPan
            // 
            this.btnPan.Location = new System.Drawing.Point(469, 6);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(75, 23);
            this.btnPan.TabIndex = 5;
            this.btnPan.Text = "&Pan";
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnZoomToExtent
            // 
            this.btnZoomToExtent.Location = new System.Drawing.Point(388, 8);
            this.btnZoomToExtent.Name = "btnZoomToExtent";
            this.btnZoomToExtent.Size = new System.Drawing.Size(75, 23);
            this.btnZoomToExtent.TabIndex = 4;
            this.btnZoomToExtent.Text = "Zoom to &Extent";
            this.btnZoomToExtent.UseVisualStyleBackColor = true;
            this.btnZoomToExtent.Click += new System.EventHandler(this.btnZoomToExtent_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(307, 8);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "Zoom &Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(226, 7);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 2;
            this.btnZoomIn.Text = "Zoom &In ";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(144, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear Map";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(63, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "&Load Map";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Map Operations";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.map1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 312);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollisionDetection = false;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = null;
            this.map1.Location = new System.Drawing.Point(3, 3);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(773, 309);
            this.map1.TabIndex = 0;
            this.map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbOperations.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbOperations;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnZoomToExtent;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DotSpatial.Controls.Map map1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
    }
}

