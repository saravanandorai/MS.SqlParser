using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlParserSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Microsoft.Data.Schema.ScriptDom.Sql.TSql100Parser(true);
            System.IO.TextReader txtRdr = new System.IO.StringReader("Select * from customers as c inner join products as p on p.custid = c.id where 1 = 1 order by customers.name");

            IList<Microsoft.Data.Schema.ScriptDom.ParseError> parseErrors = new List<Microsoft.Data.Schema.ScriptDom.ParseError>();

            var fragment = parser.Parse(txtRdr, out parseErrors);

            if (fragment != null)
            {
                var tSqlScript = ((Microsoft.Data.Schema.ScriptDom.Sql.TSqlScript)(fragment));
                var tokens = tSqlScript.ScriptTokenStream;

                var stmts = tSqlScript.Batches.FirstOrDefault().Statements;

                foreach (var item in tokens)
                {
                    switch (item.TokenType)
                    {
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Add:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.AddEquals:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.All:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Alter:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Ampersand:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.And:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Any:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.As:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Asc:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.AsciiStringLiteral:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.AsciiStringOrQuotedIdentifier:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Authorization:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Backup:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Bang:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Begin:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Between:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.BitwiseAndEquals:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.BitwiseOrEquals:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.BitwiseXorEquals:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Break:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Browse:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Bulk:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.By:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Cascade:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Case:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Check:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Checkpoint:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Circumflex:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Close:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Clustered:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Coalesce:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Collate:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Colon:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Column:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Comma:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Commit:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Compute:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Constraint:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Contains:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.ContainsTable:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Continue:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Convert:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Create:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Cross:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Current:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.CurrentDate:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.CurrentTime:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.CurrentTimestamp:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.CurrentUser:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Cursor:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Database:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Dbcc:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Deallocate:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Declare:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Default:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Delete:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Deny:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Desc:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Disk:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Distinct:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Distributed:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Divide:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.DivideEquals:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.DollarPartition:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Dot:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Double:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.DoubleColon:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Drop:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Dump:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Else:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.End:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.EndOfFile:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.EqualsSign:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Errlvl:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Escape:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Except:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Exec:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Execute:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Exists:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Exit:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.External:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Fetch:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.File:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.FillFactor:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.For:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Foreign:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.FreeText:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.FreeTextTable:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.From:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Full:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Function:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Go:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.GoTo:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Grant:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.GreaterThan:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Group:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Having:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.HexLiteral:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.HoldLock:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Identifier:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Identity:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.IdentityColumn:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.IdentityInsert:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.If:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.In:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Index:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Inner:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Insert:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Integer:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Intersect:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Into:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Is:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Join:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Key:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Kill:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Label:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Left:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.LeftCurly:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.LeftParenthesis:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.LessThan:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Like:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.LineNo:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Load:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Merge:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Minus:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.ModEquals:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Money:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.MultilineComment:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.MultiplyEquals:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.National:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.NoCheck:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.NonClustered:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.None:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Not:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Null:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.NullIf:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.OdbcInitiator:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Of:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Off:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Offsets:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.On:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Open:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.OpenDataSource:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.OpenQuery:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.OpenRowSet:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.OpenXml:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Option:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Or:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Order:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Outer:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Over:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Percent:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.PercentSign:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Pivot:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Plan:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Plus:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Precision:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Primary:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Print:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Proc:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.ProcNameSemicolon:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Procedure:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.PseudoColumn:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Public:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.QuotedIdentifier:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Raiserror:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Read:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.ReadText:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Real:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Reconfigure:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.References:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Replication:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Restore:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Restrict:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Return:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Revert:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Revoke:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Right:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.RightCurly:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.RightOuterJoin:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.RightParenthesis:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Rollback:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.RowCount:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.RowGuidColumn:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Rule:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Save:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Schema:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Select:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Semicolon:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.SessionUser:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Set:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.SetUser:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Shutdown:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.SingleLineComment:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Some:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.SqlCommandIdentifier:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Star:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Statistics:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.StopList:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.SubtractEquals:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.SystemUser:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.TSEqual:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Table:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.TableSample:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.TextSize:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Then:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Tilde:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.To:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Top:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Tran:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Transaction:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Trigger:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Truncate:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.UnicodeStringLiteral:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Union:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Unique:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Unpivot:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Update:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.UpdateText:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Use:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.User:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Values:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Variable:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Varying:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.VerticalLine:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.View:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.WaitFor:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.When:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.Where:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.While:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.WhiteSpace:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.With:
                            break;
                        case Microsoft.Data.Schema.ScriptDom.Sql.TSqlTokenType.WriteText:
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine(item.Text);
                }

            }

            //parser.Parse();

            Console.ReadKey();
        }
    }
}
