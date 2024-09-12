using EF1;


using (var db = PessoaDbContext())
{
    var pessoas = db.Pessoas;
    foreach (Pessoa p in pessoas)
    {
        Console.WriteLine(p.PessoaNome + "nasceu em " + p.PessoaCidade);
    }
            
    
}