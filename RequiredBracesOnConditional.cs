using Microsoft.CodeAnalysis;
//...

public class RequiredBracesOnConditional : DiagnosticAnalyzer
{

  //TODO: Add Initialize method

  private static void AnalyzeIfOrElseStatement(SyntaxNodeAnalysisContext context)
  {
    var ifStatement = (IfStatementSyntax)context.Node;
    StatementSyntax statement = ifStatement.Statement;
    if (statement.Kind() == SyntaxKind.Block)
    {
      return;
    }
    // See Microsoft tutorial for Rule example.
    context.ReportDiagnostic(Diagnostic.Create(Rule, context.Node.GetLocation()));
  }

}
