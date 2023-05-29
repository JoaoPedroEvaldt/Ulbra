while True:
    print(f' Avaliação número:{contador}')
    print(' Escolha se o avaliado é 1- mulher | 2- Homem | 3 -SAIR ')
    opcao = int(input(' Digite a opcão desejada:'))
    contador = contador + 1
    if opcao == 1:
        nome = int(input(' Digite o nome a ser avaliado:'))
        idade = int(input('Digite a idade da avaliada:'))
        tempo = int(input(' Digite o tempo de contribuição da avaliada: '))
        if idade >= 55 and tempo >=30: 
            print(f' Parabéns {nome} você pode se aposentar, bom descanso!')
        else:
            print(f' sinto muito {nome}, você ainda não pode se aposentar!') 
    elif opcao == 2:
        nome = int(input(' Digite o nome a ser avaliado:'))
        idade = int(input('Digite a idade da avaliada:'))
        tempo = int(input(' Digite o tempo de contribuição da avaliada: '))
        if idade >= 60 and tempo >= 35:
             print(f' Parabéns {nome} você pode se aposentar, bom descanso!')
        else:
            print(f' sinto muito {nome}, você ainda não pode se aposentar!') 
    elif opcao == 3:
        print(' Saindo do programa...') 
        break
    else:
        print(' Digite uma  opção válida')       


