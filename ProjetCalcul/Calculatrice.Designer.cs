namespace ProjetCalcul
{
    partial class Calculatrice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBox = new TextBox();
            suppBtn = new Button();
            unBtn = new Button();
            quatreBtn = new Button();
            setBtn = new Button();
            neufBtn = new Button();
            cinqBtn = new Button();
            troixBtn = new Button();
            resteBtn = new Button();
            multiBtn = new Button();
            moinsBtn = new Button();
            plusBtn = new Button();
            diviBtn = new Button();
            witeBtn = new Button();
            sixBtn = new Button();
            deuxBtn = new Button();
            arriereBtn = new Button();
            zeroBtn = new Button();
            equaleBtn = new Button();
            dotBtn = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.BackColor = SystemColors.InfoText;
            txtBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBox.ForeColor = SystemColors.Window;
            txtBox.Location = new Point(128, 40);
            txtBox.Name = "txtBox";
            txtBox.ReadOnly = true;
            txtBox.Size = new Size(471, 43);
            txtBox.TabIndex = 0;
            txtBox.Text = "0";
            txtBox.TextAlign = HorizontalAlignment.Right;
            txtBox.UseWaitCursor = true;
            txtBox.TextChanged += textBox1_TextChanged;
            // 
            // suppBtn
            // 
            suppBtn.BackColor = Color.FromArgb(64, 64, 64);
            suppBtn.FlatAppearance.BorderSize = 0;
            suppBtn.FlatStyle = FlatStyle.Flat;
            suppBtn.Font = new Font("Segoe UI", 20F);
            suppBtn.Location = new Point(128, 105);
            suppBtn.Name = "suppBtn";
            suppBtn.Size = new Size(95, 45);
            suppBtn.TabIndex = 1;
            suppBtn.Text = "AC";
            suppBtn.UseVisualStyleBackColor = false;
            suppBtn.UseWaitCursor = true;
            suppBtn.Click += suppBtn_Click;
            // 
            // unBtn
            // 
            unBtn.BackColor = SystemColors.AppWorkspace;
            unBtn.FlatAppearance.BorderSize = 0;
            unBtn.FlatStyle = FlatStyle.Flat;
            unBtn.Font = new Font("Segoe UI", 20F);
            unBtn.ForeColor = SystemColors.ControlLightLight;
            unBtn.Location = new Point(128, 301);
            unBtn.Name = "unBtn";
            unBtn.Size = new Size(95, 45);
            unBtn.TabIndex = 2;
            unBtn.Text = "1";
            unBtn.UseVisualStyleBackColor = false;
            unBtn.UseWaitCursor = true;
            unBtn.Click += button2_Click;
            // 
            // quatreBtn
            // 
            quatreBtn.BackColor = SystemColors.AppWorkspace;
            quatreBtn.FlatAppearance.BorderSize = 0;
            quatreBtn.FlatStyle = FlatStyle.Flat;
            quatreBtn.Font = new Font("Segoe UI", 20F);
            quatreBtn.ForeColor = SystemColors.ControlLightLight;
            quatreBtn.Location = new Point(128, 235);
            quatreBtn.Name = "quatreBtn";
            quatreBtn.Size = new Size(95, 45);
            quatreBtn.TabIndex = 3;
            quatreBtn.Text = "4";
            quatreBtn.UseVisualStyleBackColor = false;
            quatreBtn.UseWaitCursor = true;
            quatreBtn.Click += quatreBtn_Click;
            // 
            // setBtn
            // 
            setBtn.BackColor = SystemColors.AppWorkspace;
            setBtn.FlatAppearance.BorderSize = 0;
            setBtn.FlatStyle = FlatStyle.Flat;
            setBtn.Font = new Font("Segoe UI", 20F);
            setBtn.ForeColor = SystemColors.ControlLightLight;
            setBtn.Location = new Point(128, 171);
            setBtn.Name = "setBtn";
            setBtn.Size = new Size(95, 45);
            setBtn.TabIndex = 4;
            setBtn.Text = "7";
            setBtn.UseVisualStyleBackColor = false;
            setBtn.UseWaitCursor = true;
            setBtn.Click += setBtn_Click;
            // 
            // neufBtn
            // 
            neufBtn.BackColor = SystemColors.AppWorkspace;
            neufBtn.FlatAppearance.BorderSize = 0;
            neufBtn.FlatStyle = FlatStyle.Flat;
            neufBtn.Font = new Font("Segoe UI", 20F);
            neufBtn.ForeColor = SystemColors.ControlLightLight;
            neufBtn.Location = new Point(379, 170);
            neufBtn.Name = "neufBtn";
            neufBtn.Size = new Size(95, 45);
            neufBtn.TabIndex = 8;
            neufBtn.Text = "9";
            neufBtn.UseVisualStyleBackColor = false;
            neufBtn.UseWaitCursor = true;
            neufBtn.Click += neufBtn_Click;
            // 
            // cinqBtn
            // 
            cinqBtn.BackColor = SystemColors.AppWorkspace;
            cinqBtn.FlatAppearance.BorderSize = 0;
            cinqBtn.FlatStyle = FlatStyle.Flat;
            cinqBtn.Font = new Font("Segoe UI", 20F);
            cinqBtn.ForeColor = SystemColors.ControlLightLight;
            cinqBtn.Location = new Point(259, 235);
            cinqBtn.Name = "cinqBtn";
            cinqBtn.Size = new Size(95, 45);
            cinqBtn.TabIndex = 7;
            cinqBtn.Text = "5";
            cinqBtn.UseVisualStyleBackColor = false;
            cinqBtn.UseWaitCursor = true;
            cinqBtn.Click += sixBtn_Click;
            // 
            // troixBtn
            // 
            troixBtn.BackColor = SystemColors.AppWorkspace;
            troixBtn.FlatAppearance.BorderSize = 0;
            troixBtn.FlatStyle = FlatStyle.Flat;
            troixBtn.Font = new Font("Segoe UI", 20F);
            troixBtn.ForeColor = SystemColors.ButtonHighlight;
            troixBtn.Location = new Point(379, 300);
            troixBtn.Name = "troixBtn";
            troixBtn.Size = new Size(95, 45);
            troixBtn.TabIndex = 6;
            troixBtn.Text = "3";
            troixBtn.UseVisualStyleBackColor = false;
            troixBtn.UseWaitCursor = true;
            troixBtn.Click += troixBtn_Click;
            // 
            // resteBtn
            // 
            resteBtn.BackColor = Color.FromArgb(64, 64, 64);
            resteBtn.FlatAppearance.BorderSize = 0;
            resteBtn.FlatStyle = FlatStyle.Flat;
            resteBtn.Font = new Font("Segoe UI", 20F);
            resteBtn.Location = new Point(379, 105);
            resteBtn.Name = "resteBtn";
            resteBtn.Size = new Size(95, 45);
            resteBtn.TabIndex = 5;
            resteBtn.Text = "%";
            resteBtn.UseVisualStyleBackColor = false;
            resteBtn.UseWaitCursor = true;
            resteBtn.Click += resteBtn_Click;
            // 
            // multiBtn
            // 
            multiBtn.BackColor = Color.FromArgb(255, 128, 0);
            multiBtn.FlatAppearance.BorderSize = 0;
            multiBtn.FlatStyle = FlatStyle.Flat;
            multiBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            multiBtn.ForeColor = SystemColors.ButtonHighlight;
            multiBtn.Location = new Point(504, 171);
            multiBtn.Name = "multiBtn";
            multiBtn.Size = new Size(95, 45);
            multiBtn.TabIndex = 12;
            multiBtn.Text = "X";
            multiBtn.UseVisualStyleBackColor = false;
            multiBtn.UseWaitCursor = true;
            multiBtn.Click += multiBtn_Click;
            // 
            // moinsBtn
            // 
            moinsBtn.BackColor = Color.FromArgb(255, 128, 0);
            moinsBtn.FlatAppearance.BorderSize = 0;
            moinsBtn.FlatStyle = FlatStyle.Flat;
            moinsBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            moinsBtn.ForeColor = SystemColors.ButtonHighlight;
            moinsBtn.Location = new Point(504, 235);
            moinsBtn.Name = "moinsBtn";
            moinsBtn.Size = new Size(95, 45);
            moinsBtn.TabIndex = 11;
            moinsBtn.Text = "-";
            moinsBtn.UseVisualStyleBackColor = false;
            moinsBtn.UseWaitCursor = true;
            moinsBtn.Click += moinsBtn_Click;
            // 
            // plusBtn
            // 
            plusBtn.BackColor = Color.FromArgb(255, 128, 0);
            plusBtn.FlatAppearance.BorderSize = 0;
            plusBtn.FlatStyle = FlatStyle.Flat;
            plusBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            plusBtn.ForeColor = SystemColors.ButtonHighlight;
            plusBtn.Location = new Point(504, 300);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(95, 45);
            plusBtn.TabIndex = 10;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = false;
            plusBtn.UseWaitCursor = true;
            plusBtn.Click += plusBtn_Click;
            // 
            // diviBtn
            // 
            diviBtn.BackColor = Color.FromArgb(255, 128, 0);
            diviBtn.FlatAppearance.BorderSize = 0;
            diviBtn.FlatStyle = FlatStyle.Flat;
            diviBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            diviBtn.ForeColor = SystemColors.ButtonHighlight;
            diviBtn.Location = new Point(504, 106);
            diviBtn.Name = "diviBtn";
            diviBtn.Size = new Size(95, 45);
            diviBtn.TabIndex = 9;
            diviBtn.Text = "/";
            diviBtn.UseVisualStyleBackColor = false;
            diviBtn.UseWaitCursor = true;
            diviBtn.Click += diviBtn_Click;
            // 
            // witeBtn
            // 
            witeBtn.BackColor = SystemColors.AppWorkspace;
            witeBtn.FlatAppearance.BorderSize = 0;
            witeBtn.FlatStyle = FlatStyle.Flat;
            witeBtn.Font = new Font("Segoe UI", 20F);
            witeBtn.ForeColor = SystemColors.ControlLightLight;
            witeBtn.Location = new Point(259, 171);
            witeBtn.Name = "witeBtn";
            witeBtn.Size = new Size(95, 45);
            witeBtn.TabIndex = 16;
            witeBtn.Text = "8";
            witeBtn.UseVisualStyleBackColor = false;
            witeBtn.UseWaitCursor = true;
            witeBtn.Click += witeBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = SystemColors.AppWorkspace;
            sixBtn.FlatAppearance.BorderSize = 0;
            sixBtn.FlatStyle = FlatStyle.Flat;
            sixBtn.Font = new Font("Segoe UI", 20F);
            sixBtn.ForeColor = SystemColors.ControlLightLight;
            sixBtn.Location = new Point(379, 235);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(95, 45);
            sixBtn.TabIndex = 15;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.UseWaitCursor = true;
            sixBtn.Click += cinqBtn_Click;
            // 
            // deuxBtn
            // 
            deuxBtn.BackColor = SystemColors.AppWorkspace;
            deuxBtn.FlatAppearance.BorderSize = 0;
            deuxBtn.FlatStyle = FlatStyle.Flat;
            deuxBtn.Font = new Font("Segoe UI", 20F);
            deuxBtn.ForeColor = SystemColors.ControlLightLight;
            deuxBtn.Location = new Point(259, 301);
            deuxBtn.Name = "deuxBtn";
            deuxBtn.Size = new Size(95, 45);
            deuxBtn.TabIndex = 14;
            deuxBtn.Text = "2";
            deuxBtn.UseVisualStyleBackColor = false;
            deuxBtn.UseWaitCursor = true;
            deuxBtn.Click += button15_Click;
            // 
            // arriereBtn
            // 
            arriereBtn.BackColor = Color.FromArgb(64, 64, 64);
            arriereBtn.FlatAppearance.BorderSize = 0;
            arriereBtn.FlatStyle = FlatStyle.Flat;
            arriereBtn.Font = new Font("Segoe UI", 20F);
            arriereBtn.Location = new Point(259, 106);
            arriereBtn.Name = "arriereBtn";
            arriereBtn.Size = new Size(95, 45);
            arriereBtn.TabIndex = 13;
            arriereBtn.Text = "+/-";
            arriereBtn.UseVisualStyleBackColor = false;
            arriereBtn.UseWaitCursor = true;
            arriereBtn.Click += arriereBtn_Click;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = SystemColors.ControlDark;
            zeroBtn.FlatAppearance.BorderSize = 0;
            zeroBtn.FlatStyle = FlatStyle.Flat;
            zeroBtn.Font = new Font("Segoe UI", 20F);
            zeroBtn.ForeColor = SystemColors.ControlLightLight;
            zeroBtn.Location = new Point(128, 363);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(226, 43);
            zeroBtn.TabIndex = 17;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.UseWaitCursor = true;
            zeroBtn.Click += button17_Click;
            // 
            // equaleBtn
            // 
            equaleBtn.BackColor = Color.FromArgb(255, 128, 0);
            equaleBtn.FlatAppearance.BorderSize = 0;
            equaleBtn.FlatStyle = FlatStyle.Flat;
            equaleBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            equaleBtn.ForeColor = SystemColors.ButtonHighlight;
            equaleBtn.Location = new Point(504, 361);
            equaleBtn.Name = "equaleBtn";
            equaleBtn.Size = new Size(95, 45);
            equaleBtn.TabIndex = 18;
            equaleBtn.Text = "=";
            equaleBtn.UseVisualStyleBackColor = false;
            equaleBtn.UseWaitCursor = true;
            equaleBtn.Click += equaleBtn_Click;
            // 
            // dotBtn
            // 
            dotBtn.BackColor = SystemColors.AppWorkspace;
            dotBtn.FlatAppearance.BorderSize = 0;
            dotBtn.FlatStyle = FlatStyle.Flat;
            dotBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            dotBtn.ForeColor = SystemColors.ButtonHighlight;
            dotBtn.Location = new Point(379, 361);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(95, 45);
            dotBtn.TabIndex = 19;
            dotBtn.Text = ",";
            dotBtn.UseVisualStyleBackColor = false;
            dotBtn.UseWaitCursor = true;
            dotBtn.Click += dotBtn_Click;
            // 
            // Calculatrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(dotBtn);
            Controls.Add(equaleBtn);
            Controls.Add(zeroBtn);
            Controls.Add(witeBtn);
            Controls.Add(sixBtn);
            Controls.Add(deuxBtn);
            Controls.Add(arriereBtn);
            Controls.Add(multiBtn);
            Controls.Add(moinsBtn);
            Controls.Add(plusBtn);
            Controls.Add(diviBtn);
            Controls.Add(neufBtn);
            Controls.Add(cinqBtn);
            Controls.Add(troixBtn);
            Controls.Add(resteBtn);
            Controls.Add(setBtn);
            Controls.Add(quatreBtn);
            Controls.Add(unBtn);
            Controls.Add(suppBtn);
            Controls.Add(txtBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculatrice";
            Opacity = 0.01D;
            Text = "Calculatrice";
            TransparencyKey = Color.White;
            UseWaitCursor = true;
            Load += Calculatrice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button suppBtn;
        private Button unBtn;
        private Button quatreBtn;
        private Button setBtn;
        private Button neufBtn;
        private Button cinqBtn;
        private Button troixBtn;
        private Button resteBtn;
        private Button multiBtn;
        private Button moinsBtn;
        private Button plusBtn;
        private Button diviBtn;
        private Button witeBtn;
        private Button sixBtn;
        private Button deuxBtn;
        private Button arriereBtn;
        private Button zeroBtn;
        private Button equaleBtn;
        private Button dotBtn;
    }
}
