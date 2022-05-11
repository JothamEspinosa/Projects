# -*- coding: utf-8 -*-
"""
Created on Sun Mar 20 11:56:49 2022

@author: jothamespinosa
"""

from numpy import linalg

import cmath
import math
from sys import exit
#e = []
#v = []
# Form a 3x3 matrix
#A = [[5,2,1],[2,6,3],[1,3,7]]
#A = [[1,0,0],[0,2,0],[0,0,3]]

#A = [[5,4],[3,2]]
#b = [[3],[-1]]
#Ab = [] 
 
#User input of 4 integers
a= int(input("Enter 1st Integer = " ))
b= int(input("Enter 2nd Integer = " ))
c= int(input("Enter 3rd Integer = " ))
d= int(input("Enter 4th Integer = " ))

#Values for variables within the quadratic equation 
A = 1 
B = -a-d
C = a*d - b*c

D= B**2- (4*A*C)

if D >= 0:
    #math.sqrt to get the square root of D
     e1 = (-B + math.sqrt(D))/(2*A)
     e2 = (-B - math.sqrt(D))/(2*A)
      
else:
    #cmath.sqrt if there is an imaginary number with the square root
    e1 = (-B + cmath.sqrt(D))/(2*A)
    e2 = (-B - cmath.sqrt(D))/(2*A)

#print above values based on requirments 
print("Eiganvalues=", e1, e2)
     #Exit here for no interference from previous code     
exit() 







# Find the eigenvalues (e) and the eigenvectors (v) of matrix A
e,v = linalg.eig(A)
print(e)
print(v)

# Extract the first column eigenvector
v1 = v[:,0]

print(v1)
# Multiply A times the first eigenvector
Av1 = A @ v1
print(Av1)
# e(0) is the first eigenvalue
print(e[0]*v1)
