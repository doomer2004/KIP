import func
def main():
    print("Enter text(use ctrl + d to close):")
    path1='text1.txt'
    path2 = 'text2.txt'
    func.getinput(path1)
    print("\nFile 1:")
    print(''.join(func.readfile(path1)))
    print("\nFile 2:")
    func.countedtext(path1, path2, func.readfile(path1))
    print(''.join(func.readfile(path2)))

main()