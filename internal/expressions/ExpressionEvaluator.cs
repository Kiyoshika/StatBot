using System;
using System.Data;

public class ExpressionEvaluator
{
    // this will return a tuple where the first element indicates if any
    // special functions are found and the second element will be the list
    // of all special functions contained. It will be empty if none are found.
    private static Tuple<bool, List<string>> checkSpecialFunctions(ref string expression)
    {
        bool containsSpecialFunction = false;
        List<string> specialFunctions = new List<string>();
        if (expression.Contains("sqrt")) { containsSpecialFunction = true; specialFunctions.Add("sqrt"); }
        if (expression.Contains("log")) { containsSpecialFunction = true; specialFunctions.Add("log"); }
        if (expression.Contains("pow")) { containsSpecialFunction = true; specialFunctions.Add("pow"); }
        if (expression.Contains("exp")) { containsSpecialFunction = true; specialFunctions.Add("exp"); }

        Tuple<bool, List<string>> return_values = new Tuple<bool, List<string>>(containsSpecialFunction, specialFunctions);
        return return_values;
    }

    // this works for simple expressions but doesn't support generic functions like
    // sqrt, log, ^ (powers), etc.
    public static dynamic evaluateExpression_legacy(ref string expression)
    {
        DataTable dt = new DataTable();
        var v = dt.Compute(expression,"");
        return v;
    }

    // this is a modified parser to handle the special functions before passing the
    // final expression to DataTable
    public static dynamic evaluateExpression(ref string expression)
    {
        // check if any special functions are contained
        Tuple<bool, List<string>> specialFunctions = checkSpecialFunctions(ref expression);

        // TODO: continue from here
        return 0;
    }
}