public class ListaEncadeada {
    private No primeiro;

    public ListaEncadeada() {
        this.primeiro = null;
    }

    public void inserir(int elemento) {
        No novoNo = new No(elemento);

        if (primeiro == null) {
            primeiro = novoNo;
        } else {
            No noAtual = primeiro;
            while (noAtual.proximo != null) {
                noAtual = noAtual.proximo;
            }
            noAtual.proximo = novoNo;
        }
    }
}
