using static System.Net.Mime.MediaTypeNames;

class BubbleSort
{
    static void bubbleSort(int[] tablica)
    {
        int temp = 0;
        for (int i = 0; i < tablica.Length - 1; i++)
        {
            for (int j = 0; j < tablica.Length - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                }
            }
        }
    } 
    static void insertSort(int[] tablica)
    {

        for (int i = 1; i < tablica.Length; i++)
        {
            int temp = tablica[i];
            int j = i - 1;
            while (j >= 0 && tablica[j] > temp)
            {

                tablica[j + 1] = tablica[j];
                j--;
            }
            tablica[j + 1] = temp;
        }
    }
    static void mergeSort(int[] tablica)
    {
        int lenght = tablica.Length;
        if (lenght <= 1) return;
        int middle = lenght / 2;
        int[] leftarray = new int[middle];
        int[] rightarray = new int[lenght - middle];
        for (int i = 0; i < middle; i++)
        {
            leftarray[i] = tablica[i];
        }
        for (int i = middle; i < lenght; i++)
        {
            rightarray[i - middle] = tablica[i];
        }
        mergeSort(leftarray);
        mergeSort(rightarray);
        merge(leftarray, rightarray, tablica);
    }
    static void merge(int[] leftarray, int[] rightarray, int[] tablica)
    {
        int leftsize = leftarray.Length;
        int rightsize = rightarray.Length;
        int l = 0; int r = 0; int i = 0;
        while (l < leftsize && r < rightsize)
        {
            if (leftarray[l] < rightarray[r])
            {
                tablica[i] = leftarray[l];
                l++;
                i++;
            }
            else
            {
                tablica[i] = rightarray[r];
                r++;
                i++;

            }
        }
        while (l < leftsize)
        {
            tablica[i] = leftarray[l];
            l++; i++;
        }
        while (r < rightsize)
        {
            tablica[i] = rightarray[r];
            r++; i++;
        }

    }
    static void quicksort(int[] array, int start, int end) 
    {
        if (end <= start) return;
        int pivot=partition(array, start, end);
        quicksort(array, start, pivot-1);
        quicksort(array,pivot+1, end);
    
    }
    static int partition(int[] array, int start, int end)
    {
        int pivot = array[end];
        int i = start - 1;
        for (int j = start; j <= end-1; j++) { 
            if(array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            
        }
        i++;
        int temp1 = array[i];
        array[i] = array[end];
        array[end] = temp1;
    
        return i;
    }
    static void CountingSort(int[] array)
    {
        int max = array.Max(); // Znajdź maksymalny element w tablicy
        int min = array.Min(); // Znajdź minimalny element (dla przesunięcia, jeśli są liczby ujemne)
        int range = max - min + 1; // Zakres wartości w tablicy

        int[] count = new int[range]; // Tablica zliczająca
        int[] output = new int[array.Length]; // Tablica wynikowa

        // Zliczanie wystąpień
        for (int i = 0; i < array.Length; i++)
        {
            count[array[i] - min]++;
        }

        // Kumulacja
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        // Umieszczanie elementów w posortowanej tablicy
        for (int i = array.Length - 1; i >= 0; i--)
        {
            output[count[array[i] - min] - 1] = array[i];
            count[array[i] - min]--;
        }

        // Przepisanie wyników do pierwotnej tablicy
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = output[i];
        }
    }



    [STAThread]
        static void Main()
        {


            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        //bubbleSort(array);
        //insertSort(array);
        //mergeSort(array);
        //quicksort(array,0,array.Length-1);
        CountingSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }

    
