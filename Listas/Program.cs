using System;
using System.Collections.Generic;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista1 = new List<string>();//Criando uma lista vazia

            lista1.Add("Maria"); //Inserir elemento na lista
            lista1.Add("Alex");
            lista1.Add("Bob");
            lista1.Add("Anna");
            lista1.Insert(2, "Felipe"); //INSERIR NA LISTA passando o index e o valor


            foreach (string objLista in lista1)
            {
                Console.WriteLine(objLista);
            }

            string ListaA = lista1.Find(x => x[0] == 'A');//Função tipo Lambida
            Console.WriteLine("Primeira da Lista A: " + ListaA);
            //Varrer lista e encontrar Tal Valor...

            int pos1 = lista1.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição Começando com A: " + pos1);
            //Achar tal posição de um valor na lista
            
            int pos2 = lista1.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição que começa com A: " + pos2);
            //Achar ultima posição de tal valor.

            List<string> listaResultadoFiltro = lista1.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------");
            foreach(string objFiltro in listaResultadoFiltro)
            {
                Console.WriteLine(objFiltro);
            }
            //Lista de Filtragem instaciando nossa lista carregadas 
            //Dps Fazendo um foreach varrendo ela com o filtro.

            lista1.RemoveAt(3);  //List1.Remove("Ana")
            //Removendo um valor de uma lista or removenod um valor pelo index
            foreach(string obj in lista1)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------");

            lista1.RemoveAll(x => x[0] == 'M');
            foreach(string obj in lista1)
            {
                Console.WriteLine(obj);
            }
            //Removendo tal valor especifico.

            


            Console.WriteLine("Valor Máximo da Lista: " + lista1.Count);
        }   // Valor total da lista
           
          



    }
}