import random
def binary_insertionsort(array):
    for i in range(1, len(array)):
        temp = array[i]
        pos = binary_search(array, temp, 0, i) + 1
 
        for k in range(i, pos, -1):
            array[k] = array[k - 1]
 
        array[pos] = temp
    print(lista)

def binary_search(array, key, strt, end):
    if end - strt <= 1:
        if key < array[strt]:
            return strt - 1
        else:
            return strt

    middle = (strt + end)//2
    if array[middle] < key:
        return binary_search(array, key, middle, end)
    elif array[middle] > key:
        return binary_search(array, key, strt, middle)
    else:
        return middle




lista = [int(random.randint(0,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA
print(binary_insertionsort(lista))