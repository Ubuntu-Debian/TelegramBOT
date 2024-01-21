def gcd(a, b):
    while b != 0:
        a, b = b, a % b
    return a

def lcm(a, b):
    """
    Функция для вычисления наименьшего общего кратного (НОК).
    Используется свойство: НОК(a, b) = (a * b) / НОД(a, b)
    """
    return (a * b) // gcd(a, b)

