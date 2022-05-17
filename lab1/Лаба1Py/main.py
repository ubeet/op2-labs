def main():
    path = ""
    inp = ""
    str = ""
    while str != "endl":
        str = input()
        if str != "endl":
            inp += str + "\n"

    FileWrite("{0}untitledPy.txt".format(path), inp.strip("\n"))
    text = FileRead("{0}untitledPy.txt".format(path))
    txtArr = text.split("\n")
    text1 = ""
    text2 = ""
    for i in range(len(txtArr)):
        if i % 2 == 0:
            text1 += txtArr[i] + "\n"
        else:
            text2 += txtArr[i] + "\n"

    FileWrite("{0}note1Py.txt".format(path), text1)
    FileWrite("{0}note2Py.txt".format(path), text2)

    FileOut("{0}untitledPy.txt".format(path))
    FileOut("{0}note1Py.txt".format(path))
    FileOut("{0}note2Py.txt".format(path))


    FileAlphSort("{0}note1Py.txt".format(path))
    FileOut("{0}note1Py.txt".format(path))
    FileWordSort("{0}note2Py.txt".format(path))
    FileOut("{0}note2Py.txt".format(path))

def FileRead(path):
    with open(path, "r") as file:
        text = file.read()
    return text

def FileWrite(path, text):
    with open(path,"w") as file:
        file.write(text)

def FileOut(path):
    txt = FileRead(path)

    print("\nТекст файла {0}:".format(path))
    print(txt)

def FileAlphSort(path):
    text = FileRead(path)
    textArr = text.split("\n")
    for i in range(len(textArr)):
        mass = []
        mass.extend(textArr[i])
        mass.sort()
        textArr[i] = "".join(mass)
    txt = ""
    for i in range(len(textArr)):
        txt += textArr[i] + "\n"
    FileWrite(path, txt)

def FileWordSort(path):
    text = FileRead(path)
    textArr = text.split("\n")
    n = int(input("Введите кол-во строк для сортировки: "))
    while n > len(textArr):
        n = int(input())
    for i in range(n):
        ss = textArr[i].split(" ")
        ss.sort()
        textArr[i] = " ".join(ss)
    text = "\n".join(textArr)
    FileWrite(path, text)

main()

