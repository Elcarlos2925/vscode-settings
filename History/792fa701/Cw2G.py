import random
class Ordenamiento_Burbuja(object):
    def __init__(self):#METODO ALMACENAMIENTO DE DATOS
        self.lista = []
    def add(self):#METODO AGREGAR ELEMENTO
        item=random.randint(1, 100)
        self.lista.append(item)
    