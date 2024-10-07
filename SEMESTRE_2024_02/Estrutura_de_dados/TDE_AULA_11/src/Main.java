public class Main {
    public static void main(String[] args) {
        ListaEncadeada<Integer> lista = new ListaEncadeada<>();
        lista.adicionarNoFim(10);
        lista.adicionarNoFim(20);
        lista.adicionarNoInicio(5);
        lista.adicionarNaPosicao(2, 15);

        System.out.println("Lista: " + lista);
        System.out.println("Remover do fim: " + lista.removerDoFim());
        System.out.println("Lista: " + lista);
        System.out.println("Buscar valor na posição 1: " + lista.buscar(1));
        System.out.println("Tamanho: " + lista.tamanho());
        lista.limpar();
        System.out.println("Lista após limpar: " + lista);
    }
}
