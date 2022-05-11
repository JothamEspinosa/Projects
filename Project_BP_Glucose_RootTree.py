# -*- coding: utf-8 -*-
"""
Created on Thu Apr 28 17:28:59 2022

@author: Jotham Espinosa
"""
import pandas as pd
from sys import exit


col_names = ['glucose','bp','outcome']
output_names = ['0', '1']
pima = pd.read_csv("diabetesv.csv")
X = pima[col_names]
y = pima['outcome']

xa = pima.to_numpy() # Extract number of rows in file
nrows = xa.shape[0]


Glucose = 0
No_Glucose = 0
BP = 0
No_BP = 0 
Positive_Outcome_With_Glucose = 0
Negative_Outcome_With_Glucose = 0
Positive_Outcome_Without_Glucose = 0
Negative_Outcome_Without_Glucose = 0
Positive_Outcome_With_BP = 0
Positive_Outcome_Without_BP = 0
Negative_Outcome_With_BP = 0
Negative_Outcome_Without_BP = 0



for i in range(0,nrows):
    #Patients with and with out glucose
    if (xa[i,0] == 1):
        Glucose = Glucose + 1
    else: 
        No_Glucose = No_Glucose + 1
    #patients with and without High BP
    if (xa[i,1]==1):    
        BP = BP + 1
    else: 
        No_BP = No_BP + 1
        
        
    if (xa[i,0] == 1 and xa[i,2] == 1):
        Positive_Outcome_With_Glucose = Positive_Outcome_With_Glucose + 1
    
    if (xa[i,0] == 1 and xa[i,2] == 0):
        Negative_Outcome_With_Glucose = Negative_Outcome_With_Glucose + 1
        
    if (xa[i,0] == 0 and xa[i,2] == 0):
        Negative_Outcome_Without_Glucose = Negative_Outcome_Without_Glucose + 1
        
    if (xa[i,0] == 0 and xa[i,2] == 1):
        Positive_Outcome_Without_Glucose = Positive_Outcome_Without_Glucose + 1
        
        
    if (xa[i,1] == 1 and xa[i,2] == 1):
        Positive_Outcome_With_BP = Positive_Outcome_With_BP + 1
    
    if (xa[i,1] == 1 and xa[i,2] == 0):
        Negative_Outcome_With_BP = Negative_Outcome_With_BP + 1
        
    if (xa[i,1] == 0 and xa[i,2] == 0):
        Negative_Outcome_Without_BP = Negative_Outcome_Without_BP + 1
        
    if (xa[i,1] == 0 and xa[i,2] == 1):
        Positive_Outcome_Without_BP = Positive_Outcome_Without_BP + 1
        
        
  
Gini_ImpurityPG = 1 - (Positive_Outcome_With_Glucose/Glucose)**2 - (Negative_Outcome_With_Glucose/Glucose)**2

Gini_ImpurityNG = 1 - (Positive_Outcome_Without_Glucose/No_Glucose)**2 - (Negative_Outcome_Without_Glucose/No_Glucose)**2

Gini_ImpurityPBP = 1 -(Positive_Outcome_With_BP/BP)**2 - (Negative_Outcome_With_BP/BP)**2

Gini_ImpurityNBP = 1 - (Positive_Outcome_Without_BP/No_BP)**2 - (Negative_Outcome_Without_BP/No_BP)**2

Total_Impurity_G = Gini_ImpurityPG * (Glucose/(Glucose + No_Glucose)) + Gini_ImpurityNG * (No_Glucose/(Glucose + No_Glucose))

Total_Impurity_BP = Gini_ImpurityPBP * (BP/(BP+No_BP)) + Gini_ImpurityNBP * (No_BP/(BP+No_BP))

if (Total_Impurity_G < Total_Impurity_BP):
    print('Glucose should be the feature selected for the root node for the diabetes tree. Total Impurity for Glucose:',Total_Impurity_G,'Total Impurity for BP:',Total_Impurity_BP)
    
else: 
    print('BP should be the feature selected for the root node for the diabetes tree. Total Impurity for BP:', Total_Impurity_BP, 'Total Impurity for Glucose',Total_Impurity_G)