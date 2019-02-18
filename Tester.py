import clr
clr.AddReference(r'..\CsLibrary\bin\Release\CsLibrary.dll')
from CsLibrary import PyWrapper
wrapper = PyWrapper()

x = 1.23
y = 2.34

print(wrapper.Add(x, y))
print(wrapper.Subtract(x, y))
print(wrapper.Multiply(x, y))
print(wrapper.Divide(x, y))