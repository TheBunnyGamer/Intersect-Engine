using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandHotbarSpell : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private CommandHotbarSpellCommand mMyCommand;

        public EventCommandHotbarSpell(CommandHotbarSpellCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            mMyCommand = refCommand;
            mEventEditor = editor;

            InitLocalization();
            cmbItem.Items.Clear();
            cmbItem.Items.AddRange(SpellBase.Names);
            cmbItem.SelectedIndex = SpellBase.ListIndex(mMyCommand.SpellId);
        }

        private void InitLocalization()
        {
            grpHotbarSpell.Text = Strings.EventHotbarSpell.title;
            btnSave.Text = Strings.EventHotbarSpell.okay;
            btnCancel.Text = Strings.EventHotbarSpell.cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mMyCommand.SpellId = SpellBase.IdFromList(cmbItem.SelectedIndex);
            mEventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mEventEditor.CancelCommandEdit();
        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }
    }

}
