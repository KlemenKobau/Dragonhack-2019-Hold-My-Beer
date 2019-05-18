import re
import json
import os

def add_attribute(data, file, regex, name, start, stop):
    rx = re.compile(regex)

    match = rx.findall(file)

    for i in range(len(match)):
        if(len(data) <= i): data.append({})
        out = match[i][start:stop]
        j=0
        while out[j].isspace(): j+=1
        out = out[j:]
        j=-1
        while out[j].isspace(): j-=1
        if(j != -1): out = out[:j+1]
        data[i][name] = out


count = 1
for f in os.listdir("temp_data"):
    filename = os.fsdecode(f)
    try:
        f = open("temp_data/" + filename)
        file = f.read()

        data = []

        add_attribute(data, file, r'<b>Title:</b>.*?</td>', 'title', 13, -5)
        add_attribute(data, file, r'<span itemprop="recipeCuisine">.*?</span>', 'style', 31, -7)


        regex = r'<td><span itemprop="recipeYield">.*?</span></td>.*?<td>.*?%</td>.*?<td>.*?</td>.*?<td>.*?</td>.*?<td>.*?</td>.*?<td>.*?°L'
        rx = re.compile(regex, re.DOTALL)

        match = rx.findall(file)

        for i in range(len(match)):
            sez = match[i].split('<td>')
            if(len(data) <= i): data.append({})
            data[i]['alcohol'] = sez[2][:sez[2].find('%')]
            data[i]['IBU'] = sez[3][:sez[3].find('<')]
            data[i]['color'] = sez[6][:sez[6].find('°')]

        for i in range(len(data)):
            with open('out_data/beer{0}.json'.format(count), 'w') as outfile:  
                json.dump(data[i], outfile)
            count+=1
    except:
        pass