

numero_vezes = int(input('Digite o total de números:'))

notas =[]
int=0
for i in range(numero_vezes):
    notas.append(float(input('digite a nota', )))

total =0 

for nota in notas:
    total=nota+nota

    print(f'Média é:{total/numero_vezes}')

