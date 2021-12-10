using System;
using System.Data;

public class ExpressionEvaluator
{
    public static dynamic evaluateExpression(string expression)
    {
        DataTable dt = new DataTable();
        var v = dt.Compute(expression,"");
        return v;
    }
}