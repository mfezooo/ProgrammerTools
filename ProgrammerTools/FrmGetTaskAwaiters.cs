using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;


using System.Windows.Forms;
using Microsoft.CodeAnalysis;

namespace ProgrammerTools
{
    public partial class FrmGetTaskAwaiters : Form
    {
        public FrmGetTaskAwaiters()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var result =  getTaskWithOutAwaiter();
            MessageBox.Show(result);
        }
        
        private string getTaskWithOutAwaiter()
        {
            string result = null;
            var projectPath = @"F:\Test file\Controlllers\Setup";
            var project = new DirectoryInfo(projectPath);
            var syntaxTrees = project.GetFiles("*Controller.cs", SearchOption.AllDirectories)
                .Select(file => CSharpSyntaxTree.ParseText(File.ReadAllText(file.FullName)));

            var methodsWithoutAwait = new List<(MethodDeclarationSyntax Method, string FileName, int LineNumber)>();

            foreach (var syntaxTree in syntaxTrees)
            {
                var root = syntaxTree.GetRoot();
                var methods = root.DescendantNodes().OfType<MethodDeclarationSyntax>();

                foreach (var method in methods)
                {
                    if (!ContainsAwait(method))
                    {
                        methodsWithoutAwait.Add((method, syntaxTree.FilePath, method.GetLocation().GetMappedLineSpan().StartLinePosition.Line));
                    }
                }
            }

            foreach (var (method, fileName, lineNumber) in methodsWithoutAwait)
            {
                Console.WriteLine($"Method without await: {method.Identifier} - File: {fileName} - Line: {lineNumber}");
                result+=$"Method without await: {method.Identifier} - File: {fileName} - Line: {lineNumber} \n";
            }
            return result;
        }
     
        private static bool ContainsAwait(MethodDeclarationSyntax method)
        {
            // Check if the method is async and returns Task
            if (method.Modifiers.Any(SyntaxKind.AsyncKeyword) &&
                method.ReturnType is GenericNameSyntax returnType &&
                returnType.Identifier.Text == "Task")
            {
                // Check if the method contains an await expression
                return method.DescendantNodes().OfType<AwaitExpressionSyntax>().Any();
            }

            return false;
        }
    }
}
