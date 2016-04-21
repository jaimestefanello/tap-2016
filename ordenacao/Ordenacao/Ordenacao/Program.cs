using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("Escolha o algoritmo");
                Console.WriteLine("1. InsertionSort");
                Console.WriteLine("2. SelectionSort");
                Console.WriteLine("3. QuickSort");
                Console.WriteLine("4. ShellSort");
                Console.WriteLine("5. MergeSort");
                Console.WriteLine("Qualquer outra opção: Sair");
                int.TryParse(Console.ReadLine(), out opcao);

                if (opcao == 0)
                {
                    Console.WriteLine("Saindo...");
                }
                else
                {
                    if (opcao == 1)
                    {
                        // Cria o Contador tempo de Execução
                        Stopwatch sw = new Stopwatch();

                        //Gera os 100 números do vetor automatico/aleatoriamente
                        Random randNum = new Random();
                        int[] vet = new int[100];
                        for (int x = 0; x < vet.Length; x++)
                        {
                            vet[x] = randNum.Next(100);
                        }


                        //Chama a função ImprimeLista e mostra o vetor inicial na tela
                        Console.WriteLine();
                        Console.Write("Algoritmo InsertSort");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Vetor original: ");
                        ImprimeLista(vet);
                        Console.WriteLine();

                        sw.Reset();
                        // Começa a contar o tempo
                        sw.Start();

                        InsertionSort(vet);


                        // Para de contar o tempo
                        sw.Stop();

                        Console.WriteLine();
                        Console.Write("Vetor ordenado: ");
                        ImprimeLista(vet);
                        Console.WriteLine();


                        Console.WriteLine();
                        Console.Write("Tempo de Execução: " + sw.Elapsed.TotalMilliseconds.ToString());
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    if (opcao == 2)
                    {
                        // Cria o Contador tempo de Execução
                        Stopwatch sw = new Stopwatch();

                        //Gera os 100 números do vetor automatico/aleatoriamente
                        Random randNum = new Random();
                        int[] vet = new int[100];
                        for (int x = 0; x < vet.Length; x++)
                        {
                            vet[x] = randNum.Next(100);
                        }


                        //Chama a função ImprimeLista e mostra o vetor inicial na tela
                        Console.WriteLine();
                        Console.Write("Algoritmo SelectionSort");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Vetor original: ");
                        ImprimeLista(vet);
                        Console.WriteLine();

                        sw.Reset();
                        // Começa a contar o tempo
                        sw.Start();

                        SelectionSort(vet);


                        // Para de contar o tempo
                        sw.Stop();

                        Console.WriteLine();
                        Console.Write("Vetor ordenado: ");
                        ImprimeLista(vet);
                        Console.WriteLine();


                        Console.WriteLine();
                        Console.Write("Tempo de Execução: " + sw.Elapsed.TotalMilliseconds.ToString());
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    if (opcao == 3)
                    {
                        // Cria o Contador tempo de Execução
                        Stopwatch sw = new Stopwatch();

                        //Gera os 100 números do vetor automatico/aleatoriamente
                        Random randNum = new Random();
                        int[] vet = new int[100];
                        for (int x = 0; x < vet.Length; x++)
                        {
                            vet[x] = randNum.Next(100);
                        }


                        //Chama a função ImprimeLista e mostra o vetor inicial na tela
                        Console.WriteLine();
                        Console.Write("Algoritmo QuickSort");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Vetor original: ");
                        ImprimeLista(vet);
                        Console.WriteLine();

                        sw.Reset();
                        // Começa a contar o tempo
                        sw.Start();

                        Quicksort(vet, 0, vet.Length - 1);


                        // Para de contar o tempo
                        sw.Stop();

                        Console.WriteLine();
                        Console.Write("Vetor ordenado: ");
                        ImprimeLista(vet);
                        Console.WriteLine();


                        Console.WriteLine();
                        Console.Write("Tempo de Execução: " + sw.Elapsed.TotalMilliseconds.ToString());
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    if (opcao == 4)
                    {
                        // Cria o Contador tempo de Execução
                        Stopwatch sw = new Stopwatch();

                        //Gera os 100 números do vetor automatico/aleatoriamente
                        Random randNum = new Random();
                        int[] vet = new int[100];
                        for (int x = 0; x < vet.Length; x++)
                        {
                            vet[x] = randNum.Next(100);
                        }


                        //Chama a função ImprimeLista e mostra o vetor inicial na tela
                        Console.WriteLine();
                        Console.Write("Algoritmo ShellSort");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Vetor original: ");
                        ImprimeLista(vet);
                        Console.WriteLine();

                        sw.Reset();
                        // Começa a contar o tempo
                        sw.Start();

                        ShellSort(vet);


                        // Para de contar o tempo
                        sw.Stop();

                        Console.WriteLine();
                        Console.Write("Vetor ordenado: ");
                        ImprimeLista(vet);
                        Console.WriteLine();


                        Console.WriteLine();
                        Console.Write("Tempo de Execução: " + sw.Elapsed.TotalMilliseconds.ToString());
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    if (opcao == 5)
                    {
                        // Cria o Contador tempo de Execução
                        Stopwatch sw = new Stopwatch();

                        //Gera os 100 números do vetor automatico/aleatoriamente
                        Random randNum = new Random();
                        int[] vet = new int[100];
                        for (int x = 0; x < vet.Length; x++)
                        {
                            vet[x] = randNum.Next(100);
                        }


                        //Chama a função ImprimeLista e mostra o vetor inicial na tela
                        Console.WriteLine();
                        Console.Write("Algoritmo MergeSort");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Vetor original: ");
                        ImprimeLista(vet);
                        Console.WriteLine();

                        sw.Reset();
                        // Começa a contar o tempo
                        sw.Start();

                        vet = MergeSort(vet);


                        // Para de contar o tempo
                        sw.Stop();

                        Console.WriteLine();
                        Console.Write("Vetor ordenado: ");
                        ImprimeLista(vet);
                        Console.WriteLine();


                        Console.WriteLine();
                        Console.Write("Tempo de Execução: " + sw.Elapsed.TotalMilliseconds.ToString());
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
            } while (opcao != 0);


        }

        static void ImprimeLista(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i].ToString() + ",");
            }
            Console.WriteLine();
        }

        public static int[] InsertionSort(int[] vet)
        {
            //Criação das variaveis j e aux
            int j;
            int aux;
            //Execução do algoritmo InsertSort
            //For que vai de i = 1 até quado i for menor que o número de possições do vetor
            for (int i = 1; i < vet.Length; i++)
            {
                //Variavel j recebe a possição do vetor que esta sendo executado no for
                j = i;

                while ((j > 0) && (vet[j - 1] > vet[j])) // Válida que enquanto j>0 e vet[j-1]> vet[j] 
                {
                    aux = vet[j - 1];//aux = 8
                    vet[j - 1] = vet[j];// vet[1]= 6
                    vet[j] = aux; //vet[2]= 8
                    j--;
                }

            }

            return vet;
        }


        public static int[] SelectionSort(int[] vet)
        {
            int j;
            int i;
            int _min = 0;
            //Percore até o penultimo numero
            for (i = 0; i < vet.Length - 1; i++)
            {
                //Pega o indice de i
                _min = i;

                //Percore novamente o vetor para achar o menor elemento
                for (j = i; j < vet.Length; j++)
                {
                    //se achar min recebe o indice
                    if (vet[j] < vet[_min])
                        _min = j;
                }
                int _temp = vet[i];
                vet[i] = vet[_min];
                vet[_min] = _temp;
            }

            return vet;
        }


        public static void Quicksort(int[] vet, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = vet[(left + right) / 2];

            while (i <= j)
            {
                while (vet[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (vet[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Faz a troca
                    int tmp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = tmp;

                    i++;
                    j--;
                }
            }

            //Chamadas Recursivas
            if (left < j)
            {
                Quicksort(vet, left, j);
            }

            if (i < right)
            {
                Quicksort(vet, i, right);
            }
        }


        public static int[] ShellSort(int[] vet)
        {
            int h = 1;
            int n = vet.Length;
            while (h < n)
                h = h * 3 + 1;

            int c, j;

            while (h > 0)
            {
                h = h / 3;
                for (int i = h; i < n; i++)
                {
                    c = vet[i];
                    j = i;
                    while (j >= h && vet[j - h] > c)
                    {
                        vet[j] = vet[j - h];
                        j = j - h;
                    }
                    vet[j] = c;

                }
            }

            return vet;
        }


        public static int[] Merge(int[] left, int[] right)
        {
            // Converte as matrizes de entrada para as listas , o que dá mais flexibilidade
            // E a opção de redimensionar as matrizes dinamicamente.
            List<int> leftList = left.OfType<int>().ToList();
            List<int> rightList = right.OfType<int>().ToList();
            List<int> resultList = new List<int>();

            // Enquanto a sub-lista não estão vazias fundi-los repetidamente para produzir novas sublists
            // Até ​​que haja apenas uma sub-lista restante. Esta será a lista ordenada .
            while (leftList.Count > 0 || rightList.Count > 0)
            {
                if (leftList.Count > 0 && rightList.Count > 0)
                {
                    // Compare os 2 lista , acrescentar o elemento mais pequeno para a lista de resultados
                    // E removê-lo da lista original.
                    if (leftList[0] <= rightList[0])
                    {
                        resultList.Add(leftList[0]);
                        leftList.RemoveAt(0);
                    }

                    else
                    {
                        resultList.Add(rightList[0]);
                        rightList.RemoveAt(0);
                    }
                }

                else if (leftList.Count > 0)
                {
                    resultList.Add(leftList[0]);
                    leftList.RemoveAt(0);
                }

                else if (rightList.Count > 0)
                {
                    resultList.Add(rightList[0]);
                    rightList.RemoveAt(0);
                }
            }

            // Converte a lista resultante de volta para uma matriz estática
            int[] result = resultList.ToArray();
            return result;
        }

        public static int[] MergeSort(int[] array)
        {
            // Se o tamanho da lista é 0 ( vazio ) ou 1, consideram- classificado e devolvê-lo
            // ( Usando menos do que ou igual impede recursão infinita para uma matriz de comprimento zero ) .
            if (array.Length <= 1)
            {
                return array;
            }

            // Tamanho da lista Else for> 1 , então dividir a lista em duas sub-listas .
            int middleIndex = (array.Length) / 2;
            int[] left = new int[middleIndex];
            int[] right = new int[array.Length - middleIndex];

            Array.Copy(array, left, middleIndex);
            Array.Copy(array, middleIndex, right, 0, right.Length);

            // Chame recursivamente mergesort () para dividir ainda mais cada sublista
            // Até ​​o tamanho sublista é 1.
            left = MergeSort(left);
            right = MergeSort(right);

            // Mesclar as sublists retornado de chamadas anteriores a mergesort ()
            // E devolver o sub-lista mesclada resultante .
            return Merge(left, right);
        }

    }
}

