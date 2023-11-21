import random
def pedirNumero(lista):
    num=int(input("\nHumano por favor ingresa un numero de la lista anterior:"))
    return num
def busquedaSecuencia(lista,num):
    for i in range(0,len(lista)):
        if num==lista[i]:
            return True
    return False
lista = [int(random.randint(0,100)) for i in range (20)]
print (lista)
while True:
    num=pedirNumero(lista)
    encontrado=busquedaSecuencia(lista,num)
    if encontrado==True:
        print("Felicidades humano haz colocado un numero de la lista ahora dame la patita:)")
        break
    else:
        print("Humano tonto intentalo de nuevo:")