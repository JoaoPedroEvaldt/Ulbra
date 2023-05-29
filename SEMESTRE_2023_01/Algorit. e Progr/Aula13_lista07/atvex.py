lista = []
while True:
    nome = input('Digite um nome:')

    if nome.lower() == 'sair':
        break   
    else:
        lista.append(nome)



for item in lista:
     print(item)
