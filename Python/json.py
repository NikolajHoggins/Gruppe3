import urllib3
from bs4 import BeautifulSoup
import requests
import simplejson as json
urllib3.disable_warnings()


web = requests.get('https://mars.tekkom.dk/mrbs/json.php', verify=False)
json_string = json.loads(web.text)

token = "x"
laravel = "http://nikolaj.bricksite.net"


for x in json_string:
    hovedforlob = {
        "A": "anden",
        "B": "h1",
        "C": "h2",
        "D": "h3",
        "E": "h4",
        "F": "h5",
        "G": "h6",
        "H": "gf1",
        "I": "gf2",
        "J": "amu"
    }
    json_request = "/addclass/{}/{}/{}/{}/{}".format(token, hovedforlob.get(x["type"], "None"), x["time"], x["room"], x["name"])
    requests.get(laravel + json_request)
