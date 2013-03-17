OVERVIEW

This project is used for the first ASP.NET Assignment. It has the virtues of providing a grand tour of the features of ASP.NET including ASP.Net Web Forms and controls, Session Variables, and a fair amount of C# code including an added class. The class itself is fairly trivial and exists mostly to show how a class can be added and used.

It is a simple calculator and limited in functionality. 

THE FILES:
Default.aspx contains a table containing the calcutor. The top row of the table consists of a textbox which spans 4 columns. All the other table cells contain asp.Button objects. The number buttons all share the same click event.

Default.aspx.cs. contains all the button handling code. I have tried to refractor it so that most of the action happens in the OperatorProcessing Method.

SimpleCalc is an added class that contains a method for each of the four operators Add, Subtract, Multiply, and Divide.

I have included a simple CSS style sheet Calculator.css

I have also included the web config file, though I made no changes to it.