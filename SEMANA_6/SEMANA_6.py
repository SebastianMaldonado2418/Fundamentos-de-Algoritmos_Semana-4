# num = int(input("Ingrese número de la tabla: "))

#while num <= 0:
#    num = int(input("Número invalido: Ingrese número de la tabla: "))

#i=1
#print()
#while i <=12:
#    print(f"{num} x {i} = {num*i}")
#    i+=1

while True:
    num = int(input("Ingrese número positivo (0 salir): "))

    if num < 0:
        print("Número invalido. Ingrese número positivo: ")
        continue
    if (num == 0):
        break

    if num%2  ==0:
        sumaP += num;
    else:
        sumaI +=  num;

print("\nSuma de pres: ", sumaP)
print("\nSuma de impares: ", sumaI)