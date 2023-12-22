// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Text.Json;
// using System.Threading.Tasks;
// using Microsoft.DotNet.Interactive;
// using InteractiveKernel = Microsoft.DotNet.Interactive.Kernel;
// ReSharper disable InconsistentNaming
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.DotNet.Interactive;
//using ConfigClass;

public static class AppConfig
{
    private const string configFile = "../../secrets.json";
    //private const string configFile = "../secrets.json";
    

    public class aoaiSettings
    {        
        public string? endpoint { get; set; } //= null;
        public string? APIKey { get; set; } //= null;
        public string? deployDavinci { get; set; } //= null;
        public string? deployTurbo { get; set; } //= null;
        public string? deployEmbed { get; set; } //= null;
        public string? QdrantEndpoint { get; set; } //= null;
        
    }

    public static aoaiSettings GetSecrets()
    {        
        aoaiSettings myConfig = new();

        if (File.Exists(configFile))
        {            
            //Console.WriteLine("file find");
            myConfig = JsonSerializer.Deserialize<aoaiSettings>(File.ReadAllText(configFile));            
        }
        else
        {
            //Console.WriteLine("file not find");
        }

        return myConfig;

    }
  
}