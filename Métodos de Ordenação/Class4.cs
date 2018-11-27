using System;

public class QuickSort
{

    public static int[] quickSort1(int[] vetor1)
    {
        int inicio = 0;
        int fim = vetor1.Length - 1;

        quickSort1(vetor1, inicio, fim);

        return vetor1;
    }

    private static void quickSort1(int[] vetor1, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int p = vetor1[inicio];
            int i = inicio + 1;
            int f = fim;

            while (i <= f)
            {
                if (vetor1[i] <= p)
                {
                    i++;
                }
                else if (p < vetor1[f])
                {
                    f--;
                }
                else
                {
                    int troca = vetor1[i];
                    vetor1[i] = vetor1[f];
                    vetor1[f] = troca;
                    i++;
                    f--;
                }
            }

            vetor1[inicio] = vetor1[f];
            vetor1[f] = p;

            quickSort1(vetor1, inicio, f - 1);
            quickSort1(vetor1, f + 1, fim);
        }
    }

    public static int[] quickSort2(int[] vetor1)
    {
        int inicio = 0;
        int fim = vetor1.Length - 1;

        quickSort1(vetor1, inicio, fim);

        return vetor1;
    }

    private static void quickSort2(int[] vetor2, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int p = vetor2[inicio];
            int i = inicio + 1;
            int f = fim;

            while (i <= f)
            {
                if (vetor2[i] <= p)
                {
                    i++;
                }
                else if (p < vetor2[f])
                {
                    f--;
                }
                else
                {
                    int troca = vetor2[i];
                    vetor2[i] = vetor2[f];
                    vetor2[f] = troca;
                    i++;
                    f--;
                }
            }

            vetor2[inicio] = vetor2[f];
            vetor2[f] = p;

            quickSort2(vetor2, inicio, f - 1);
            quickSort2(vetor2, f + 1, fim);
        }
    }
    public static int[] quickSort3(int[] vetor3)
    {
        int inicio = 0;
        int fim = vetor3.Length - 1;

        quickSort3(vetor3, inicio, fim);

        return vetor3;
    }

    private static void quickSort3(int[] vetor3, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int p = vetor3[inicio];
            int i = inicio + 1;
            int f = fim;

            while (i <= f)
            {
                if (vetor3[i] <= p)
                {
                    i++;
                }
                else if (p < vetor3[f])
                {
                    f--;
                }
                else
                {
                    int troca = vetor3[i];
                    vetor3[i] = vetor3[f];
                    vetor3[f] = troca;
                    i++;
                    f--;
                }
            }

            vetor3[inicio] = vetor3[f];
            vetor3[f] = p;

            quickSort1(vetor3, inicio, f - 1);
            quickSort1(vetor3, f + 1, fim);
        }
    }
}