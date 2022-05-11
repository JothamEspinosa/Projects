import math
import random
import numpy as np
import matplotlib.pyplot as plt
import statistics
from sys import exit

# Create four clusters in 2D and find the cluster means - upload the code and plot
# Create four clusters in 3D and find the cluster means - upload the code and plot

npts = 500 # Number of points
ndim = 3 # Number of dimensions
nclusters = 4 # Number of clusters to use
nitmax = 10000 # Maximum number of iterations k-means algorithm

sample_points = np.zeros((npts,ndim),dtype = float) # Initialize sample_points array

# Arrays used for visualization
xxp = np.zeros(npts,dtype=float)
yyp = np.zeros(npts,dtype=float)
zzp = np.zeros(npts,dtype=float)

means = np.zeros((nclusters,ndim),dtype = float) # Means of clusters
means_old = np.zeros((nclusters,ndim),dtype = float) # Means of old clusters

mincluster = np.zeros(npts,dtype = int) # Assign point to closest cluster
label = np.zeros(npts,dtype = int) # Labels assigned to points
num_in_cluster = np.zeros(nclusters,dtype = int)

# Coordinates of converged cluster locations
meanx = np.zeros(nclusters,dtype=float)
meany = np.zeros(nclusters,dtype=float)
meanz = np.zeros(nclusters,dtype=float)

diffa = np.zeros(nclusters,dtype=float) # Distance between old and new cluster locations

# New point to be assigned
new_point = np.zeros(2,dtype=float)

sigmau = .5 # Standard deviation of normal distribution

# Create points
for i in range(0,npts):

     if (i < npts//4):
             #Sample from a normal distribution with mean(-1.0,0.0)
           xx = np.random.normal(1.0,sigmau,1)
           yy = np.random.normal(5.0,sigmau,1)
           zz = np.random.normal(-2.0,sigmau,1)
           sample_points[i][0] = xx
           sample_points[i][1] = yy
           sample_points[i][2] = zz
           label[i] = 0

     if  (i > npts//4 and i < npts//2):
             #Sample from normal distribution with a mean (-1.0,0.0)
          xx = np.random.normal(-1.0,sigmau,1)
          yy = np.random.normal(-2.0,sigmau,1)
          zz = np.random.normal(3.0,sigmau,1)
          sample_points[i][0] = xx
          sample_points[i][1] = yy 
          sample_points[i][2] = zz
          label[i] = 1
           
     if (i > npts//2 and i < 3*(npts//4)):
          xx = np.random.normal(0.0,sigmau,1)
          yy = np.random.normal(1.0,sigmau,1)
          zz = np.random.normal(4.0,sigmau,1)
          sample_points[i][0] = xx
          sample_points[i][1] = yy 
          sample_points[i][2] = zz
          label[i] = 2
               
     if (i > 3*(npts//4)):
          xx = np.random.normal(2.0,sigmau,1)
          yy = np.random.normal(-1.0,sigmau,1)
          zz = np.random.normal(-5.0,sigmau,1)
          sample_points[i][0] = xx
          sample_points[i][1] = yy
          sample_points[i][2] = zz
          label[i] = 3    
           
           
           
           
           
           
           
           
     xxp[i] = xx
     yyp[i] = yy
     zzp[i] = zz

#fig = plt.figure(figsize=(12,12))
#fig = plt.figure()
#ax = fig.add_subplot(projection='3d')
#ax.scatter3D(xxp,yyp,zzp)
#plt.show()
#exit()


#plt.clf() # Clear any previous plots
#plt.scatter(xxp,yyp)


# Apply the k-means algorithm

#create a guess for the cluster means
for i in range(0,nclusters):
    for j in range(0,ndim):
        rr = random.random()
        means[i][j] = rr

diff = 1.0
nit = 0
while (diff > .001 and nit < nitmax): # Convergence while loop 
    
    nit = nit + 1

    # Assign each point to its nearest cluster
    for i in range(0,npts): #visit all the points
        jmin = 0
        distancemin = 1.e+10
        for j in range(0,nclusters):
            # Compute the distance to each cluster mean
            distance = math.sqrt( (sample_points[i,0] - means[j,0])**2 + (sample_points[i,1] - means[j,1])**2 + (sample_points[i,2] - means[j,2])**2 )
            if (distance < distancemin):
               jmin = j
               distancemin = distance
            

        mincluster[i] = jmin # Point assigned to cluster jmin

    # Save old cluster mean coordinates
    for j in range(0,nclusters):   
        for i in range(0,ndim):
            means_old[j,i] = means[j,i]
    
    for j in range(0,nclusters):
        num_in_cluster[j] = 0
        for i in range(0,ndim):
            means[j,i] = 0.0


    # Compute the new cluster centers using all points assigned to the cluster
    for i in range(0,npts):
        num_in_cluster[mincluster[i]]  = num_in_cluster[mincluster[i]] + 1 # Increment number of points in cluster
        for j in range(0,ndim):
            means[mincluster[i],j] = means[mincluster[i],j] + sample_points[i,j]
       


#    print(num_in_cluster)
    
    for j in range(0,nclusters):
        for i in range(0,ndim):
           means[j,i] = means[j,i]/num_in_cluster[j]

        # Compute the distance between the old and new means
        diffa[j] = math.sqrt( (means[j,0] - means_old[j,0])**2 + (means[j,1] - means_old[j,1])**2 + (means[j,2] - means_old[j,2])**2 )
        
    diff = max(diffa)
    print("Difference and number of iterations",diff,nit)

# Plot cluster means
for j in range(0,nclusters):
    meanx[j] = means[j,0]
    meany[j] = means[j,1]
    meanz[j] = means[j,2]
    
    

fig = plt.figure(figsize=(12,12))
fig = plt.figure()
ax = fig.add_subplot(projection='3d')
ax.scatter3D(meanx,meany,meanz, color = "red")
ax.scatter3D(xxp,yyp,zzp, color = "cyan")
plt.show()
print("Cluster means",means)    
