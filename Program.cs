
using Atividade_Back_End.Classes;

string opcao = "";
PessoaJuridica PJ =new PessoaJuridica();

do{
        Console.WriteLine(@"
        1 - Cadastrar
        2 - Sair");
        opcao=Console.ReadLine();

        if (opcao =="1"){
            PessoaJuridica pj = new PessoaJuridica();
            Console.WriteLine("Digite o Nome da pessoa juridica");
            pj.Nome =Console.ReadLine ;
            
            


        }
}
while (opcao !="2");
{
    
}


