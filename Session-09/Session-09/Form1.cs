using CalculatorLib;

namespace Session_09 {
    public partial class Form1 : Form {

        private string? _value1 = string.Empty;
        private string? _value2 = string.Empty;
        private double? _result = null;
        private bool hasOperation = false;
        

        private CalcOperation _calcOperation;

        enum CalcOperation {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            SquareRoot,
            RaisetoPower
        }


        public Form1() {
            InitializeComponent();
        }

        
        private void ButtonImplement(double value) {
            if (_result != null) {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
            ctrlDisplay.Text += Convert.ToString(value);

            if (hasOperation == false) {
                _value1 += Convert.ToString(value);
            }
            else {
                _value2 += Convert.ToString(value);
            }

        }

        private void btnEquals_Click(object sender, EventArgs e) {
            if (_result != null) {
                btnClear_Click(sender, e);
            }
            else { 
                ctrlDisplay.Text += " = ";
            }
            switch (_calcOperation) {
                case CalcOperation.Addition:

                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value2);
                    
                    break;
                case CalcOperation.Subtraction:

                    Subtraction subtraction = new Subtraction();
                    _result = subtraction.Do(_value1, _value2);

                    break;
                case CalcOperation.Multiplication:

                    Multiplication multiplication = new Multiplication();
                    _result = multiplication.Do(_value1, _value2);

                    break;
                case CalcOperation.Division:

                    Division division = new Division();
                    _result = division.Do(_value1, _value2);

                    break;
                case CalcOperation.SquareRoot:

                    SquareRoot squareRoot = new SquareRoot();
                    _result = squareRoot.Do(_value1);

                    break;
                case CalcOperation.RaisetoPower:

                    RaisetoPower raisetoPower = new RaisetoPower();
                    _result = raisetoPower.Do(_value1, _value2);

                    break;
                default:
                    break;
            }
            hasOperation = false;
            ctrlDisplay.Text += _result;
        }


        //  NUMBER KEYS CLICK
        private void btnOne_Click(object sender, EventArgs e) {

            ButtonImplement(1);
        }

        private void btnTwo_Click(object sender, EventArgs e) {
            ButtonImplement(2);
        }

        private void btnThree_Click(object sender, EventArgs e) {
            ButtonImplement(3);
        }

        private void btnFour_Click(object sender, EventArgs e) {
            ButtonImplement(4);
        }

        private void btnFive_Click(object sender, EventArgs e) {
            ButtonImplement(5);
        }

        private void btnSix_Click(object sender, EventArgs e) {
            ButtonImplement(6);
        }

        private void btnSeven_Click(object sender, EventArgs e) {
            ButtonImplement(7);
        }

        private void btnEight_Click(object sender, EventArgs e) {
            ButtonImplement(8);

        }

        private void btnNine_Click(object sender, EventArgs e) {
            ButtonImplement(9);

        }

        private void btnZero_Click(object sender, EventArgs e) {
            ButtonImplement(0);
        }




        // OPERATION KEYS

        private void btnAdd_Click(object sender, EventArgs e) {
            hasOperation = true;
            if (_result !=null) {
                btnClear_Click(sender, e);
            }
            else {
                ctrlDisplay.Text += " + ";
                _calcOperation = CalcOperation.Addition;
            }
           
        }
        private void btnMinus_Click(object sender, EventArgs e) {
            hasOperation = true;
            if (_result != null) {
                btnClear_Click(sender, e);
            }
            else {
                ctrlDisplay.Text += " - ";
                _calcOperation = CalcOperation.Subtraction;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e) {
            hasOperation = true;
            if (_result != null) {
                btnClear_Click(sender, e);
            }
            else {
                ctrlDisplay.Text += " / ";
                _calcOperation = CalcOperation.Division;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e) {
            hasOperation = true;
            if (_result != null) {
                btnClear_Click(sender, e);
            }
            else {
                ctrlDisplay.Text += " x ";
                _calcOperation = CalcOperation.Multiplication;
            }
        }

        private void btnRoot_Click(object sender, EventArgs e) {
            hasOperation = true;
            if (_result != null) {
                btnClear_Click(sender, e);
            }
            else {
                ctrlDisplay.Text += (char)0x221A;
                _calcOperation = CalcOperation.SquareRoot;
            }
        }

        private void btnPower_Click(object sender, EventArgs e) {
            hasOperation = true;
            if (_result != null) {
                btnClear_Click(sender, e);
            }
            else {
                ctrlDisplay.Text += " ^ ";
                _calcOperation = CalcOperation.RaisetoPower;
            }
        }

        //decimal doesnt work yet!
        private void btnDecimal_Click(object sender, EventArgs e) {
            if (_result != null) {
                btnClear_Click(sender, e);
            }
            else {
                ctrlDisplay.Text += ".";

            }
            //_calcOperation = CalcOperation.Decimal;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            ctrlDisplay.Text = string.Empty;
            _value1 = null;
            _value2 = null;
            _result = null;

    }
    }
}

    
