from random import randint

left = 0
right = 100

x = randint(left, right)

# count_perebor = 0
# # Метод последовательного перебора
# for i in range(0, 101):
#     count_perebor += 1
#     if i == x:
#         print ("Число найдено!")
#         break

# print ("Загаданное число было", x, "и для его поиска перебором потребовалось", count_perebor, "итераций")

# count_random = 1
# # метод случайного отгадывания
# y = randint(0, 100)
# while x != y:
#     y = randint(0, 100)
#     count_random += 1

# print ("Загаданное число было", x, "и для его поиска угадыванием потребовалось", count_random, "итераций")

count_bin = 0
# метод деления пополам
print('Давай начнем игру - угадай число от 0 до 100')

mid = (right + left) // 2
while x != mid:
    if x < mid: 
        print (mid, "Меньше")
        right = mid - 1
    else: 
        print(mid, "Больше")
        left = mid + 1
    mid = (right + left) // 2
    count_bin += 1

print ("Загаданное число было", x, "и для его поиска бинарным алгоритмом потребовалось", count_bin, "итераций")