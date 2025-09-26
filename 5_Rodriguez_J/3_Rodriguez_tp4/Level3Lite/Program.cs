using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
        int[,] g =
        {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
        bool ok = Level3.CountAdjacent(g, 1, 1) == 4
               && Level3.CountAdjacent(g, 0, 0) == 2;
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
    }
}

static class Level3
{
    public static int CountAdjacent(int[,] grid, int row, int col)
    {
        // TODO: implementar
        // Considerar vecinos: (r-1,c), (r+1,c), (r,c-1), (r,c+1)
        // Devolver cuántos valen 1
        int count = 0;
        int maxRow = grid.GetLength(0); // Número de filas
        int maxCol = grid.GetLength(1); // Número de columnas

        // Definimos los 4 movimientos adyacentes: (dr, dc)
        // Arriba: (-1, 0), Abajo: (+1, 0), Izquierda: (0, -1), Derecha: (0, +1)
        int[] dr = { -1, 1, 0, 0 };
        int[] dc = { 0, 0, -1, 1 };

        // Iteramos sobre los 4 vecinos
        for (int i = 0; i < 4; i++)
        {
            int neighborRow = row + dr[i];
            int neighborCol = col + dc[i];

            // 1. Verificar límites: La posición debe estar dentro de la matriz
            bool isInBounds =
                neighborRow >= 0 && neighborRow < maxRow &&
                neighborCol >= 0 && neighborCol < maxCol;

            if (isInBounds)
            {
                // 2. Contar si el valor es 1
                if (grid[neighborRow, neighborCol] == 1)
                {
                    count++;
                }
            }
        }

        return count; // Devolvemos el total de vecinos que valen 1
    }
}