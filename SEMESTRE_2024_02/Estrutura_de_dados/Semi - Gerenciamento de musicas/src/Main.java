import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Playlist playlist = new Playlist();
        Scanner scanner = new Scanner(System.in);

        int opcao;

        do {
            System.out.println("\nBem-vindo ao seu Gerenciador de Músicas!");
            System.out.println("1. Próxima música");
            System.out.println("2. Música anterior");
            System.out.println("3. Ordenar playlist por título");
            System.out.println("4. Tocar música");
            System.out.println("5. Adicionar música");
            System.out.println("6. Remover música");
            System.out.println("7. Listar músicas");
            System.out.println("8. Sair");
            System.out.print("Digite a opção desejada: ");
            opcao = scanner.nextInt();
            scanner.nextLine(); // Consumir a quebra de linha

            switch (opcao) {
                case 1 -> playlist.proximaMusica();
                case 2 -> playlist.musicaAnterior();
                case 3 -> {
                    playlist.ordenarPorTitulo();
                    System.out.println("Playlist ordenada por título.");
                }
                case 4 -> playlist.tocarMusica();
                case 5 -> {
                    System.out.print("Digite o título da música: ");
                    String titulo = scanner.nextLine();
                    System.out.print("Digite o artista: ");
                    String artista = scanner.nextLine();
                    System.out.print("Digite o álbum: ");
                    String album = scanner.nextLine();
                    System.out.print("Digite a duração (segundos): ");
                    int duracao = scanner.nextInt();
                    scanner.nextLine(); // Consumir a quebra de linha
                    System.out.print("Digite a posição (início, fim ou índice): ");
                    String posicao = scanner.nextLine();
                    int indice = 0;
                    if (posicao.equalsIgnoreCase("índice")) {
                        System.out.print("Digite o índice: ");
                        indice = scanner.nextInt();
                        scanner.nextLine();
                    }
                    Musica novaMusica = new Musica(titulo, artista, album, duracao);
                    playlist.adicionarMusica(novaMusica, posicao, indice);
                }
                case 6 -> {
                    System.out.print("Digite o título da música a ser removida: ");
                    String titulo = scanner.nextLine();
                    if (playlist.removerMusica(titulo)) {
                        System.out.println("Música removida com sucesso.");
                    } else {
                        System.out.println("Música não encontrada.");
                    }
                }
                case 7 -> playlist.listarMusicas();
                case 8 -> System.out.println("Saindo...");
                default -> System.out.println("Opção inválida.");
            }
        } while (opcao != 8);

        scanner.close();
    }
}
