import random
                                                                                                
def busquedaSecuencia(lista,num):
    for i in range(0,len(lista)):
        if num==lista[i]:
                print("Encontrado")
        else:
            print("Humano tonto intentalo de nuevo")

lista = [int(random.randint(0,100)) for i in range (20)]
print (lista)
num=int(input("\nHumano por favor ingresa un numero de la lista anterior:"))
encontrado=busquedaSecuencia(lista,num)