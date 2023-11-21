import random
def Quicksort(array):
        if len(array)<=1:
            return array
        r=array.pop()

        p=[]#list 1
        q=[]#list 2
        for i in array:
            if i <= r:
                p.append(i)
            else:
                q.append(i)
        p=Quicksort(p)
        q=Quicksort(q)
        return p + [r] + q
    
lista = [int(random.randint(0,100)) for i in range (20)]#LISTA PARA ALMACENAR 20 ELEMENTOS
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{lista}")#IMPRIMIR LISTA ALEATORIA
print(Quicksort(lista))