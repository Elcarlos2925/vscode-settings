import random
                                                                                                
def busquedaSecuencia(array,numero):
    for i in range(0,len(array)):
        if numero==array[i]:
                print("Encontrado")
                print(f"El número que desea buscar es el número {numero}\nA sido encontrado con {i+1} iteraciones\nEl número se encuentra en la pocisión {i} de la lista")
                break
    return("Elemento no encontrado.")

lista = [int(random.randint(0,100)) for i in range (20)]
print (lista)
num=int(input("\nHumano por favor ingresa un numero de la lista anterior:"))
encontrado=busquedaSecuencia(lista,num)