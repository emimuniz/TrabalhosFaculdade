public static void main(String[] args) 
{
        ObjectContainer db;     
        Scanner sc = new Scanner(System.in);
        System.out.println("Digite L para Livros");
        System.out.println("Digite P para Pessoas");
        String option = sc.nextLine();
        if("L".equals(option))

{
            Livro umlivro = new Livro();
            ObjectSet<Livro> lista;
            db = Db4o.openFile("meubanco.dbo");
            lista = db.get(Livro.class); 
            while (lista.hasNext())
{
                umlivro = lista.next();
                System.out.println(umlivro.getTitulo());
                System.out.println(umlivro.getAutor());
                System.out.println(umlivro.getEditora());
                System.out.println(umlivro.getAnoEdicao());
                System.out.println(umlivro.getLocalizacao());
            }
            db.close();
        }
else  if("P".equals(option)) 
{
            Pessoa umapessoa = new Pessoa();
            ObjectSet<Pessoa> lista;
            db = Db4o.openFile("meubanco.dbo");
            lista = db.get(Pessoa.class); 
            while (lista.hasNext())
{
                umapessoa = lista.next();            
                System.out.println(umapessoa.getNome());
                System.out.println(umapessoa.getIdade());
                System.out.println(umapessoa.getSexo());
            }
            db.close();
        }
    }
