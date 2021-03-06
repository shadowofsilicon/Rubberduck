using Rubberduck.Inspections.Abstract;
using Rubberduck.Inspections.Concrete;
using Rubberduck.Parsing;
using Rubberduck.Parsing.Grammar;
using Rubberduck.Parsing.Inspections.Abstract;
using Rubberduck.Parsing.Symbols;
using Rubberduck.Parsing.VBA;

namespace Rubberduck.Inspections.QuickFixes
{
    public sealed class ReplaceIfElseWithConditionalStatementQuickFix : QuickFixBase
    {
        private readonly RubberduckParserState _state;

        public ReplaceIfElseWithConditionalStatementQuickFix(RubberduckParserState state)
            : base(typeof(BooleanAssignedInIfElseInspection))
        {
            _state = state;
        }

        public override void Fix(IInspectionResult result)
        {
            var ifContext = (VBAParser.IfStmtContext) result.Context;
            var letStmt = ifContext.block().GetDescendent<VBAParser.LetStmtContext>();

            var conditional = ifContext.booleanExpression().GetText();

            if (letStmt.expression().GetText() == Tokens.False)
            {
                conditional = $"Not ({conditional})";
            }

            var rewriter = _state.GetRewriter(result.QualifiedSelection.QualifiedName);
            rewriter.Replace(result.Context, $"{letStmt.lExpression().GetText()} = {conditional}");
        }

        public override string Description(IInspectionResult result) => Resources.Inspections.QuickFixes.ReplaceIfElseWithConditionalStatementQuickFix;

        public override bool CanFixInProcedure => true;
        public override bool CanFixInModule => true;
        public override bool CanFixInProject => true;
    }
}
