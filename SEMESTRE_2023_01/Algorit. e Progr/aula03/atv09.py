distancia_final=int(input("digite o valor da distancia percorrida final"))
distancia_incial=int(input("digite o valor da distancia percorrida incial")) 
tempo_inicial=float(input("digite o tempo levado incial"))
tempo_final=float(input("digite o tempo levado final")) 

resultado = (distancia_incial - distancia_final) / (tempo_inicial - tempo_final) 

print("A velocidade média do homem foi de:", resultado)
