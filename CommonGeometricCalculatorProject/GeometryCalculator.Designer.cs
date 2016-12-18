namespace CommonGeometricCalculatorProject
{
    partial class GeometryCalculator
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
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.rdoParallelogram = new System.Windows.Forms.RadioButton();
            this.rdoRhombus = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoTrapezoid = new System.Windows.Forms.RadioButton();
            this.rdoCirle = new System.Windows.Forms.RadioButton();
            this.rdoArea = new System.Windows.Forms.RadioButton();
            this.rdoPerimeter = new System.Windows.Forms.RadioButton();
            this.rdoAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInputOne = new System.Windows.Forms.TextBox();
            this.txtInputTwo = new System.Windows.Forms.TextBox();
            this.txtInputThree = new System.Windows.Forms.TextBox();
            this.txtInputFour = new System.Windows.Forms.TextBox();
            this.txtAreaCalculate = new System.Windows.Forms.TextBox();
            this.txtPerimeterCalculate = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rdoModulus = new System.Windows.Forms.RadioButton();
            this.rdoPercentage = new System.Windows.Forms.RadioButton();
            this.rdoPower = new System.Windows.Forms.RadioButton();
            this.txtInputCalculator = new System.Windows.Forms.TextBox();
            this.txtDisplayCalculatorInput = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCalculatorInput2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picCalculatorPicture = new System.Windows.Forms.PictureBox();
            this.pictureDisplay = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCalculatorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Location = new System.Drawing.Point(25, 29);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdoRectangle.TabIndex = 0;
            this.rdoRectangle.TabStop = true;
            this.rdoRectangle.Text = "Rectangle";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            this.rdoRectangle.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(25, 52);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(59, 17);
            this.rdoSquare.TabIndex = 1;
            this.rdoSquare.TabStop = true;
            this.rdoSquare.Text = "Square";
            this.rdoSquare.UseVisualStyleBackColor = true;
            this.rdoSquare.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoParallelogram
            // 
            this.rdoParallelogram.AutoSize = true;
            this.rdoParallelogram.Location = new System.Drawing.Point(25, 75);
            this.rdoParallelogram.Name = "rdoParallelogram";
            this.rdoParallelogram.Size = new System.Drawing.Size(88, 17);
            this.rdoParallelogram.TabIndex = 2;
            this.rdoParallelogram.TabStop = true;
            this.rdoParallelogram.Text = "Parallelogram";
            this.rdoParallelogram.UseVisualStyleBackColor = true;
            this.rdoParallelogram.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoRhombus
            // 
            this.rdoRhombus.AutoSize = true;
            this.rdoRhombus.Location = new System.Drawing.Point(25, 98);
            this.rdoRhombus.Name = "rdoRhombus";
            this.rdoRhombus.Size = new System.Drawing.Size(70, 17);
            this.rdoRhombus.TabIndex = 3;
            this.rdoRhombus.TabStop = true;
            this.rdoRhombus.Text = "Rhombus";
            this.rdoRhombus.UseVisualStyleBackColor = true;
            this.rdoRhombus.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Location = new System.Drawing.Point(25, 121);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(63, 17);
            this.rdoTriangle.TabIndex = 4;
            this.rdoTriangle.TabStop = true;
            this.rdoTriangle.Text = "Triangle";
            this.rdoTriangle.UseVisualStyleBackColor = true;
            this.rdoTriangle.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoTrapezoid
            // 
            this.rdoTrapezoid.AutoSize = true;
            this.rdoTrapezoid.Location = new System.Drawing.Point(25, 144);
            this.rdoTrapezoid.Name = "rdoTrapezoid";
            this.rdoTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.rdoTrapezoid.TabIndex = 5;
            this.rdoTrapezoid.TabStop = true;
            this.rdoTrapezoid.Text = "Trapezoid";
            this.rdoTrapezoid.UseVisualStyleBackColor = true;
            this.rdoTrapezoid.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoCirle
            // 
            this.rdoCirle.AutoSize = true;
            this.rdoCirle.Location = new System.Drawing.Point(25, 167);
            this.rdoCirle.Name = "rdoCirle";
            this.rdoCirle.Size = new System.Drawing.Size(51, 17);
            this.rdoCirle.TabIndex = 6;
            this.rdoCirle.TabStop = true;
            this.rdoCirle.Text = "Circle";
            this.rdoCirle.UseVisualStyleBackColor = true;
            this.rdoCirle.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoArea
            // 
            this.rdoArea.AutoSize = true;
            this.rdoArea.Location = new System.Drawing.Point(24, 11);
            this.rdoArea.Name = "rdoArea";
            this.rdoArea.Size = new System.Drawing.Size(47, 17);
            this.rdoArea.TabIndex = 0;
            this.rdoArea.TabStop = true;
            this.rdoArea.Text = "Area";
            this.rdoArea.UseVisualStyleBackColor = true;
            this.rdoArea.Click += new System.EventHandler(this.perimeterAndArea);
            // 
            // rdoPerimeter
            // 
            this.rdoPerimeter.AutoSize = true;
            this.rdoPerimeter.Location = new System.Drawing.Point(24, 37);
            this.rdoPerimeter.Name = "rdoPerimeter";
            this.rdoPerimeter.Size = new System.Drawing.Size(69, 17);
            this.rdoPerimeter.TabIndex = 1;
            this.rdoPerimeter.TabStop = true;
            this.rdoPerimeter.Text = "Perimeter";
            this.rdoPerimeter.UseVisualStyleBackColor = true;
            this.rdoPerimeter.Click += new System.EventHandler(this.perimeterAndArea);
            // 
            // rdoAreaPerimeter
            // 
            this.rdoAreaPerimeter.AutoSize = true;
            this.rdoAreaPerimeter.Location = new System.Drawing.Point(24, 63);
            this.rdoAreaPerimeter.Name = "rdoAreaPerimeter";
            this.rdoAreaPerimeter.Size = new System.Drawing.Size(115, 17);
            this.rdoAreaPerimeter.TabIndex = 2;
            this.rdoAreaPerimeter.TabStop = true;
            this.rdoAreaPerimeter.Text = "Area and Perimeter";
            this.rdoAreaPerimeter.UseVisualStyleBackColor = true;
            this.rdoAreaPerimeter.Click += new System.EventHandler(this.perimeterAndArea);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAreaPerimeter);
            this.groupBox1.Controls.Add(this.rdoPerimeter);
            this.groupBox1.Controls.Add(this.rdoArea);
            this.groupBox1.Location = new System.Drawing.Point(119, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // txtInputOne
            // 
            this.txtInputOne.Location = new System.Drawing.Point(80, 15);
            this.txtInputOne.Name = "txtInputOne";
            this.txtInputOne.Size = new System.Drawing.Size(93, 20);
            this.txtInputOne.TabIndex = 0;
            // 
            // txtInputTwo
            // 
            this.txtInputTwo.Location = new System.Drawing.Point(80, 37);
            this.txtInputTwo.Name = "txtInputTwo";
            this.txtInputTwo.Size = new System.Drawing.Size(93, 20);
            this.txtInputTwo.TabIndex = 1;
            // 
            // txtInputThree
            // 
            this.txtInputThree.Location = new System.Drawing.Point(80, 63);
            this.txtInputThree.Name = "txtInputThree";
            this.txtInputThree.Size = new System.Drawing.Size(93, 20);
            this.txtInputThree.TabIndex = 2;
            // 
            // txtInputFour
            // 
            this.txtInputFour.Location = new System.Drawing.Point(80, 87);
            this.txtInputFour.Name = "txtInputFour";
            this.txtInputFour.Size = new System.Drawing.Size(93, 20);
            this.txtInputFour.TabIndex = 3;
            // 
            // txtAreaCalculate
            // 
            this.txtAreaCalculate.Location = new System.Drawing.Point(80, 121);
            this.txtAreaCalculate.Name = "txtAreaCalculate";
            this.txtAreaCalculate.ReadOnly = true;
            this.txtAreaCalculate.Size = new System.Drawing.Size(93, 20);
            this.txtAreaCalculate.TabIndex = 4;
            // 
            // txtPerimeterCalculate
            // 
            this.txtPerimeterCalculate.Location = new System.Drawing.Point(80, 148);
            this.txtPerimeterCalculate.Name = "txtPerimeterCalculate";
            this.txtPerimeterCalculate.ReadOnly = true;
            this.txtPerimeterCalculate.Size = new System.Drawing.Size(93, 20);
            this.txtPerimeterCalculate.TabIndex = 5;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(28, 126);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(23, 151);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(51, 13);
            this.lblPerimeter.TabIndex = 6;
            this.lblPerimeter.Text = "Perimeter";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 28);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calcualate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPerimeterCalculate);
            this.groupBox2.Controls.Add(this.txtAreaCalculate);
            this.groupBox2.Controls.Add(this.txtInputFour);
            this.groupBox2.Controls.Add(this.txtInputThree);
            this.groupBox2.Controls.Add(this.txtInputTwo);
            this.groupBox2.Controls.Add(this.txtInputOne);
            this.groupBox2.Controls.Add(this.lblPerimeter);
            this.groupBox2.Controls.Add(this.lblArea);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(278, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 191);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // rtxtDisplay
            // 
            this.rtxtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDisplay.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtxtDisplay.Location = new System.Drawing.Point(478, 157);
            this.rtxtDisplay.Name = "rtxtDisplay";
            this.rtxtDisplay.ReadOnly = true;
            this.rtxtDisplay.Size = new System.Drawing.Size(143, 27);
            this.rtxtDisplay.TabIndex = 11;
            this.rtxtDisplay.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(287, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 27);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(166, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(21, 222);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(372, 30);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "Percentag, Modulus and Square Calculator";
            // 
            // rdoModulus
            // 
            this.rdoModulus.AutoSize = true;
            this.rdoModulus.Location = new System.Drawing.Point(10, 30);
            this.rdoModulus.Name = "rdoModulus";
            this.rdoModulus.Size = new System.Drawing.Size(65, 17);
            this.rdoModulus.TabIndex = 15;
            this.rdoModulus.TabStop = true;
            this.rdoModulus.Text = "Modulus";
            this.rdoModulus.UseVisualStyleBackColor = true;
            this.rdoModulus.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoPercentage
            // 
            this.rdoPercentage.AutoSize = true;
            this.rdoPercentage.Location = new System.Drawing.Point(10, 64);
            this.rdoPercentage.Name = "rdoPercentage";
            this.rdoPercentage.Size = new System.Drawing.Size(80, 17);
            this.rdoPercentage.TabIndex = 16;
            this.rdoPercentage.TabStop = true;
            this.rdoPercentage.Text = "Percentage";
            this.rdoPercentage.UseVisualStyleBackColor = true;
            this.rdoPercentage.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // rdoPower
            // 
            this.rdoPower.AutoSize = true;
            this.rdoPower.Location = new System.Drawing.Point(10, 96);
            this.rdoPower.Name = "rdoPower";
            this.rdoPower.Size = new System.Drawing.Size(89, 17);
            this.rdoPower.TabIndex = 17;
            this.rdoPower.TabStop = true;
            this.rdoPower.Text = "Square Value";
            this.rdoPower.UseVisualStyleBackColor = true;
            this.rdoPower.Click += new System.EventHandler(this.shapeOfObjects);
            // 
            // txtInputCalculator
            // 
            this.txtInputCalculator.Location = new System.Drawing.Point(71, 21);
            this.txtInputCalculator.Name = "txtInputCalculator";
            this.txtInputCalculator.Size = new System.Drawing.Size(111, 20);
            this.txtInputCalculator.TabIndex = 0;
            // 
            // txtDisplayCalculatorInput
            // 
            this.txtDisplayCalculatorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayCalculatorInput.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDisplayCalculatorInput.Location = new System.Drawing.Point(71, 88);
            this.txtDisplayCalculatorInput.Name = "txtDisplayCalculatorInput";
            this.txtDisplayCalculatorInput.ReadOnly = true;
            this.txtDisplayCalculatorInput.Size = new System.Drawing.Size(277, 29);
            this.txtDisplayCalculatorInput.TabIndex = 2;
            this.txtDisplayCalculatorInput.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoPower);
            this.groupBox3.Controls.Add(this.rdoPercentage);
            this.groupBox3.Controls.Add(this.rdoModulus);
            this.groupBox3.Location = new System.Drawing.Point(15, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 129);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // txtCalculatorInput2
            // 
            this.txtCalculatorInput2.Location = new System.Drawing.Point(72, 58);
            this.txtCalculatorInput2.Name = "txtCalculatorInput2";
            this.txtCalculatorInput2.Size = new System.Drawing.Size(109, 20);
            this.txtCalculatorInput2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Number1 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Number2:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtCalculatorInput2);
            this.groupBox4.Controls.Add(this.txtDisplayCalculatorInput);
            this.groupBox4.Controls.Add(this.txtInputCalculator);
            this.groupBox4.Location = new System.Drawing.Point(157, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 122);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // picCalculatorPicture
            // 
            this.picCalculatorPicture.Location = new System.Drawing.Point(495, 268);
            this.picCalculatorPicture.Name = "picCalculatorPicture";
            this.picCalculatorPicture.Size = new System.Drawing.Size(168, 114);
            this.picCalculatorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCalculatorPicture.TabIndex = 25;
            this.picCalculatorPicture.TabStop = false;
            // 
            // pictureDisplay
            // 
            this.pictureDisplay.Location = new System.Drawing.Point(495, 29);
            this.pictureDisplay.Name = "pictureDisplay";
            this.pictureDisplay.Size = new System.Drawing.Size(168, 118);
            this.pictureDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDisplay.TabIndex = 9;
            this.pictureDisplay.TabStop = false;
            // 
            // GeometryCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.picCalculatorPicture);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtxtDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdoCirle);
            this.Controls.Add(this.rdoTrapezoid);
            this.Controls.Add(this.rdoTriangle);
            this.Controls.Add(this.rdoRhombus);
            this.Controls.Add(this.rdoParallelogram);
            this.Controls.Add(this.rdoSquare);
            this.Controls.Add(this.rdoRectangle);
            this.Name = "GeometryCalculator";
            this.Text = "Common Geometry Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCalculatorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.RadioButton rdoParallelogram;
        private System.Windows.Forms.RadioButton rdoRhombus;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.RadioButton rdoTrapezoid;
        private System.Windows.Forms.RadioButton rdoCirle;
        private System.Windows.Forms.RadioButton rdoArea;
        private System.Windows.Forms.RadioButton rdoPerimeter;
        private System.Windows.Forms.RadioButton rdoAreaPerimeter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInputOne;
        private System.Windows.Forms.TextBox txtInputTwo;
        private System.Windows.Forms.TextBox txtInputThree;
        private System.Windows.Forms.TextBox txtInputFour;
        private System.Windows.Forms.TextBox txtAreaCalculate;
        private System.Windows.Forms.TextBox txtPerimeterCalculate;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pictureDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rdoModulus;
        private System.Windows.Forms.RadioButton rdoPercentage;
        private System.Windows.Forms.RadioButton rdoPower;
        private System.Windows.Forms.TextBox txtInputCalculator;
        private System.Windows.Forms.RichTextBox txtDisplayCalculatorInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCalculatorInput2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox picCalculatorPicture;
    }
}

