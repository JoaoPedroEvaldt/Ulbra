while True:
    peso = float(input('Digite o peso do paciente:'))
    altura =  float(input('Digite a altura do paciente:'))

    if peso/altura %18.5 == 24.9:
        print('O seu IMC está dentro do ideal')
    else: peso/altura % 17 == 25 
    print('O seu IMC não está ideal') 

