namespace MapSample
{
    partial class FrmMain
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadInfoMap = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnGetRouteInfo = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnAddPoly = new System.Windows.Forms.Button();
            this.btnRemoveOverlay = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.chkMouseClick = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(369, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(346, 426);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lattitude";
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Location = new System.Drawing.Point(387, 47);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(124, 20);
            this.txtLat.TabIndex = 3;
            // 
            // txtLong
            // 
            this.txtLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLong.Location = new System.Drawing.Point(387, 108);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(124, 20);
            this.txtLong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Longitude";
            // 
            // btnLoadInfoMap
            // 
            this.btnLoadInfoMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadInfoMap.Location = new System.Drawing.Point(387, 176);
            this.btnLoadInfoMap.Name = "btnLoadInfoMap";
            this.btnLoadInfoMap.Size = new System.Drawing.Size(95, 23);
            this.btnLoadInfoMap.TabIndex = 6;
            this.btnLoadInfoMap.Text = "Load Info";
            this.btnLoadInfoMap.UseVisualStyleBackColor = true;
            this.btnLoadInfoMap.Click += new System.EventHandler(this.btnLoadInfoMap_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoint.Location = new System.Drawing.Point(526, 47);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPoint.TabIndex = 7;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(526, 106);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 8;
            this.btnClearList.Text = "Clear";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnGetRouteInfo
            // 
            this.btnGetRouteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetRouteInfo.Location = new System.Drawing.Point(506, 176);
            this.btnGetRouteInfo.Name = "btnGetRouteInfo";
            this.btnGetRouteInfo.Size = new System.Drawing.Size(95, 23);
            this.btnGetRouteInfo.TabIndex = 9;
            this.btnGetRouteInfo.Text = "Get Route";
            this.btnGetRouteInfo.UseVisualStyleBackColor = true;
            this.btnGetRouteInfo.Click += new System.EventHandler(this.btnGetRouteInfo_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(384, 145);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(85, 13);
            this.lblDistance.TabIndex = 10;
            this.lblDistance.Text = "[Distance in KM]";
            // 
            // btnAddPoly
            // 
            this.btnAddPoly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPoly.Location = new System.Drawing.Point(387, 220);
            this.btnAddPoly.Name = "btnAddPoly";
            this.btnAddPoly.Size = new System.Drawing.Size(95, 23);
            this.btnAddPoly.TabIndex = 11;
            this.btnAddPoly.Text = "Delimit";
            this.btnAddPoly.UseVisualStyleBackColor = true;
            this.btnAddPoly.Click += new System.EventHandler(this.btnAddPoly_Click);
            // 
            // btnRemoveOverlay
            // 
            this.btnRemoveOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveOverlay.Location = new System.Drawing.Point(506, 220);
            this.btnRemoveOverlay.Name = "btnRemoveOverlay";
            this.btnRemoveOverlay.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveOverlay.TabIndex = 12;
            this.btnRemoveOverlay.Text = "Remove Overlay";
            this.btnRemoveOverlay.UseVisualStyleBackColor = true;
            this.btnRemoveOverlay.Click += new System.EventHandler(this.btnRemoveOverlay_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(387, 286);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 152);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.Text = "";
            // 
            // chkMouseClick
            // 
            this.chkMouseClick.AutoSize = true;
            this.chkMouseClick.Location = new System.Drawing.Point(387, 256);
            this.chkMouseClick.Name = "chkMouseClick";
            this.chkMouseClick.Size = new System.Drawing.Size(95, 17);
            this.chkMouseClick.TabIndex = 14;
            this.chkMouseClick.Text = "Enable Marker";
            this.chkMouseClick.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.chkMouseClick);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnRemoveOverlay);
            this.Controls.Add(this.btnAddPoly);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnGetRouteInfo);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.btnLoadInfoMap);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUNA MAP";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadInfoMap;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnGetRouteInfo;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnAddPoly;
        private System.Windows.Forms.Button btnRemoveOverlay;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.CheckBox chkMouseClick;
    }
}

