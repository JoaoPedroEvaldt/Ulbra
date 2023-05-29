while True:
    lista= [1,2,3,4]
    print('qual forma geometrica você deseja calcular')

    print('digite 1 - circulo| 2 - quadrado| 3 - retangulo| 4 - sair ') #menu

    opcao = int(input('digite a opção desejada:'))
    if opcao in [1,2,3,4]:
        if opcao == 1:
            pi = 3.14
            raio=int(input('digite o raio do circulo:'))
            area = pi * raio ** 2
            print(f' a area do circulo é {area}')

    elif opcao == 2:
        lado = int(input('digite o lado do quadrado:'))  
        area = lado ** 2

    elif opcao == 3:
        lado = int(input('digite o lado do retângulo:'))
        altura = int(input('digite a altura do retângulo:'))          
        area = lado ** 2
        print(f' Á area do quadrado é {area}')

    else:
        print('saindo...')
        break
else:
    print('digite uma opção valida!')   