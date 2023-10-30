public class Mensagem {

    private string Texto;

    public void Exibir()
    {
        Console.WriteLine(this.Texto);

    }

    public string getTexto()
    {
        return this.Texto;
    }

    public void setTexto(String txt)
    {
        this.Texto = txt;

    }

    static void Main( string [] args)
    {
        Mensagem txt1, txt2; 

        txt1 = new  Mensagem();
        txt1.setTexto("CURSO AVANÇADO C#");
        txt1.Exibir();
    }
}