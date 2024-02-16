import matplotlib.pyplot as plt
import numpy as np
import sympy as sp
from sys import argv
import mpmath as mp

expression = 'x'
# Crear el objeto expr
x = sp.Symbol('x')
expr = sp.lambdify(x, expression, 'numpy')

# Generar el conjunto de datos x, y
x_data = np.linspace(-10, 10, 400)
y_data = expr(x_data)

# Graficar la función ingresada por el usuario
plt.plot(x_data, y_data)
plt.title('Gráfica de la función')
plt.xlabel('x')
plt.ylabel('y')
plt.grid(True)
plt.show()