using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicaDotNet.Recursive
{
    public static class HanoiTower
    {
        private static string result;
        public static string GetResult(int n)
        {
            result = string.Empty;
            Move(n, "IZQUIERDA", "CENTRO", "DERECHA");
            return result;
        }

        public static void Move(int n, string origin, string aux, string destine)
        {
            if (n == 0)
            {
                result = "There are 0 discs";
            }
            if (n == 1)
            {
                result = $"{result} Move: {n}, {origin}, {destine} \n"; 
            }
            else
            {
                Move(n - 1, origin, destine, aux);
                result = $"{result} Move: 1, {origin}, {destine}";
                Move(n - 1, aux, origin, destine);
            }
        }
    }
}
