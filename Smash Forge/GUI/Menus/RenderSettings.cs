using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smash_Forge.GUI
{
    public partial class RenderSettings : Form
    {
        public RenderSettings()
        {
            InitializeComponent();

            checkBox1.Checked = Runtime.renderModel;
            checkBox2.Checked = Runtime.renderBones;
            checkBox3.Checked = Runtime.renderHitboxes;
            checkBox4.Checked = Runtime.renderPath;
            checkBox5.Checked = Runtime.renderFloor;
            checkBox6.Checked = Runtime.renderLVD;
            checkBox7.Checked = Runtime.renderCollisions;
            checkBox8.Checked = Runtime.renderSpawns;
            checkBox9.Checked = Runtime.renderRespawns;
            checkBox10.Checked = Runtime.renderItemSpawners;
            checkBox11.Checked = Runtime.renderGeneralPoints;
            checkBox12.Checked = Runtime.renderCollisionNormals;
            swagViewing.Checked = Runtime.renderSwag;

            depthSlider.Value = (int)Runtime.renderDepth;

            cb_normals.Checked = Runtime.renderNormals;
            cb_vertcolor.Checked = Runtime.renderVertColor;
            renderMode.SelectedIndex = (int)Runtime.renderType;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //Disable all the checkboxes for LVD
            checkChanged();
            checkBox7.Enabled = checkBox6.Checked;
            checkBox8.Enabled = checkBox6.Checked;
            checkBox9.Enabled = checkBox6.Checked;
            checkBox10.Enabled = checkBox6.Checked;
            checkBox11.Enabled = checkBox6.Checked;
            checkBox12.Enabled = checkBox6.Checked && checkBox7.Checked;
        }

        private void checkChanged()
        {
            Runtime.renderModel = checkBox1.Checked;
            Runtime.renderBones = checkBox2.Checked;
            Runtime.renderHitboxes = checkBox3.Checked;
            Runtime.renderPath = checkBox4.Checked;
            Runtime.renderFloor = checkBox5.Checked;
            Runtime.renderLVD = checkBox6.Checked;
            Runtime.renderCollisions = checkBox7.Checked;
            Runtime.renderSpawns = checkBox8.Checked;
            Runtime.renderRespawns = checkBox9.Checked;
            Runtime.renderItemSpawners = checkBox10.Checked;
            Runtime.renderGeneralPoints = checkBox11.Checked;
            Runtime.renderCollisionNormals = checkBox12.Checked;
            checkBox12.Enabled = checkBox6.Checked && checkBox7.Checked;
        }

        private void checkChanged(object sender, EventArgs e)
        {
            checkChanged();
        }

        private void RenderSettings_Load(object sender, EventArgs e)
        {
            safemode.Checked = Properties.Settings.Default.SafeCheck;
            DeleteMesh.Checked = Properties.Settings.Default.DltMesh;
            Clearwrk.Checked = Properties.Settings.Default.ClearWrkCheck;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void depthSlider_ValueChanged(object sender, EventArgs e)
        {
            Runtime.renderDepth = depthSlider.Value;
        }

        private void renderMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Runtime.renderType = (Runtime.RenderTypes)renderMode.SelectedIndex;
            
        }

        private void swagViewing_CheckedChanged(object sender, EventArgs e)
        {
            Runtime.renderSwag = swagViewing.Checked;
        }

        private void safemode_CheckedChanged(object sender, EventArgs e)
        {
            
            if (DeleteMesh.Checked | Clearwrk.Checked | ClearAnims.Checked == false)
            {
                DeleteMesh.Checked = true;
                Clearwrk.Checked = true;
                //ClearMoves.Checked = true;
                ClearAnims.Checked = true;
                Properties.Settings.Default.SafeCheck = safemode.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.SafeCheck = safemode.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void Clearwrk_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClearWrkCheck = Clearwrk.Checked;
            Properties.Settings.Default.Save();
        }

        private void DeleteMesh_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DltMesh = DeleteMesh.Checked;
            Properties.Settings.Default.Save();
        }

        private void ClearAnims_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClearAnim = ClearAnims.Checked;
            Properties.Settings.Default.Save();
        }

        private void ClearMoves_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ClearMove = ClearMoves.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
