#Algoritmo por inserción directa (Método de la baraja)

#Función para mostrar estado de la lista

def mostrarLista(lista, lon):
	listaordenada=""
	for i in range(0,lon):
		listaordenada+=str(lista[i])+" "
	print(listaordenada)   
	
arreglo = [15,67,8,16,44,27,12,35];

#Recorrer el arreglo
for i in range(1,len(arreglo)):
	clave = arreglo[i]
	j = i-1

	#Comparar el valor seleccionado con todos los valores anteriores
	while (j>=0 and arreglo[j] > clave):

		#Insertar el valor donde corresponda
		arreglo[j+1] = arreglo[j]
		j = j-1
	arreglo[j+1] = clave
	mostrarLista(arreglo, len(arreglo))
mostrarLista(arreglo, len(arreglo))