using Blog.Shared;
using Masa.Blazor.Extensions.Languages.Razor;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis;
using Semi.Design.Blazor;

namespace Blog.Component;

public partial class Editor
{
    private SMonacoEditor _monacoEditor;

    private object Options;

    private Type? ComponentType;

    private static List<PortableExecutableReference>? portableExecutableReferences = new();

    private static List<RazorExtension>? razorExtensions = new();
    private void GetBack()
    {
        NavigationManager.NavigateTo("/");
    }

    private async Task RunCode()
    {
        try
        {
            ComponentType = RazorCompile.CompileToType(new CompileRazorOptions
            {
                Code = await _monacoEditor.GetValue(),
            });
        }
        catch (Exception e)
        {
            await PopupService.ToastErrorAsync(e.Message);
        }
    }

    protected override async Task OnInitializedAsync()
    {
        Options = new
        {
            value = "", // 初始代码
            language = "razor", // 语法支持语言
            automaticLayout = true, //自动适应父容器大小
            theme = "vs-dark" // monaco主题 
        };

        await GetRazorExtension();
        await GetReference();
        RazorCompile.Initialized(portableExecutableReferences, razorExtensions);

        await base.OnInitializedAsync();
    }


    private static List<string> Assemblys = new()
    {
        "BlazorComponent",
        "Masa.Blazor",
        "OneOf",
        "FluentValidation",
        "FluentValidation.DependencyInjectionExtensions",
        "System",
        "Microsoft.AspNetCore.Components",
        "System.Linq.Expressions",
        "System.Net.Http.Json",
        "System.Private.CoreLib",
        "Microsoft.AspNetCore.Components.Web",
        "System.Collections",
        "System.Linq",
        "System.Runtime"
    };
    
    private async Task GetReference()
    {
        if (portableExecutableReferences?.Count>0)
        {
            return;
        }
        #region WebAsembly

        var http = new HttpClient()
        {
            BaseAddress = new Uri(StorageService.WebAssemblyBaseAddress)
        };
        
        foreach (var assembly in Assemblys)
        {
            try
            {
                // WebAssembly You need to get the assembly over the network
                var stream = await http!.GetStreamAsync($"_framework/{assembly}.dll");
                if (stream.Length > 0)
                {
                    portableExecutableReferences?.Add(MetadataReference.CreateFromStream(stream));
                }
            }
            catch (Exception e) // There may be a 404
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

    }

    private async Task GetRazorExtension()
    {
        if (razorExtensions?.Count>0)
        {
            return;
        }
        foreach (var asm in typeof(Editor).Assembly.GetReferencedAssemblies())
        {
            razorExtensions.Add(new AssemblyExtension(asm.FullName, AppDomain.CurrentDomain.Load(asm.FullName)));
        }
    }
}