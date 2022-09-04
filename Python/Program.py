"""Программа, которая из имеющегося массива строк формирует массив
из строк, длина которых меньше либо равна 3 символа.
"""

def func_string_array_new (string_size, string_array):
    """Функция принимает целое число string_size и список возвращает список
    из имеющихся строк, длинна которых <= string_size
    """
    string_array_new=[]
    for string in string_array:
        if len(string) <= string_size:                
            string_array_new.append(string)   
    return string_array_new

#Набор массивов данных на выбор.

#string_array = ['1234', '1567', '-2', 'computer science']
#string_array = ['Russia', 'Denmark', 'Kazan']
string_array = ['hello', '2', 'world', ':-)']

#условие отбора
string_size = 3 

string_array_new = func_string_array_new (string_size, string_array)

print (string_array_new)





