using System;
using System.Windows.Forms;

using Intersect.Editor.Localization;
using Intersect.GameObjects;
using Intersect.GameObjects.Events.Commands;

namespace Intersect.Editor.Forms.Editors.Events.Event_Commands
{

    public partial class EventCommandRemoveHotbarSpell : UserControl
    {

        private readonly FrmEvent mEventEditor;

        private CommandRemoveHotbarSpellCommand mMyCommand;

        public EventCommandRemoveHotbarSpell(CommandRemoveHotbarSpellCommand refCommand, FrmEvent editor)
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
            grpHotbarSpell.Text = Strings.EventRemoveHotbarSpell.title;
            btnSave.Text = Strings.EventRemoveHotbarSpell.okay;
            btnCancel.Text = Strings.EventRemoveHotbarSpell.cancel;
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
