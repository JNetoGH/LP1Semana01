using System;

namespace TiposVarios {
    
    internal static class Exec {
        
        private static void Main(string[] args) { 
            
            // Integers (Z)
            // Guardados nos formatos de Módulo e Sinal(MS), Complemento para 1(c1) e Complemento para 2(c2), 1 bit é reservado para o sinal.
            sbyte n1 = 120; // 8 bits  => 1 byte:  (MS/c1/c2) sign(0)0000000
            short n2 = 651; // 16 bits => 2 bytes: (MS/c1/c2) sign(0)0000000.00000000
            int   n3 = 10;  // 32 bits => 4 bytes: (MS/c1/c2) sign(0)0000000.00000000.00000000.00000000
            long  n4 = 645; // 64 bits => 8 bytes: (MS/c1/c2) sign(0)0000000.00000000.00000000.00000000.00000000.00000000.00000000.00000000

            // Alternatives to System Structs declaration, é exatamente a mesma coisa que usar os alias A.K.A short, long, etc...
            // o compilador vai reescrever usando as structs de System.IntX equivalentes anyway.
            Byte  n5 = 13;
            Int16 n6 = 13;
            Int32 n7 = 13134;
            Int64 n8 = 13123;
            
            // Unsigned Integers: o 1º bit deixa de ser reservardo para o sinal, liberando esse bit para storage, porém, o número é sempre positivo.
            byte   n9  = 225;  // 8 bits  => 1 byte:  (ALWAYS POSITIVE) 00000000
            ushort n10 = 986;  // 16 bits => 2 bytes: (ALWAYS POSITIVE) 00000000.00000000
            uint   n11 = 464;  // 32 bits => 4 bytes: (ALWAYS POSITIVE) 00000000.00000000.00000000.00000000
            ulong  n12 = 1561; // 64 bits => 8 bytes: (ALWAYS POSITIVE) 00000000.00000000.00000000.00000000.00000000.00000000.00000000.00000000
        
            // Literals (Hexadecimal/Binário): é simplesmente uma notação que vem antes do número que permite escrever fora do formato de base 10. 
            int n13 = 0b1001;
            int n14 = 0x54EA;
            
            ValueType[] arr = new ValueType[] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14 };
            for (int i = 0; i < arr.Length; i++) 
                Console.WriteLine($"{arr[i].GetType().Name} n{i} = {arr[i]}");
            
        }
    }
}