import os
import re
import sys
import tempfile

from repository import Wiki, clone

p_dates = re.compile("\d\d\d\d-\d\d-\d\d")
p_times = re.compile("\d\d:\d\d")
p_hours = re.compile("\d+h")
p_minutes = re.compile("\d+m")


class LogReader:
    logs = []

    def __init__(self, args):
        """
        Reads
        00:00         \d\d:\d\d
        0h            (\d)+h
        0m            (\d)+m
        2016-10-25    \d\d\d\d-\d\d-\d\d
        01.01.2016    \d\d(-|\.)\d\d(-|\.)\d\d\d\d

        :param args: source, private, username, password
        """
        self.wiki = Wiki(args)
        self.read_logs()

    def read_logs(self):
        with tempfile.TemporaryDirectory() as tmpdir:
            clone(self.wiki.source, tmpdir)

            print("The following Markdown Files are available in this GitHub Wiki:")
            for file in os.listdir(tmpdir):
                if file.endswith(".md"):
                    print("=>    " + file)

                if "LOG" in file.upper():
                    print("      - Time: " + calculate(tmpdir + "/" + file))


def calculate(file):
    # File reading
    f = open(file)
    log = str(f.read())
    f.close()

    hours = re.findall(p_hours, log)
    minutes = re.findall(p_minutes, log)

    total_hours = 0
    total_minutes = 0

    for h in hours:
        total_hours += int(h[:-1])

    for m in minutes:
        total_minutes += int(m[:-1])
        total_hours += int(total_minutes / 60)
        total_minutes %= 60

    return str(total_hours) + "h " + str(total_minutes) + "m"

if __name__ == "__main__":
    LogReader(sys.argv)
    input("")
