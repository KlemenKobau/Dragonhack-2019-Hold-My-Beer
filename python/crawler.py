import requests
import os

#CONSTANTS AND TEMPLATES

page_url_template = r"https://www.brewersfriend.com/homebrew-recipes/page/{0}/"
data_directory = "temp_data"
page_filename_template = "beers_{0}.html"


#FUNCTIONS

def download_url_to_string(url):
    '''This function takes a URL as argument and tries to download it
    using requests. Upon success, it returns the page contents as string.'''
    try:
        r = requests.get(url)
    except requests.exceptions.RequestException:
        print('Failed to connect to url ' + url)
        return None
    return r.text


def save_string_to_file(text, directory, filename):
    '''Write "text" to the file "filename" located in directory "directory",
    creating "directory" if necessary. If "directory" is the empty string, use
    the current directory.'''
    os.makedirs(directory, exist_ok=True)
    path = os.path.join(directory, filename)
    with open(path, 'w') as file_out:
        file_out.write(text)
    return None


def download_page_to_file(url, directory, filename):
    '''This functions tries to download a page with "url" and upon success,
    writes the page string to file "filename" at "directory".'''
    content = download_url_to_string(url)
    if content:
        save_string_to_file(content, directory, filename)
    return None

#PROGRAM

for page_num in range(1,1 +1):
    page_url = page_url_template.format(str(page_num))
    page_filename = page_filename_template.format(str(page_num))
    download_page_to_file(page_url, data_directory, page_filename)
    print("Downloaded: {0}.".format(page_filename))
