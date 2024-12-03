public class Node {
    private Musica musica;
    private Node proximo;
    private Node anterior;

    public Node(Musica musica) {
        this.musica = musica;
        this.proximo = null;
        this.anterior = null;
    }

    public Musica getMusica() {
        return musica;
    }

    public Node getProximo() {
        return proximo;
    }

    public void setProximo(Node proximo) {
        this.proximo = proximo;
    }

    public Node getAnterior() {
        return anterior;
    }

    public void setAnterior(Node anterior) {
        this.anterior = anterior;
    }
}
