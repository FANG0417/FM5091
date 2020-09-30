import numpy as np

# a=np.arange(5)
# print(a[4])

# g=['a','b','c','d']

# for i in range(len(g)):
#     print(i,g[i])

# f=[1,2,3,4]

# for i in range(4):
#     print(i,f[i])

#why this happen


# g = int(np.random.rand() * 10) 
# i = g + 1
# while(g != int(i)): 
#     i = input("Guess a number!")
# print("You guessed correctly!")

def do_things(vector, position): 
    if(position < len(vector)): 
        vector[position] = np.random.rand() 
        return do_things(vector, position + 1) 
    else: 
        return vector
g = do_things(np.zeros(3), 0)
print(g)
