using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrota.Servicos

{
    public static class Constantes
    {
        public const string NomeArquivoBd = "frota.db3";
        
        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;
        public static string CaminhoBd
        { 
            get
            {  
                var caminhoBase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(caminhoBase, NomeArquivoBd);
            }

        }

        // também poderia ser escrito como abaixo
       /* public static string CaminhoDB => Path.Combine(
                                                Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData)
                                                , nomeArquivoBD);
       */
    }
}
