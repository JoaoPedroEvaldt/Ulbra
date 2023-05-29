while True:
    valor_a_ser_convertido = float(input('Digite a temperatura a ser convertida:\n'))
    entrada=int(input('Qual a temperatura de entrada:\1 - Celsius \n 2- Fahreint \n 3- Keven'))
    saida=int(input('Qual a temperatura de entrada:\1 - Celsius \n 2- Fahreint \n 3- Keven'))
    if entrada == 1:
        if saida ==1:
            print(f'Valor igual seu bobão{valor_a_ser_convertido}')
        if saida == 2:
            valor_a_ser_convertido=(valor_a_ser_convertido - 32)/9
            print(f'Valor em Fahreint{valor_a_ser_convertido}')
        if saida == 3:
            
