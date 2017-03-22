﻿
using System;
using System.Windows.Forms;
using DarkUI.Controls;
using Intersect.GameObjects.Events;
using Intersect.Localization;

namespace Intersect_Editor.Forms.Editors.Event_Commands
{
    public partial class EventCommand_Wait : UserControl
    {
        private EventCommand _myCommand;
        private readonly FrmEvent _eventEditor;
        public EventCommand_Wait(EventCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            _myCommand = refCommand;
            _eventEditor = editor;
            InitLocalization();
            scrlWait.Value = _myCommand.Ints[0];
            lblWait.Text = Strings.Get("eventwait", "label", scrlWait.Value);
        }

        private void InitLocalization()
        {
            grpWait.Text = Strings.Get("eventwait", "title");
            lblWait.Text = Strings.Get("eventwait", "label", scrlWait.Value);
            btnSave.Text = Strings.Get("eventwait", "okay");
            btnCancel.Text = Strings.Get("eventwait", "cancel");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _myCommand.Ints[0] =scrlWait.Value;
            _eventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _eventEditor.CancelCommandEdit();
        }

        private void scrlWait_Scroll(object sender, ScrollValueEventArgs e)
        {
            lblWait.Text = Strings.Get("eventwait", "label", scrlWait.Value);
        }
    }
}
