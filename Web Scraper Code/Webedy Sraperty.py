import requests
import bs4
import os
url = "https://www.vgmusic.com/music/console/nintendo/nes/"
save_path = r"c:\Users\benjo\OneDrive\Documents\NEA\MidiFiles"
audioFolder = os.path.join(save_path, "Midi Files.wav")  
r = requests.get(url)

soup = bs4.BeautifulSoup(r.text, features = "html.parser")

for element in soup.find_all("a"):
    
    print(element.text)
    if element.has_attr("href"):
        if element["href"].endswith(".mid"):
            file = element["href"]
            print(file)
            webFile = requests.get(url + file, allow_redirects = True)
            
            with open(file, "wb+")as f:
                f.write(webFile.content)
print(r.text)