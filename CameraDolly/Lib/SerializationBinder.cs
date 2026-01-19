using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Decal.Adapter;
using Newtonsoft.Json.Serialization;

namespace CameraDolly
{
    internal class SerializationBinder : ISerializationBinder
    {
        public Type BindParentType = null;

        public Type BindToType(string assemblyName, string typeName)
        {
            var genRe = new Regex(@"^(?<gen>[^\[]+)\[(?<type>[^\]]*,?)+\]$");
            var m = genRe.Match(typeName);
            if (m.Success)
            {
                var gen = GetFlatTypeMapping(assemblyName, m.Groups["gen"].Value);
                var genArgs = m.Groups["type"].Captures
                    .Cast<Capture>()
                    .Where(c => !string.IsNullOrEmpty(c.Value))
                    .Select(c =>
                    {
                        if (genRe.IsMatch(c.Value))
                        {
                            return BindToType(assemblyName, c.Value);
                        }
                        else
                        {
                            return GetFlatTypeMapping(assemblyName, c.Value);
                        }
                    }).ToArray();
                if (gen != null && genArgs.All(t => t != null))
                {
                    return gen.MakeGenericType(genArgs);
                }
            }

            return GetFlatTypeMapping(assemblyName, typeName);
        }

        private Type GetFlatTypeMapping(string assemblyName, string typeName = "")
        {
            Type ret = GetType().Assembly.GetType(typeName) ?? GetType().Assembly.GetType($"{assemblyName}, {typeName}");
            
            if (ret != null) return ret;

            // 1. Try to find the type in the current executing assembly (Plugin)
            ret = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.FullName == typeName || t.Name == typeName);
            if (ret != null) return ret;

            // 2. Try BindParentType assembly if set
            if (BindParentType != null)
            {
                ret = BindParentType.Assembly.GetTypes()
                    .FirstOrDefault(t => t.FullName == typeName || t.Name == typeName);
                if (ret != null) return ret;
            }

            // 3. Fallback: Search all loaded assemblies
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    ret = asm.GetTypes().FirstOrDefault(t => t.FullName == typeName || t.Name == typeName);
                    if (ret != null) return ret;
                }
                catch
                {
                    // Ignore assembly load errors
                }
            }

            return null;
        }

        public void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            assemblyName = null;
            typeName = serializedType.FullName;
        }
    }
}
