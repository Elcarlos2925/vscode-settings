import random
"""
def Busqueda_binaria(array,q):
    if len (array)<=0:
        return"Lamentablemente su número no a podido ser encontrado"
    p=array[len(array)//2]
    if p == q:
        return f"Felicidades su número a sido encontrado exitosamente ({q})"
    else:
        if q<p:
            return Busqueda_binaria(array[:len(array)//2],q)
        else:
            return Busqueda_binaria(array[(len(array)//2)+1],q)

lista = [int(random.randint(0,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA

Num=int(input("Que número desea buscar en la lista\n\t--->"))
print(Busqueda_binaria(lista,Num))
"""
def Dicotomica (array,numero) :
    n = 0
    for i , item in enumerate (array) :
        n+=1
        if item ==numero :
            return f"El número que desea buscar es el número {(numero)} \nA sido encontrado en tan solo {i} iteraciones\nEl número {numero} se encuentra en la posición {i+1} de la lista."
    return "Elemento no encontrado."

lista = [int(random.randint(0,100)) for i in range (20)]
print (lista)
Num=int(input("Que número desea buscar en la lista\n\t--->"))
buscar =Dicotomica(lista,Num)
print(buscar)