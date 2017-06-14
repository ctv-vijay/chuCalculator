namespace chuCalculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.pipes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addPipe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.removeAngle = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pipeShape = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pipeType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pipeEntrance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pipeAngle = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.valveType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.valveOpeness = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.removeValves = new System.Windows.Forms.Button();
            this.valves = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addValves = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.undoDrag = new System.Windows.Forms.Button();
            this.Drag3 = new System.Windows.Forms.PictureBox();
            this.Drag2 = new System.Windows.Forms.PictureBox();
            this.Drag1 = new System.Windows.Forms.PictureBox();
            this.schematic = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drag3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drag1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(307, 417);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(10, 13);
            this.answer.TabIndex = 3;
            this.answer.Text = " ";
            // 
            // pipes
            // 
            this.pipes.FormattingEnabled = true;
            this.pipes.Location = new System.Drawing.Point(430, 89);
            this.pipes.Name = "pipes";
            this.pipes.Size = new System.Drawing.Size(207, 186);
            this.pipes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pipes and bends and stuff";
            // 
            // addPipe
            // 
            this.addPipe.Location = new System.Drawing.Point(324, 132);
            this.addPipe.Name = "addPipe";
            this.addPipe.Size = new System.Drawing.Size(100, 23);
            this.addPipe.TabIndex = 7;
            this.addPipe.Text = "Add ->";
            this.addPipe.UseVisualStyleBackColor = true;
            this.addPipe.Click += new System.EventHandler(this.addPipe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Angle of pipe:";
            // 
            // removeAngle
            // 
            this.removeAngle.Location = new System.Drawing.Point(324, 208);
            this.removeAngle.Name = "removeAngle";
            this.removeAngle.Size = new System.Drawing.Size(100, 23);
            this.removeAngle.TabIndex = 9;
            this.removeAngle.Text = "<- Remove";
            this.removeAngle.UseVisualStyleBackColor = true;
            this.removeAngle.Click += new System.EventHandler(this.removeAngle_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 383);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pipeShape);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pipeType);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pipeEntrance);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pipeAngle);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.removeAngle);
            this.tabPage1.Controls.Add(this.pipes);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.addPipe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pipe Values";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pipeShape
            // 
            this.pipeShape.AllowDrop = true;
            this.pipeShape.FormattingEnabled = true;
            this.pipeShape.Items.AddRange(new object[] {
            "Elbow",
            "Return Bend",
            "Line",
            "Branch",
            "Union"});
            this.pipeShape.Location = new System.Drawing.Point(26, 204);
            this.pipeShape.Name = "pipeShape";
            this.pipeShape.Size = new System.Drawing.Size(121, 21);
            this.pipeShape.TabIndex = 16;
            this.pipeShape.Text = "Elbow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pipe shape:";
            // 
            // pipeType
            // 
            this.pipeType.AllowDrop = true;
            this.pipeType.FormattingEnabled = true;
            this.pipeType.Items.AddRange(new object[] {
            "Flanged",
            "Threaded"});
            this.pipeType.Location = new System.Drawing.Point(26, 270);
            this.pipeType.Name = "pipeType";
            this.pipeType.Size = new System.Drawing.Size(121, 21);
            this.pipeType.TabIndex = 14;
            this.pipeType.Text = "Flanged";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pipe type: ";
            // 
            // pipeEntrance
            // 
            this.pipeEntrance.AllowDrop = true;
            this.pipeEntrance.FormattingEnabled = true;
            this.pipeEntrance.Items.AddRange(new object[] {
            "Regular",
            "Long Radius"});
            this.pipeEntrance.Location = new System.Drawing.Point(29, 134);
            this.pipeEntrance.Name = "pipeEntrance";
            this.pipeEntrance.Size = new System.Drawing.Size(121, 21);
            this.pipeEntrance.TabIndex = 12;
            this.pipeEntrance.Text = "Regular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pipe Entrance: ";
            // 
            // pipeAngle
            // 
            this.pipeAngle.AllowDrop = true;
            this.pipeAngle.FormattingEnabled = true;
            this.pipeAngle.Items.AddRange(new object[] {
            "Add a value",
            "45",
            "90",
            "180"});
            this.pipeAngle.Location = new System.Drawing.Point(29, 69);
            this.pipeAngle.Name = "pipeAngle";
            this.pipeAngle.Size = new System.Drawing.Size(121, 21);
            this.pipeAngle.TabIndex = 10;
            this.pipeAngle.Text = "45";
            this.pipeAngle.SelectedIndexChanged += new System.EventHandler(this.pipeAngle_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.valveType);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.valveOpeness);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.removeValves);
            this.tabPage2.Controls.Add(this.valves);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.addValves);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Valve Values";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // valveType
            // 
            this.valveType.AllowDrop = true;
            this.valveType.FormattingEnabled = true;
            this.valveType.Items.AddRange(new object[] {
            "Globe",
            "Angle",
            "Gate",
            "Swing Check",
            "Ball"});
            this.valveType.Location = new System.Drawing.Point(39, 230);
            this.valveType.Name = "valveType";
            this.valveType.Size = new System.Drawing.Size(121, 21);
            this.valveType.TabIndex = 24;
            this.valveType.Text = "Gate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Type of Valve:";
            // 
            // valveOpeness
            // 
            this.valveOpeness.AllowDrop = true;
            this.valveOpeness.FormattingEnabled = true;
            this.valveOpeness.Items.AddRange(new object[] {
            "Add a value",
            "0",
            "1",
            "1/2",
            "1/3",
            "2/3",
            "1/4",
            "3/4"});
            this.valveOpeness.Location = new System.Drawing.Point(39, 75);
            this.valveOpeness.Name = "valveOpeness";
            this.valveOpeness.Size = new System.Drawing.Size(121, 21);
            this.valveOpeness.TabIndex = 22;
            this.valveOpeness.Text = "1";
            this.valveOpeness.SelectedIndexChanged += new System.EventHandler(this.valveOpeness_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Valves";
            // 
            // removeValves
            // 
            this.removeValves.Location = new System.Drawing.Point(327, 214);
            this.removeValves.Name = "removeValves";
            this.removeValves.Size = new System.Drawing.Size(100, 23);
            this.removeValves.TabIndex = 21;
            this.removeValves.Text = "<- Remove";
            this.removeValves.UseVisualStyleBackColor = true;
            this.removeValves.Click += new System.EventHandler(this.removeValves_Click);
            // 
            // valves
            // 
            this.valves.FormattingEnabled = true;
            this.valves.Location = new System.Drawing.Point(433, 95);
            this.valves.Name = "valves";
            this.valves.Size = new System.Drawing.Size(207, 186);
            this.valves.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Openess of Valve:";
            // 
            // addValves
            // 
            this.addValves.Location = new System.Drawing.Point(327, 138);
            this.addValves.Name = "addValves";
            this.addValves.Size = new System.Drawing.Size(100, 23);
            this.addValves.TabIndex = 19;
            this.addValves.Text = "Add ->";
            this.addValves.UseVisualStyleBackColor = true;
            this.addValves.Click += new System.EventHandler(this.addValves_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.undoDrag);
            this.tabPage3.Controls.Add(this.Drag3);
            this.tabPage3.Controls.Add(this.Drag2);
            this.tabPage3.Controls.Add(this.Drag1);
            this.tabPage3.Controls.Add(this.schematic);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(668, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // undoDrag
            // 
            this.undoDrag.Location = new System.Drawing.Point(275, 271);
            this.undoDrag.Name = "undoDrag";
            this.undoDrag.Size = new System.Drawing.Size(116, 44);
            this.undoDrag.TabIndex = 4;
            this.undoDrag.Text = "Undo";
            this.undoDrag.UseVisualStyleBackColor = true;
            this.undoDrag.Click += new System.EventHandler(this.undoDrag_Click);
            // 
            // Drag3
            // 
            this.Drag3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drag3.Image = ((System.Drawing.Image)(resources.GetObject("Drag3.Image")));
            this.Drag3.Location = new System.Drawing.Point(218, 6);
            this.Drag3.Name = "Drag3";
            this.Drag3.Size = new System.Drawing.Size(100, 100);
            this.Drag3.TabIndex = 3;
            this.Drag3.TabStop = false;
            // 
            // Drag2
            // 
            this.Drag2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drag2.Image = ((System.Drawing.Image)(resources.GetObject("Drag2.Image")));
            this.Drag2.Location = new System.Drawing.Point(112, 6);
            this.Drag2.Name = "Drag2";
            this.Drag2.Size = new System.Drawing.Size(100, 100);
            this.Drag2.TabIndex = 2;
            this.Drag2.TabStop = false;
            // 
            // Drag1
            // 
            this.Drag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Drag1.Image = ((System.Drawing.Image)(resources.GetObject("Drag1.Image")));
            this.Drag1.InitialImage = ((System.Drawing.Image)(resources.GetObject("Drag1.InitialImage")));
            this.Drag1.Location = new System.Drawing.Point(6, 6);
            this.Drag1.Name = "Drag1";
            this.Drag1.Size = new System.Drawing.Size(100, 100);
            this.Drag1.TabIndex = 1;
            this.Drag1.TabStop = false;
            // 
            // schematic
            // 
            this.schematic.AutoSize = true;
            this.schematic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schematic.Location = new System.Drawing.Point(6, 113);
            this.schematic.Name = "schematic";
            this.schematic.Size = new System.Drawing.Size(656, 124);
            this.schematic.TabIndex = 0;
            this.schematic.WrapContents = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.button1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drag3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drag1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.ListBox pipes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeAngle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox pipeShape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pipeType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pipeEntrance;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox pipeAngle;
        private System.Windows.Forms.ComboBox valveType;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox valveOpeness;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button removeValves;
        private System.Windows.Forms.ListBox valves;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addValves;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel schematic;
        private System.Windows.Forms.PictureBox Drag1;
        private System.Windows.Forms.PictureBox Drag2;
        private System.Windows.Forms.PictureBox Drag3;
        private System.Windows.Forms.Button undoDrag;
    }
}

