n = int(input())
B = list(map(int, input().split()))

    
min = max = B[0]
imin = 0

for i in range(1, len(B)):
   if min > B[i]:
       min = B[i]
       imin = i
   if max < B[i]:
       max = B[i]
        
        

print(max - min)
temp = B[imin]
B[imin] = B[len(B) - 1]
B[len(B) - 1] = temp;

print(*B)
