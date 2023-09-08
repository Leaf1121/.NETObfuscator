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
                // 클래스 생성
                TypeDef classDef = new TypeDefUser(Utils.Random.GetRandomString(), module.CorLibTypes.Object.TypeDefOrRef);
                module.Types.Add(classDef);

                // 메서드 생성
                MethodDef methodDef = new MethodDefUser(Utils.Random.GetRandomString(), MethodSig.CreateStatic(module.CorLibTypes.Void), MethodImplAttributes.IL, MethodAttributes.Public | MethodAttributes.Static);
                classDef.Methods.Add(methodDef);

                // 메서드 바디 생성
                CilBody body = new CilBody();
                methodDef.Body = body;
                body.MaxStack = 8; // 예상 스택 크기를 설정

                // 워터마크 문자열을 스택에 로드
                body.Instructions.Add(OpCodes.Ldstr.ToInstruction("king_ss"));

                // 반환
                body.Instructions.Add(OpCodes.Ret.ToInstruction());
            }
        }
    }
}
