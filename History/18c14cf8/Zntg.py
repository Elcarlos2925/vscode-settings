import random
class QuickSort:
    def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista20 = []

    def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista20.append(item)

    def intercambia(self, A, x, y):
        tmp = A[x]
        A[x] = A[y]
        A[y] = tmp

    def Particionar(self, A, p, r):
        x = A[r]
        i = p - 1
        for j in range(p, r):
            if (A[j] <= x):
                i = i + 1
                self.intercambia (A, i, j)
        self.intercambia(A, i+1, r)
        return i + 1

    def QuickSort(self, A, p, r):
        if (p < r):
            q = self.Particionar(A, p, r)
            #print (A[p:r])
            self.QuickSort(A, p, q-1)
            self.QuickSort(A, q+1, r)
        return A

    def ordenar(self, A):
        p = 0
        r = len(A) - 1
        q = int((p + r) / 2)
        return self.QuickSort(A, p, r)

def main():
    lista = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]#LISTA PARA ALMACENAR 20 ELEMENTOS
    Lista=Ordenamiento_Quicksort()
    for i in range(len(lista)):#VECTOR PARA ALMACENAR ELEMENTOS
      Lista.add()#AGREGAR ELEMENTO A LA LISTA
    print(f"\t\t\t <<<LISTA DE ELEMENTOS>>>\n{Lista.lista20}")#IMPRIMIR LISTA ALEATORIA
    print(sort(lista))