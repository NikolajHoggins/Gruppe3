# [1::]
import json
import urllib3
from bs4 import BeautifulSoup
import requests

urllib3.disable_warnings()
web = requests.get('https://mars.tekkom.dk/mrbs/dayFull.php', verify=False)
soup = BeautifulSoup(web.text, 'html5lib')

errors = []
rowspan = [0,0,0,0,0]
lokaler = []
array1 = []
array2 = []
array3 = []
array4 = []
array5 = []
array6 = []
array7 = []
array8 = []


print("")

# Header
for header in soup.thead.find_all("tr")[0].find_all("th"):
    lokaler.append(header.text.replace('\n','').replace(" ", ""))

# Row 1
row1 = 0
for x in rowspan:
    try:
        s = soup.tbody.find_all("tr")[0].find_all("td")[row1]
        if rowspan[row1] != 0:
            rowspan[row1] += -1
            if row1 != 3:
                print("x")
                array1.append("x")
        if s.attrs.get("rowspan") != None:
            rowspan[row1] += int(s.attrs.get("rowspan"))
        if s.text.replace('\n','') != "":
            print(s.text.replace('\n',''))
            array1.append(s.text.replace('\n',''))
        else:
            if len(array1) == 5:
                errors.append("Error")
            else:
                print("x")
                array1.append("x")
    except:
        if len(array1) != 5:
            if len(array1) >= 5:
                errors.append("Error")
            else:
                print("x")
                array1.append("x") 
        errors.append("Error")
    row1+=1
print("-------------------------")
# print(len(array1))
print("")

# Row 2
row2 = 0
for x in rowspan:
    try:
        s = soup.tbody.find_all("tr")[1].find_all("td")[row2]
        if rowspan[row2] != 0:
            rowspan[row2] += -1
            if row2 != 3:
                print("x")
                array2.append("x")
        if s.attrs.get("rowspan") != None:
            rowspan[row2] += int(s.attrs.get("rowspan"))
        if s.text.replace('\n','') != "":
            print(s.text.replace('\n',''))
            array2.append(s.text.replace('\n',''))
        else:
            if len(array2) == 5:
                errors.append("Error")
            else:
                print("x")
                array2.append("x")
    except:
        if len(array2) != 5:
            if len(array2) >= 5:
                errors.append("Error")
            else:
                print("x")
                array2.append("x") 
        errors.append("Error")
    row2+=1
print("-------------------------")
# print(len(array2))
print("")

# Row 3
row3 = 0
for x in rowspan:
    try:
        s = soup.tbody.find_all("tr")[2].find_all("td")[row3]
        if rowspan[row3] != 0:
            rowspan[row3] += -1
            if row3 != 3:
                print("x")
                array3.append("x")
        if s.attrs.get("rowspan") != None:
            rowspan[row3] += int(s.attrs.get("rowspan"))
        if s.text.replace('\n','') != "":
            print(s.text.replace('\n',''))
            array3.append(s.text.replace('\n',''))
        else:
            if len(array3) == 5:
                errors.append("Error")
            else:
                print("x")
                array3.append("x")
    except:
        if len(array3) != 5:
            if len(array3) >= 5:
                errors.append("Error")
            else:
                print("x")
                array3.append("x") 
        errors.append("Error")
    row3+=1
print("-------------------------")
# print(len(array3))
print("")

# Row 4
row4 = 0
for x in rowspan:
    try:
        s = soup.tbody.find_all("tr")[3].find_all("td")[row4]
        if rowspan[row4] != 0:
            rowspan[row4] += -1
            if row4 != 3:
                print("x")
                array4.append("x")
        if s.attrs.get("rowspan") != None:
            rowspan[row4] += int(s.attrs.get("rowspan"))
        if s.text.replace('\n','') != "":
            print(s.text.replace('\n',''))
            array4.append(s.text.replace('\n',''))
        else:
            if len(array4) == 5:
                errors.append("Error")
            else:
                print("x")
                array4.append("x")
    except:
        if len(array4) != 5:
            if len(array4) >= 5:
                errors.append("Error")
            else:
                print("x")
                array4.append("x") 
        errors.append("Error")
    row4+=1
