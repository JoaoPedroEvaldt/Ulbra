valor_produto = float(input("Digite o valor do produto:"))
desconto = float(input("Digite o valor do desconto:"))

valor_venda = valor_produto - (valor_produto/100*desconto)


print("O valor de venda é:",valor_venda)
