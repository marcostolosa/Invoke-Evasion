using System;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Collections;
using System.Collections.Generic;

/*
Directly from https://github.com/danielbohannon/Revoke-Obfuscation/tree/master/Checks

Daniel Bohannon & Lee Holmes, Apache 2.0 license
*/

public class MemberMetrics
{
    public static IDictionary AnalyzeAst(Ast ast)
    {
        // Build string list of all AST object values that will be later sent to StringMetricCalculator.
        List<string> stringList = new List<string>();

        foreach(MemberExpressionAst targetAst in ast.FindAll( testAst => testAst is MemberExpressionAst, true ))
        {
            // Extract the AST object value.
            stringList.Add(targetAst.Member.Extent.Text);
        }
        
        // Return character distribution and additional string metrics across all targeted AST objects across the entire input AST object.
        return RevokeObfuscationHelpers.StringMetricCalculator(stringList, "AstMemberMetrics");
    }
}