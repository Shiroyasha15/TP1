using System;

public class SelectionSort
{
        public static int[] selectionSortVetor1(int[] vetor1)
        {
            int min, aux;

            for (int i = 0; i < vetor1.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor1.Length; j++)
                    if (vetor1[j] < vetor1[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor1[min];
                    vetor1[min] = vetor1[i];
                    vetor1[i] = aux;
                }
            }
        return vetor1;
        }

         public static int[] selectionSortVetor2(int[] vetor2)
        {
            int min, aux;

            for (int i = 0; i < vetor2.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor2.Length; j++)
                    if (vetor2[j] < vetor2[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor2[min];
                    vetor2[min] = vetor2[i];
                    vetor2[i] = aux;
                }
            }
        return vetor2;
        }


        public static int[] selectionSortVetor3(int[] vetor3)
        {
            int min, aux;

            for (int i = 0; i < vetor3.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor3.Length; j++)
                    if (vetor3[j] < vetor3[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor3[min];
                    vetor3[min] = vetor3[i];
                    vetor3[i] = aux;
                }
            }
        return vetor3;
        }
    }
}
