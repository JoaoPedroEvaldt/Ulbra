salario1 = float(input('Digite o seu salario:'))
imposto_10 = (salario1/100) * 10
imposto_20 = (salario1/100) * 20

print(f'valor á ser pago{imposto_10}')
print(f' valor á ser pago {imposto_20}')

if salario1 > 1.000:
    print(' O valor do seu salário é:', salario1 - imposto_10)

elif salario1 > 2.000:
    print( ' o valor do salário é de:', salario1 - imposto_20)    

else:
    print( ' Você está insento!')    
