# mostrar un menú con las tres opciones (Actualizar Valor Dollar, Compra y Venta), en base a la opción que el usuario seleccione realizar la operación correspondiente.

Menú=int(input("<<<QUÉ OPERACIÓN DESEA REALIZAR>>>   \n\t 1. ACTUALIZAR VALOR \n\t 2. COMPRA \n\t 3. VENTA"))
dollar=0
if(Menú==1):
    dollar=float(input("Ingrese el nuevo valor del dolar: "))
    print(f"El valor del dolar se a actualizado correctamente\nEL VALOR DE DOLAR ES DE {dollar}")
