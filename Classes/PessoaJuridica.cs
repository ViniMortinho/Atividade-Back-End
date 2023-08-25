using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Back_End.Classes
{
    public class PessoaJuridica
    {
        public string? Cnpj { get; set; }
       

        //metodo para inserir um objeto em arquivo txt
            public void inserir(PessoaJuridica pj){
                using(StreamWriter sw =new StreamWriter($"{pj.Nome}"))
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.Cnpj}");
                }
}  
}