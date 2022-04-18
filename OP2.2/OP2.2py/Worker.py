import datetime
from datetime import timedelta
from Caller import call_info


def create_file(path):
    file_hander = open(path, "wb")
    file_hander.close()


def append_to_file(path, text: str):
    with open(path, "ab") as file:
        calls = str.encode(text)
        file.write(calls)


def read_file(path) -> str:
    calls = []
    with open(path, "rb") as file:
        calls = file.read()
    return calls.decode()


def print_file(path):
    print(read_file(path))


def take_calls() -> list[call_info]:
    count_calls = int(input("Enter num of calls: "))
    calls_and_time = {}
    calls = []
    for i in range(count_calls):
        call = call_info(
            input("Enter T num: "),
            datetime.datetime.strptime(input("Enter start time: "), "%H:%M").time(),
            datetime.datetime.strptime(input("Enter end time: "), "%H:%M").time(),
        )
        calls.append(call)

    return calls


def list_to_str(calls: list):
    calls_str = []
    for call in calls:
        calls_str.append(str(call))
    return '\n'.join(calls_str)


def day_or_night(calls: list):
    day = []
    night = []
    for call in calls:
        if 6 <= call.start.hour <= 20:
            day.append(call)

        else:
            night.append(call)
    return '\n'.join([str(x) for x in day]), '\n'.join([str(x) for x in night])


def append_or_create(path1, path2, path3, answer):
    if answer == "Yes":
        append_to_file(path1, '\n')
        append_to_file(path2, '\n')
        append_to_file(path3, '\n')
    else:
        create_file(path1)
        create_file(path2)
        create_file(path3)
