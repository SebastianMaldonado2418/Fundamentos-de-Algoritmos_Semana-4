cant = int(input("Ingrese la cantidad de números: "))
pares = impares = ceros = 0

print()

for i in range (1, cant+1):
    num = int(input("Ingrese número" {i} ":" ))

    if num == 0:
        ceros+=1 # ceros++
    elif num %2 == 0:
        pares += 1
    else:
        impares += 1

print("# de pares: ", pares)
print("# de Impares: ", impares)
print("# de ceros: ", ceros)  
