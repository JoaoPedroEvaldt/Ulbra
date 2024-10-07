public class ListaEncadeada<T> {
    private Node<T> inicio;
    private int tamanho;

    public ListaEncadeada() {
        this.inicio = null;
        this.tamanho = 0;
    }

    public void adicionarNoInicio(T valor) {
        Node<T> novoNo = new Node<>(valor);
        novoNo.setProximo(inicio);
        inicio = novoNo;
        tamanho++;
    }

    public void adicionarNoFim(T valor) {
        Node<T> novoNo = new Node<>(valor);
        if (estaVazia()) {
            inicio = novoNo;
        } else {
            Node<T> atual = inicio;
            while (atual.getProximo() != null) {
                atual = atual.getProximo();
            }
            atual.setProximo(novoNo);
        }
        tamanho++;
    }

    public void adicionarNaPosicao(int posicao, T valor) {
        if (posicao < 0 || posicao > tamanho) {
            throw new IndexOutOfBoundsException("Posição inválida.");
        }
        if (posicao == 0) {
            adicionarNoInicio(valor);
        } else {
            Node<T> novoNo = new Node<>(valor);
            Node<T> atual = inicio;
            for (int i = 0; i < posicao - 1; i++) {
                atual = atual.getProximo();
            }
            novoNo.setProximo(atual.getProximo());
            atual.setProximo(novoNo);
            tamanho++;
        }
    }

    public T removerDoInicio() {
        if (estaVazia()) {
            throw new IllegalStateException("Lista vazia.");
        }
        Node<T> removido = inicio;
        inicio = inicio.getProximo();
        tamanho--;
        return removido.getValor();
    }

    public T removerDoFim() {
        if (estaVazia()) {
            throw new IllegalStateException("Lista vazia.");
        }
        if (tamanho == 1) {
            return removerDoInicio();
        }
        Node<T> atual = inicio;
        while (atual.getProximo().getProximo() != null) {
            atual = atual.getProximo();
        }
        Node<T> removido = atual.getProximo();
        atual.setProximo(null);
        tamanho--;
        return removido.getValor();
    }

    public T removerDaPosicao(int posicao) {
        if (posicao < 0 || posicao >= tamanho) {
            throw new IndexOutOfBoundsException("Posição inválida.");
        }
        if (posicao == 0) {
            return removerDoInicio();
        }
        Node<T> atual = inicio;
        for (int i = 0; i < posicao - 1; i++) {
            atual = atual.getProximo();
        }
        Node<T> removido = atual.getProximo();
        atual.setProximo(removido.getProximo());
        tamanho--;
        return removido.getValor();
    }

    public T removerPorValor(T valor) {
        if (estaVazia()) {
            throw new IllegalStateException("Lista vazia.");
        }
        if (inicio.getValor().equals(valor)) {
            return removerDoInicio();
        }
        Node<T> atual = inicio;
        while (atual.getProximo() != null && !atual.getProximo().getValor().equals(valor)) {
            atual = atual.getProximo();
        }
        if (atual.getProximo() == null) {
            return null;
        }
        Node<T> removido = atual.getProximo();
        atual.setProximo(removido.getProximo());
        tamanho--;
        return removido.getValor();
    }

    public T buscar(int posicao) {
        if (posicao < 0 || posicao >= tamanho) {
            throw new IndexOutOfBoundsException("Posição inválida.");
        }
        Node<T> atual = inicio;
        for (int i = 0; i < posicao; i++) {
            atual = atual.getProximo();
        }
        return atual.getValor();
    }

    public int buscarPosicao(T valor) {
        Node<T> atual = inicio;
        for (int i = 0; i < tamanho; i++) {
            if (atual.getValor().equals(valor)) {
                return i;
            }
            atual = atual.getProximo();
        }
        return -1;
    }

    public void atualizar(int posicao, T novoValor) {
        if (posicao < 0 || posicao >= tamanho) {
            throw new IndexOutOfBoundsException("Posição inválida.");
        }
        Node<T> atual = inicio;
        for (int i = 0; i < posicao; i++) {
            atual = atual.getProximo();
        }
        atual.setValor(novoValor);
    }

    public int tamanho() {
        return tamanho;
    }

    public boolean estaVazia() {
        return tamanho == 0;
    }

    public void limpar() {
        inicio = null;
        tamanho = 0;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        Node<T> atual = inicio;
        while (atual != null) {
            sb.append(atual.getValor()).append(" -> ");
            atual = atual.getProximo();
        }
        sb.append("null");
        return sb.toString();
    }
}
