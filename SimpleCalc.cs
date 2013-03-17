using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SimpleCalc
/// </summary>
public class SimpleCalc
{
    /// <summary>
    /// This class contains the methods to perform
    /// the basic calculations for the calendar
    /// steve conger 3/17/2013
    /// </summary>

    
	public SimpleCalc()
	{
		
	}

  

    //public Methods
    public double Add(double n1, double n2)
    {
        return n1 + n2;
    }

    public double Subtract(double n1, double n2)
    {
        return n1 - n2;
    }

    public double Multiply(double n1, double n2)
    {
        return n1 * n2;
    }

    public double Divide(double n1, double n2)
    {
        return n1 / n2;
    }

}