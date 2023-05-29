lista = []
while True:
    numero = int(input('Digite um número:'))
   
    if numero == 0:
        break
    else: 
     
     lista.append(numero)

valor = lista [0]
for item in lista:
    if item <valor:
        valor = item
        print(valor)

print(lista)
print(valor)

print(lista)


