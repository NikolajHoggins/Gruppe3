# [1::]
# print(soup.find_all("td", class_="B")[0].text.replace('\n',''))
import urllib3
from bs4 import BeautifulSoup
import requests

urllib3.disable_warnings()
web = requests.get('https://mars.tekkom.dk/mrbs/dayFull.php', verify=False)
soup = BeautifulSoup(web.text, 'html5lib')

lokaler = []
array1 = []

# Header
for header in soup.thead.find_all("tr")[0].find_all("th"):
    lokaler.append(header.text.rstrip("\n\r").replace(" ", ""))

# Versionering og Dokumentation
for vd in soup.find_all("td", class_="B"):
    vds = vd.text.replace('\n','')
    if vds != "H1":
        print(vds)


