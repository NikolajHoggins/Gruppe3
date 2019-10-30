import urllib3
from bs4 import BeautifulSoup
import requests
import simplejson as json
urllib3.disable_warnings()


web = requests.get('https://mars.tekkom.dk/mrbs/json.php', verify=False)
json_string = json.loads(web.text)

laravel = "http://nikolaj.bricksite.net/addclass/{token}/{hoved}/{hour}/{location}/{name}"


for x in json_string:
    requests.get('https://mars.tekkom.dk/mrbs/json.php', verify=False)
    print("")
    print(x["name"])
    print(x["type"])
    print(x["time"])
    print(x["room"])
    print("-------------------------")
