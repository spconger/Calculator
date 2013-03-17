using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    //declaing the Simple Calc Class
    SimpleCalc calc = new SimpleCalc();
    //declaring the answer variable
    double answer = 0;
  
 
    double number1 = 0;
    double number2 = 0;


    protected void Page_Load(object sender, EventArgs e)
    {
        //start with a zero
        if(!IsPostBack)
        txtEntry.Text = "0";
    }
    protected void calc_click(object sender, EventArgs e)
    {
        //this method determines which number button has been clicked,
        //gets its text (the number) and places it in the textbox
        //the stylesheet has set the alignment of the textbox to 
        //right align so the numbers display correctly
        Button b = (Button)sender;
        txtEntry.Text += b.Text;
    }
    protected void btnMinus_Click(object sender, EventArgs e)
    {
        //for each of the operators we pass the operator on to our
        //method that processes the operator 
      
        ProcessOperator("-");
        txtEntry.Text = "";

    }
    protected void btnPlus_Click(object sender, EventArgs e)
    {
        ProcessOperator("+");
        txtEntry.Text = "";
     

    }
    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        ProcessOperator("*");
        txtEntry.Text = "";
    }
    protected void btnDivide_Click(object sender, EventArgs e)
    {
        ProcessOperator("/");
        txtEntry.Text = "";
       
    }
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        //this method processes the calculate button
        //If there is a current operator stored
        //it passes the numbers and current operator
        //to the ProcessOperator() method
        //then it nulls out both session variables
        //otherwise it does nothing
        if (Session["operator"] != null)
        {
            string oper = Session["operator"].ToString();
            ProcessOperator(oper);
            txtEntry.Text = answer.ToString();
            Session["answer"] = null;
            Session["operator"] = null;
        }
       


    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        //this method clears everything
        txtEntry.Text = "";
        Session["answr"]=null;
        Session["operator"] = null;
    }

    protected void ProcessOperator(string curOperator)
    {
        //this method is the heart of the operation
        //it gets the operator
        string op = curOperator;
        
        //first it tests to see if it is a valid numerical entry
        //by checking to see if the ParseTextEntry() method returns
        //a true or a false
        //if false than it launches a javascript alert
        if (!ParseTextEntry())
        {

            Response.Write("<script type='Text/JavaScript'>alert('Enter only valid Numbers')</script>");

          
            return;
        }
        //if it is good it writes the current operator
        //to the operator session
        Session["operator"] = op;

        //next it checks whether there is anything in
        //the answr session
        //if there is it determins the operator
        //and calls the appropriate method
        //from the SimpleCalc class
        if (Session["answr"] != null)
        {
            number1 = (double)Session["answr"];
            Session["answr"] = null;
            switch (op)
            {
                case "+":
                    answer = calc.Add(number1, number2);
                    break;
                case "-":
                    answer = calc.Subtract(number1, number2);
                    break;
                case "*":
                    answer = calc.Multiply(number1, number2);
                    break;
                case "/":
                    answer = calc.Divide(number1, number2);
                    break;
                default:
                    Response.Write("<script type='Text/JavaScript'>alert('Invalid Operator')</script>");
                    break;

            }
            //it writes the answer to the textbox
            txtEntry.Text = answer.ToString();
            //and clears the session
            Session["answr"] = null;

        }
        else
        {
            //otherwise it writes the number from the textbox
            //to the session variable
            Session["answr"] = number2;
        }
       
    }

    protected bool ParseTextEntry()
    {
        //this method applies a try parse to the textbox value
        //if it it fails to parse a double it will
        //return false. IF it succeeds it will assign the value
        //to number2 and return true
        bool testIt = double.TryParse(txtEntry.Text, out number2);
      
        return testIt;
    }

  
}