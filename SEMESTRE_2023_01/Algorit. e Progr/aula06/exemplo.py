
while True:
    try:
        nota = int(input('Digite a nota:'))
    except ValueError:
        print('digite um inteiro:')  
        continue
    if nota == 0:
        print( 'VOCÊ SAIU DO PROGRAMA')
        break
    elif nota >=  7:
        print ('você passou')
    else:
        print( 'você rodou')    

        except ValueError: 
        print('digite um inteiro')
        continue