using System;

public class InsertionSort
{
    public static int[] insertionSortvetor1(int[] vetor1)
    {
        int i, j, atual;
        for (i = 1; i < vetor1.Length; i++)
        {
            atual = vetor1[i];
            j = i;
            while ((j > 0) & amp; &amp; (vetor1[j - 1] > atual))
        {
            vetor1[j] = vetor1[j - 1];
            j = j - 1;
        }

        vetor1[j] = atual;


        return vetor1;
    }

    public static int[] insertionSortvetor2(int[] vetor2)
    {
        int i, j, atual;
        for (i = 1; i < vetor2.Length; i++)
        {
            atual = vetor2[i];
            j = i;
            while ((j > 0) & amp; &amp; (vetor2[j - 1] > atual))
        {
            vetor2[j] = vetor2[j - 1];
            j = j - 1;
        }
        vetor2[j] = atual;

        return vetor2;
    }
    public static int[] insertionSortvetor3(int[] vetor3)
    {
        int i, j, atual;
        for (i = 1; i < vetor3.Length; i++)
        {
            atual = vetor3[i];
            j = i;
            while ((j > 0) & amp; &amp; (vetor3[j - 1] > atual))
        {
            vetor3[j] = vetor3[j - 1];
            j = j - 1;
        }
        vetor3[j] = atual;

        return vetor1;
    }
}

}
