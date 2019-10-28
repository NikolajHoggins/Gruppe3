# Test.py
#!/usr/bin/python

import urllib3
from bs4 import BeautifulSoup
import requests

urllib3.disable_warnings()

web = requests.get('https://mars.tekkom.dk/mrbs/dayFull.php', verify=False)

soup = BeautifulSoup(web.text, 'html5lib')


print(soup.html)



# for elev_id in soup.find_all('table', attrs={'style':'margin-left:50px;margin-right:50px;'})[0].find_all('a', href=True):
#     nElev_id = elev_id['href'].replace('elev_visning.php?elevid=', '')
#     nnElev_id = nElev_id.replace(' ', '')
#     elevId.append(nnElev_id)


# for table in soup.find_all('table', attrs={'style':'margin-left:50px;margin-right:50px;'})[0].find_all('a'):
#     tableList.append(table.get_text())

# for font in soup.find_all('table', attrs={'style':'margin-left:50px;margin-right:50px;'})[0].find_all('font'):
#     fontList.append(font.get_text())

# for items in range(len(tableList)):
#   web = "https://mercantec.dev/update-elev/{}/{}/{}".format(elevId[items], tableList[items], fontList[items])
#   check = requests.get(web, verify=False)
#   if "Elev updated" in check.text:
#     print(elevId[items] + " " + tableList[items] + " " + fontList[items] + "<br>")