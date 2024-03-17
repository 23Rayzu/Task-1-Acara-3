using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;

namespace Working_with_Dotspatial_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grbOperations_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip btnToolTip = new ToolTip();
            btnToolTip.SetToolTip(btnLoad, "Shift + L");
            btnToolTip.SetToolTip(btnZoomIn, "Shift + I");
            btnToolTip.SetToolTip(btnZoomOut, "Shift + O");
            btnToolTip.SetToolTip(btnClear, "Shift + C");
            btnToolTip.SetToolTip(btnZoomToExtent, "Shift + E");
            btnToolTip.SetToolTip(btnLoad, "Shift + L");
            btnToolTip.SetToolTip(btnInfo, "Shift + f");
            btnToolTip.SetToolTip(btnSelect, "Shift + S");
            btnToolTip.SetToolTip(btnNone, "Shift + N");
            btnToolTip.SetToolTip(btnPan, "Shift + N");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            map1.AddLayer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            map1.ClearLayers();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            map1.ZoomIn();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            map1.ZoomOut();
        }

        private void btnZoomToExtent_Click(object sender, EventArgs e)
        {
            map1.ZoomToMaxExtent();
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            map1.FunctionMode=FunctionMode.Pan;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Info;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Select;
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.None;
        }
    }
}
