import random
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

Num=(str(input("Que número desea buscar en la lista\n\t--->")))
print(Busqueda_binaria(lista,Num))