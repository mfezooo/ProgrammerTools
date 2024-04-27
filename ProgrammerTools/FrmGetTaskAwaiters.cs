using System; 
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;


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
            var result = getTaskWithOutAwaiter();
            MessageBox.Show(result);

        }
        private string getServiceshOutAwaiter()
        {
            string result = null;
            var projectPath = @"F:\Test file\Controllers";
            var project = new DirectoryInfo(projectPath);
            var syntaxTrees = project.GetFiles("*Controller.cs", SearchOption.AllDirectories)
                .Select(file => CSharpSyntaxTree.ParseText(File.ReadAllText(file.FullName)));

            var methodsUsingFields = new List<(MethodDeclarationSyntax Method, string FileName, int LineNumber)>();

            foreach (var syntaxTree in syntaxTrees)
            {
                string controllerName = getFileName(syntaxTree.ToString());

                var root = syntaxTree.GetRoot();
                var methods = root.DescendantNodes().OfType<MethodDeclarationSyntax>();

                var privateReadonlyFields = root.DescendantNodes().OfType<FieldDeclarationSyntax>()
                    .Where(field =>
                        field.Modifiers.Any(modifier => modifier.Kind() == SyntaxKind.PrivateKeyword) &&
                        field.Modifiers.Any(modifier => modifier.Kind() == SyntaxKind.ReadOnlyKeyword))
                    .SelectMany(field => field.Declaration.Variables.Select(variable => variable.Identifier.Text))
                    .Where(field => field != "_mapper") // Exclude _mapper field
                    .ToList();

                privateReadonlyFields = privateReadonlyFields.Where(x=>x.EndsWith("Service")).ToList();
                foreach (var privateReadonlyField in privateReadonlyFields)
                {
                    int lineNo = 0;
                    var lines = root.ToFullString().Split('\n');
                    var privateReadonlyFieldWithout = privateReadonlyField.TrimStart('_');
                    foreach (var line in lines)
                    {
                        lineNo++;
                        if (line.Contains(privateReadonlyField) && !line.Contains("await") && !line.Contains("private readonly")
                            && !line.Contains(privateReadonlyField +" = " + privateReadonlyFieldWithout))
                        { 
                            result += $"Controller: {controllerName} - Line: {lineNo} - Method: {line.Trim()} \n";

                        }
                    }
                }

                
            }

            foreach (var (method, fileName, lineNumber) in methodsUsingFields)
            {
                result += $"Method using private readonly field: Controller: {fileName} - Line: {lineNumber} - Method: {method.Identifier} \n";
            }

            return result;
        }
        private string getTaskWithOutAwaiter()
        {
            string result = null;
            var projectPath = @"F:\Test file\Controllers"; 
            var project = new DirectoryInfo(projectPath);
            var syntaxTrees = project.GetFiles("*Controller.cs", SearchOption.AllDirectories)
                .Select(file => CSharpSyntaxTree.ParseText(File.ReadAllText(file.FullName)));


            var methodsWithoutAwait = new List<(MethodDeclarationSyntax Method, string FileName, int LineNumber)>();

            foreach (var syntaxTree in syntaxTrees)
            {

                string controllerName= getFileName(syntaxTree.ToString());
                var root = syntaxTree.GetRoot();
                var methods = root.DescendantNodes().OfType<MethodDeclarationSyntax>();

                foreach (var method in methods)
                {
                    if (IsAsyncTaskMethod(method) && !ReturnsActionResult(method))
                    {
                        var methodCalls = root.DescendantNodes().OfType<InvocationExpressionSyntax>()
                            .Where(invocation => invocation.Expression is IdentifierNameSyntax identifier &&
                                                  identifier.Identifier.Text == method.Identifier.Text)
                            .ToList();

                        foreach (var methodCall in methodCalls)
                        {
                            if (!IsCalledWithAwait(methodCall))
                            {
                                methodsWithoutAwait.Add((method, controllerName, methodCall.GetLocation().GetMappedLineSpan().StartLinePosition.Line));
                            }
                        }
                    }
                }
            }

            foreach (var (method, fileName, lineNumber) in methodsWithoutAwait)
            {  
                result += $"Method without await: Controller: {fileName} - Line: {lineNumber} - Methoud: {method.Identifier} \n";
            }
            return result;
        }

        private static bool IsAsyncTaskMethod(MethodDeclarationSyntax method)
        {
            return method.Modifiers.Any(SyntaxKind.AsyncKeyword) &&
         method.ReturnType is GenericNameSyntax returnType &&
         returnType.Identifier.Text == "Task";
        }

        private static bool ReturnsActionResult(MethodDeclarationSyntax method)
        {
            return method.ReturnType.ToString() == "ActionResult";
        }

        private static bool IsCalledWithAwait(InvocationExpressionSyntax invocation)
        {
            return invocation.Ancestors().OfType<AwaitExpressionSyntax>().Any();
        }
        private string getFileName(string controllerData)
        {             
            string[] words = controllerData.Split(' ');
            string controllerName = words.FirstOrDefault(word => word.EndsWith("Controller"));
            return controllerName;
        }
        
        private void btnServices_Click(object sender, EventArgs e)
        {
            var result2 = getServiceshOutAwaiter();
            MessageBox.Show(result2);
        }
    }
}
