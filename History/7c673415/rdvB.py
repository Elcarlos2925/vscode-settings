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
def busqueda_binaria (lista,valor) :
    steps = 0
    for i , item in enumerate (lista) :
        steps+=1
        if item ==valor :
            return "Valor encontrado en {} pasos en la posicion {}." .format (steps, i)
    return "Elemento no encontrado."

lista = [1,2,3,4,5,6,7,8,9,10]
busqueda =busqueda_binaria(lista,10)
print(busqueda)