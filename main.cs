using System;

class Program {
  public static void Main (string[] args) {
  string convert, convert2;
  Double codigo, preco, maior, media, soma;
  
    soma = 0;
    media= 0;
    
    for (int i = 0; i < 12 ; i++)
    {
      
    Console. WriteLine("Informe o codigo do produto " + i + ":" ); 
    convert = Console.ReadLine();
    codigo = Double.Parse(convert);
    Console. WriteLine(" Qual o valor do produto" + i + ":" );
    convert2 = Console.ReadLine ();
    preco = Double.Parse(convert2);
    }
      
  }
}