using dnlib.DotNet.Emit;
using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAssembly.Protection
{
    class FakeCode
    {
        public static void Execute(ModuleDefMD module)
        {
            foreach (var type in module.Types)
            {
                foreach (var method in type.Methods)
                {
                    if (method.HasBody && method.Body.HasInstructions)
                    {
                        InsertFakeCode(method);
                    }
                }
            }
        }
        public static void InsertFakeCode(MethodDef method)
        {
            var body = method.Body;
            var instructions = body.Instructions.ToList();

            for (int i = 0; i < instructions.Count; i++)
            {
                if (i % 3 == 0) // Insert fake code every 3 instructions
                {
                    var fakeInstruction = Instruction.Create(OpCodes.Nop);
                    body.Instructions.Insert(i, fakeInstruction);
                }
            }
        }
    }
}
