using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // red, Dark blue, Light blue, grey, yellow, purple, orange, green
            int[,] adjacencyMatrix =
            {//              Red     DarkBlue  Yellow   LightBlue  Purple     Grey     Orange     Green
            /*Red      */   {(-1),    ( 1),     (-1),      (-1),    (-1),     ( 5),     (-1),     (-1)},
            /*DarkBlue */   {(-1),    (-1),     ( 8),      ( 1),    (-1),     (-1),     (-1),     (-1)},
            /*Yellow   */   {(-1),    (-1),     (-1),      (-1),    (-1),     (-1),     (-1),     ( 6)},
            /*LightBlue*/   {(-1),    ( 1),     (-1),      (-1),    (-1),     ( 0),     (-1),     (-1)},
            /*Purple   */   {(-1),    (-1),     ( 1),      (-1),    (-1),     (-1),     (-1),     (-1)},
            /*grey     */   {(-1),    (-1),     (-1),      ( 0),    (-1),     (-1),     ( 1),     (-1)},
            /*Orange   */   {(-1),    (-1),     (-1),      (-1),    ( 1),     (-1),     (-1),     (-1)},
            /*Green    */   {(-1),    (-1),     (-1),      (-1),    (-1),     (-1),     (-1),     (-1)}
            };

            (int, int)[][] adjacencyList = new (int, int)[8][];
            /*Red      */  adjacencyList[0] = new (int, int)[] {(1, 1), (5, 5)};
            /*DarkBlue */  adjacencyList[1] = new (int, int)[] {(2, 8), (3, 1)};
            /*Yellow   */  adjacencyList[2] = new (int, int)[] {(7, 6) };
            /*LightBlue*/  adjacencyList[3] = new (int, int)[] {(1, 1), (5, 0) };
            /*Purple   */  adjacencyList[4] = new (int, int)[] {(2, 1) };
            /*grey     */  adjacencyList[5] = new (int, int)[] {(3, 0), (6, 1) };
            /*Orange   */  adjacencyList[6] = new (int, int)[] {(4, 1) };
            /*Green    */  adjacencyList[7] = new (int, int)[] { };
        }
    }
}
