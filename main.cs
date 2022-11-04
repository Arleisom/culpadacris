using System;

class Program 
{
  public static void Main (string[] args) 
  {
    string nomeEmpresarial;
   string numerodeins;
    string CEP;
    string conhecido;
    string cnpj;
    string logradouro;
    string uf;
    string municipio;
    string bairrodistrito;
    
    Console.WriteLine ("Digite seu Nome da Empresa:  :");
    nomeEmpresarial = Console.ReadLine();
     Console.WriteLine("");

    Console.WriteLine(" Digite o Numero de inscrição : ");
    numerodeins = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Digite seu CEP : ");
    CEP = Console.ReadLine();
    Console.WriteLine("");
  

    Console.WriteLine("Por qual Nome as pessoas geralmente conhecem a empresa :");
      conhecido = Console.ReadLine();
    Console.WriteLine("");

      Console.WriteLine(" Agora digite seu CNPJ :");
      cnpj = Console.ReadLine();
     Console.WriteLine("");

    Console.WriteLine(" Digite seu logradouro : ");
    logradouro = Console.ReadLine();
     Console.WriteLine("");

     Console.WriteLine("Agora o seu UF : ");
    uf = Console.ReadLine();
     Console.WriteLine("");

     Console.WriteLine("Qual seu Municipio ? ");
    municipio = Console.ReadLine();
    Console.WriteLine("");
    
    Console.WriteLine("Qual Bairro/Distrito se localiza a Empresa ? :");
    bairrodistrito = Console.ReadLine(); 
    Console.WriteLine("");
   
  
  }
}