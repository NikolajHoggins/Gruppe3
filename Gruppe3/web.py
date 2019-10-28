# Test.py
#!/usr/bin/python

import urllib3
from bs4 import BeautifulSoup
import requests

urllib3.disable_warnings()

web = requests.get('https://mars.tekkom.dk/mrbs/dayFull.php', verify=False)

soup = BeautifulSoup(web.text, 'html5lib')
   

lokaler = []
array1 = []
array2 = []
array3 = []
array4 = []
array5 = []
array6 = []
array7 = []
array8 = []

# [1::]

for header in soup.thead.find_all("tr")[0].find_all("th"):
    lokaler.append(header.text.rstrip("\n\r"))
print(len(lokaler))


for row in soup.tbody.find_all("tr")[0].find_all("td"):
    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array1.append(row.text.rstrip("\n\r"))
    else:
        print("x")
        array1.append("X")
print(len(array1))

for row in soup.tbody.find_all("tr")[1].find_all("td"):
    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array2.append(row.text.rstrip("\n\r"))
    else:
        print("x")
        array2.append("X")
print(len(array2))

for row in soup.tbody.find_all("tr")[2].find_all("td"):
    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array3.append(row.text.rstrip("\n\r"))
    else:
        print("x")
        array3.append("X")
print(len(array3))

for row in soup.tbody.find_all("tr")[3].find_all("td"):
    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array4.append(row.text.rstrip("\n\r"))
    else:
        print("x")
        array4.append("X")
print(len(array4))

for row in soup.tbody.find_all("tr")[4].find_all("td"):
    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array5.append(row.text.rstrip("\n\r"))
    else:
        print("x")
        array5.append("X")
print(len(array5))

for row in soup.tbody.find_all("tr")[5].find_all("td"):
    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array6.append(row.text.rstrip("\n\r"))
    else:
        print("x")
        array6.append("X")
print(len(array6))

for row in soup.tbody.find_all("tr")[6].find_all("td"):
    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array7.append(row.text.rstrip("\n\r"))
    else:
        print("x")
        array7.append("X")
print(len(array7))

for row in soup.tbody.find_all("tr")[7].find_all("td"):
    if len(row.text.rstrip("\n\r")) > 3:
        print(row.text.rstrip("\n\r"))
        array8.append(row.text.rstrip("\n\r"))
    else:
        
        print("x")
        array8.append("X")
print(len(array8))
