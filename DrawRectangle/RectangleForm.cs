using System;
using System.Drawing;
using System.Windows.Forms;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;

namespace DrawRectangle
{
    public partial class RectangleForm : Form
    {
        Point3d insPt;
        double xCoord, yCoord;

        public RectangleForm()
        {
            InitializeComponent();
        }

        private void BtnDrawRectangle_Click(object sender, EventArgs e)
        {
            // Validate the Width
            bool isValid = ValidateEntry(txtWidth);
            if (isValid == false)
            {
                MessageBox.Show("Invalid Width. Please enter a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWidth.Focus();
                return;
            }

            // Validate the Height
            isValid = ValidateEntry(txtHeight);
            if (isValid == false)
            {
                MessageBox.Show("Invalid Height. Please enter a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.Focus();
                return;
            }

            if (rbPickPoint.Checked)
            {
                // Ask for the insertionPoint of the Rectangle
                this.Hide();
                Editor edt = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
                PromptPointOptions ppo = new PromptPointOptions("Pick lower left corner of the Rectangle:");
                PromptPointResult ppr = edt.GetPoint(ppo);
                insPt = ppr.Value;
                this.Show();
            }

            if (rbCoordinates.Checked)
            {
                // Validate X-Coordinate
                isValid = ValidateEntry(txtXCoord);
                if (isValid == false)
                {
                    MessageBox.Show("Invalid X-Coordinate. Please enter a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtXCoord.Focus();
                    return;
                }

                // Validate Y-Coordinate
                isValid = ValidateEntry(txtYCoord);
                if (isValid == false)
                {
                    MessageBox.Show("Invalid Y-Coordinate. Please enter a valid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtYCoord.Focus();
                    return;
                }

                xCoord = double.Parse(txtXCoord.Text.Trim());
                yCoord = double.Parse(txtXCoord.Text.Trim());
                insPt = new Point3d(xCoord, yCoord, 0);
            }

            double width = double.Parse(txtWidth.Text.Trim());
            double height = double.Parse(txtHeight.Text.Trim());
            RectangleUtil rect = new RectangleUtil();
            rect.DrawRectangle(width, height, insPt);
            lblInfo.Text = "Rectangle was created successfully!";
            lblInfo.ForeColor = Color.Green;
        }

        private bool ValidateEntry(TextBox tb)
        {
            bool isValid = false;
            double value;

            try
            {
                // Validate the Textbox value
                if (tb.Text.Trim() == "")
                {
                    lblInfo.Text = "Please enter a value.";
                    lblInfo.ForeColor = Color.Red;                    
                }
                else
                {
                    value = double.Parse(tb.Text.Trim());
                    isValid = true;
                }                                
            }
            catch (System.Exception ex)
            {
                lblInfo.Text = "Invalid input. " + ex.Message;
                lblInfo.ForeColor = Color.Red;                
            }
            return isValid;
        }

        private void RbPickPoint_CheckedChanged(object sender, EventArgs e)
        {
            gbCoordinates.Enabled = false;
        }

        private void RbCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            gbCoordinates.Enabled = true;
        }
    }
}
