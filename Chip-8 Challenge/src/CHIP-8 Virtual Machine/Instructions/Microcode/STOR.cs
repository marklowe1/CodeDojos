using CHIP_8_Virtual_Machine.InstructionBases;

namespace CHIP_8_Virtual_Machine.Instructions;
public class STOR : RegisterInstruction
{
    public override void Execute(VM vm)
    {
        for (Nibble i = 0; i <= X; i++)
        {
            vm.RAM[vm.I + i] = vm.V[i];
        }
    }

    public STOR(Register X)
        : base(X, 0x55) { }
}