nome = input("Digite o nome da pessoa: ")

sexo = input("Digite o sexo da pessoa (M ou F): ")

idade = int(input("Digite a idade da pessoa: "))

tempo_contribuicao = int(input("Digite o tempo de contribuição da pessoa (em anos): "))

if sexo == "F":
        if idade >= 55 and tempo_contribuicao >= 30:
            print(nome + " pode requerer a aposentadoria.")
        else:
            print(nome + " não pode requerer a aposentadoria.")
elif sexo == "M":
        if idade >= 60 and tempo_contribuicao >= 35:
            print(nome + " pode requerer a aposentadoria.")
        else:
            print(nome + " não pode requerer a aposentadoria.")
else:
        print("Sexo inválido.")

contador_consultas = 0

while True:
    print("Digite 1 para consultar a aposentadoria de uma pessoa.")
    print("Digite 2 para sair do programa.")
    opcao = input()

    if opcao == "1":
        contador_consultas += 1
        print("Consulta número " + str(contador_consultas))
        
    elif opcao == "2":
        break
    else:
        print("Opção inválida. Digite novamente.")





