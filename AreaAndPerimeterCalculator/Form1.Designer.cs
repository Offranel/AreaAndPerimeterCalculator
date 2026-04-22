namespace AreaAndPerimeterCalculator
{
    partial class Form1
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
            txtLenght = new TextBox();
            txtWidth = new TextBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            lblLength = new Label();
            lblWidth = new Label();
            lblArea = new Label();
            lblPerimeter = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtLenght
            // 
            txtLenght.Location = new Point(207, 34);
            txtLenght.Name = "txtLenght";
            txtLenght.Size = new Size(250, 47);
            txtLenght.TabIndex = 0;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(207, 113);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(250, 47);
            txtWidth.TabIndex = 1;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(207, 186);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(250, 47);
            txtArea.TabIndex = 2;
            // 
            // txtPerimeter
            // 
            txtPerimeter.AcceptsTab = true;
            txtPerimeter.BorderStyle = BorderStyle.FixedSingle;
            txtPerimeter.Location = new Point(207, 261);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.ReadOnly = true;
            txtPerimeter.Size = new Size(250, 47);
            txtPerimeter.TabIndex = 3;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(77, 34);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(110, 41);
            lblLength.TabIndex = 4;
            lblLength.Text = "Length";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(77, 113);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(98, 41);
            lblWidth.TabIndex = 5;
            lblWidth.Text = "Width";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(77, 186);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(78, 41);
            lblArea.TabIndex = 6;
            lblArea.Text = "Area";
            // 
            // lblPerimeter
            // 
            lblPerimeter.AutoSize = true;
            lblPerimeter.Location = new Point(30, 264);
            lblPerimeter.Name = "lblPerimeter";
            lblPerimeter.Size = new Size(145, 41);
            lblPerimeter.TabIndex = 7;
            lblPerimeter.Text = "Perimeter";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.Control;
            btnCalculate.FlatAppearance.BorderColor = Color.Blue;
            btnCalculate.FlatAppearance.BorderSize = 3;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Location = new Point(94, 393);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(325, 162);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Area and Perimeter";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 628);
            Controls.Add(btnCalculate);
            Controls.Add(lblPerimeter);
            Controls.Add(lblArea);
            Controls.Add(lblWidth);
            Controls.Add(lblLength);
            Controls.Add(txtPerimeter);
            Controls.Add(txtArea);
            Controls.Add(txtWidth);
            Controls.Add(txtLenght);
            Name = "Form1";
            Text = "Area and Perimeter...";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtLenght;
        private TextBox txtWidth;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Label lblLength;
        private Label lblWidth;
        private Label lblArea;
        private Label lblPerimeter;
        private Button btnCalculate;
    }
}
