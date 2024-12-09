using System;
using System.IO;
using System.Xml;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;

public class ReproTest
{
    public static void Test()
    {
        var projectRootElement = @"<Project Sdk=""Microsoft.Build.Traversal/4.1.0""></Project>";
        var stringReader = new StringReader(projectRootElement);
        var xmlReader = new XmlTextReader(stringReader);
        var root = ProjectRootElement.Create(xmlReader);
        // root.Sdk = "Microsoft.Build.Traversal/4.1.0";

        var project = new Project(root);
        project.AddItem("ProjectReference", "./**/*.csproj");

        Console.WriteLine("Generated project:");
        Console.WriteLine(project.Xml.RawXml);
    }
}