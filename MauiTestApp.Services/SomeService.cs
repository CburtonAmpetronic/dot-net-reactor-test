// Exclude All (Any Type) =>  Namespace: ALL;  Types: SomeService
// Methods = All; Properties = All; 
using System.Reflection;

//[assembly: Obfuscation(Feature = @"rule: (-all) (types=SomeService)")]

namespace MauiTestApp.Services;

public static class SomeService
{
    public static string DoSomething()
    {
        return "Something has been done - latest attempt.";
    }
}
