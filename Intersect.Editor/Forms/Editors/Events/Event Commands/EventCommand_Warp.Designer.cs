using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandWarp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCommandWarp));
            this.grpWarp = new DarkUI.Controls.DarkGroupBox();
            this.warpSpecificLocation = new DarkUI.Controls.DarkRadioButton();
            this.yid = new System.Windows.Forms.Label();
            this.cmbVariable3 = new DarkUI.Controls.DarkComboBox();
            this.xid = new System.Windows.Forms.Label();
            this.cmbVariable2 = new DarkUI.Controls.DarkComboBox();
            this.mapid = new System.Windows.Forms.Label();
            this.cmbVariable = new DarkUI.Controls.DarkComboBox();
            this.warpPlayerVariable = new DarkUI.Controls.DarkRadioButton();
            this.btnVisual = new DarkUI.Controls.DarkButton();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.scrlY = new DarkUI.Controls.DarkScrollBar();
            this.scrlX = new DarkUI.Controls.DarkScrollBar();
            this.cmbMap = new DarkUI.Controls.DarkComboBox();
            this.cmbDirection = new DarkUI.Controls.DarkComboBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.grpWarp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWarp
            // 
            this.grpWarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpWarp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpWarp.Controls.Add(this.warpSpecificLocation);
            this.grpWarp.Controls.Add(this.yid);
            this.grpWarp.Controls.Add(this.cmbVariable3);
            this.grpWarp.Controls.Add(this.xid);
            this.grpWarp.Controls.Add(this.cmbVariable2);
            this.grpWarp.Controls.Add(this.mapid);
            this.grpWarp.Controls.Add(this.cmbVariable);
            this.grpWarp.Controls.Add(this.warpPlayerVariable);
            this.grpWarp.Controls.Add(this.btnVisual);
            this.grpWarp.Controls.Add(this.btnCancel);
            this.grpWarp.Controls.Add(this.btnSave);
            this.grpWarp.Controls.Add(this.scrlY);
            this.grpWarp.Controls.Add(this.scrlX);
            this.grpWarp.Controls.Add(this.cmbMap);
            this.grpWarp.Controls.Add(this.cmbDirection);
            this.grpWarp.Controls.Add(this.lblDir);
            this.grpWarp.Controls.Add(this.lblY);
            this.grpWarp.Controls.Add(this.lblMap);
            this.grpWarp.Controls.Add(this.lblX);
            this.grpWarp.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpWarp.Location = new System.Drawing.Point(3, 3);
            this.grpWarp.Name = "grpWarp";
            this.grpWarp.Size = new System.Drawing.Size(414, 257);
            this.grpWarp.TabIndex = 17;
            this.grpWarp.TabStop = false;
            this.grpWarp.Text = "Warp";
            // 
            // warpSpecificLocation
            // 
            this.warpSpecificLocation.AutoSize = true;
            this.warpSpecificLocation.Location = new System.Drawing.Point(6, 34);
            this.warpSpecificLocation.Name = "warpSpecificLocation";
            this.warpSpecificLocation.Size = new System.Drawing.Size(107, 17);
            this.warpSpecificLocation.TabIndex = 44;
            this.warpSpecificLocation.Text = "Specific Location";
            this.warpSpecificLocation.Click += new System.EventHandler(this.warpSpecificLocation_CheckedChanged);
            // 
            // yid
            // 
            this.yid.AutoSize = true;
            this.yid.Location = new System.Drawing.Point(175, 139);
            this.yid.Name = "yid";
            this.yid.Size = new System.Drawing.Size(17, 13);
            this.yid.TabIndex = 43;
            this.yid.Text = "Y:";
            // 
            // cmbVariable3
            // 
            this.cmbVariable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbVariable3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbVariable3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbVariable3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbVariable3.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbVariable3.ButtonIcon")));
            this.cmbVariable3.DrawDropdownHoverOutline = false;
            this.cmbVariable3.DrawFocusRectangle = false;
            this.cmbVariable3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVariable3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVariable3.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbVariable3.FormattingEnabled = true;
            this.cmbVariable3.Location = new System.Drawing.Point(212, 136);
            this.cmbVariable3.Name = "cmbVariable3";
            this.cmbVariable3.Size = new System.Drawing.Size(129, 21);
            this.cmbVariable3.TabIndex = 42;
            this.cmbVariable3.Text = null;
            this.cmbVariable3.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // xid
            // 
            this.xid.AutoSize = true;
            this.xid.Location = new System.Drawing.Point(175, 112);
            this.xid.Name = "xid";
            this.xid.Size = new System.Drawing.Size(17, 13);
            this.xid.TabIndex = 41;
            this.xid.Text = "X:";
            this.xid.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbVariable2
            // 
            this.cmbVariable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbVariable2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbVariable2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbVariable2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbVariable2.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbVariable2.ButtonIcon")));
            this.cmbVariable2.DrawDropdownHoverOutline = false;
            this.cmbVariable2.DrawFocusRectangle = false;
            this.cmbVariable2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVariable2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVariable2.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbVariable2.FormattingEnabled = true;
            this.cmbVariable2.Location = new System.Drawing.Point(212, 109);
            this.cmbVariable2.Name = "cmbVariable2";
            this.cmbVariable2.Size = new System.Drawing.Size(129, 21);
            this.cmbVariable2.TabIndex = 40;
            this.cmbVariable2.Text = null;
            this.cmbVariable2.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // mapid
            // 
            this.mapid.AutoSize = true;
            this.mapid.Location = new System.Drawing.Point(175, 82);
            this.mapid.Name = "mapid";
            this.mapid.Size = new System.Drawing.Size(31, 13);
            this.mapid.TabIndex = 39;
            this.mapid.Text = "Map:";
            // 
            // cmbVariable
            // 
            this.cmbVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbVariable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbVariable.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbVariable.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbVariable.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbVariable.ButtonIcon")));
            this.cmbVariable.DrawDropdownHoverOutline = false;
            this.cmbVariable.DrawFocusRectangle = false;
            this.cmbVariable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVariable.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbVariable.FormattingEnabled = true;
            this.cmbVariable.Location = new System.Drawing.Point(212, 79);
            this.cmbVariable.Name = "cmbVariable";
            this.cmbVariable.Size = new System.Drawing.Size(129, 21);
            this.cmbVariable.TabIndex = 38;
            this.cmbVariable.Text = null;
            this.cmbVariable.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // warpPlayerVariable
            // 
            this.warpPlayerVariable.AutoSize = true;
            this.warpPlayerVariable.Location = new System.Drawing.Point(178, 34);
            this.warpPlayerVariable.Name = "warpPlayerVariable";
            this.warpPlayerVariable.Size = new System.Drawing.Size(63, 17);
            this.warpPlayerVariable.TabIndex = 37;
            this.warpPlayerVariable.Text = "Variable";
            this.warpPlayerVariable.Click += new System.EventHandler(this.warpPlayerVariable_CheckedChanged);
            // 
            // btnVisual
            // 
            this.btnVisual.Location = new System.Drawing.Point(12, 193);
            this.btnVisual.Name = "btnVisual";
            this.btnVisual.Padding = new System.Windows.Forms.Padding(5);
            this.btnVisual.Size = new System.Drawing.Size(155, 23);
            this.btnVisual.TabIndex = 21;
            this.btnVisual.Text = "Open Visual Interface";
            this.btnVisual.Click += new System.EventHandler(this.btnVisual_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(87, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // scrlY
            // 
            this.scrlY.Location = new System.Drawing.Point(46, 136);
            this.scrlY.Name = "scrlY";
            this.scrlY.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlY.Size = new System.Drawing.Size(121, 17);
            this.scrlY.TabIndex = 18;
            this.scrlY.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlY_Scroll);
            // 
            // scrlX
            // 
            this.scrlX.Location = new System.Drawing.Point(46, 109);
            this.scrlX.Name = "scrlX";
            this.scrlX.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlX.Size = new System.Drawing.Size(121, 17);
            this.scrlX.TabIndex = 17;
            this.scrlX.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlX_Scroll);
            // 
            // cmbMap
            // 
            this.cmbMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbMap.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbMap.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbMap.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbMap.ButtonIcon")));
            this.cmbMap.DrawDropdownHoverOutline = false;
            this.cmbMap.DrawFocusRectangle = false;
            this.cmbMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbMap.FormattingEnabled = true;
            this.cmbMap.Location = new System.Drawing.Point(46, 79);
            this.cmbMap.Name = "cmbMap";
            this.cmbMap.Size = new System.Drawing.Size(121, 21);
            this.cmbMap.TabIndex = 16;
            this.cmbMap.Text = null;
            this.cmbMap.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbMap.SelectedIndexChanged += new System.EventHandler(this.cmbMap_SelectedIndexChanged);
            // 
            // cmbDirection
            // 
            this.cmbDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDirection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDirection.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDirection.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbDirection.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbDirection.ButtonIcon")));
            this.cmbDirection.DrawDropdownHoverOutline = false;
            this.cmbDirection.DrawFocusRectangle = false;
            this.cmbDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDirection.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Location = new System.Drawing.Point(46, 160);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(121, 21);
            this.cmbDirection.TabIndex = 15;
            this.cmbDirection.Text = null;
            this.cmbDirection.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbDirection.SelectedIndexChanged += new System.EventHandler(this.cmbDirection_SelectedIndexChanged);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(9, 163);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(23, 13);
            this.lblDir.TabIndex = 14;
            this.lblDir.Text = "Dir:";
            this.lblDir.Click += new System.EventHandler(this.label23_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(9, 136);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(26, 13);
            this.lblY.TabIndex = 13;
            this.lblY.Text = "Y: 0";
            this.lblY.Click += new System.EventHandler(this.lblY_Click);
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(9, 82);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(31, 13);
            this.lblMap.TabIndex = 8;
            this.lblMap.Text = "Map:";
            this.lblMap.Click += new System.EventHandler(this.label21_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(9, 109);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 13);
            this.lblX.TabIndex = 12;
            this.lblX.Text = "X: 0";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // EventCommandWarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpWarp);
            this.Name = "EventCommandWarp";
            this.Size = new System.Drawing.Size(420, 263);
            this.grpWarp.ResumeLayout(false);
            this.grpWarp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpWarp;
        private DarkComboBox cmbMap;
        private DarkComboBox cmbDirection;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblX;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkScrollBar scrlY;
        private DarkScrollBar scrlX;
        private DarkButton btnVisual;
        private DarkRadioButton warpPlayerVariable;
        internal DarkComboBox cmbVariable;
        private System.Windows.Forms.Label yid;
        internal DarkComboBox cmbVariable3;
        private System.Windows.Forms.Label xid;
        internal DarkComboBox cmbVariable2;
        private System.Windows.Forms.Label mapid;
        private DarkRadioButton warpSpecificLocation;
    }
}
