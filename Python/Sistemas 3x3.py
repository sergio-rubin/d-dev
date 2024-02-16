from os import system

def imprimir_matriz(matriz, nombre, determinante):
    print(f"\n{nombre}: (({matriz[0][0]})({matriz[1][1]})({matriz[2][2]}) + ({matriz[1][0]})({matriz[2][1]})({matriz[0][2]}) + ({matriz[2][0]})({matriz[0][1]})({matriz[1][2]})) - (({matriz[0][2]})({matriz[1][1]})({matriz[2][0]}) + ({matriz[1][2]})({matriz[2][1]})({matriz[0][0]}) + ({matriz[2][2]})({matriz[0][1]})({matriz[1][0]})) = {matriz[0][0] * matriz[1][1] * matriz[2][2] + matriz[1][0] * matriz[2][1] * matriz[0][2] + matriz[2][0] * matriz[0][1] * matriz[1][2]} - {matriz[0][2] * matriz[1][1] * matriz[2][0] + matriz[1][2] * matriz[2][1] * matriz[0][0] + matriz[2][2] * matriz[0][1] * matriz[1][0]} = {determinante}")
    
    for fila in matriz:
        print(fila)


while True:
    a1, b1, c1, d1 = int(input("a1 = ")), int(input("b1 = ")), int(input("c1 = ")), int(input("d1 = "))
    a2, b2, c2, d2 = int(input("\na2 = ")), int(input("b2 = ")), int(input("c2 = ")), int(input("d2 = "))
    a3, b3, c3, d3 = int(input("\na3 = ")), int(input("b3 = ")), int(input("c3 = ")), int(input("d3 = "))

    numerador_x = (d1 * b2 * c3 + d2 * b3 * c1 + d3 * b1 * c2) - (c1 * b2 * d3 + c2 * b3 * d1 + c3 * b1 * d2)
    numerador_y = (a1 * d2 * c3 + a2 * d3 * c1 + a3 * d1 * c2) - (c1 * d2 * a3 + c2 * d3 * a1 + c3 * d1 * a2)
    numerador_z = (a1 * b2 * d3 + a2 * b3 * d1 + a3 * b1 * d2) - (d1 * b2 * a3 + d2 * b3 * a1 + d3 * b1 * a2)
    denominador_comun = (a1 * b2 * c3 + a2 * b3 * c1 + a3 * b1 * c2) - (c1 * b2 * a3 + c2 * b3 * a1 + c3 * b1 * a2)

    imprimir_matriz(((a1, b1, c1), (a2, b2, c2), (a3, b3, c3)), "Matriz de los coeficientes de las incógnitas", denominador_comun)
    imprimir_matriz(((d1, b1, c1), (d2, b2, c2), (d3, b3, c3)), "Numerador de x", numerador_x)
    imprimir_matriz(((a1, d1, c1), (a2, d2, c2), (a3, d3, c3)), "Numerador de y", numerador_y)
    imprimir_matriz(((a1, b1, d1), (a2, b2, d2), (a3, b3, d3)), "Numerador de z", numerador_z)

    print(f"\nx = {numerador_x} / {denominador_comun} = {numerador_x / denominador_comun}\ny = {numerador_y} / {denominador_comun} = {numerador_y / denominador_comun}\nz = {numerador_z} / {denominador_comun} = {numerador_z / denominador_comun}\n")
    input("Presiona enter para ingresar otro sistema")
    system('cls')