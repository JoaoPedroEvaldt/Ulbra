# Loop principal do programa
while True:
    print("Selecione uma opção:")
    print("1. Criar aluno")
    print("2. Ler alunos")
    print("3. Buscar aluno por ID")
    print("4. Atualizar aluno")
    print("5. Excluir aluno")
    print("0. Sair")

    opcao = input("Digite o número da opção desejada: ")

    if opcao == "1": # Cadastro do aluno
        pass

    elif opcao == "2": # Consultar aluno
        pass

    elif opcao == "3": #Busca aluno por ID
        pass
        id_busca = int(input('Digite o ID do aluno que deseja buscar:'))
        encontrado = False
        for aluno in aluno:
            if aluno[0]==id_busca:
                print('ID:', aluno[0])
                print('Nome:', aluno[1])
                print('Idade:',aluno[2])
                encontrado = True
                break
        if not encontrado:
            print('Aluno não encontrado.')    

    elif opcao == "4": # Atualiza por ID
        pass

    elif opcao == "5": # Excluir Aluno
        pass

    elif opcao == "0": # SAIR DO PROGRAMA
        break

    else:
        print("Opção inválida. Por favor, digite novamente.")