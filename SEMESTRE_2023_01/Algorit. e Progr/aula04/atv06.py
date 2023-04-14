base=float(input('Digite a base do triangulo'))
lado =  float(input('digite o lado do triangulo'))
lado2 = float(input('digite o outro lado do triangulo'))
if base == lado == lado2 :
    print('o triangulo é equilátero')
elif lado==lado2 or lado==base or lado2==base:  
    print('triângulo é isósceles')
else: 
    print('"O triângulo é escaleno')