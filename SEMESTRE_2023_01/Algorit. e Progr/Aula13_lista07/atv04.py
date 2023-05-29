"""lista = []
while True:
    numero = int(input('Digite um número:'))
    lista.append(numero)

    soma = sum(lista)
    print(soma)
    contagem = len(lista)

    media = soma / contagem

    print(media) 
    print(sum(lista)/len(lista))
    """
def imprimir_multiplos(lista):
    for numero in lista:
        if numero % 3 == 0 and numero % 5 == 0:
            print(numero)


entrada = input("Digite uma lista de números separados por espaço: ")


numeros = list(map(int, entrada.split()))


imprimir_multiplos(numeros)