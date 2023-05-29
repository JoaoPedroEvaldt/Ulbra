


import time
import os
pedido = []
while True:
#MENU
    print("TERMINAL DE VENDAS")
    print("Menu de produtos")
    print("1 - ÁGUA")
    print("2 - REFRI")
    print("3 - CAFÉ")
    print("4 - PÃO DE QUEIJO")
    print("5 - IMPRIMIR LISTA")
    print("6 - ENCERRAR VENDA")
    print("7 - SAIR")

    opc = int(input("DIGITE O CÓDIGO: "))
#    os.system('cls' if os.name == 'nt' else 'clear')
    if opc == 1:
        pedido.append(["Água - R$ 3,00", 3.00])
    elif opc == 2:
        pedido.append(["Refri - R$ 6,00", 6.00])
    elif opc == 3:
        pedido.append(["Café - R$ 5,00", 5.00])
    elif opc == 4:
        pedido.append(["Pão de Queijo - R$ 10,00", 10.00])
    elif opc == 5:
        print("----------------------------")
        print("|  Produtos Selecionados:  |")
        print("----------------------------")
        for item in pedido:
            print(item[0])
        print("----------------------------")      
        print("Pressione uma tecla para continuar...")
        input()
#        os.system('cls' if os.name == 'nt' else 'clear')          
    elif opc == 6:
        total = 0
        print("----------------------------")
        print("|  Encerramento do pedido  |")
        print("----------------------------")
        for item in pedido:
            print("|",item[0])
            total += item[1]
        print("----------------------------")
        print(f"|Total do Pedido: R$ {total:.2f}|")
        print("----------------------------")
        print("Pressione uma tecla para continuar...")
        input()
#        os.system('cls' if os.name == 'nt' else 'clear')
    elif opc == 7:
        break
    else:
        print("Digite uma opção válida!")