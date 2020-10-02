using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events.Commands;
using Intersect.Enums;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandChangeStat : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private ChangeStatCommand mMyCommand;

        public EventCommandChangeStat(ChangeStatCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;

            InitLocalization();
            cmbItem.Items.Clear();
            for (var i = 0; i < (int)Stats.StatCount; i++)
            {
                cmbItem.Items.Add(Strings.Combat.stats[i]);
            }
            for (var i = 0; i < (int)PlayerVariableBase.Names.Length; i++)
            {
                cmbVariable.Items.Add(PlayerVariableBase.Names[i]);
            }

            /*for (int i = 0; i < Strings.Combat.stats.Count - 1; i++)
            {
                if (Strings.Combat.stats[i] == mMyCommand.StatName)
                {
                    cmbItem.SelectedIndex = i;
                }
            }*/
            cmbItem.SelectedIndex = mMyCommand.StatName;
            nudStat.Value = mMyCommand.AddValue;
            chkUseVariable.Checked = mMyCommand.UsingVariable;
            cmbVariable.SelectedIndex = PlayerVariableBase.ListIndex(mMyCommand.VariableId);
        }

        private void InitLocalization()
        {
            grpChangeStat.Text = Strings.ChangeStat.title;
            btnSave.Text = Strings.ChangeStat.okay;
            btnCancel.Text = Strings.ChangeStat.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.StatName = cmbItem.SelectedIndex;
            mMyCommand.AddValue = nudStat.Value;
            if (chkUseVariable.Checked == true)
            {
                mMyCommand.UsingVariable = true;
                mMyCommand.VariableId = PlayerVariableBase.IdFromList(cmbVariable.SelectedIndex);
            }
            else
            {
                mMyCommand.UsingVariable = false;
                mMyCommand.VariableId = Guid.NewGuid();
            }
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }

        private void grpChangeStat_Enter(object sender, EventArgs e)
        {

        }

        private void btnUseVariable(object sender, EventArgs e)
        {
            
        }
    }

}
