pedido = []
descricao = []
while True:
 #menu
    print("TERMINAL DE VENDAS")
    print('Menu de Produtos')
    print('1   -  ÁGUA')
    print('2   -  REFRI')
    print('3   -  CAFÉ')
    print('4   -  Pão de queijo')
    print('5   -  IMPRIMIR LISTA')
    print('6   -  ENCERRAR VENDA ')
    print('7   -  SAIR' )

    opc = int(input('Digite o código do produto:'))
    if opc == 1:
        pedido.append (3.00)
        descricao.append('Água  -  R$ 3.00')
    elif opc == 2:
        pedido.append(6.00)     
    elif opc == 3:
        pedido.append(5.00)  
    elif opc == 4:
        pedido.append(10.00) 
    elif opc == 5:
        print(descricao) 
    elif opc == 6:
        print(sum(pedido))
    elif opc == 7:
        break
    else:
        print('Digite uma opção válida!')      
  
