namespace cs_automaton_collection
{
  public class RiscV
  {
    public enum RV32I
    {
      LUI, AUIPC, JAL, JALR, BEQ,
      BNE, BLT, BGE, BLTU, BGEU,
      
      LB, LH, LW, LBU, LHU,
      SB, SH, SW, ADDI, SLTI,
      
      SLTIU, XORI, ORI, ANDI, SLLI,
      SRLI, SRAI, ADD, SUB, SLL,
      
      SLT, SLTU, XOR, SRL, SRA,
      OR, AND, FENCE, FENCEI, ECALL,
      
      EBREAK, CSRRW, CSRRS, CSRRC, CSRRWI,
      CSRRSI, CSRRCI
    }
    
    
    
    
  }
}