import random
                                                                                                
def busquedaSecuencia(lista,num):
    for i in range(0,len(lista)):
        if num==lista[i]:
                print("Encontrado")
                print(f"El número que desea buscar es el número {num}\nA sido encontrado con {i+1} iteraciones\nEl número se encuentra en la pocisión {i} de la lista")
                break
    return "Elemento no encontrado."

lista = [int(random.randint(0,100)) for i in range (20)]
print (lista)
num=int(input("\nHumano por favor ingresa un numero de la lista anterior:"))
encontrado=busquedaSecuencia(lista,num)