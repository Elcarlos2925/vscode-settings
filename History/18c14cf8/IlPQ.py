import random
class Ordenamiento_Quicksort(object):
    def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista = []
    def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista.append(item)
    def  Quicksort(self,array):
        array=self.lista
        r=array[0]
        p=[]#numeros menores a r(pivote)
        q=[]#numeros mayores o igual a r(pivote)
        lenght=len(array)
        for i in range(1,lenght):
            if array [i] < r:
                p.append(array[i])
            else:
                q.append(array[i])
            return p,q,r

        if len(array)<2:
            return array
        p, q, r = array
        print(array)
        return p + [r] + q



lista = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]#LISTA PARA ALMACENAR 20 ELEMENTOS
Lista=Ordenamiento_Quicksort()
for i in range(len(lista)):#VECTOR PARA ALMACENAR ELEMENTOS
    Lista.add()#AGREGAR ELEMENTO A LA LISTA
print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{Lista.lista}")#IMPRIMIR LISTA ALEATORIA
print(Lista.Quicksort(lista))