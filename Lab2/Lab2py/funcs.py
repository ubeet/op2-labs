from datetime import datetime, date, time
import pickle


def FileWrite(text, path, fb):
    file = open(path, fb)
    for i in text:
        file.write((i + "\n").encode())


def FileRead(path):
    txt = []
    file = open(path, "rb")
    for text in file:
        str = ""
        str += text.decode()
        txt.append(str[:-1])
    return txt

def TxtOut(ss):
    for el in ss:
        print(el)
    print()


def RemoveElement(elements, j):
    newLines = []
    k = 0
    i = 0
    while i < elements.Length:
        if i != j:
            newLines[k] = elements[i]
            k += 1
        i += 1
    return newLines

def FindEndTime(openTime, endTime):
    openH = int(openTime.split(":")[0])
    openM = int(openTime.split(":")[1])
    endH = int(endTime.split(":")[0])
    endM = int(endTime.split(":")[1])
    days = 0
    hours = (openH + endH)
    minutes = (endM + openM)
    if minutes >= 60:
        minutes -= 60
        hours += 1
    if hours >= 24:
        hours -= 24
        days += 1
    return "{}.{}:{}".format(days, hours, ("0" + str(minutes)) if len(str(minutes)) == 1 else minutes)



def ListOfDrugs(path):
    txt = FileRead(path)
    list = []
    i = 0
    while i < len(txt):
        list.append(txt[i].split(" ")[0])
        i += 1
    return list

def ChangeDate(days, date):
    now = date.strftime("%d/%m/%Y").split("/")
    changedDay = (int(now[0]) + days)
    now[0] = str(changedDay)
    dt = datetime.strptime("/".join(now) + " {}:{}".format(date.hour, date.minute), "%d/%m/%Y %H:%M")
    return dt

def RemoveOverdue(path):
    lines = FileRead(path)
    i = 0
    while i < len(lines):
        s = lines[i].split(" ")[2]
        ss = s.split(".")[1]
        h = ss.split(":")[0]
        x = lines[i].split(" ")[2]
        xx = x.split(".")[1]
        m = xx.split(":")[1]

        dt = datetime.today()


        curDate = datetime.combine(date(dt.year, dt.month, dt.day), time(int(h), int(m)))
        endTime = ChangeDate(int(lines[i].split(" ")[2].split(".")[0]), curDate)

        if endTime < datetime.now():
            del lines[i]
        i += 1
    FileWrite(lines, path, "wb")