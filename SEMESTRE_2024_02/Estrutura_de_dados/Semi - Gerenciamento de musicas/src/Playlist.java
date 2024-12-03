import java.util.Scanner;

public class Playlist {
    private Node inicio;
    private Node fim;
    private Node atual;

    public Playlist() {
        this.inicio = null;
        this.fim = null;
        this.atual = null;
    }

    // Adicionar música
    public void adicionarMusica(Musica musica, String posicao, int index) {
        Node novo = new Node(musica);
        if (inicio == null) {
            inicio = fim = atual = novo;
        } else if (posicao.equalsIgnoreCase("início")) {
            novo.setProximo(inicio);
            inicio.setAnterior(novo);
            inicio = novo;
        } else if (posicao.equalsIgnoreCase("fim")) {
            fim.setProximo(novo);
            novo.setAnterior(fim);
            fim = novo;
        } else if (posicao.equalsIgnoreCase("posicao")) {
            if (index <= 0) {
                adicionarMusica(musica, "início", 0);
            } else {
                Node temp = inicio;
                int contador = 0;

                while (temp != null && contador < index - 1) {
                    temp = temp.getProximo();
                    contador++;
                }

                if (temp == null || temp.getProximo() == null) {
                    adicionarMusica(musica, "fim", 0);
                } else {
                    novo.setProximo(temp.getProximo());
                    novo.setAnterior(temp);
                    temp.getProximo().setAnterior(novo);
                    temp.setProximo(novo);
                }
            }
        }
    }

    // Remover música
    public boolean removerMusica(String titulo) {
        Node temp = inicio;
        while (temp != null) {
            if (temp.getMusica().getTitulo().equalsIgnoreCase(titulo)) {
                if (temp == inicio) {
                    inicio = temp.getProximo();
                    if (inicio != null) inicio.setAnterior(null);
                } else if (temp == fim) {
                    fim = temp.getAnterior();
                    if (fim != null) fim.setProximo(null);
                } else {
                    temp.getAnterior().setProximo(temp.getProximo());
                    temp.getProximo().setAnterior(temp.getAnterior());
                }
                return true;
            }
            temp = temp.getProximo();
        }
        return false;
    }

    // Listar músicas
    public void listarMusicas() {
        Node temp = inicio;
        if (temp == null) {
            System.out.println("A playlist está vazia.");
        } else {
            while (temp != null) {
                System.out.println(temp.getMusica());
                temp = temp.getProximo();
            }
        }
    }

    // Ordenar por critério
    public void ordenarPorTitulo() {
        if (inicio == null) return;

        boolean trocou;
        do {
            Node temp = inicio;
            trocou = false;

            while (temp.getProximo() != null) {
                if (temp.getMusica().getTitulo().compareToIgnoreCase(temp.getProximo().getMusica().getTitulo()) > 0) {
                    // Trocar os nós
                    Musica aux = temp.getMusica();
                    temp.setMusica(temp.getProximo().getMusica());
                    temp.getProximo().setMusica(aux);
                    trocou = true;
                }
                temp = temp.getProximo();
            }
        } while (trocou);
    }

    // Tocar música atual
    public void tocarMusica() {
        if (atual != null) {
            System.out.println("Reproduzindo: " + atual.getMusica());
        } else {
            System.out.println("Nenhuma música está sendo reproduzida.");
        }
    }

    // Próxima música
    public void proximaMusica() {
        if (atual != null && atual.getProximo() != null) {
            atual = atual.getProximo();
            tocarMusica();
        } else {
            System.out.println("Você já está na última música.");
        }
    }

    // Música anterior
    public void musicaAnterior() {
        if (atual != null && atual.getAnterior() != null) {
            atual = atual.getAnterior();
            tocarMusica();
        } else {
            System.out.println("Você já está na primeira música.");
        }
    }
}
