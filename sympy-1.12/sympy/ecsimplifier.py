import sympy

def simplificar(expresion):
    x = sympy.simbols('x')
    return sympy.simplify(expresion, x)

def derivar(espresion, variable):
    pass