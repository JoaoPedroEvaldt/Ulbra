lista = []
while True:
    nome = input("Digite um nome: ")
    if nome == "sair":
        break
    else:
        lista.append(nome)

    teste = 0
    nova_lista = []

for nome in lista:
    if len(nome) > teste:
        teste = len(nome)
        nova_lista = [nome]
    elif len(nome) == teste:
        nova_lista.append(nome)

print("Nomes mais longos:")

for nome in nova_lista:
    print(nome)