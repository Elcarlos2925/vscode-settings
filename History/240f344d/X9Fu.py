import random
def merge(array1, array2):
    array3=[]
    while (len(array1)> 0 and len(array2)>0):
        print(array3)
        if array1[0]<array2[0]:
            array3.append(array1[0])
            array1=array1[1:]
        else:
            array3.append(array2[0])
            array2=array2[1:]
    if len(array1)>0:
        array3=array3+array1
    if len(array2)>0:
        array3=array3+array2
    return array3

def mergesort (array):
    if len(array)==1:
        return array
    array_izq=array[:len(array)//2]
    array_der=array[len(array)//2:]

    array_izq=mergesort(array_izq)
    array_der=mergesort(array_der)

    return merge(array_izq, array_der)

lista = [int(random.randint(0,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA
print(mergesort(lista))
