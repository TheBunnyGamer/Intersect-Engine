﻿using System;
using System.Windows.Forms;
using Intersect_Editor.Classes;
using Intersect_Editor.Classes.Maps;
using Microsoft.Xna.Framework.Graphics;
using WeifenLuo.WinFormsUI.Docking;
using Intersect.Localization;

namespace Intersect_Editor.Forms.DockingElements
{
    public partial class frmMapGrid : DockContent
    {
        //MonoGame Swap Chain
        private SwapChainRenderTarget _chain;
        private bool _dragging = false;
        private int _dragX = 0;
        private int _dragY = 0;
        private int _posX = 0;
        private int _posY = 0;
        private ToolTip _toolTip = new ToolTip();
        private MapGridItem _toolTipItem;

        public frmMapGrid()
        {
            InitializeComponent();
            pnlMapGrid.MouseWheel += PnlMapGrid_MouseWheel;
        }

        private void frmMapGrid_Load(object sender, EventArgs e)
        {
            CreateSwapChain();
            if (Globals.MapGrid == null) Globals.MapGrid = new MapGrid(linkMapToolStripMenuItem,unlinkMapToolStripMenuItem,recacheMapToolStripMenuItem, contextMenuStrip);
            InitLocalization();
        }

        private void InitLocalization()
        {
            Text = Strings.Get("mapgrid", "title");
            btnScreenshotWorld.Text = Strings.Get("mapgrid", "screenshotworld");
            btnGridView.Text = Strings.Get("mapgrid", "gridlines");
            btnFetchPreview.Text = Strings.Get("mapgrid", "preview");
            downloadMissingPreviewsToolStripMenuItem.Text = Strings.Get("mapgrid", "downloadmissing");
            reDownloadAllPreviewsToolStripMenuItem.Text = Strings.Get("mapgrid", "downloadall");
            unlinkMapToolStripMenuItem.Text = Strings.Get("mapgrid", "unlink");
            linkMapToolStripMenuItem.Text = Strings.Get("mapgrid", "link");
            recacheMapToolStripMenuItem.Text = Strings.Get("mapgrid", "recache");
        }

        public void InitGridWindow()
        {
            CreateSwapChain();
        }

        private void CreateSwapChain()
        {
            if (!Globals.ClosingEditor)
            {
                if (_chain != null)
                {
                    _chain.Dispose();
                }
                if (EditorGraphics.GetGraphicsDevice() != null)
                {
                    if (pnlMapGrid.Width > 0 && pnlMapGrid.Height > 0)
                    {
                        if (pnlMapGrid.Width > 0 && pnlMapGrid.Height > 0)
                        {
                            _chain = new SwapChainRenderTarget(EditorGraphics.GetGraphicsDevice(),
                                pnlMapGrid.Handle,
                                pnlMapGrid.Width, pnlMapGrid.Height, false, SurfaceFormat.Color,
                                DepthFormat.Depth24, 0, RenderTargetUsage.DiscardContents, PresentInterval.Immediate);
                            EditorGraphics.SetMapGridChain(_chain);
                        }
                    }
                }
            }
        }

        private void frmMapGrid_DockStateChanged(object sender, EventArgs e)
        {
            CreateSwapChain();
        }

        private void pnlMapGrid_Resize(object sender, EventArgs e)
        {
            CreateSwapChain();
        }


        private void PnlMapGrid_MouseWheel(object sender, MouseEventArgs e)
        {
            Globals.MapGrid.ZoomIn(e.Delta, e.X,e.Y);
        }

        private void pnlMapGrid_MouseMove(object sender, MouseEventArgs e)
        {
            _posX = e.X;
            _posY = e.Y;
            if (_dragging)
            {
                Globals.MapGrid.Move(_dragX-e.X, _dragY-e.Y);
                _dragX = e.X;
                _dragY = e.Y;
            }
            if (_toolTip.Active && _toolTipItem != null)
            {
                if (Globals.MapGrid.GetItemAt(_posX, _posY) != _toolTipItem)
                {
                    _toolTip.Hide(pnlMapGrid);
                    _toolTipItem = null;
                }
            }
            else
            {
                _toolTipItem = Globals.MapGrid.GetItemAt(_posX, _posY);
                if (_toolTipItem != null)
                {
                    _toolTip.Show(_toolTipItem.name, pnlMapGrid);
                }
            }
        }

        private void pnlMapGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Middle) { 
                _dragging = true;
                _dragX = e.X;
                _dragY = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Globals.MapGrid.RightClickGrid(e.X, e.Y,pnlMapGrid);
            }
        }

        private void pnlMapGrid_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pnlMapGrid_MouseLeave(object sender, EventArgs e)
        {
            if (_toolTip.Active)
            {
                _toolTip.Hide(pnlMapGrid);
                _toolTipItem = null;
            }
        }

        private void pnlMapGrid_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnGridView_Click(object sender, EventArgs e)
        {
            Globals.MapGrid.ShowLines = !Globals.MapGrid.ShowLines;
        }

        private void pnlMapGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Globals.MapGrid.DoubleClick(e.X, e.Y);
        }

        private void downloadMissingPreviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.MapGrid.FetchMissingPreviews(false);
        }

        private void reDownloadAllPreviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.MapGrid.FetchMissingPreviews(true);
        }

        private void btnScreenshotWorld_Click(object sender, EventArgs e)
        {
            Globals.MapGrid.ScreenshotWorld();
        }

        private void frmMapGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                MouseEventArgs args = new MouseEventArgs(MouseButtons.None, 0,_posX, _posY, 120);
                PnlMapGrid_MouseWheel(null, args);
            }
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                MouseEventArgs args = new MouseEventArgs(MouseButtons.None, 0, _posX, _posY, - 120);
                PnlMapGrid_MouseWheel(null, args);
            }
            var xDiff = 0;
            var yDiff = 0;
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                yDiff -= 20;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                yDiff += 20;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                xDiff -= 20;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                xDiff += 20;
            }
            if (xDiff != 0 || yDiff != 0)
            {
                Globals.MapGrid.Move(xDiff,yDiff);
            }
        }
    }
}
