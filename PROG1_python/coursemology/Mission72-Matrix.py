#Programming I

#######################
#     Mission 7.1     #
#   MartrixMultiply   #
#######################

#Background
#==========
#Tom has studied about creating 3D games and wanted
#to write a function to multiply 2 matrices.
#Define a function MaxtrixMulti() function with 2 parameters.
#Both parameters are in a matrix format.


#Important Notes
#===============
#1) Comment out ALL input prompts before submitting.

A = [[1,2,3],
     [4,5,6],
     [7,8,9]]

B = [[2,0,0],
     [0,2,0],
     [0,0,2]]

#START CODING FROM HERE
#======================

#Create your function here

def matrixmulti(A, B):
     result = [[0,0,0],
         [0,0,0],
         [0,0,0]]
     for i in range(len(A)):
          # iterate through columns of Y
          for j in range(len(B[0])):
               # iterate through rows of Y
               for k in range(len(B)):
                    result[i][j] += A[i][k] * B[k][j]
     print(result)
     return result

   
#Do not remove the next line
matrixmulti(A, B)

#3) For testing, print out the output
#   - Comment out before submitting
