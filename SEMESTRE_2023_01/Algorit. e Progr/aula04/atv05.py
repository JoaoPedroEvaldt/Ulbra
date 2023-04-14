velocidade_inicial=float(input("Digite a velocidade inicial:"))
aceleração=float(input("Digite a Aceleração:"))
tempo=float(input("Digite o tempo de deslocamento:"))
#Processamento de Dados
movimento= velocidade_inicial + (aceleração*tempo)
#Saída de Dados
print("O movimento uniforme acelerado é:", movimento)