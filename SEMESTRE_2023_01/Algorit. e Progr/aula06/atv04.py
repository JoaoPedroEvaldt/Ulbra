valor_produto = float(input('Digite o valor do produto:'))
 
desconto = (valor_produto/100*10)

valor_desconto_extra = (valor_produto / 100 * 5)

if valor_produto <= 50.00:
    print ('valor do produto :', valor_produto - desconto)

else:
    print('valor do produto é:', valor_produto - (desconto* valor_desconto_extra))   
