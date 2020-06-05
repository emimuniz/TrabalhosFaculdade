Application word = new Application();
Document document = word.Documents.Open(@"c:\matar\teste.docx");
String text, aux, tipo = "";
int linha = 1;

int count = document.Words.Count;
for (int i = 1; i <= count; i++)
{
    text = document.Words[i].Text;

    for (int j = 0; j < text.Length; j++)
    {
        aux = "";
        if (text[j] == 13)
        {
            linha++;
            break;
        }
        else if (char.IsDigit(text[j]))
        {
            tipo = "Inteiro";
            do
            {
                aux += text[j];
                j++;
            } while (j < text.Length && char.IsDigit(text[j]));
        }
        else if (char.IsLetter(text[j]))
        {
            tipo = "String ";
            do
            {
                aux += text[j];
                j++;
            } while (j < text.Length && char.IsLetter(text[j]));
        }
        else
        {
            tipo = "Simbolo";
            aux += text[j];
        }

        Console.WriteLine("Linha {0} ({1})...: {2}", linha, tipo, aux);
        Console.ReadKey();
    }
}

word.Documents.Close();
word.Quit();
