# -*- coding: utf-8 -*-
"""
Created on Sat Jan 29 06:21:25 2022

@author jothamespinosa
"""

# Importing libraries 
import numpy as np
from numpy import random
import math
import random
from sys import exit
import sys
# Import library to plot the arrays
import matplotlib.pyplot as plt

# Define the sigmoid function
def sigmoid(z):
    return 1./(1. + math.exp(-z))

# Define the derivative of the sigmoid function
def derivative_sigmoid(z):
    return sigmoid(z)*(1.0-sigmoid(z))

# Compute the dot product of the weights and add the bias
def weight_inputs(x,weights):
    dota = weights[0]
    for i in range(0,ninputs):
        dota = dota + weights[i+1]*x[i]
    z = dota
    sigma = sigmoid(dota)  
    return sigma,z

# Compute the gradient of the cost function with respect to each weight
def gradient(x,yp,y,z):
    
    i = 0
    grad[i] = 0.0
    for k in range(0,ntrain):
        grad[i] = grad[i] + (y[k] -  yp[k])*derivative_sigmoid(z[k])
    grad[i] = -2.0*grad[i]/float(ntrain)
    
    for i in range(0,ninputs):
       grad[i+1] = 0.0
       for k in range(0,ntrain):
           grad[i+1] = grad[i+1] + (y[k] -  yp[k])*derivative_sigmoid(z[k])*x[k,i]
       grad[i+1] = -2.0*grad[i+1]/float(ntrain)
       
    return grad
    

max_iterations = 5000 # Maximum iterations for the learning algorithm to converge
ntrain = 200 # Number of training sets
ntest = 20 # Number of test sets
ninputs = 16 # Number of inputs
ninputso2 = ninputs//2 # Half the number of inputs


x = np.zeros((ntrain,ninputs),dtype='float') # Array storing the ntrain sets of ninputs
y = np.zeros(ntrain,dtype='float') # Array storing the ntrain expected values

yp = np.zeros(ntrain,dtype='float') # Array storing the ntrain expected values
z = np.zeros(ntrain,dtype='float') # Array storing the ntrain z values
xx = np.zeros(ninputs,dtype='float')
weights = np.zeros(ninputs+1,dtype='float') # Weights used in neural network
grad = np.zeros(ninputs+1,dtype='float') # Gradient of cost function

xtest = np.zeros((ntest,ninputs),dtype='float') # Array storing the ntest sets of ninputs
ytest = np.zeros(ntest,dtype='float') # Array storing the ntest expected values
yptest = np.zeros(ntest,dtype='float') # Array storing the ntest predicted values
ztest = np.zeros(ntest,dtype='float') # Array storing the ntest z values
yguess = np.zeros(ntest,dtype='float') # Predicted values of y values (0 or 1) using sigmoid function

alpha = .1 # Learning parameter

# Construct the training set
for k in range(0,ntrain):
    sum1 = 0.0
    sum2 = 0.0
    for i in range(0,ninputs):
        x[k,i] = random.random()

        
         
        sum1 = sum1 + (x[k,0] + x[k,1] + x[k,2] + x[k,3] + x[k,4] + x[k,5] + x[k,8]+ x[k,9])
        
        sum2 = sum2 + (x[k,6]+ x[k,7]+ x[k,10]+ x[k,11]+ x[k,12]+ x[k,13]+ x[k,14]+ x[k,15])
        
        
    if (sum1 > sum2):
        y[k] = 1
    else:
        y[k] = 0
            
# Construct the test set           
for k in range(0,ntest):
    sum1 = 0.0
    sum2 = 0.0
    for i in range(0,ninputs):
        xtest[k,i] = random.random()

        
        sum1 = sum1 + (xtest[k,0] + xtest[k,1] + xtest[k,2] + xtest[k,3] + xtest[k,4] + xtest[k,5] + xtest[k,8]+ xtest[k,9])
       
        sum2 = sum2 + (xtest[k,6]+ xtest[k,7]+ xtest[k,10]+ xtest[k,11]+ xtest[k,12]+ xtest[k,13]+ xtest[k,14]+ xtest[k,15])
           
           
    if (sum1 > sum2):
        ytest[k] = 1
    else:
        ytest[k] = 0            
  
# Assign random values to weights            
for i in range(0,ninputs+1):
    weights[i] = random.random()  

cost = 1.0
nit = 0
# Iterate until the neural network is converged
while (cost > .0001 and nit < max_iterations):   

   nit = nit + 1 # Increment the number of iterations       

#  Compute the cost function
   cost = 0.0
   for k in range(0,ntrain):
    
       xx = x[k,:] # Extract the inputs from the k'th training set
       yp[k],z[k] = weight_inputs(xx,weights)
       cost = cost + (y[k]-yp[k])**2

   cost = cost/float(ntrain) 
   
   print('Cost function =',cost)     
 
   grad = gradient(x,yp,y,z)   
 
   for i in range(0,ninputs+1):  
       weights[i] = weights[i] - alpha*grad[i] 
       
print("Cost function value = ",cost)
exit()

# Determine how well the weights perform on the test sets  
error = 0.0
for k in range(0,ntest):

    xx = xtest[k,:] # Extract the inputs from the k'th training set
    yptest[k],ztest[k] = weight_inputs(xx,weights)
    if (yptest[k] > .5):
        yguess[k] = 1
    else:
        yguess[k] = 0
        
    error = error + (ytest[k]-yguess[k])**2
    print(ytest[k],yguess[k])
error = error/float(ntest)  

print('Accuracy = ',100*(1 -error))
     



