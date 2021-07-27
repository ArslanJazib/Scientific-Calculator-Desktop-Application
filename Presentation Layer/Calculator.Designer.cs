namespace VPAssignment3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCalculatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificOptions1 = new System.Windows.Forms.Panel();
            this.OutDisplay = new System.Windows.Forms.RichTextBox();
            this.InputDisplay = new System.Windows.Forms.RichTextBox();
            this.Display = new System.Windows.Forms.SplitContainer();
            this.scientificOptions2 = new System.Windows.Forms.Panel();
            this.bar = new VPAssignment3.RoundButton();
            this.denote = new VPAssignment3.RoundButton();
            this.shift = new VPAssignment3.RoundButton();
            this.log = new VPAssignment3.RoundButton();
            this.sqrt = new VPAssignment3.RoundButton();
            this.tan_tani = new VPAssignment3.RoundButton();
            this.pi = new VPAssignment3.RoundButton();
            this.cos_cosi = new VPAssignment3.RoundButton();
            this.radian_degree = new VPAssignment3.RoundButton();
            this.sin_sini = new VPAssignment3.RoundButton();
            this.fraction = new VPAssignment3.RoundButton();
            this.factorial = new VPAssignment3.RoundButton();
            this.lognatural_base = new VPAssignment3.RoundButton();
            this.square = new VPAssignment3.RoundButton();
            this.exponent = new VPAssignment3.RoundButton();
            this.cube = new VPAssignment3.RoundButton();
            this.power = new VPAssignment3.RoundButton();
            this.Tax = new VPAssignment3.RoundButton();
            this.remove = new VPAssignment3.RoundButton();
            this.multiply = new VPAssignment3.RoundButton();
            this.divide = new VPAssignment3.RoundButton();
            this.clear = new VPAssignment3.RoundButton();
            this.mod = new VPAssignment3.RoundButton();
            this.nine = new VPAssignment3.RoundButton();
            this.eight = new VPAssignment3.RoundButton();
            this.seven = new VPAssignment3.RoundButton();
            this.minus = new VPAssignment3.RoundButton();
            this.six = new VPAssignment3.RoundButton();
            this.five = new VPAssignment3.RoundButton();
            this.four = new VPAssignment3.RoundButton();
            this.plus = new VPAssignment3.RoundButton();
            this.three = new VPAssignment3.RoundButton();
            this.two = new VPAssignment3.RoundButton();
            this.one = new VPAssignment3.RoundButton();
            this.equal = new VPAssignment3.RoundButton();
            this.ans = new VPAssignment3.RoundButton();
            this.braces = new VPAssignment3.RoundButton();
            this.dec = new VPAssignment3.RoundButton();
            this.zero = new VPAssignment3.RoundButton();
            this.menuStrip1.SuspendLayout();
            this.scientificOptions1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.Display.Panel1.SuspendLayout();
            this.Display.Panel2.SuspendLayout();
            this.Display.SuspendLayout();
            this.scientificOptions2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.basicCalculatorToolStripMenuItem,
            this.taxCalculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 33);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // basicCalculatorToolStripMenuItem
            // 
            this.basicCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicCalculatorToolStripMenuItem1,
            this.scientificCalculatorToolStripMenuItem});
            this.basicCalculatorToolStripMenuItem.Name = "basicCalculatorToolStripMenuItem";
            this.basicCalculatorToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.basicCalculatorToolStripMenuItem.Text = "Calculator Type";
            this.basicCalculatorToolStripMenuItem.Click += new System.EventHandler(this.CalculatorTypeToolStripMenuItem_Click);
            // 
            // basicCalculatorToolStripMenuItem1
            // 
            this.basicCalculatorToolStripMenuItem1.Name = "basicCalculatorToolStripMenuItem1";
            this.basicCalculatorToolStripMenuItem1.Size = new System.Drawing.Size(248, 30);
            this.basicCalculatorToolStripMenuItem1.Text = "Basic Calculator";
            this.basicCalculatorToolStripMenuItem1.Click += new System.EventHandler(this.basicCalculatorToolStripMenuItem1_Click);
            // 
            // scientificCalculatorToolStripMenuItem
            // 
            this.scientificCalculatorToolStripMenuItem.Name = "scientificCalculatorToolStripMenuItem";
            this.scientificCalculatorToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.scientificCalculatorToolStripMenuItem.Text = "Scientific Calculator";
            this.scientificCalculatorToolStripMenuItem.Click += new System.EventHandler(this.scientificCalculatorToolStripMenuItem_Click);
            // 
            // taxCalculatorToolStripMenuItem
            // 
            this.taxCalculatorToolStripMenuItem.Name = "taxCalculatorToolStripMenuItem";
            this.taxCalculatorToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.taxCalculatorToolStripMenuItem.Text = "Tax Calculator";
            // 
            // scientificOptions1
            // 
            this.scientificOptions1.Controls.Add(this.shift);
            this.scientificOptions1.Controls.Add(this.log);
            this.scientificOptions1.Controls.Add(this.sqrt);
            this.scientificOptions1.Controls.Add(this.tan_tani);
            this.scientificOptions1.Controls.Add(this.pi);
            this.scientificOptions1.Controls.Add(this.cos_cosi);
            this.scientificOptions1.Controls.Add(this.radian_degree);
            this.scientificOptions1.Controls.Add(this.sin_sini);
            this.scientificOptions1.Controls.Add(this.fraction);
            this.scientificOptions1.Controls.Add(this.factorial);
            this.scientificOptions1.Controls.Add(this.lognatural_base);
            this.scientificOptions1.Controls.Add(this.square);
            this.scientificOptions1.Controls.Add(this.exponent);
            this.scientificOptions1.Controls.Add(this.cube);
            this.scientificOptions1.Controls.Add(this.power);
            this.scientificOptions1.Location = new System.Drawing.Point(12, 195);
            this.scientificOptions1.Name = "scientificOptions1";
            this.scientificOptions1.Size = new System.Drawing.Size(437, 188);
            this.scientificOptions1.TabIndex = 74;
            // 
            // OutDisplay
            // 
            this.OutDisplay.BackColor = System.Drawing.Color.White;
            this.OutDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutDisplay.Location = new System.Drawing.Point(7, -1);
            this.OutDisplay.Name = "OutDisplay";
            this.OutDisplay.ReadOnly = true;
            this.OutDisplay.Size = new System.Drawing.Size(430, 55);
            this.OutDisplay.TabIndex = 1;
            this.OutDisplay.TabStop = false;
            this.OutDisplay.Text = "";
            // 
            // InputDisplay
            // 
            this.InputDisplay.BackColor = System.Drawing.Color.White;
            this.InputDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputDisplay.Location = new System.Drawing.Point(7, 4);
            this.InputDisplay.Name = "InputDisplay";
            this.InputDisplay.ReadOnly = true;
            this.InputDisplay.Size = new System.Drawing.Size(430, 65);
            this.InputDisplay.TabIndex = 0;
            this.InputDisplay.TabStop = false;
            this.InputDisplay.Text = "";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(5, 45);
            this.Display.Name = "Display";
            this.Display.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Display.Panel1
            // 
            this.Display.Panel1.Controls.Add(this.InputDisplay);
            this.Display.Panel1MinSize = 50;
            // 
            // Display.Panel2
            // 
            this.Display.Panel2.Controls.Add(this.OutDisplay);
            this.Display.Size = new System.Drawing.Size(444, 144);
            this.Display.SplitterDistance = 72;
            this.Display.TabIndex = 0;
            // 
            // scientificOptions2
            // 
            this.scientificOptions2.Controls.Add(this.bar);
            this.scientificOptions2.Controls.Add(this.denote);
            this.scientificOptions2.Location = new System.Drawing.Point(79, 381);
            this.scientificOptions2.Name = "scientificOptions2";
            this.scientificOptions2.Size = new System.Drawing.Size(209, 72);
            this.scientificOptions2.TabIndex = 75;
            // 
            // bar
            // 
            this.bar.BorderColor = System.Drawing.Color.Black;
            this.bar.ButtonColor = System.Drawing.Color.Silver;
            this.bar.FlatAppearance.BorderSize = 0;
            this.bar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar.Location = new System.Drawing.Point(27, 8);
            this.bar.Name = "bar";
            this.bar.OnHoverBorderColor = System.Drawing.Color.White;
            this.bar.OnHoverButtonColor = System.Drawing.Color.Black;
            this.bar.OnHoverTextColor = System.Drawing.Color.White;
            this.bar.Size = new System.Drawing.Size(58, 45);
            this.bar.TabIndex = 41;
            this.bar.Text = "|x|";
            this.bar.TextColor = System.Drawing.Color.Black;
            this.bar.UseVisualStyleBackColor = true;
            this.bar.Click += new System.EventHandler(this.bar_Click);
            // 
            // denote
            // 
            this.denote.BorderColor = System.Drawing.Color.Black;
            this.denote.ButtonColor = System.Drawing.Color.Silver;
            this.denote.FlatAppearance.BorderSize = 0;
            this.denote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.denote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.denote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denote.Location = new System.Drawing.Point(124, 8);
            this.denote.Name = "denote";
            this.denote.OnHoverBorderColor = System.Drawing.Color.White;
            this.denote.OnHoverButtonColor = System.Drawing.Color.Black;
            this.denote.OnHoverTextColor = System.Drawing.Color.White;
            this.denote.Size = new System.Drawing.Size(58, 45);
            this.denote.TabIndex = 46;
            this.denote.Text = "(-)";
            this.denote.TextColor = System.Drawing.Color.Black;
            this.denote.UseVisualStyleBackColor = true;
            this.denote.Click += new System.EventHandler(this.denote_Click);
            // 
            // shift
            // 
            this.shift.BorderColor = System.Drawing.Color.Black;
            this.shift.ButtonColor = System.Drawing.Color.Orange;
            this.shift.FlatAppearance.BorderSize = 0;
            this.shift.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.shift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shift.Location = new System.Drawing.Point(3, 3);
            this.shift.Name = "shift";
            this.shift.OnHoverBorderColor = System.Drawing.Color.White;
            this.shift.OnHoverButtonColor = System.Drawing.Color.Black;
            this.shift.OnHoverTextColor = System.Drawing.Color.White;
            this.shift.Size = new System.Drawing.Size(58, 45);
            this.shift.TabIndex = 68;
            this.shift.Text = "Shift";
            this.shift.TextColor = System.Drawing.Color.White;
            this.shift.UseVisualStyleBackColor = true;
            this.shift.Click += new System.EventHandler(this.shift_Click);
            // 
            // log
            // 
            this.log.BorderColor = System.Drawing.Color.Black;
            this.log.ButtonColor = System.Drawing.Color.White;
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(376, 3);
            this.log.Name = "log";
            this.log.OnHoverBorderColor = System.Drawing.Color.White;
            this.log.OnHoverButtonColor = System.Drawing.Color.Black;
            this.log.OnHoverTextColor = System.Drawing.Color.White;
            this.log.Size = new System.Drawing.Size(58, 45);
            this.log.TabIndex = 72;
            this.log.Text = "log";
            this.log.TextColor = System.Drawing.Color.Black;
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // sqrt
            // 
            this.sqrt.BorderColor = System.Drawing.Color.Black;
            this.sqrt.ButtonColor = System.Drawing.Color.Silver;
            this.sqrt.FlatAppearance.BorderSize = 0;
            this.sqrt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sqrt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.Image = ((System.Drawing.Image)(resources.GetObject("sqrt.Image")));
            this.sqrt.Location = new System.Drawing.Point(372, 135);
            this.sqrt.Name = "sqrt";
            this.sqrt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sqrt.OnHoverButtonColor = System.Drawing.Color.White;
            this.sqrt.OnHoverTextColor = System.Drawing.Color.White;
            this.sqrt.Size = new System.Drawing.Size(58, 45);
            this.sqrt.TabIndex = 51;
            this.sqrt.TextColor = System.Drawing.Color.Black;
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // tan_tani
            // 
            this.tan_tani.BorderColor = System.Drawing.Color.Black;
            this.tan_tani.ButtonColor = System.Drawing.Color.White;
            this.tan_tani.FlatAppearance.BorderSize = 0;
            this.tan_tani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tan_tani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.tan_tani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tan_tani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tan_tani.Location = new System.Drawing.Point(285, 3);
            this.tan_tani.Name = "tan_tani";
            this.tan_tani.OnHoverBorderColor = System.Drawing.Color.White;
            this.tan_tani.OnHoverButtonColor = System.Drawing.Color.Black;
            this.tan_tani.OnHoverTextColor = System.Drawing.Color.White;
            this.tan_tani.Size = new System.Drawing.Size(58, 45);
            this.tan_tani.TabIndex = 71;
            this.tan_tani.Text = "tan";
            this.tan_tani.TextColor = System.Drawing.Color.Black;
            this.tan_tani.UseVisualStyleBackColor = true;
            this.tan_tani.Click += new System.EventHandler(this.tan_tani_Click);
            // 
            // pi
            // 
            this.pi.BorderColor = System.Drawing.Color.Black;
            this.pi.ButtonColor = System.Drawing.Color.Silver;
            this.pi.FlatAppearance.BorderSize = 0;
            this.pi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.pi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.pi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi.Image = ((System.Drawing.Image)(resources.GetObject("pi.Image")));
            this.pi.Location = new System.Drawing.Point(282, 135);
            this.pi.Name = "pi";
            this.pi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.pi.OnHoverButtonColor = System.Drawing.Color.White;
            this.pi.OnHoverTextColor = System.Drawing.Color.White;
            this.pi.Size = new System.Drawing.Size(58, 45);
            this.pi.TabIndex = 56;
            this.pi.TextColor = System.Drawing.Color.Black;
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // cos_cosi
            // 
            this.cos_cosi.BorderColor = System.Drawing.Color.Black;
            this.cos_cosi.ButtonColor = System.Drawing.Color.White;
            this.cos_cosi.FlatAppearance.BorderSize = 0;
            this.cos_cosi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cos_cosi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cos_cosi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cos_cosi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos_cosi.Location = new System.Drawing.Point(188, 3);
            this.cos_cosi.Name = "cos_cosi";
            this.cos_cosi.OnHoverBorderColor = System.Drawing.Color.White;
            this.cos_cosi.OnHoverButtonColor = System.Drawing.Color.Black;
            this.cos_cosi.OnHoverTextColor = System.Drawing.Color.White;
            this.cos_cosi.Size = new System.Drawing.Size(58, 45);
            this.cos_cosi.TabIndex = 70;
            this.cos_cosi.Text = "cos";
            this.cos_cosi.TextColor = System.Drawing.Color.Black;
            this.cos_cosi.UseVisualStyleBackColor = true;
            this.cos_cosi.Click += new System.EventHandler(this.cos_cosi_Click);
            // 
            // radian_degree
            // 
            this.radian_degree.BorderColor = System.Drawing.Color.Black;
            this.radian_degree.ButtonColor = System.Drawing.Color.Orange;
            this.radian_degree.FlatAppearance.BorderSize = 0;
            this.radian_degree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radian_degree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.radian_degree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radian_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radian_degree.Location = new System.Drawing.Point(3, 133);
            this.radian_degree.Name = "radian_degree";
            this.radian_degree.OnHoverBorderColor = System.Drawing.Color.White;
            this.radian_degree.OnHoverButtonColor = System.Drawing.Color.Black;
            this.radian_degree.OnHoverTextColor = System.Drawing.Color.White;
            this.radian_degree.Size = new System.Drawing.Size(58, 45);
            this.radian_degree.TabIndex = 58;
            this.radian_degree.Text = "Rad";
            this.radian_degree.TextColor = System.Drawing.Color.White;
            this.radian_degree.UseVisualStyleBackColor = true;
            this.radian_degree.Click += new System.EventHandler(this.radian_degree_Click);
            // 
            // sin_sini
            // 
            this.sin_sini.BorderColor = System.Drawing.Color.Black;
            this.sin_sini.ButtonColor = System.Drawing.Color.White;
            this.sin_sini.FlatAppearance.BorderSize = 0;
            this.sin_sini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sin_sini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sin_sini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sin_sini.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sin_sini.Location = new System.Drawing.Point(94, 3);
            this.sin_sini.Name = "sin_sini";
            this.sin_sini.OnHoverBorderColor = System.Drawing.Color.White;
            this.sin_sini.OnHoverButtonColor = System.Drawing.Color.Black;
            this.sin_sini.OnHoverTextColor = System.Drawing.Color.White;
            this.sin_sini.Size = new System.Drawing.Size(58, 45);
            this.sin_sini.TabIndex = 69;
            this.sin_sini.Text = "sin";
            this.sin_sini.TextColor = System.Drawing.Color.Black;
            this.sin_sini.UseVisualStyleBackColor = true;
            this.sin_sini.Click += new System.EventHandler(this.sin_sini_Click);
            // 
            // fraction
            // 
            this.fraction.BorderColor = System.Drawing.Color.Black;
            this.fraction.ButtonColor = System.Drawing.Color.White;
            this.fraction.FlatAppearance.BorderSize = 0;
            this.fraction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.fraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.fraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fraction.Location = new System.Drawing.Point(94, 135);
            this.fraction.Name = "fraction";
            this.fraction.OnHoverBorderColor = System.Drawing.Color.White;
            this.fraction.OnHoverButtonColor = System.Drawing.Color.Black;
            this.fraction.OnHoverTextColor = System.Drawing.Color.White;
            this.fraction.Size = new System.Drawing.Size(58, 45);
            this.fraction.TabIndex = 59;
            this.fraction.Text = "1/x";
            this.fraction.TextColor = System.Drawing.Color.Black;
            this.fraction.UseVisualStyleBackColor = true;
            this.fraction.Click += new System.EventHandler(this.fraction_Click);
            // 
            // factorial
            // 
            this.factorial.BorderColor = System.Drawing.Color.Black;
            this.factorial.ButtonColor = System.Drawing.Color.White;
            this.factorial.FlatAppearance.BorderSize = 0;
            this.factorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.factorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.Location = new System.Drawing.Point(188, 133);
            this.factorial.Name = "factorial";
            this.factorial.OnHoverBorderColor = System.Drawing.Color.White;
            this.factorial.OnHoverButtonColor = System.Drawing.Color.Black;
            this.factorial.OnHoverTextColor = System.Drawing.Color.White;
            this.factorial.Size = new System.Drawing.Size(58, 45);
            this.factorial.TabIndex = 60;
            this.factorial.Text = "x!";
            this.factorial.TextColor = System.Drawing.Color.Black;
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // lognatural_base
            // 
            this.lognatural_base.BorderColor = System.Drawing.Color.Black;
            this.lognatural_base.ButtonColor = System.Drawing.Color.White;
            this.lognatural_base.FlatAppearance.BorderSize = 0;
            this.lognatural_base.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.lognatural_base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lognatural_base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lognatural_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lognatural_base.Location = new System.Drawing.Point(376, 69);
            this.lognatural_base.Name = "lognatural_base";
            this.lognatural_base.OnHoverBorderColor = System.Drawing.Color.White;
            this.lognatural_base.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lognatural_base.OnHoverTextColor = System.Drawing.Color.White;
            this.lognatural_base.Size = new System.Drawing.Size(58, 45);
            this.lognatural_base.TabIndex = 67;
            this.lognatural_base.Text = "ln";
            this.lognatural_base.TextColor = System.Drawing.Color.Black;
            this.lognatural_base.UseVisualStyleBackColor = true;
            this.lognatural_base.Click += new System.EventHandler(this.lognatural_base_Click);
            // 
            // square
            // 
            this.square.BorderColor = System.Drawing.Color.Black;
            this.square.ButtonColor = System.Drawing.Color.White;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square.Location = new System.Drawing.Point(3, 68);
            this.square.Name = "square";
            this.square.OnHoverBorderColor = System.Drawing.Color.White;
            this.square.OnHoverButtonColor = System.Drawing.Color.Black;
            this.square.OnHoverTextColor = System.Drawing.Color.White;
            this.square.Size = new System.Drawing.Size(58, 45);
            this.square.TabIndex = 63;
            this.square.Text = "X^2 ";
            this.square.TextColor = System.Drawing.Color.Black;
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // exponent
            // 
            this.exponent.BorderColor = System.Drawing.Color.Black;
            this.exponent.ButtonColor = System.Drawing.Color.White;
            this.exponent.FlatAppearance.BorderSize = 0;
            this.exponent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exponent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponent.Location = new System.Drawing.Point(285, 69);
            this.exponent.Name = "exponent";
            this.exponent.OnHoverBorderColor = System.Drawing.Color.White;
            this.exponent.OnHoverButtonColor = System.Drawing.Color.Black;
            this.exponent.OnHoverTextColor = System.Drawing.Color.White;
            this.exponent.Size = new System.Drawing.Size(58, 45);
            this.exponent.TabIndex = 66;
            this.exponent.Text = "e^x";
            this.exponent.TextColor = System.Drawing.Color.Black;
            this.exponent.UseVisualStyleBackColor = true;
            this.exponent.Click += new System.EventHandler(this.exponent_Click);
            // 
            // cube
            // 
            this.cube.BorderColor = System.Drawing.Color.Black;
            this.cube.ButtonColor = System.Drawing.Color.White;
            this.cube.FlatAppearance.BorderSize = 0;
            this.cube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cube.Location = new System.Drawing.Point(97, 69);
            this.cube.Name = "cube";
            this.cube.OnHoverBorderColor = System.Drawing.Color.White;
            this.cube.OnHoverButtonColor = System.Drawing.Color.Black;
            this.cube.OnHoverTextColor = System.Drawing.Color.White;
            this.cube.Size = new System.Drawing.Size(58, 45);
            this.cube.TabIndex = 64;
            this.cube.Text = "X^3";
            this.cube.TextColor = System.Drawing.Color.Black;
            this.cube.UseVisualStyleBackColor = true;
            this.cube.Click += new System.EventHandler(this.cube_Click);
            // 
            // power
            // 
            this.power.BorderColor = System.Drawing.Color.Black;
            this.power.ButtonColor = System.Drawing.Color.White;
            this.power.FlatAppearance.BorderSize = 0;
            this.power.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.power.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(191, 68);
            this.power.Name = "power";
            this.power.OnHoverBorderColor = System.Drawing.Color.White;
            this.power.OnHoverButtonColor = System.Drawing.Color.Black;
            this.power.OnHoverTextColor = System.Drawing.Color.White;
            this.power.Size = new System.Drawing.Size(58, 45);
            this.power.TabIndex = 65;
            this.power.Text = "X^Y";
            this.power.TextColor = System.Drawing.Color.Black;
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // Tax
            // 
            this.Tax.BorderColor = System.Drawing.Color.Black;
            this.Tax.ButtonColor = System.Drawing.Color.Orange;
            this.Tax.FlatAppearance.BorderSize = 0;
            this.Tax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Tax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Tax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.Location = new System.Drawing.Point(294, 585);
            this.Tax.Name = "Tax";
            this.Tax.OnHoverBorderColor = System.Drawing.Color.White;
            this.Tax.OnHoverButtonColor = System.Drawing.Color.Black;
            this.Tax.OnHoverTextColor = System.Drawing.Color.White;
            this.Tax.Size = new System.Drawing.Size(152, 45);
            this.Tax.TabIndex = 61;
            this.Tax.Text = "Tax";
            this.Tax.TextColor = System.Drawing.Color.White;
            this.Tax.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.BorderColor = System.Drawing.Color.Black;
            this.remove.ButtonColor = System.Drawing.Color.Red;
            this.remove.FlatAppearance.BorderSize = 0;
            this.remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Image = ((System.Drawing.Image)(resources.GetObject("remove.Image")));
            this.remove.Location = new System.Drawing.Point(388, 390);
            this.remove.Name = "remove";
            this.remove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.remove.OnHoverButtonColor = System.Drawing.Color.White;
            this.remove.OnHoverTextColor = System.Drawing.Color.White;
            this.remove.Size = new System.Drawing.Size(58, 45);
            this.remove.TabIndex = 57;
            this.remove.TextColor = System.Drawing.Color.Black;
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // multiply
            // 
            this.multiply.BorderColor = System.Drawing.Color.Black;
            this.multiply.ButtonColor = System.Drawing.Color.Silver;
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.multiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(297, 459);
            this.multiply.Name = "multiply";
            this.multiply.OnHoverBorderColor = System.Drawing.Color.White;
            this.multiply.OnHoverButtonColor = System.Drawing.Color.Black;
            this.multiply.OnHoverTextColor = System.Drawing.Color.White;
            this.multiply.Size = new System.Drawing.Size(58, 45);
            this.multiply.TabIndex = 55;
            this.multiply.Text = "x";
            this.multiply.TextColor = System.Drawing.Color.Black;
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.BorderColor = System.Drawing.Color.Black;
            this.divide.ButtonColor = System.Drawing.Color.Silver;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.divide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(294, 389);
            this.divide.Name = "divide";
            this.divide.OnHoverBorderColor = System.Drawing.Color.White;
            this.divide.OnHoverButtonColor = System.Drawing.Color.Black;
            this.divide.OnHoverTextColor = System.Drawing.Color.White;
            this.divide.Size = new System.Drawing.Size(58, 45);
            this.divide.TabIndex = 54;
            this.divide.Text = "/";
            this.divide.TextColor = System.Drawing.Color.Black;
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // clear
            // 
            this.clear.BorderColor = System.Drawing.Color.Black;
            this.clear.ButtonColor = System.Drawing.Color.Orange;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(15, 390);
            this.clear.Name = "clear";
            this.clear.OnHoverBorderColor = System.Drawing.Color.White;
            this.clear.OnHoverButtonColor = System.Drawing.Color.Black;
            this.clear.OnHoverTextColor = System.Drawing.Color.White;
            this.clear.Size = new System.Drawing.Size(58, 45);
            this.clear.TabIndex = 53;
            this.clear.Text = "AC";
            this.clear.TextColor = System.Drawing.Color.White;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // mod
            // 
            this.mod.BorderColor = System.Drawing.Color.Black;
            this.mod.ButtonColor = System.Drawing.Color.Silver;
            this.mod.FlatAppearance.BorderSize = 0;
            this.mod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.mod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.Location = new System.Drawing.Point(391, 459);
            this.mod.Name = "mod";
            this.mod.OnHoverBorderColor = System.Drawing.Color.White;
            this.mod.OnHoverButtonColor = System.Drawing.Color.Black;
            this.mod.OnHoverTextColor = System.Drawing.Color.White;
            this.mod.Size = new System.Drawing.Size(58, 45);
            this.mod.TabIndex = 52;
            this.mod.Text = "%";
            this.mod.TextColor = System.Drawing.Color.Black;
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // nine
            // 
            this.nine.BorderColor = System.Drawing.Color.Black;
            this.nine.ButtonColor = System.Drawing.Color.White;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.nine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(203, 459);
            this.nine.Name = "nine";
            this.nine.OnHoverBorderColor = System.Drawing.Color.White;
            this.nine.OnHoverButtonColor = System.Drawing.Color.Black;
            this.nine.OnHoverTextColor = System.Drawing.Color.White;
            this.nine.Size = new System.Drawing.Size(58, 45);
            this.nine.TabIndex = 50;
            this.nine.Text = "9";
            this.nine.TextColor = System.Drawing.Color.Black;
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BorderColor = System.Drawing.Color.Black;
            this.eight.ButtonColor = System.Drawing.Color.White;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.eight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(109, 459);
            this.eight.Name = "eight";
            this.eight.OnHoverBorderColor = System.Drawing.Color.White;
            this.eight.OnHoverButtonColor = System.Drawing.Color.Black;
            this.eight.OnHoverTextColor = System.Drawing.Color.White;
            this.eight.Size = new System.Drawing.Size(58, 45);
            this.eight.TabIndex = 49;
            this.eight.Text = "8";
            this.eight.TextColor = System.Drawing.Color.Black;
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BorderColor = System.Drawing.Color.Black;
            this.seven.ButtonColor = System.Drawing.Color.White;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.seven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(15, 459);
            this.seven.Name = "seven";
            this.seven.OnHoverBorderColor = System.Drawing.Color.White;
            this.seven.OnHoverButtonColor = System.Drawing.Color.Black;
            this.seven.OnHoverTextColor = System.Drawing.Color.White;
            this.seven.Size = new System.Drawing.Size(58, 45);
            this.seven.TabIndex = 48;
            this.seven.Text = "7";
            this.seven.TextColor = System.Drawing.Color.Black;
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // minus
            // 
            this.minus.BorderColor = System.Drawing.Color.Black;
            this.minus.ButtonColor = System.Drawing.Color.Silver;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(297, 525);
            this.minus.Name = "minus";
            this.minus.OnHoverBorderColor = System.Drawing.Color.White;
            this.minus.OnHoverButtonColor = System.Drawing.Color.Black;
            this.minus.OnHoverTextColor = System.Drawing.Color.White;
            this.minus.Size = new System.Drawing.Size(58, 45);
            this.minus.TabIndex = 47;
            this.minus.Text = "-";
            this.minus.TextColor = System.Drawing.Color.Black;
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // six
            // 
            this.six.BorderColor = System.Drawing.Color.Black;
            this.six.ButtonColor = System.Drawing.Color.White;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.six.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(200, 525);
            this.six.Name = "six";
            this.six.OnHoverBorderColor = System.Drawing.Color.White;
            this.six.OnHoverButtonColor = System.Drawing.Color.Black;
            this.six.OnHoverTextColor = System.Drawing.Color.White;
            this.six.Size = new System.Drawing.Size(58, 45);
            this.six.TabIndex = 45;
            this.six.Text = "6";
            this.six.TextColor = System.Drawing.Color.Black;
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BorderColor = System.Drawing.Color.Black;
            this.five.ButtonColor = System.Drawing.Color.White;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.five.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(106, 525);
            this.five.Name = "five";
            this.five.OnHoverBorderColor = System.Drawing.Color.White;
            this.five.OnHoverButtonColor = System.Drawing.Color.Black;
            this.five.OnHoverTextColor = System.Drawing.Color.White;
            this.five.Size = new System.Drawing.Size(58, 45);
            this.five.TabIndex = 44;
            this.five.Text = "5";
            this.five.TextColor = System.Drawing.Color.Black;
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.BorderColor = System.Drawing.Color.Black;
            this.four.ButtonColor = System.Drawing.Color.White;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.four.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 525);
            this.four.Name = "four";
            this.four.OnHoverBorderColor = System.Drawing.Color.White;
            this.four.OnHoverButtonColor = System.Drawing.Color.Black;
            this.four.OnHoverTextColor = System.Drawing.Color.White;
            this.four.Size = new System.Drawing.Size(58, 45);
            this.four.TabIndex = 43;
            this.four.Text = "4";
            this.four.TextColor = System.Drawing.Color.Black;
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // plus
            // 
            this.plus.BorderColor = System.Drawing.Color.Black;
            this.plus.ButtonColor = System.Drawing.Color.Silver;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(388, 525);
            this.plus.Name = "plus";
            this.plus.OnHoverBorderColor = System.Drawing.Color.White;
            this.plus.OnHoverButtonColor = System.Drawing.Color.Black;
            this.plus.OnHoverTextColor = System.Drawing.Color.White;
            this.plus.Size = new System.Drawing.Size(58, 45);
            this.plus.TabIndex = 42;
            this.plus.Text = "+";
            this.plus.TextColor = System.Drawing.Color.Black;
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // three
            // 
            this.three.BorderColor = System.Drawing.Color.Black;
            this.three.ButtonColor = System.Drawing.Color.White;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.three.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(200, 585);
            this.three.Name = "three";
            this.three.OnHoverBorderColor = System.Drawing.Color.White;
            this.three.OnHoverButtonColor = System.Drawing.Color.Black;
            this.three.OnHoverTextColor = System.Drawing.Color.White;
            this.three.Size = new System.Drawing.Size(58, 45);
            this.three.TabIndex = 40;
            this.three.Text = "3";
            this.three.TextColor = System.Drawing.Color.Black;
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BorderColor = System.Drawing.Color.Black;
            this.two.ButtonColor = System.Drawing.Color.White;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.two.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(106, 585);
            this.two.Name = "two";
            this.two.OnHoverBorderColor = System.Drawing.Color.White;
            this.two.OnHoverButtonColor = System.Drawing.Color.Black;
            this.two.OnHoverTextColor = System.Drawing.Color.White;
            this.two.Size = new System.Drawing.Size(58, 45);
            this.two.TabIndex = 39;
            this.two.Text = "2";
            this.two.TextColor = System.Drawing.Color.Black;
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BorderColor = System.Drawing.Color.Black;
            this.one.ButtonColor = System.Drawing.Color.White;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.one.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 585);
            this.one.Name = "one";
            this.one.OnHoverBorderColor = System.Drawing.Color.White;
            this.one.OnHoverButtonColor = System.Drawing.Color.Black;
            this.one.OnHoverTextColor = System.Drawing.Color.White;
            this.one.Size = new System.Drawing.Size(58, 45);
            this.one.TabIndex = 38;
            this.one.Text = "1";
            this.one.TextColor = System.Drawing.Color.Black;
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // equal
            // 
            this.equal.BorderColor = System.Drawing.Color.Black;
            this.equal.ButtonColor = System.Drawing.Color.SkyBlue;
            this.equal.FlatAppearance.BorderSize = 0;
            this.equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(388, 650);
            this.equal.Name = "equal";
            this.equal.OnHoverBorderColor = System.Drawing.Color.White;
            this.equal.OnHoverButtonColor = System.Drawing.Color.Black;
            this.equal.OnHoverTextColor = System.Drawing.Color.White;
            this.equal.Size = new System.Drawing.Size(58, 45);
            this.equal.TabIndex = 37;
            this.equal.Text = "=";
            this.equal.TextColor = System.Drawing.Color.Black;
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // ans
            // 
            this.ans.BorderColor = System.Drawing.Color.Black;
            this.ans.ButtonColor = System.Drawing.Color.Silver;
            this.ans.FlatAppearance.BorderSize = 0;
            this.ans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(294, 650);
            this.ans.Name = "ans";
            this.ans.OnHoverBorderColor = System.Drawing.Color.White;
            this.ans.OnHoverButtonColor = System.Drawing.Color.Black;
            this.ans.OnHoverTextColor = System.Drawing.Color.White;
            this.ans.Size = new System.Drawing.Size(58, 45);
            this.ans.TabIndex = 29;
            this.ans.Text = "Ans";
            this.ans.TextColor = System.Drawing.Color.Black;
            this.ans.UseVisualStyleBackColor = true;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // braces
            // 
            this.braces.BorderColor = System.Drawing.Color.Black;
            this.braces.ButtonColor = System.Drawing.Color.Silver;
            this.braces.FlatAppearance.BorderSize = 0;
            this.braces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.braces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.braces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.braces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braces.Location = new System.Drawing.Point(200, 650);
            this.braces.Name = "braces";
            this.braces.OnHoverBorderColor = System.Drawing.Color.White;
            this.braces.OnHoverButtonColor = System.Drawing.Color.Black;
            this.braces.OnHoverTextColor = System.Drawing.Color.White;
            this.braces.Size = new System.Drawing.Size(58, 45);
            this.braces.TabIndex = 21;
            this.braces.Text = "()";
            this.braces.TextColor = System.Drawing.Color.Black;
            this.braces.UseVisualStyleBackColor = true;
            this.braces.Click += new System.EventHandler(this.braces_Click);
            // 
            // dec
            // 
            this.dec.BorderColor = System.Drawing.Color.Black;
            this.dec.ButtonColor = System.Drawing.Color.White;
            this.dec.FlatAppearance.BorderSize = 0;
            this.dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(106, 650);
            this.dec.Name = "dec";
            this.dec.OnHoverBorderColor = System.Drawing.Color.White;
            this.dec.OnHoverButtonColor = System.Drawing.Color.Black;
            this.dec.OnHoverTextColor = System.Drawing.Color.White;
            this.dec.Size = new System.Drawing.Size(58, 45);
            this.dec.TabIndex = 13;
            this.dec.Text = ".";
            this.dec.TextColor = System.Drawing.Color.Black;
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // zero
            // 
            this.zero.BorderColor = System.Drawing.Color.Black;
            this.zero.ButtonColor = System.Drawing.Color.White;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 650);
            this.zero.Name = "zero";
            this.zero.OnHoverBorderColor = System.Drawing.Color.White;
            this.zero.OnHoverButtonColor = System.Drawing.Color.Black;
            this.zero.OnHoverTextColor = System.Drawing.Color.White;
            this.zero.Size = new System.Drawing.Size(58, 45);
            this.zero.TabIndex = 5;
            this.zero.Text = "0";
            this.zero.TextColor = System.Drawing.Color.Black;
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 705);
            this.Controls.Add(this.scientificOptions2);
            this.Controls.Add(this.scientificOptions1);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.braces);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.scientificOptions1.ResumeLayout(false);
            this.Display.Panel1.ResumeLayout(false);
            this.Display.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.Display.ResumeLayout(false);
            this.scientificOptions2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundButton braces;
        private RoundButton ans;
        private RoundButton equal;
        private RoundButton plus;
        private RoundButton bar;
        private RoundButton three;
        private RoundButton minus;
        private RoundButton denote;
        private RoundButton six;
        private RoundButton mod;
        private RoundButton nine;
        private RoundButton remove;
        private RoundButton multiply;
        private RoundButton zero;
        private RoundButton dec;
        private RoundButton one;
        private RoundButton two;
        private RoundButton four;
        private RoundButton five;
        private RoundButton seven;
        private RoundButton eight;
        private RoundButton clear;
        private RoundButton divide;
        private RoundButton Tax;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxCalculatorToolStripMenuItem;
        private System.Windows.Forms.Panel scientificOptions1;
        private RoundButton shift;
        private RoundButton log;
        private RoundButton sqrt;
        private RoundButton tan_tani;
        private RoundButton pi;
        private RoundButton cos_cosi;
        private RoundButton radian_degree;
        private RoundButton sin_sini;
        private RoundButton fraction;
        private RoundButton factorial;
        private RoundButton lognatural_base;
        private RoundButton square;
        private RoundButton exponent;
        private RoundButton cube;
        private RoundButton power;
        private System.Windows.Forms.RichTextBox OutDisplay;
        private System.Windows.Forms.RichTextBox InputDisplay;
        private System.Windows.Forms.SplitContainer Display;
        private System.Windows.Forms.Panel scientificOptions2;
        private System.Windows.Forms.ToolStripMenuItem basicCalculatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scientificCalculatorToolStripMenuItem;
    }
}