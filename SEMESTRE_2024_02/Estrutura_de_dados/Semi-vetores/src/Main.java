public class Main {
    public static void main(String[] args) {
        VetorClientes vetor = new VetorClientes(20);

        // Criando e adicionando 30 clientes
        for (int i = 1; i <= 30; i++) {
            Cliente cliente = new Cliente("Cliente " + i, "12345-6789", "cliente" + i + "@exemplo.com");
            vetor.adicionar(cliente); // Tratará automaticamente os casos de vetor cheio
        }

        // Alterando um cliente específico
        Cliente novoCliente = new Cliente("Cliente Alterado", "98765-4321", "alterado@exemplo.com");
        vetor.alterarCliente(0, novoCliente);

        // Removendo um cliente específico
        vetor.removerCliente(5);

        // Inserindo um novo cliente em uma posição específica
        vetor.adicionar(new Cliente("Cliente Novo", "00000-0000", "novo@exemplo.com"));

        // Listando todos os clientes
        System.out.println("\nClientes armazenados:");
        vetor.listarClientes();

        // Buscando um cliente pelo nome
        System.out.println("\nBuscando cliente 'Cliente 10':");
        Cliente clienteBuscado = vetor.buscarPorNome("Cliente 10");
        System.out.println(clienteBuscado != null ? clienteBuscado : "Cliente não encontrado.");

        // Filtrando clientes por domínio de email
        System.out.println("\nFiltrando clientes com email que termina em '@exemplo.com':");
        vetor.filtrarPorDominio("@exemplo.com");
    }
}
