from sympy import simplify, diff, limit
from sys import argv

def fix(expresion: str) -> str:
    #Arregla las expresiones para permitir la entrada de nuevas características no disponibles de base de sympy

    #Tupla con tuplas que contienen las diferentes maneras de escribir algo y su corrección al lenguaje de sympy
    TRADUCCIONES = (('sen, sin'), ('csc', '1/sin'), ('sec', '1/cos'), ('cot', '1/tan'))

    for modismo in TRADUCCIONES:    #por modismo se entiende las distintas maneras de escribir lo mismo
        expresion = expresion.replace(modismo[0], modismo[1])

    return expresion


match argv[1]:
    case 'S':
        print(simplify(fix(argv[2])))

    case 'D':
        #   2: variable   3: expresión    
        print(simplify(diff(fix(argv[3]), argv[2])))

    case 'L':
        #   2: variable   3: tendencia    4: expresion
        ecuación_arreglada = fix(argv[4])
        if(limit(ecuación_arreglada, argv[2], argv[3], '-') != limit(ecuación_arreglada, argv[2], argv[3], '+')):
            print("Este límite no existe porque sus límites laterales son diferentes")
        else:
            print(limit(ecuación_arreglada, argv[2], argv[3]))