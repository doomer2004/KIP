import fileinput
def getinput(path1): #зчитуємо текст введений з консолі
    text = []
    file1 = open(path1, 'w')
    for s in fileinput.input():
        text.append(s.strip())

    file1.write('\n'.join(text))
    file1.close()


def readfile(path1): #зчитує файл 
    file1 = open(path1, 'r')
    text = file1.readlines()
    file1.close()
    return text

def countedtext(path2, text): #додаємо до непарних строчок їх довжику
    file2 = open(path2, 'w')
    for s in range(len(text)):
        text[s] = text[s].replace('\n', '')
        if s % 2 == 0:
            text[s]=text[s]+' '+str(len(text[s]))
    file2.write('\n'.join(text))
    file2.close()


