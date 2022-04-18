
import Worker


def main():
    path1 = "C:\\Users\\HP\\Desktop\\OP2.2p\\calls"
    path2 = "C:\\Users\\HP\\Desktop\\OP2.2p\\daycalls"
    path3 = "C:\\Users\\HP\\Desktop\\OP2.2p\\nightcalls"
    answer = str(input("Add to file(Yes) or create new one(No):"))
    Worker.append_or_create(path1, path2, path3, answer)
    calls = Worker.take_calls()
    Worker.append_to_file(path1, Worker.list_to_str(calls))
    Worker.print_file(path1)
    day, night = Worker.day_or_night(calls)
    Worker.append_to_file(path2, day)
    Worker.append_to_file(path3, night)
    print("Day calls:")
    Worker.print_file(path2)
    print("Night calls:")
    Worker.print_file(path3)

main()
