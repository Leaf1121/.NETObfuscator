using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Resources;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NetAssembly.Protection
{
    internal class WaterMark
    {
        public static void Execute(ModuleDef module)
        {
            Random rand = new Random();
            int count = rand.Next(200, 300);
            for(int i=0; i<count; i++)
            {
                TypeDef classDef = new TypeDefUser(Utils.Random.GetRandomString(), module.CorLibTypes.Object.TypeDefOrRef);
                module.Types.Add(classDef);

                MethodDef methodDef = new MethodDefUser(Utils.Random.GetRandomString(), MethodSig.CreateStatic(module.CorLibTypes.Void), MethodImplAttributes.IL, MethodAttributes.Public | MethodAttributes.Static);
                classDef.Methods.Add(methodDef);

                CilBody body = new CilBody();
                methodDef.Body = body;
                body.MaxStack = 8;
                body.Instructions.Add(OpCodes.Ldstr.ToInstruction("water_mark"));
                body.Instructions.Add(OpCodes.Ret.ToInstruction());
            }
        }
    }
}
