
public class VetorClientes {
    private Cliente[] clientes;
    private int tamanhoAtual;

    public VetorClientes(int capacidade) {
        this.clientes = new Cliente[capacidade];
        this.tamanhoAtual = 0;
    }

    // Adiciona um cliente ao vetor
    public boolean adicionar(Cliente cliente) {
        if (tamanhoAtual >= clientes.length) {
            System.out.println("Vetor cheio! Não foi possível adicionar o cliente: " + cliente.getNome());
            return false;
        }
        clientes[tamanhoAtual] = cliente;
        tamanhoAtual++;
        return true;
    }

    // Listar todos os clientes
    public void listarClientes() {
        if (tamanhoAtual == 0) {
            System.out.println("Nenhum cliente armazenado.");
        } else {
            for (int i = 0; i < tamanhoAtual; i++) {
                System.out.println(clientes[i]);
            }
        }
    }

    // Buscar cliente pelo nome
    public Cliente buscarPorNome(String nome) {
        for (int i = 0; i < tamanhoAtual; i++) {
            if (clientes[i].getNome().equalsIgnoreCase(nome)) {
                return clientes[i];
            }
        }
        return null;
    }

    // Filtrar clientes pelo domínio do email
    public void filtrarPorDominio(String dominio) {
        boolean encontrado = false;
        for (int i = 0; i < tamanhoAtual; i++) {
            if (clientes[i].getEmail().endsWith(dominio)) {
                System.out.println(clientes[i]);
                encontrado = true;
            }
        }
        if (!encontrado) {
            System.out.println("Nenhum cliente encontrado com o domínio: " + dominio);
        }
    }

    // Alterar cliente em uma posição específica
    public boolean alterarCliente(int posicao, Cliente novoCliente) {
        if (posicao < 0 || posicao >= tamanhoAtual) {
            System.out.println("Posição inválida.");
            return false;
        }
        clientes[posicao] = novoCliente;
        return true;
    }

    // Remover cliente em uma posição específica
    public boolean removerCliente(int posicao) {
        if (posicao < 0 || posicao >= tamanhoAtual) {
            System.out.println("Posição inválida.");
            return false;
        }
        for (int i = posicao; i < tamanhoAtual - 1; i++) {
            clientes[i] = clientes[i + 1];
        }
        tamanhoAtual--;
        clientes[tamanhoAtual] = null;
        return true;
    }
}
