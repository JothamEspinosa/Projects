# -*- coding: utf-8 -*-
"""
Created on Sun Mar 20 11:56:49 2022

@author: jothamespinosa
"""

from numpy import linalg
import matplotlib.pyplot as plt
from numpy import matmul
import numpy as np  # this package supports a powerful N-dimentioon array object 
from sys import exit
import scipy.linalg as la
e = []
v = []
# Form a 3x3 matrix
#A = [[5,2,1],[2,6,3],[1,3,7]]
#A = [[1,0,0],[0,2,0],[0,0,3]]

A = np.array([[2,4],[-1,3]]) # using np.array we turn the values into a matrix
b = np.array([[3],[-1]])
Ab = A.dot(b) #dot() method is used to multiply two matrices

#print(Ab)
print(A, 'is the matrix we are using to find the Eigenvalues & Eigenvectors:')

eigvals, eigvecs = la.eig(A)
print(eigvals,':Eigenvalues')
print(eigvecs, ':Eigenvectors')

eigvals = eigvals.real
print(eigvals)

lambda1 = eigvals[1]
print(lambda1)

v1 = eigvecs[:,1].reshape(2,1)
print(v1)

B = lambda1 * v1
print(B)







#nrows = 2

#ncols = 2
#for i in range(0,nrows):
 #   sum = 0
 #   for j in range(0,ncols):
 #       sum = sum + A[i,j]*b
 #  #  Ab[] = ????    

#print(Ab)


# Find the eigenvalues (e) and the eigenvectors (v) of matrix A
#e,v = linalg.eig(A)
#print(e)
#print(v)

# Extract the first column eigenvector
#v1 = v[:,0]

#print(v1)
# Multiply A times the first eigenvector
#Av1 = A @ v1
#print(Av1)
# e(0) is the first eigenvalue
#print(e[0]*v1)
