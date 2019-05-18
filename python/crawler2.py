from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import os
import time

def save_string_to_file(text, directory, filename):
    '''Write "text" to the file "filename" located in directory "directory",
    creating "directory" if necessary. If "directory" is the empty string, use
    the current directory.'''
    os.makedirs(directory, exist_ok=True)
    path = os.path.join(directory, filename)
    with open(path, 'w') as file_out:
        try:
            file_out.write(text)
        except:
            print('Never ', end='')
            return None
    return None

#launch url
url_template = "https://www.brewersfriend.com/homebrew-recipes/page/{0}/"
data_directory = "temp_data"
page_filename_template = "beers_{0}.html"

# create a new Firefox session

t1 = time.time()
driver = webdriver.Firefox(executable_path=r'C:\Users\AkanusGod\webdriver\gecko\v0.24.0\geckodriver-v0.24.0-win64\geckodriver.exe')
driver.implicitly_wait(10)
for page_num in range(1, 200 +1):
    url = url_template.format(str(page_num))
    page_filename = page_filename_template.format(str(page_num))
    driver.get(url)
    t = driver.page_source
    save_string_to_file(t, data_directory, page_filename)
    print("Downloaded: {0}.".format(page_filename))
    python_button = driver.find_element_by_link_text(str(page_num)) #FHSU
    python_button.click() #click fhsu link

driver.quit()

t2 = time.time()
print('Time needed: ' + str(t2-t1))
