public class No<T> {
    T valor;
    No<T> anterior;
    No<T> proximo;

    public No(T dado) {
        this.valor = dado;
        this.anterior = null;
        this.proximo = null;
    }


}