print("-------------------------")
# print(len(array4))
print("")

# Row 5
row5 = 0
for x in rowspan:
    try:
        s = soup.tbody.find_all("tr")[4].find_all("td")[row5]
        if rowspan[row5] != 0:
            rowspan[row5] += -1
            if row5 != 3:
                print("x")
                array5.append("x")
        if s.attrs.get("rowspan") != None:
            rowspan[row5] += int(s.attrs.get("rowspan"))
        if s.text.replace('\n','') != "":
            print(s.text.replace('\n',''))
            array5.append(s.text.replace('\n',''))
        else:
            if len(array5) == 5:
                errors.append("Error")
            else:
                print("x")
                array5.append("x")
    except:
        if len(array5) != 5:
            if len(array5) >= 5:
                errors.append("Error")
            else:
                print("x")
                array5.append("x") 
        errors.append("Error")
    row5+=1
print("-------------------------")
# print(len(array5))
print("")

# Row 6
row6 = 0
for x in rowspan:
    try:
        s = soup.tbody.find_all("tr")[5].find_all("td")[row6]
        if rowspan[row6] != 0:
            rowspan[row6] += -1
            if row6 != 3:
                print("x")
                array6.append("x")
        if s.attrs.get("rowspan") != None:
            rowspan[row6] += int(s.attrs.get("rowspan"))
        if s.text.replace('\n','') != "":
            print(s.text.replace('\n',''))
            array6.append(s.text.replace('\n',''))
        else:
            if len(array6) == 5:
                errors.append("Error")
            else:
                print("x")
                array6.append("x")
    except:
        if len(array6) != 5:
            if len(array6) >= 5:
                errors.append("Error")
            else:
                print("x")
                array6.append("x") 
        errors.append("Error")
    row6+=1
print("-------------------------")
# print(len(array6))
print("")

# Row 7
row7 = 0
for x in rowspan:
    try:
        s = soup.tbody.find_all("tr")[6].find_all("td")[row7]
        if rowspan[row7] != 0:
            rowspan[row7] += -1
            if row7 != 3:
                print("x")
                array7.append("x")
        if s.attrs.get("rowspan") != None:
            rowspan[row7] += int(s.attrs.get("rowspan"))
        if s.text.replace('\n','') != "":
            print(s.text.replace('\n',''))
            array7.append(s.text.replace('\n',''))
        else:
            if len(array7) == 5:
                errors.append("Error")
            else:
                print("x")
                array7.append("x")
    except:
        if len(array7) != 5:
            if len(array7) >= 5:
                errors.append("Error")
            else:
                print("x")
                array7.append("x") 
        errors.append("Error")
    row7+=1
print("-------------------------")
# print(len(array7))
print("")

# Row 8
row8 = 0
for x in rowspan:
    try:
        s = soup.tbody.find_all("tr")[7].find_all("td")[row8]
        if rowspan[row8] != 0:
            rowspan[row8] += -1
            if row8 != 3:
                print("x")
                array8.append("x")
        if s.attrs.get("rowspan") != None:
            rowspan[row8] += int(s.attrs.get("rowspan"))
        if s.text.replace('\n','') != "":
            print(s.text.replace('\n',''))
            array8.append(s.text.replace('\n',''))
        else:
            if len(array8) == 5:
                errors.append("Error")
            else:
                print("x")
                array8.append("x")
    except:
        if len(array8) != 5:
            if len(array8) >= 5:
                errors.append("Error")
            else:
                print("x")
                array8.append("x") 
        errors.append("Error")
    row8+=1
print("-------------------------")
# print(len(array8))
print("")



with open('Python/data.json', 'w') as f:
    json.dump((lokaler, array1, array2, array3, array4, array5, array6, array7, array8), f)
