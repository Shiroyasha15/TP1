using System;

public class BubbleSort
{

    public static int[] bubbleSortvetor1(int[] vetor1)
    {
        int tamanho = vetor1.Length;
        int comparacoes = 0;
        int trocas = 0;

        for (int i = tamanho - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                comparacoes++;
                if (vetor1[j] > vetor1[j + 1])
                {
                    int aux = vetor1[j];
                    vetor1[j] = vetor1[j + 1];
                    vetor1[j + 1] = aux;
                    trocas++;
                }
            }
        }

        return vetor1;
    }

    public static int[] bubbleSortvetor2(int[] vetor2)
    {
        int tamanho = vetor2.Length;
        int comparacoes = 0;
        int trocas = 0;

        for (int i = tamanho - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                comparacoes++;
                if (vetor2[j] > vetor2[j + 1])
                {
                    int aux = vetor2[j];
                    vetor2[j] = vetor2[j + 1];
                    vetor2[j + 1] = aux;
                    trocas++;
                }
            }
        }

        return vetor2;
    }

    public static int[] bubbleSortvetor3(int[] vetor3)
    {
        int tamanho = vetor3.Length;
        int comparacoes = 0;
        int trocas = 0;

        for (int i = tamanho - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                comparacoes++;
                if (vetor3[j] > vetor3[j + 1])
                {
                    int aux = vetor3[j];
                    vetor3[j] = vetor3[j + 1];
                    vetor3[j + 1] = aux;
                    trocas++;
                }
            }
        }

        return vetor3;
    }

}
}
