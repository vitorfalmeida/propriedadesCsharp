using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedadesCsharp.Model
{
  public class LeituraArquivo
  {
    public (bool sucesso, String[] linhas, int QuantidadeDeLinhas)  LerArquivos(String caminho)
    {
      try
      { 
        String[] linhas = File.ReadAllLines(caminho);
        return (true, linhas, linhas.Count());
      }
      catch (Exception)
      {
        return (false, new string[0], 0);
      }

    }
  }
}