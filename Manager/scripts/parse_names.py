with open ("names - Kopia.txt", "r") as myfile:
    data=myfile.read()
with open ("names.txt", "w") as myfile:
    memory = ""
    counter = 0
    condition1 = True
    for a in data:
        if counter == 2:
            
            counter = 0
            if a == "m":
                myfile.write(memory)
            memory = ""
        if a == ",":
            condition1 = False
            counter +=1
        elif a == "\n":
            condition1 = True
            #myfile.write(a)
        if condition1:
            memory = memory + a 
          