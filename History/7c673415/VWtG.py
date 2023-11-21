
import random
def Dicotomica (array,numero) :
    for i , item in enumerate (array) :
        if item ==numero :
            return f"El número que desea buscar es el número {(numero)} \nA sido encontrado en tan solo {i} iteraciones\nEl número {numero} se encuentra en la posición {i+1} de la lista."
    return "Elemento no encontrado."

lista = [int(random.randint(0,100)) for i in range (20)]
print (lista)
Num=int(input("Que número desea buscar en la lista\n\t--->"))
buscar =Dicotomica(lista,Num)
print(buscar)