using System;
using System.Windows.Forms;

using DarkUI.Controls;

using Intersect.Editor.Localization;
using Intersect.Enums;
using Intersect.GameObjects.Events.Commands;
using Intersect.GameObjects.Maps.MapList;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandWarp : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private WarpCommand mMyCommand;

        public EventCommandWarp(WarpCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;
            InitLocalization();
            cmbMap.Items.Clear();
            for (var i = 0; i < MapList.OrderedMaps.Count; i++)
            {
                cmbMap.Items.Add(MapList.OrderedMaps[i].Name);
                if (MapList.OrderedMaps[i].MapId == mMyCommand.MapId)
                {
                    cmbMap.SelectedIndex = i;
                }
            }

            if (cmbMap.SelectedIndex == -1)
            {
                cmbMap.SelectedIndex = 0;
            }

            scrlX.Maximum = Options.MapWidth - 1;
            scrlY.Maximum = Options.MapHeight - 1;
            scrlX.Value = mMyCommand.X;
            scrlY.Value = mMyCommand.Y;
            lblX.Text = Strings.Warping.x.ToString(scrlX.Value);
            lblY.Text = Strings.Warping.y.ToString(scrlY.Value);
            cmbDirection.SelectedIndex = (int) mMyCommand.Direction;
            if (GameObjects.PlayerVariableBase.Get(mMyCommand.VariableMapID) != null)
            {
                cmbVariable.Text = GameObjects.PlayerVariableBase.Get(mMyCommand.VariableMapID).Name;
            }
            if (GameObjects.PlayerVariableBase.Get(mMyCommand.VariableXID) != null)
            {
                cmbVariable2.Text = GameObjects.PlayerVariableBase.Get(mMyCommand.VariableXID).Name;
            }
            if (GameObjects.PlayerVariableBase.Get(mMyCommand.VariableYID) != null)
            {
                cmbVariable3.Text = GameObjects.PlayerVariableBase.Get(mMyCommand.VariableYID).Name;
            }
            
            
        }

        private void InitLocalization()
        {
            cmbVariable.Items.Clear();
            cmbVariable.Items.AddRange(Intersect.GameObjects.PlayerVariableBase.Names);
            cmbVariable.SelectedIndex = Intersect.GameObjects.PlayerVariableBase.ListIndex(mMyCommand.VariableMapID);

            cmbVariable2.Items.Clear();
            cmbVariable2.Items.AddRange(Intersect.GameObjects.PlayerVariableBase.Names);
            cmbVariable2.SelectedIndex = Intersect.GameObjects.PlayerVariableBase.ListIndex(mMyCommand.VariableXID);

            cmbVariable3.Items.Clear();
            cmbVariable3.Items.AddRange(Intersect.GameObjects.PlayerVariableBase.Names);
            cmbVariable3.SelectedIndex = Intersect.GameObjects.PlayerVariableBase.ListIndex(mMyCommand.VariableYID);

            warpSpecificLocation.Checked = !mMyCommand.usingvariableloc;
            warpPlayerVariable.Checked = !mMyCommand.usingvariableloc;
            

            grpWarp.Text = Strings.EventWarp.title;
            lblMap.Text = Strings.Warping.map.ToString("");
            lblX.Text = Strings.Warping.x.ToString(scrlX.Value);
            lblY.Text = Strings.Warping.y.ToString(scrlY.Value);
            lblDir.Text = Strings.Warping.direction.ToString("");
            btnVisual.Text = Strings.Warping.visual;
            cmbDirection.Items.Clear();
            for (var i = -1; i < 4; i++)
            {
                cmbDirection.Items.Add(Strings.Directions.dir[i]);
            }

            btnSave.Text = Strings.EventWarp.okay;
            btnCancel.Text = Strings.EventWarp.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mMyCommand.usingvariableloc == false)
            {
                mMyCommand.MapId = MapList.OrderedMaps[cmbMap.SelectedIndex].MapId;
                mMyCommand.X = (byte)scrlX.Value;
                mMyCommand.Y = (byte)scrlY.Value;
            }
            else
            {
                mMyCommand.VariableMapID = Intersect.GameObjects.PlayerVariableBase.IdFromList(cmbVariable.SelectedIndex);
                mMyCommand.VariableXID = Intersect.GameObjects.PlayerVariableBase.IdFromList(cmbVariable2.SelectedIndex);
                mMyCommand.VariableYID = Intersect.GameObjects.PlayerVariableBase.IdFromList(cmbVariable3.SelectedIndex);
            }

            mMyCommand.Direction = (WarpDirection)cmbDirection.SelectedIndex;

            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void scrlX_Scroll(object sender, ScrollValueEventArgs e)
        {
            lblX.Text = Strings.Warping.x.ToString(scrlX.Value);
        }

        private void scrlY_Scroll(object sender, ScrollValueEventArgs e)
        {
            lblY.Text = Strings.Warping.y.ToString(scrlY.Value);
        }

        private void btnVisual_Click(object sender, EventArgs e)
        {
            var frmWarpSelection = new FrmWarpSelection();
            frmWarpSelection.SelectTile(MapList.OrderedMaps[cmbMap.SelectedIndex].MapId, scrlX.Value, scrlY.Value);
            frmWarpSelection.ShowDialog();
            if (frmWarpSelection.GetResult())
            {
                for (var i = 0; i < MapList.OrderedMaps.Count; i++)
                {
                    if (MapList.OrderedMaps[i].MapId == frmWarpSelection.GetMap())
                    {
                        cmbMap.SelectedIndex = i;

                        break;
                    }
                }

                scrlX.Value = frmWarpSelection.GetX();
                scrlY.Value = frmWarpSelection.GetY();
                lblX.Text = Strings.Warping.x.ToString(scrlX.Value);
                lblY.Text = Strings.Warping.y.ToString(scrlY.Value);
            }
        }

        private void lblY_Click(object sender, EventArgs e)
        {
        }

        private void lblX_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void cmbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbMap_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void warpSpecificLocation_CheckedChanged(object sender, EventArgs e)
        {
            changespecificorvariable();
        }
        private void warpPlayerVariable_CheckedChanged(object sender, EventArgs e)
        {
            changespecificorvariable();
        }

        private void changespecificorvariable()
        {
            if (warpSpecificLocation.Checked == true)
            {
                mMyCommand.usingvariableloc = false;
            }
            else
            {
                if (warpPlayerVariable.Checked == true)
                {
                    mMyCommand.usingvariableloc = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
