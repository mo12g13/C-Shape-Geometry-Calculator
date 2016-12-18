using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonGeometricCalculatorProject
{
    public partial class GeometryCalculator : Form
    {   

        String shapeText;//Variable for the various
        String perimeter_Area;//Variable for area, perimeter and Area and Perimeter
        public GeometryCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCalculatorInput2.Visible = false;
            txtDisplayCalculatorInput.Visible = false;
            txtInputCalculator.Visible = false;
        }


        //An event handler method for Rectangle, Square, Parallelogram, Triangle, Cicle, Trapezoid and Rhombus
        private void shapeOfObjects(object sender, EventArgs e)
        {
            //Casting of various shape radio button to a text in order to check which button was clicked
            RadioButton values = (RadioButton)sender;
            shapeText = values.Text;

            if (shapeText.Equals("Rectangle"))
            {
                pictureDisplay.Image = Properties.Resources.Rectangle;//Setting of the Parallelogram Gif image
                rtxtDisplay.Text = "RECTANGLE"; //Setting of the text Square in the rtxtDisplay text box
                isRadioButtonOn(false, false, false);//Turn of the selection of Area, Perimeter and Area and Perimeter when Rectangle is clicked
                setLableName("Length", "Width", "", "", "", "");
                isTextboxVisible(true, true, false, false, false, false);
                islableVisible(true, true, false, false, true, false);
            }
            //If the user clicked the Square buttong, set the following visibility
            else if (shapeText.Equals("Square"))

            {
                pictureDisplay.Image = Properties.Resources.Square;//Setting the Square Gif image
               
                isRadioButtonOn(false, false, false);//Turn of the selection of Area, Perimeter and Area and Perimeter when Square is clicked
                rtxtDisplay.Text = "SQUARE";// Setting of the text Square in the rtxtDisplay text box
                clearInput();
                isTextboxVisible(true, false, false, false, false, false);
                setLableName("Side", "", "", "", "", "");
                islableVisible(true, false, false, false, false, false);
            }
            //If the user clicked the Parallelogram radio button, set the following visibility
            else if (shapeText.Equals("Parallelogram"))
            {
                pictureDisplay.Image = Properties.Resources.Parallelogram; //Setting of the Parallelogram Gif image
                isRadioButtonOn(false, false, false);//Turn of the selection of Area, Perimeter and Area and Perimeter when Parallelogram is clicked
                rtxtDisplay.Text = "PARALLELOGRAM"; //Setting of the text Parallelogram in the rtxtDisplay text box
                clearInput();                
                isTextboxVisible(true, true, false, false, false, false);
                setLableName("Base", "Height", "", "", "", "");
                islableVisible(true, true, false, false, false, false);

            }
            //If the user clicked the Rhombus radio button, set the following visibility
            else if (shapeText.Equals("Rhombus"))
            {
                pictureDisplay.Image = Properties.Resources.Rhombus;//Setting of the Rhombus Png image
                rtxtDisplay.Text = "RHOMBUS";// Setting of the text Rhombus in the rtxtDisplay text box
                isRadioButtonOn(false, false, false);//Turn of the selection of Area, Perimeter and Area and Perimeter when Rhombus is clicked
                setLableName("Base", "Height", "", "", "", "");
                islableVisible(true, true, false, false, false, false);
                isTextboxVisible(true, true, false, false, false, false);
            }
            //If the user clicked the Triangle radio button, set the following visibilty
            else if (shapeText.Equals("Triangle"))
            {
                pictureDisplay.Image = Properties.Resources.Triangle;//Setting of the Triangle Gif image
                rtxtDisplay.Text = "TRIANGLE";// Setting of the text Trianglein the rtxtDisplay text box
                isRadioButtonOn(false, false, false);//Turn of the selection of Area, Perimeter and Area and Perimeter when Triangle is clicked
                setLableName("Base", "Height", "", "", "", "");
                islableVisible(true, true, false, false, false, false);
                isTextboxVisible(true, true, false, false, false, false);
            }

            //if the user clicked the Trapezoid radio button, set the following visiblity 
            else if (shapeText.Equals("Trapezoid"))
            {
                pictureDisplay.Image = Properties.Resources.Trapezoid;//Setting of the Trapezoid Gif image
                rtxtDisplay.Text = "TRAPEZOID";//Setting of the text Trapezoid in the rtxtDisplay text box
                isRadioButtonOn(false, false, false);//Turn of the selection of Area, Perimeter and Area and Perimeter when Trapezoid is clicked
                setLableName("Base", "Base", "Height", "", "", "");
                islableVisible(true, true, true, false, false, false);
                isTextboxVisible(true, true,true, false, false, false);
            }
            //If the user clicked the circle, set the following visibility
            else if (shapeText.Equals("Circle"))
            {
                pictureDisplay.Image = Properties.Resources.Circle;//Setting of the circle Gif image
                rtxtDisplay.Text = "CIRCLE";//Setting of the text Circle in the rtxtDisplay text box
                isRadioButtonOn(false, false, false);//Turn of the selection of Area, Perimeter and Area and Perimeter when Circle is clicked
                setLableName("Radius", "", "", "", "", "");
                islableVisible(true, false, false, false, false, false);
                isTextboxVisible(true, false, false, false, false, false);
            }
            else if (shapeText.Equals("Modulus"))
            {
                picCalculatorPicture.Image = Properties.Resources.remainder1;
                txtDisplayCalculatorInput.Visible = true;
                txtCalculatorInput2.Visible = true;
                txtInputCalculator.Visible = true;
                label6.Visible = true;
            }else if (shapeText.Equals("Percentage"))
            {
                picCalculatorPicture.Image = Properties.Resources.Percentage;
                txtDisplayCalculatorInput.Visible = true;
                txtCalculatorInput2.Visible = false;
                txtInputCalculator.Visible = true;
                label6.Visible = false;
            }
            else if (shapeText.Equals("Square Value"))
            {
                picCalculatorPicture.Image = Properties.Resources.squareroot;
                txtInputCalculator.Visible = true;
                txtDisplayCalculatorInput.Visible = true;
                txtCalculatorInput2.Visible = false;
                label6.Visible = false;

            }

        }

        //A multiple event handler for the Area radio button, "Perimeter radio button and Area and Perimeter radio button
        private void perimeterAndArea(object sender, EventArgs e)
        {
            //Casting of the Area, Perimeter and Area and Perimeter RadioButton to a text to be use in the in the switch statement
            RadioButton values = (RadioButton)sender;
            perimeter_Area = values.Text;
            if (perimeter_Area.Equals("Area"))
            {
                clearInput();

                lblArea.Visible = true;
                isTextboxVisible(true, true, false, false, true, false);
                setLableName("Length", "Width", "", "", "Area", "");

            }
            //If the user clicked on the perimeter radio button, set the following visibility
            else if (perimeter_Area.Equals("Perimeter"))
            {
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne

                isTextboxVisible(true, true, false, false, false, true);
                setLableName("Length", "Width", "", "", "", "Perimeter");
                islableVisible(true, true, false, false, false, true);
                //Checking to see if the Area and Perimeter button was clicked
            } //if the user clicked on the Area and Perimeter radio button, set the below visitbility
            else if (perimeter_Area.Equals("Area and Perimeter"))
            {
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                isTextboxVisible(true, true, false, false, true, true);
                setLableName("Length", "Width", "", "", "Area", "Perimeter");
                islableVisible(true, true, false, false, true, true);
            }

            //if the user clicked on the square and Area radio button, set the visibility as below
            if (shapeText.Equals("Square") && perimeter_Area.Equals("Area"))
            {
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                isTextboxVisible(true, false, false, false, true, false);
                setLableName("Side", "", "", "", "Area", "");
                islableVisible(true, false, false, false, true, false);

            }
            //If the user clicked on Square and Primeter radio buttons set the visibility as below
            else if (shapeText.Equals("Square") && perimeter_Area.Equals("Perimeter"))
            {
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                isTextboxVisible(true, false, false, false, false, true);
                setLableName("Side", "", "", "", "", "Perimeter");
                islableVisible(true, false, false, false, false, true);

            }
            //If user clicked on Square and Area and Perimeter set the below visibility
            else if (shapeText.Equals("Square") && perimeter_Area.Equals("Area and Perimeter"))
            {
                //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                islableVisible(true, false, false, false, true, true);
                setLableName("Side", "", "", "", "Area", "Perimeter");
                isTextboxVisible(true, false, false, false, true, true);

            }
            //Checking to see if the clicked on the parallelogram radio button and area radio button
            if (shapeText.Equals("Parallelogram") && perimeter_Area.Equals("Area"))
            {
                //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Base", "Length", "", "", "Area", "");
                islableVisible(true, true, false, false, true, false);
            }
            // If the user clicked Parallelogram and Perimeter, set the visibility of the below radio buttons
            else if (shapeText.Equals("Parallelogram") && perimeter_Area.Equals("Perimeter"))
            {
                //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Base", "Height", "", "", "", "Perimeter");
                islableVisible(true, true, false, false, false, true);
                isTextboxVisible(true, true, false, false, false, true);
            }
            //Checking to see if the user clicked the area and perimeter and the parallelegram button
            //If the user clicked these buttons, set the various label, textbox, visibility property
            else if (perimeter_Area.Equals("Area and Perimeter") && shapeText.Equals("Parallelogram"))

            {
                //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Base", "Height", "", "", "Area", "Perimeter");
                islableVisible(true, true, false, false, true, true);
                isTextboxVisible(true, true, false, false, true, true);
            }
            //Checking to see if the user clicked on the Rhombus radio button and area radio button
            //if the user clicked on both buttons, set the visibility of various label and textboxes
            if (shapeText.Equals("Rhombus") && perimeter_Area.Equals("Area"))
            {
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                isTextboxVisible(true, true, false, false, true, false);
                islableVisible(true, true, false, false, true, false);
                setLableName("Base", "Height", "", "", "Area", "");
            }
            //Checking to see if the user clicked the Rhombus and Perimeter radio button
            //If the user clicked both buttons, set the visibility of the label and textbox as below
            else if (shapeText.Equals("Rhombus") && perimeter_Area.Equals("Perimeter"))
            {
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                islableVisible(true, false, false, false, false, true);
                isTextboxVisible(true, false, false, false, false, true);
                setLableName("Base", "", "", "", "", "Perimeter");
            }
            
            //If the user clicked both buttons, set the visibility of the label and textbox as below
            else if (shapeText.Equals("Rhombus") && perimeter_Area.Equals("Area and Perimeter"))
            {
                clearInput(); //A method that clears the text in the text area and focus the cursor in txtInputboxOne
                islableVisible(true, true, false, false, true, true);
                isTextboxVisible(true, true, false, false, true, true);
                setLableName("Base", "Height", "", "", "Area", "Perimeter");

            }
            //Setting of the visibility of the user checked the Triangle and Area radio button
            if (shapeText.Equals("Triangle") && perimeter_Area.Equals("Area"))
            {    //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Base", "Height", "", "", "Area", "");
                isTextboxVisible(true, true, false, false, true, false);
                islableVisible(true, true, false, false, true, false);

            }
            //Setting of the visibility if the user checked the Triangle and Perimeter button
            else if (shapeText.Equals("Triangle") && perimeter_Area.Equals("Perimeter"))
            {    //Setting of various controls using methods that are being created
                setLableName("A", "B", "C", "", "", "Perimeter");
                isTextboxVisible(true, true, true, false, false, true);
                islableVisible(true, true, true, false, false, true);
            }
            //Setting of the visibility if the user checked the Triangle and Area and Perimeter button
            else if (shapeText.Equals("Triangle") && perimeter_Area.Equals("Area and Perimeter"))
            {    //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Base - A", "Height - B", "C", "", "Area", "Perimeter");
                isTextboxVisible(true, true, true, false, true, true);
                islableVisible(true, true, true, false, true, true);

            }
            //Setting of the visibility if the user checked the Trapezoid and Area button
            if (shapeText.Equals("Trapezoid") && perimeter_Area.Equals("Area"))
            {    //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Base", "Base", "Height", "", "Area", "");
                islableVisible(true, true, true, false, true, false);
                isTextboxVisible(true, true, true, false, true, false);

            }
            //Setting of the Visibility if the user checked the Trapezoid and Perimeter button
            else if (shapeText.Equals("Trapezoid") && perimeter_Area.Equals("Perimeter"))
            {    //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("A", "B", "C", "D", "", "Perimeter");
                islableVisible(true, true, true, true, false, true);
                isTextboxVisible(true, true, true, true, false, true);

            }
            //Setting of the visibility if the user checked the Trapezoid and Area and Perimeter radio button
            else if (shapeText.Equals("Trapezoid") && perimeter_Area.Equals("Area and Perimeter"))
            {    //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Base-A", "Base-B", "Height-C", "D", "Area", "Perimeter");
                islableVisible(true, true, true, true, true, true);
                isTextboxVisible(true, true, true, true, true, true);

            }
            //Setting of the various visibility if the user checked the Circle and Area button
            if (shapeText.Equals("Circle") && perimeter_Area.Equals("Area"))
            {    //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Radius", "", "", "", "Area", "");
                islableVisible(true, false, false, false, true, false);
                isTextboxVisible(true, false, false, false, true, false);
            }
            //Setting of the visibility if the user checked the circle and Perimeter radio button
            else if (shapeText.Equals("Circle") && (perimeter_Area.Equals("Perimeter")))
            {    //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Radius", "", "", "", "", "Perimeter");
                islableVisible(true, false, false, false, false, true);
                isTextboxVisible(true, false, false, false, false, true);

            }
            //Setting of the visibility if the user clicked the circle and Area and Perimeter radio button
            else if (shapeText.Equals("Circle") && perimeter_Area.Equals("Area and Perimeter"))
            {    //Setting of various controls using methods that are being created
                clearInput();//A method that clears the text in the text area and focus the cursor in txtInputboxOne
                setLableName("Radius", "", "", "", "Area", "Perimeter");
                islableVisible(true, false, false, false, true, true);
                isTextboxVisible(true, false, false, false, true, true);
            }
           
            {

            }
        
    }
        //A method that calculates the perimeter of a Rectangle and Parallelogram
        private decimal perimeterOfRecAndPara(String l, String w)
        {
            decimal length, width;
            if (decimal.TryParse(l, out length) && decimal.TryParse(w, out width))
            {
                return (2 * length) + (2 * width);
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return 0;
            }         
          
        }
        //A method that calculates the area of a Rectangle, Parallelogram and Rhombus
        private decimal areaOfRecParaAndRhombus(String l, String w)
        {
            decimal length, width;
            if (decimal.TryParse(l, out length) && decimal.TryParse(w, out width))
            {
               return length * width;
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return 0;
            }
            
        }
        //A method that calculates perimeter of a Square and Rhombus
        private decimal perimeterOfSquareAndRhombus(String number)
        {
           decimal result;
           if(Decimal.TryParse(number, out result))
            {
                return result * 4;
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return 0;
            }
           
        }
        //A method that calculates the an Area of a square
        private decimal areaOfSquare(String number)
        {
            decimal answer = 0; ;
            if (decimal.TryParse(number, out answer))
            {
                return answer * answer;
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return answer;
            }
        }
        //A method that calculates the perimeter of a Triangle and Trapezoid
        private decimal perimeterOfTriAndTra(String a, String b, String c, String d = "0")
        {
            decimal answer = 0;
            decimal firstNum, secondNum, thirdNum, fourthNum;
            
            if (decimal.TryParse(a, out firstNum)
                && decimal.TryParse(b, out secondNum) && decimal.TryParse(c, out thirdNum) && decimal.TryParse(d, out fourthNum))
            {
                return firstNum + secondNum + thirdNum + fourthNum;
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return answer;
            }
                

            }
        //A Method that calculates an area of a triangle
        private decimal areaOfTriangle(String b, String h)
        {
            decimal bases, heigth;
            if (decimal.TryParse(b, out bases) && decimal.TryParse(h, out heigth))
            {
               return (bases * heigth) / 2;
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return 0;
            }
        }

        //A method that calculates an area of a Trapezoid
        private decimal areaOfTrapezoid(String a, String b, String h)
            {
            decimal area, bases, heigth;
            if (decimal.TryParse(b, out bases) & decimal.TryParse(h, out heigth) && decimal.TryParse(a, out area))
            {
                return ((area + bases) / 2) * heigth;
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return 0;
            }
          }
        //A method that calculates a perimeter of a circle
        private double perimeterCircle(String d)
        {

            double result;
            if (double.TryParse(d, out result))
            {
               return result * (Math.PI * 2);
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return 0;
            }
          }
        //A method that calculates the area of a circle
        private double areaOfCircle(String d)
        {
            double result;
            if (double.TryParse(d, out result))
            {
               return (Math.PI * result * result);
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
                clearInput();
                return 0;
            }
                       
        }
        //Calculate button that perform specific operation base on the switch statement
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        
            
            //A switch statement text for the specific shape that is being clicked by the user
            switch (shapeText)
            {
                //Calculating and setting the various value in the appropriate textbox using appropriate method                
                case "Rectangle":
                    
                    
                    //If perimeter area is null, Prompt the user to make a choice
                    if (perimeter_Area == null)
                    {
                        MessageBox.Show("Please make a valid choice, you haven't selected Area, Perimeter or Area and Perimeter");
                        clearInput();
                    }
                    else
                    {
                        //if radio button selected is the area radio button, calculate the area
                        if (perimeter_Area.Equals("Area"))
                        {
                           txtAreaCalculate.Text = ""+ areaOfRecParaAndRhombus(txtInputOne.Text, txtInputTwo.Text).ToString("f2");
                        }
                        //if radio button selected is the perimeter, calculate the perimeter
                        else if (perimeter_Area.Equals("Perimeter"))
                        {

                            txtPerimeterCalculate.Text = "" + perimeterOfRecAndPara(txtInputOne.Text, txtInputTwo.Text).ToString("f2"); ;
                        }
                        //If the radio button selected is the Area and Perimeter, calculate the area and perimeter
                        else if (perimeter_Area.Equals("Area and Perimeter"))
                        {
                            txtPerimeterCalculate.Text = "" + perimeterOfRecAndPara(txtInputOne.Text, txtInputTwo.Text).ToString("f2");
                            txtAreaCalculate.Text = "" + areaOfRecParaAndRhombus(txtInputOne.Text, txtInputTwo.Text).ToString("f2");

                        }
                    }
                    break;
                //check if the shape selected is a square
                case "Square":
                    //If perimeter_area is null, prompt the user to make a valid choice
                    if (perimeter_Area == null)
                    {
                        MessageBox.Show("Please make a valid choice, you haven't selected Area, Perimeter or Area and Perimeter");
                        clearInput();
                    }
                    else
                    {
                        //If the radio button selected is the area radio button, calculate the area of the square


                        if (perimeter_Area.Equals("Area"))

                        {
                            /*Calculating the area of square using the areaOfSquare Method
                             * and set the calculated result in the textAreaCalculate Textbox
                             */
                            txtAreaCalculate.Text = "" + areaOfSquare(txtInputOne.Text).ToString("f2");
                        }
                        //If the radio button selected is perimeter, calculate the perimeter of the square
                        else if (perimeter_Area.Equals("Perimeter"))
                        {
                            /*Calculating the perimeter of the square using the perimeterOfSquareAndRhombus Method
                             * and set the result in the perimeterCalculate TextBox
                             */

                            txtPerimeterCalculate.Text = "" + perimeterOfSquareAndRhombus(txtInputOne.Text).ToString("f2");
                        }
                        else
                        {
                            /*if previous condition aren't perform, calculate the area and the perimeter
                             * and display both results in the area and perimeter calculated textbox
                            */
                            txtAreaCalculate.Text = "" + areaOfSquare(txtInputOne.Text);
                            txtPerimeterCalculate.Text = "" + perimeterOfSquareAndRhombus(txtInputOne.Text).ToString("f2");
                        }
                    }
                    break;
                //Checking if the button selected is a Parallelogram
                case "Parallelogram":
                    //If perimeter_area is null, prompt the user to make a valid choice
                    if (perimeter_Area == null)
                    {
                        MessageBox.Show("Please make a valid choice, you haven't selected Area, Perimeter or Area and Perimeter");
                        clearInput();
                    }
                    //If the perimeter_Area is not null perform the below operation
                    else
                    {
                        //If the radio button checked is the area button, calculate the area of the parallelogram
                        if (perimeter_Area.Equals("Area"))
                        {
                            /*Calcualting the of a Parallelogram using the areaOfRecParaAndRhombus Method
                             * The result of the calculation is set the txtAreaCalculate textBox
                             */
                            txtAreaCalculate.Text = "" + areaOfRecParaAndRhombus(txtInputOne.Text, txtInputTwo.Text).ToString("f2");
                        }
                        //If the button selected is perimeter, calculate the perimeter of the parallelogram
                        else if (perimeter_Area.Equals("Perimeter"))
                        {   /*Calculating the perimeter of the Parallelogram using the perimeterOfRecAndPara 
                            and setting the result in the txtPerimeterCalculate Textbox
                             */
                            txtPerimeterCalculate.Text = "" + perimeterOfRecAndPara(txtInputOne.Text, txtInputTwo.Text).ToString("f2");
                        }
                        else
                        {
                            /*If none of the previous condition are met, calculate the area and perimeter of the Parallelogram
                             * and set both result in the in txtPerimeterCalculate textbox
                             * and txtAreaCalculate Texbox
                             */
                            txtAreaCalculate.Text = "" + areaOfRecParaAndRhombus(txtInputOne.Text, txtInputTwo.Text).ToString("f2");
                            txtPerimeterCalculate.Text = "" + perimeterOfRecAndPara(txtInputOne.Text, txtInputTwo.Text).ToString("f2");
                        }
                    }

                    break;
                case "Rhombus":
                    //If the perimeter_area is null, prompt the user to make a valid choice
                    if (perimeter_Area == null)
                    {
                        MessageBox.Show("Please make a valid choice, you haven't selected Area, Perimeter or Area and Perimeter");
                        clearInput();
                    }
                    else
                    {
                        //if the perimeter_area is area, calculate the area of the Rhombus
                        if (perimeter_Area.Equals("Area"))
                        {
                            /*Calculate the area of the Rhombus using the areaOfRecParaAndRhombus Method
                             * set the result in the txtAreaCalculate Textbox
                             */
                            txtAreaCalculate.Text = "" + areaOfRecParaAndRhombus(txtInputOne.Text, txtInputTwo.Text);
                        }/*If the perimeter_area radio button clicked is perimeter 
                            calculate the perimeter of the Rhombus
                        */
                        else if (perimeter_Area.Equals("Perimeter"))
                        {
                            /*Calculating the perimeter of the Rhombus using the perimeterOfSquareandRhombus Method
                             * set the result in the txtPerimeterCalculate TextBox
                             */
                            txtPerimeterCalculate.Text = "" + perimeterOfSquareAndRhombus(txtInputOne.Text);
                        }
                        else
                        {
                            /*If previous condition aren't met, calculate both the area and perimeter 
                             * and set the result in the txtAreaCalculate and txtPerimeterCalculate Text Boxes*/
                            txtAreaCalculate.Text = "" + areaOfRecParaAndRhombus(txtInputOne.Text, txtInputTwo.Text);
                            txtPerimeterCalculate.Text = "" + perimeterOfSquareAndRhombus(txtInputOne.Text);
                        }
                    }

                    break;
                case "Triangle":
                    //If the user didn't make any selection, prompt the user to make a choice
                    if (perimeter_Area == null)
                    {
                        MessageBox.Show("Please make a valid choice, you haven't selected Area, Perimeter or Area and Perimeter");
                        clearInput();
                    }
                    else
                    {
                        //if the user clicked on the area radio button, calculate the area of the triangle
                        if (perimeter_Area.Equals("Area"))
                        {
                            /*Calculating the area of the triangle using the areaOfTriangle method
                             * and setting the result the in the txtAreaCalcualte textbox 
                             */
                            txtAreaCalculate.Text = "" + areaOfTriangle(txtInputOne.Text, txtInputTwo.Text);
                        }
                        //If the user clicked on the perimeter radio button, calculate the perimeter of the triangle
                        else if (perimeter_Area.Equals("Perimeter"))
                        {
                            /*Calculate the perimeter of the triangle using perimeterOfTriAndTra Method
                             and setting the result in the txtPerimeterCalculate textBox
                             */
                            txtPerimeterCalculate.Text = "" + perimeterOfTriAndTra(txtInputOne.Text, txtInputTwo.Text, txtInputThree.Text);
                        }
                        else
                        {
                            //If the previous conditon aren't met, calculate the area and perimeter and set the result to the text boxes
                            txtAreaCalculate.Text = "" + areaOfTriangle(txtInputOne.Text, txtInputTwo.Text);
                            txtPerimeterCalculate.Text = "" + perimeterOfTriAndTra(txtInputOne.Text, txtInputTwo.Text, txtInputThree.Text);
                        }
                    }
                    break;
                case "Trapezoid":
                    //If perimeter_Area is equals to null, prompt the user to make a valid selection
                    if (perimeter_Area == null)
                    {
                        MessageBox.Show("Please make a valid choice, you haven't selected Area, Perimeter or Area and Perimeter");
                        clearInput();
                    }
                    //If perimeter_Area is not null, perform the below operation
                    else
                    {
                       //if perimeter_Area equals Area, calculate the area of the Trapezoid
                        if (perimeter_Area.Equals("Area"))
                        {
                            //Use the areaOfTrapezoid Method to calculate the area and set the result in the txtAreaCalculate text box
                            txtAreaCalculate.Text = "" + areaOfTrapezoid(txtInputOne.Text, txtInputTwo.Text, txtInputThree.Text);
                        }
                        //If perimeter_Area equals perimeter calculate the area of the perimeter
                        else if (perimeter_Area.Equals("Perimeter"))
                        {
                            //Use the perimeterOfTriAndTra Method to calculate the perimeter and sets the result in the txtPerimeterCalculate textbox
                            txtPerimeterCalculate.Text = "" + perimeterOfTriAndTra(txtInputOne.Text, txtInputTwo.Text, txtInputThree.Text, txtInputFour.Text);
                        }
                        else
                        {
                            txtAreaCalculate.Text = "" + areaOfTrapezoid(txtInputOne.Text, txtInputTwo.Text, txtInputThree.Text);
                            txtPerimeterCalculate.Text = "" + perimeterOfTriAndTra(txtInputOne.Text, txtInputTwo.Text, txtInputThree.Text, txtInputFour.Text);
                        }
                    }
                    break;

                case "Modulus":
                    try
                    {
                        decimal numberII = resultInput(txtInputCalculator.Text);
                        decimal number2 = resultInput(txtCalculatorInput2.Text);
                        if (numberII <= 0 || number2 <= 0)
                        {
                            MessageBox.Show("Please enter a valid number");
                        }
                        else
                        {
                            txtDisplayCalculatorInput.Text = "The reminder is " + resultInput(txtInputCalculator.Text) % resultInput(txtCalculatorInput2.Text);
                        }
                    }catch(DivideByZeroException exe)
                    {
                        MessageBox.Show("Please enter a valid number");
                    }
                    break;
                case "Percentage":
                    try
                    {
                        
                        decimal numberI = resultInput(txtInputCalculator.Text);
                        if (numberI <= 0)
                        {
                            MessageBox.Show("Please enter a valid number");
                        }
                        else
                        {
                            txtDisplayCalculatorInput.Text = "The percentage is " + ((numberI / 100) * 100).ToString("");
                        }
                    }catch(DivideByZeroException exe)
                    {
                        MessageBox.Show("Please enter a valid number");
                    }
                    break;
                case "Square Value":
                    decimal number1 = resultInput(txtInputCalculator.Text);
                   
                        if (number1 < 0)
                        {
                            MessageBox.Show("Please enter a valid number");
                        }
                        else
                        {
                           txtDisplayCalculatorInput.Text ="The square is " + number1 * number1;
                        }
                    break;
                default:
                    //If perimeter_Area is equals a null value, prompt the user to make a selection
                    if (perimeter_Area == null)
                    {
                        MessageBox.Show("Please make a valid choice, you haven't selected Area, Perimeter or Area and Perimeter");
                        clearInput();
                    }
                    else
                    {
                        /* if the perimeter_Area equals Area, calculate the Area of the Circle */
                        if (perimeter_Area.Equals("Area"))
                        {
                            /*Using the areaOfCircle Method to calculate the Area and setting the result in
                            txtAreaCalculate textbox */
                            txtAreaCalculate.Text = areaOfCircle(txtInputOne.Text).ToString("f2");

                        }
                        //if the perimeter_Area is equals to Perimeter, calculate the perimeter of the circle
                        else if (perimeter_Area.Equals("Perimeter"))
                        {
                            /*Using the perimeterCircle Method to calculate the perimeter and setting the result in
                            txtPerimeterCalculate textbox */
                            txtPerimeterCalculate.Text = perimeterCircle(txtInputOne.Text).ToString("f2");
                        }
                        
                        {
                            /*If none of the previous condition are met, calculate the area and perimeter of the circle 
                             and sets the result in the txtAreaCalculate and txtPerimeter calculate textboxes*/
                            txtAreaCalculate.Text = areaOfCircle(txtInputOne.Text).ToString("f2");
                            txtPerimeterCalculate.Text = perimeterCircle(txtInputOne.Text).ToString("f2");
                        }
                    }
                    break;

            }

           
        }
        //A Method that sets the name of a label
        private void setLableName(String a, String b, String c, String d, String e, String f)
        {
            label1.Text = a; label2.Text = b; label3.Text = c; label4.Text = d; lblArea.Text = e; lblPerimeter.Text = f;
        }
        //A method that sets the visibility of the text boxes
        private void isTextboxVisible(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false)
        {
            txtInputOne.Visible = a; txtInputTwo.Visible = b; txtInputThree.Visible = c; txtInputFour.Visible = d; txtAreaCalculate.Visible = e; txtPerimeterCalculate.Visible = f;
        }

        //A method that clears the text boxes after user checked another option
        public void clearInput()
        {
            txtInputOne.Focus();
            txtPerimeterCalculate.Text = String.Empty;
            txtInputTwo.Text = String.Empty;
            txtInputThree.Text = String.Empty;
            txtInputOne.Text = String.Empty;
            txtInputFour.Text = String.Empty;
            txtAreaCalculate.Text = String.Empty;

        }
        //A method that sets the visibility of label name
        public void islableVisible(bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false)
        {
            label1.Visible = a; label2.Visible = b; label3.Visible = c; label4.Visible = d; lblArea.Visible = e; lblPerimeter.Visible = f;
        }
        //A method that sets the checked or unchecked of the Area, Perimeter, and Area and Perimeter checked boxes
        public void isRadioButtonOn(bool a = false, bool b = false, bool c = false)
        {
            rdoArea.Checked = a; rdoAreaPerimeter.Checked = b; rdoPerimeter.Checked = c;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private decimal resultInput(String a)
        {
            decimal result;
            if(decimal.TryParse(a , out result))
            {
                return result;
            }
            else
            {
               
                return 0;
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInput();
        }
    }
}
