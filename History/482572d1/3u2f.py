# mostrar un menú con las tres opciones (Actualizar Valor Dollar, Compra y Venta), en base a la opción que el usuario seleccione realizar la operación correspondiente.
compra=0
venta=0
dollares=0
opc=1
compra=float(input("ingrese el valor de compra: "))
venta=float(input("ingrese el valor de venta: "))
while (opc==1):
 Menú=int(input("<<<QUÉ OPERACIÓN DESEA REALIZAR>>>   \n\t 1. ACTUALIZAR VALOR \n\t 2. COMPRA \n\t 3. VENTA\n\t--->"))
 if(Menú==1):
    compra=float(input("Ingrese el nuevo valor de compra: "))
    venta=float(input("Ingrese el nuevo valor de venta: "))
    print(f"El valor del dolar se a actualizado correctamente\n\t COMPRA = {compra}\n\t VENTA = {venta}")
 elif(Menú==2):
    dollares=float(input("Cuantos dolares desea comprar: "))
    dollares_compra = dollares * compra
    print(dollares_compra)
 elif(Menú==3):
    dollares=float(input("Cuantos dolares desea vender: "))
    dollares_venta = dollares * venta
    print(dollares_venta)
 else:
    print("** opción no valida **")
 opc=int(input("Desea realizar otra acción: 1. Si / 2. No \n\t--->"))
 if (opc==1):
    print(f"\n\t COMPRA = {compra}\n\t VENTA = {venta}")
 elif (opc==2):
    print("Hasta pronto, gracias por utilizar este programa")
 else:
    print("** opcbión no valida **")