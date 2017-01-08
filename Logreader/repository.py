import re
import subprocess


def clone(source, tmpdir):
    call = ["git", "clone", source, tmpdir]
    subprocess.check_call(call)


class Repository:
    source_pattern = re.compile("https://github(\.)com/(.+)/(.+)(\.git)")
    source = ""


class Wiki(Repository):
    source_pattern = re.compile("https://github(\.)com/(.+)/(.+)(\.wiki\.git)")
    location = None

    def __init__(self, args):
        if len(args) > 1:
            source = args[1]
            print(source)
        else:
            source = str(input("Link to GitHub Wiki Repository: "))

        if re.search(self.source_pattern, source) is None:
            print("Not a valid GitHub Wiki Repository!")
            return

        if len(args) > 2:
            privacy = args[2]
        else:
            privacy = str(input("Is it a private Repository? (y/n) "))

        if privacy == "y":
            private = True
        elif privacy == "n":
            private = False
        else:
            print("Only 'y' and 'n' are allowed!")
            return

        if private:
            if len(args) > 3:
                username = args[3]
            else:
                username = input("Username: ")

            if len(args) > 4:
                password = args[4]
            else:
                password = input("Password: ")

            source = source.replace("https://", "")
            self.source = "https://" + username + ":" + password + "@" + source

