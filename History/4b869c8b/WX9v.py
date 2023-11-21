import random
def busquedaSecuencia(array,n):
    for i in range(0,len(arrray)):
        if n==array[i]:
            return True
        else:
            return False
    while True:
        if True:
            print("Felicidades humano haz colocado un numero de la lista ahora dame la patita:)")
        else:
            print("Humano tonto intentalo de nuevo:")

lista = [int(random.randint(0,100)) for i in range (20)]
print (lista)
num=int(input("\nHumano por favor ingresa un numero de la lista anterior:"))
encontrado=busquedaSecuencia(lista,num)


                                                                                                
def busquedaSecuencia(lista,num):
    for i in range(0,len(lista)):
        if num==lista[i]:
            return True
    return False
lista = [int(random.randint(0,100)) for i in range (20)]
num=int(input("\nHumano por favor ingresa un numero de la lista anterior:"))
print (lista)
while True:
    encontrado=busquedaSecuencia(lista,num)
    if encontrado==True:
        print("Felicidades humano haz colocado un numero de la lista ahora dame la patita:)")
        break
    else:
        print("Humano tonto intentalo de nuevo:")