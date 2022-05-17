import funcs

path = "";
lines = ["name0 2:30", "name1 1:30", "name2 3:00", "name3 0:10"]
funcs.FileWrite(lines, "{0}drugs.txt".format(path), "wb")
print("Введите названия препаратов из списка ниже и время их открытия в формате ГГ:ХХ")
drugsList = funcs.ListOfDrugs("{0}drugs.txt".format(path))
print(", ".join(drugsList))
ss = ""
z = " ".join(funcs.FileRead("{0}drugs.txt".format(path))).split(" ")
c = []
while (ss != "endl"):
    ss = input()
    if (ss == "endl"):
        continue
    x = funcs.FindEndTime(ss.split(" ")[1], z[z.index(ss.split()[0]) + 1])
    c.append("{0} {1} {2}".format(ss.split(" ")[0], ss.split(" ")[1], x))
funcs.FileWrite(c, "{0}openDrugs.txt".format(path), "wb")
funcs.TxtOut(funcs.FileRead("{0}openDrugs.txt".format(path)))
funcs.RemoveOverdue("{0}openDrugs.txt".format(path))
funcs.TxtOut(funcs.FileRead("{0}openDrugs.txt".format(path)))
