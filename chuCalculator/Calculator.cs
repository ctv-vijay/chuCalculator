using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuCalculator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
            // Adds drag event to pictureboxes
            Drag1.MouseDown += Drag_MouseDown;
            Drag2.MouseDown += Drag_MouseDown;
            Drag3.MouseDown += Drag_MouseDown;
            // Adds drop event to flowcontrol
            schematic.AllowDrop = true;
            schematic.DragEnter += schematic_DragEnter;
            schematic.DragDrop += schematic_DragDrop;
        }
        /**
         * The button click event for the "Calculate" button.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        private void button1_Click(object sender, EventArgs e)
        {
            // Add formulas here later
            answer.Text = "Pipes: ";
            foreach (object item in pipes.Items)
            {
                answer.Text += item + " " + '\n';
            }
            answer.Text += "Valves: ";
            foreach (object item in valves.Items)
            {
                answer.Text += item + " " + '\n';
            }
        }
        /**
         * The button click event for the "Add ->" button on the pipe page.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        private void addPipe_Click(object sender, EventArgs e)
        {
            if (pipeAngle.Text != null)
            {
                int angle;
                // Checks if angle is number and between 0 and 180
                if (int.TryParse(pipeAngle.Text, out angle) && (angle >= 0 && angle <= 180))
                {
                    pipes.Items.Add(createString(pipeAngle.Text, pipeEntrance.Text, pipeShape.Text, pipeType.Text));
                }
                else
                {
                    MessageBox.Show("Make sure you have selected an angle value between 0 and 180", "Angle Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /**
         * Creates a string given the attributes of the pipe, valve, etc.
         *  
         * param args: variable length string array of the attributes
         * 
         * Returns: csv of the pipe, valve, etc.
         **/
        private String createString(params string[] args)
        {
            String returnValue = null;
            // Grabs each argument passed in and separates it with a comma
            for (int i = 0; i < args.Length - 1; i++)
            {
                returnValue += args[i] + ", ";
            }
            returnValue += args[args.Length - 1];
            return returnValue;
        }
        /**
         * The button click event for the "remove" button for the pipe page.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        private void removeAngle_Click(object sender, EventArgs e)
        {
            pipes.Items.Remove(pipes.SelectedItem);
        }
        /**
         * The event for pipe drop down menu.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        private void pipeAngle_SelectedIndexChanged(object sender, EventArgs e)
        {
            // only runs code when drop down selects "add a value".
            if (pipeAngle.Text == "Add a value")
            {
                // Creates popup to allow for user input
                valuePopup angle = new valuePopup();
                var newDialog = angle.ShowDialog();
                if (angle.value.Text != "none")
                {
                    pipeAngle.Items.Add(angle.value.Text);
                }
                else
                {
                    MessageBox.Show("The value entered (" + angle.value.Text + ") is invalid", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /**
         * The button click event for the "Add ->" button on the valves screen
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        private void addValves_Click(object sender, EventArgs e)
        {
            if (valveOpeness.Text != null)
            {
                // checks if the string entered is a fraction
                Regex fraction = new Regex(@"\b\d+/?\d*\b");
                if (fraction.IsMatch(valveOpeness.Text) && checkFraction(valveOpeness.Text))
                {
                    // if fraction is valid, adds it to the list of valves
                    // TODO: check if values are between 0 and 1, inclusive.
                    valves.Items.Add(createString(valveOpeness.Text, valveType.Text));
                }
                else
                {
                    MessageBox.Show("Make sure you have selected a valid number between 0 and 1", "Openess Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /**
         * Checks if fraction is between 0 and 1 and is valid.
         *  
         * param text: text of the possible valid fraction
         * 
         * Returns: boolean of whether above is true.
         **/
        private bool checkFraction(string text)
        {
            string[] nums = text.Split('/');
            if (nums.Length > 2)
            {
                return false;
            } else if(nums.Length == 1)
            {
                if (!nums[0].Equals("0") || !nums[0].Equals("1"))
                    return false;
            } else if (nums.Length == 2){
                if (Int32.Parse(nums[0]) > Int32.Parse(nums[1]))
                    return false;
            } else
            {
                return false;
            }
            return true;
        }

        /**
        * The button click event for the "remove" button for the valve page.
        *  
        * param sender: The object being acted upon.
        * param e: The event arguments of the event.
        * 
        * Returns: none.
        **/
        private void removeValves_Click(object sender, EventArgs e)
        {
            valves.Items.Remove(valves.SelectedItem);
        }
        /**
         * The event for the valve drop down menu.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        private void valveOpeness_SelectedIndexChanged(object sender, EventArgs e)
        {
            // only runs code when drop down selects "add a value".
            if (valveOpeness.Text == "Add a value")
            {
                // Creates popup to allow for user input
                valuePopup openess = new valuePopup();
                var newDialog = openess.ShowDialog();
                if (openess.value.Text != "none")
                {
                    valveOpeness.Items.Add(openess.value.Text);
                }
                else
                {
                    MessageBox.Show("The value entered (" + openess.value.Text + ") is invalid", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /**
         * The left mouse click event for clicking on a pictureBox.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        private void Drag_MouseDown(object sender, MouseEventArgs e)
        {
            // Cast object to a picture box to grab image
            // NOTE: this makes this function only work on picture box objects or else the program will crash (can add an if statement to prevent this) 
            PictureBox pb = (PictureBox)sender;
            var img = pb.Image;
            // If there is no image, the drag feature does not work.
            if (img == null) return;
            // If there is, stores the dragged image into a variable
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
                pb.Image = img;
        }
        /**
         * The event handler for dragging a picture onto the flow control panel.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        void schematic_DragEnter(object sender, DragEventArgs e)
        {
            // Prepares the drop of the image when a mouse is dragging something
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }
        /**
         * The event handler for letting go of the left mouse button over the flow control panel.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        void schematic_DragDrop(object sender, DragEventArgs e)
        {
            // Get the image from the mouse event e
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            // Creates new picturebox class (Size is just for this template, you can get rid of this and it will be as big as the image)
            var picture = new PictureBox
            {
                Size = new Size(100, 100),
                Image = bmp,

            };
            schematic.Controls.Add(picture);
        }
        /**
         * The button click event for the "Undo" button.
         *  
         * param sender: The object being acted upon.
         * param e: The event arguments of the event.
         * 
         * Returns: none.
         **/
        private void undoDrag_Click(object sender, EventArgs e)
        {
            // Deletes the most recently added picture
            schematic.SuspendLayout();
            if (schematic.Controls.Count >= 1)
            {
                Control last = schematic.Controls[schematic.Controls.Count - 1];
                last.Dispose();
                GC.Collect();
            }
            schematic.ResumeLayout();
        }
    }
}
