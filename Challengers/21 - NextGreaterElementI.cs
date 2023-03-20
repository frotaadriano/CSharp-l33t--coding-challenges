using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challengers
{
    /// <summary>
    /// Desafio: Next Greater Element I 
    /// Nível de dificuldade: Médio
    /// Descrição do desafio: 
    /// Dado um array de inteiros chamado nums1, 
    /// você precisa implementar uma função NextGreaterElement que retorna um segundo array res, 
    /// onde res[i] é 
    /// o primeiro número em nums1 que é maior que nums2[j], 
    /// onde j é a posição de nums1[i] em nums2.
    /// Se não houver tal número, defina res[i] como -1.
    ///      
    /// Exemplo de entrada:
    /// nums1 = [4,1,2], nums2 = [1,3,4,2]
    /// Exemplo de saída:
    /// [-1, 3, -1]
    /// Explicação:
    /// 
    /// Para o elemento 4 de nums1, o próximo número maior que ele em nums2 é -1.
    /// Para o elemento 1 de nums1, o próximo número maior que ele em nums2 é 3.
    /// Para o elemento 2 de nums1, o próximo número maior que ele em nums2 é -1.
    /// Nota:
    /// 
    /// Todos os elementos de nums1 e nums2 são únicos.
    /// O comprimento de ambos nums1 e nums2 não excede 1000.
    /// Dica: Use uma pilha para implementar a solução.
    /// 
    /// 
    /// </summary>
    public class NextGreaterElementI
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var stack = new Stack<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                while (stack.Count > 0 && stack.Peek() < nums2[i])
                {
                    dict[stack.Pop()] = nums2[i];
                }
                stack.Push(nums2[i]);
            }

            var result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                if (dict.TryGetValue(nums1[i], out int val))
                {
                    result[i] = val;
                }
                else
                {
                    result[i] = -1;
                }
            }

            return result;
        }
    }
}
