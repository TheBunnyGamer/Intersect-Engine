using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{
    partial class EventCommandChangeStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCommandChangeStat));
            this.grpChangeStat = new DarkUI.Controls.DarkGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudStat = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbItem = new DarkUI.Controls.DarkComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.grpChangeStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChangeStat
            // 
            this.grpChangeStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.grpChangeStat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpChangeStat.Controls.Add(this.label1);
            this.grpChangeStat.Controls.Add(this.nudStat);
            this.grpChangeStat.Controls.Add(this.cmbItem);
            this.grpChangeStat.Controls.Add(this.lblItem);
            this.grpChangeStat.Controls.Add(this.btnCancel);
            this.grpChangeStat.Controls.Add(this.btnSave);
            this.grpChangeStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpChangeStat.Location = new System.Drawing.Point(3, 3);
            this.grpChangeStat.Name = "grpChangeStat";
            this.grpChangeStat.Size = new System.Drawing.Size(193, 145);
            this.grpChangeStat.TabIndex = 17;
            this.grpChangeStat.TabStop = false;
            this.grpChangeStat.Text = "Change Stat:";
            this.grpChangeStat.Enter += new System.EventHandler(this.grpChangeStat_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Add:";
            // 
            // nudStat
            // 
            this.nudStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStat.Location = new System.Drawing.Point(65, 53);
            this.nudStat.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStat.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudStat.Name = "nudStat";
            this.nudStat.Size = new System.Drawing.Size(115, 20);
            this.nudStat.TabIndex = 25;
            this.nudStat.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbItem.ButtonIcon = ((System.Drawing.Bitmap)(resources.GetObject("cmbItem.ButtonIcon")));
            this.cmbItem.DrawDropdownHoverOutline = false;
            this.cmbItem.DrawFocusRectangle = false;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(65, 23);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(115, 21);
            this.cmbItem.TabIndex = 24;
            this.cmbItem.Text = null;
            this.cmbItem.TextPadding = new System.Windows.Forms.Padding(2);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(6, 25);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(29, 13);
            this.lblItem.TabIndex = 23;
            this.lblItem.Text = "Stat:";
            this.lblItem.Click += new System.EventHandler(this.lblItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(105, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ok";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EventCommandChangeStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.grpChangeStat);
            this.Name = "EventCommandChangeStat";
            this.Size = new System.Drawing.Size(205, 157);
            this.grpChangeStat.ResumeLayout(false);
            this.grpChangeStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpChangeStat;
        private DarkButton btnCancel;
        private DarkButton btnSave;
        private DarkComboBox cmbItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label1;
        private DarkNumericUpDown nudStat;
    }
}
