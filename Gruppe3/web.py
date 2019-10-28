# Test.py
#!/usr/bin/python

import urllib3
from bs4 import BeautifulSoup
import requests

urllib3.disable_warnings()
web = requests.get('https://mars.tekkom.dk/mrbs/dayFull.php', verify=False)
soup = BeautifulSoup(web.text, 'html5lib')
   
rowspan = [0,0,0,0,0]
lokaler = []
array1 = []

# [1::]

# Header
for header in soup.thead.find_all("tr")[0].find_all("th"):
    lokaler.append(header.text.rstrip("\n\r"))

# Row 1
row1 = 0
for row in soup.tbody.find_all("tr")[0].find_all("td"):
    # Check if there is a rowspan
    if row.attrs.get("rowspan") != None:
        rowspan[row1] += int(row.attrs.get("rowspan"))

    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array1.append(row.text.rstrip("\n\r"))
    else:
        print("x")
        array1.append("X")
    
    if rowspan[row1] != 0:
        rowspan[row1] += -1
    print(rowspan[row1])
    row1+=1

print("-------------------------")
print(len(array1))