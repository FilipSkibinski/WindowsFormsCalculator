using System;
using System.Linq;
using System.Windows.Forms;

namespace WinForms_Calculator
{
    /// <summary>
    /// A basic calclulator
    /// </summary>
    public partial class Basic_Calculator : Form
    {

        #region Constructor
        
        /// <summary>
        /// Default constructor
        /// </summary>       
       public Basic_Calculator()
        {
            InitializeComponent();
        }

        #endregion

        #region Operator Methods

        //Inserts "(" when user clicks on Left_Parenthesis_Button
        private void Left_Parenthesis_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("(");

            //Focus the user input text
            FocusInputText();
        }

        //Inserts ")" when user clicks on Right_Parenthesis_Button
        private void Right_Parenthesis_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue(")");

            //Focus the user input text
            FocusInputText();
        }

        //Inserts "/" when user clicks on Devide_Button
        private void Divide_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("/");

            //Focus the user input text
            FocusInputText();
        }

        //Inserts "x" when user clicks on Devide_Button
        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("x");

            //Focus the user input text
            FocusInputText();
        }

        //Inserts "-" when user clicks on Devide_Button
        private void Minus_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("-");

            //Focus the user input text
            FocusInputText();
        }

        //Inserts "+" when user clicks on Devide_Button
        private void Plus_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("+");

            //Focus the user input text
            FocusInputText();
        }

        //Calculates the given equation in th euser input text box
        private void Equal_Button_Click(object sender, EventArgs e)
        {
            //Calculate the equation
            CalculateEquation();

            //Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Number Methods

        //Insert "0" when user clicks the Button_0
        private void Button_0_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("0");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "1" when user clicks the Button_1
        private void Button_1_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("1");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "2" when user clicks the Button_2
        private void Button_2_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("2");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "3" when user clicks the Button_3
        private void Button_3_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("3");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "4" when user clicks the Button_4
        private void Button_4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "5" when user clicks the Button_5
        private void Button_5_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("5");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "6" when user clicks the Button_6
        private void Button_6_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("6");

            //Focus the user input text
            FocusInputText();
        }
        //Insert "7" when user clicks the Button_7
        private void Button_7_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("7");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "8" when user clicks the Button_8
        private void Button_8_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("8");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "9" when user clicks the Button_9
        private void Button_9_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue("9");

            //Focus the user input text
            FocusInputText();
        }

        //Insert "." when user clicks the Dot_Button
        private void Dot_Button_Click(object sender, EventArgs e)
        {
            //Insert the value in the user input text box at the currently selected position
            InsertTextValue(".");

            //Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Clear Methods

        /// <summary>
        /// Clears all user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CE_Button_Click(object sender, EventArgs e)
        {
            //Clears the text from the UserInputText box
            this.UserInputText.Text = string.Empty;

            //Focus the user input text
            FocusInputText();
        }

        //Removes char which cursor points when user clicks a button Delete_Button
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            //Delete the value after the selection position
            DeleteTextValue();

            //Focus the user input text
            FocusInputText();            
        }

        #endregion

        /// <summary>
        /// Cakculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            this.CalcualationResultText.Text = ParsOperation();

            //Focus the user input text
            FocusInputText();
        }

        
        /// <summary>
        /// Parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParsOperation()
        {
            try
            {
                //Get the users equation input
                var input = this.UserInputText.Text;

                //Remove all spaces
                input = input.Replace(" ", "");

                //Create a new top - level operation
                var operation = new Operation();
                var leftSide = true;


                //Loop through each character of the input
                //Starting from the left working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    //Check if the current character is a number
                    if ("1234567890.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        }
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                        }
                    }
                    // If it is an operator ( + - * / ) set the operator type
                    else if ("+-*x/".Any(c => input[i] == c))
                    {
                        // If we are on the right side already, we now need to calculate our current operation
                        // and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                // Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an right side number");

                                // If we got here, the operator type is aminus, and there is no left number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // Calculate previous equation and set to the left side
                                operation.LeftSide = CalculateOperation(operation);

                                // Set new operator
                                operation.OperationType = operatorType;

                                // Clear the previous right number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a left side number
                            if (operation.LeftSide.Length == 0)
                            {
                                // Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an left side number");

                                // If we got here, the operator type is aminus, and there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // If we have left number and now an operator, so we want to move to the right side

                                // Set the operation type
                                operation.OperationType = operatorType;

                                // Move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }

                // calculate the current operation
                return CalculateOperation(operation);
            }
            catch (Exception e)
            {
                return $"Invalid equation. {e.Message}";
            }
        }
        

        /// <summary>
        /// Calculates a <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation"> The operation to calculate </param>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representations
            double left = 0;
            double right = 0;

            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Plus:
                        return (left + right).ToString();

                    case OperationType.Minus:
                        return (left - right).ToString();

                    case OperationType.Multiply:
                        return (left * right).ToString();

                    case OperationType.Devide:
                        return (left / right).ToString();

                    default:
                        throw new InvalidOperationException($"Unknow operator type when calculation operation. {operation.OperationType}");
                }
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {e.Message}");
            }
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Plus;                 
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case 'x':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Devide;
                default:
                    throw new InvalidOperationException($"Unknown operator type: { character }");
            }
        }

        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber">The current nymber string</param>
        /// <param name="currentCharacter">The new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //Check if there is already a "." in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
            {
                throw new InvalidOperationException($"Number {currentNumber} already contains a '.'");
            }
            return currentNumber + newCharacter;
        }

        #region Private Helpers

        //Focuses the user input text
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character to the right of the selection start of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {            
            //if we don't have a value to delete, return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        #endregion

    }
}
