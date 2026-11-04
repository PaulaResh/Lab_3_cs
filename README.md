### Решетникова Полина ЛА-1 Лабораторная №3
# ЗАДАНИЕ 1.

## ТЕКСТ ЗАДАЧИ:
Реализовать заполнение массива тремя способами через конструкторы.

## АЛГОРИТМ РЕШЕНИЯ:
Класс содержит единственное поле `double[,] _data`. Реализовано 4 конструктора: 
базовый, с клавиатуры (в обратном порядке), по диагоналям (случайные числа) и 
треугольный. Размеры определяются через `_data.GetLength()`.

## ТЕСТИРОВАНИЕ
### 1 способ
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/g0JeLIs3kFwq_utru7oPT5avCivRxgHhKpntgEQyzyhjvy3yuqfO8UT0oSyyFHzbnQd0pGVfBX1yx26X8OsOEbOD.jpg?quality=95&as=32x27,48x41,72x61,108x91,160x135,240x203,304x257&from=bu&cs=304x0)
![](https://sun9-39.vkuserphoto.ru/s/v1/ig2/De0FKudtnDikMN7nt0Qi0DpfQ9JxMRAKBV2gcbmSWPWYGYdYNrYXIO9Rwe41BGomQqDxO0iU_rFhUo3-ZmoXpxAY.jpg?quality=95&as=32x24,48x37,72x55,108x82,160x122,240x183,360x274,411x313&from=bu&cs=411x0)
### 2 способ
![](https://sun9-51.vkuserphoto.ru/s/v1/ig2/lTiYGE1IQ76RggbKwM9Q1myoK9Rh3_8PY_RPeHFQTmqp075kwfho9-2kW_P_J6uENUNma-8_gg728x2NzoDlCaec.jpg?quality=95&as=32x27,48x41,72x62,108x93,160x137,240x206,277x238&from=bu&cs=277x0)
### 3 способ
![](https://sun9-45.vkuserphoto.ru/s/v1/ig2/BX8TLd0q3AWyX7r1PEaEN1Pu3KGm1qcJ6Lv9GXSKe89N2eBPGan6UxVZqKQk-PuPnl22sivqfTP2--IhIrYpu0Zo.jpg?quality=95&as=32x18,48x28,72x42,108x62,160x92,240x139,327x189&from=bu&cs=327x0)
# ЗАДАНИЕ 2.

## ТЕКСТ ЗАДАЧИ:
 Найти максимальный элемент, встречающийся в массиве ровно один раз.
 
## АЛГОРИТМ РЕШЕНИЯ:

Метод `FindMaxUnique` использует вложенные циклы для подсчета вхождений 
каждого элемента. Если счетчик равен 1 и элемент больше текущего максимума, он 
запоминается. LINQ не используется.


## ТЕСТИРОВАНИЕ
![](https://sun9-16.vkuserphoto.ru/s/v1/ig2/X-3CYkxwiMApJy7n_TpruNrKzFSezYV7ib3k47MEiG9Uh9E2nxukckGp3bNyHhHLjGmBwmWJzquURwj3HEPYmD2Y.jpg?quality=95&as=32x39,48x58,72x88,108x132,160x195,240x292,311x379&from=bu&u=TcX7-NMFHndTsjzda8Xg6ZALlLF_cxI9AVF-Bw_364g&cs=311x0)
![](https://sun9-46.vkuserphoto.ru/s/v1/ig2/ndacraK_BDlO0gprN5QbkN5W_QjirhxZU_tG_DuyDBHh5USYC0inP8M2IkUJyPHbBq3Qgmfm22rtF7o8cUW6D6Lx.jpg?quality=95&as=32x36,48x54,72x81,108x122,160x181,240x271,307x347&from=bu&cs=307x0)

# ЗАДАНИЕ 3.

## ТЕКСТ ЗАДАЧИ:
Перегрузить операторы и вывести результат в виде таблицы.

## АЛГОРИТМ РЕШЕНИЯ:
Перегружены операторы `*` (матрица×матрица и скаляр×матрица) и `-`. 
Метод `ToString()` переопределен с использованием `PadLeft` для выравнивания столбцов.

## ТЕСТИРОВАНИЕ
![](https://sun9-56.vkuserphoto.ru/s/v1/ig2/r8k7YvaM31e-yOMUEnp3E-ufbk3Vci1JnlJeiVKXXfpazhW4ymc5cWd4i4TCHts7aHWrEhh7JGi3_6onsODaf_NW.jpg?quality=95&as=32x29,48x44,72x66,108x99,160x147,240x221,360x331,413x380&from=bu&cs=413x0)
![](https://sun9-83.vkuserphoto.ru/s/v1/ig2/5gxpfYlup3XvvMtrle-k78hEs0eoTldKANaDf9Bh5Fq5VuydjMyo2zddWLZiUt9YjlXH_9qm9Lgu-5VBv-w1gDtR.jpg?quality=95&as=32x33,48x50,72x74,108x111,160x165,240x248,360x372,432x446&from=bu&cs=432x0)
![](https://sun9-37.vkuserphoto.ru/s/v1/ig2/gVSne-pzG2pjJfe0HKEL9YSWdTNSWzB6TegBWj946QlvEHixWUlQ-4u_mbxPGt0sqkhCBPdDdzWykS51pfdYBc86.jpg?quality=95&as=32x14,48x20,72x31,108x46,160x68,240x102,281x120&from=bu&cs=281x0)

# ЗАДАНИЕ 4.

## ТЕКСТ ЗАДАЧИ:
Сгенерировать файл и переписать в новый только четные числа.

## АЛГОРИТМ РЕШЕНИЯ:
Метод `FillBinaryFile` заполняет файл через `BinaryWriter`. Метод 
`ExtractEvenNumbers` читает через `BinaryReader` и проверяет условие `num % 2 == 0`.

## ТЕСТИРОВАНИЕ
![](https://sun9-50.vkuserphoto.ru/s/v1/ig2/Ia_bMUNEhCYzWrDAzTarE-S-Tmvz67gBsPJ6KLJbUPqRiu4CP4IClDa5LBjhx2CNoPDlDXow-eySnzS2On9rOqG4.jpg?quality=95&as=32x20,48x30,72x45,108x67,160x100,240x150,255x159&from=bu&cs=255x0)
![](https://sun9-37.vkuserphoto.ru/s/v1/ig2/FKj0do2IOOqq_fBRP9446Jv-Ul5anjzITRAYtJL-dPJB6auWLTfAzjvO47zfhMLA1_8q3ncyG3oXodgeBLgYNBlA.jpg?quality=95&as=32x11,48x17,72x25,108x37,160x55,240x83,257x89&from=bu&u=eDlytL00xI4hhBESyTlMZ8T2x7PRoY1vZnFV_EhGQkY&cs=257x0)

# ЗАДАНИЕ 5.

## ТЕКСТ ЗАДАЧИ:
Найти пассажиров, чья средняя масса багажа отличается от общей 
средней не более чем на m кг.

## АЛГОРИТМ РЕШЕНИЯ:
Структура `BaggageItem` и класс `Passenger` помечены `[Serializable]`. 
Запись и чтение выполняются через `XmlSerializer`. Расчет средних значений 
производится через классические циклы `for`.

## ТЕСТИРОВАНИЕ
![](https://sun9-52.vkuserphoto.ru/s/v1/ig2/_cV2HjJlxpvxL7iBiKScPMscfHK23ic3AGSwusNbKB4V87Ve5DRzC1_3Sr95PPhBiHpBkUT50tonnluyu8bSHzh3.jpg?quality=95&as=32x23,48x34,72x51,108x77,160x114,240x171,334x238&from=bu&cs=334x0)

# ЗАДАНИЕ 6.

## ТЕКСТ ЗАДАЧИ:
Найти разность сумм первой и второй половин файла.

## АЛГОРИТМ РЕШЕНИЯ:
Массив строк получается через `File.ReadAllLines`. Цикл `for` делит 
индексы пополам и накапливает две суммы, затем выводит их разность.

## ТЕСТИРОВАНИЕ
![](https://sun9-63.vkuserphoto.ru/s/v1/ig2/0zEtQRN-eJxtRC-KGK4g3O8mPjQY5qamx91zAVDla56ZlC5pszJU2VpuaeCSGi0bWnXd1gbFayXOf-_yZsOOZPvz.jpg?quality=95&as=32x13,48x19,72x28,108x43,160x63,240x95,289x114&from=bu&cs=289x0)

# ЗАДАНИЕ 7.

## ТЕКСТ ЗАДАЧИ:
Вычислить сумму всех элементов файла.

## АЛГОРИТМ РЕШЕНИЯ:
Построчное чтение через `StreamReader`. Каждая строка разбивается 
методом `Split(' ')`, после чего элементы преобразуются в `int` и суммируются.

## ТЕСТИРОВАНИЕ
![](https://sun9-68.vkuserphoto.ru/s/v1/ig2/n8oEeN2H4Pf_I_N5_xDlkdjpwAxwkDJUFHWroYYzMPpLj95qakr-stEobDMMj8777rN164B1mnlbonXt9tfpDy6r.jpg?quality=95&as=32x14,48x22,72x32,108x48,160x72,240x108,261x117&from=bu&cs=261x0)

# ЗАДАНИЕ 8.

## ТЕКСТ ЗАДАЧИ:
Переписать в новый файл самую короткую и самую длинную строки.

## АЛГОРИТМ РЕШЕНИЯ:
При построчном чтении сравнивается `line.Length` с текущими минимальным 
и максимальными значениями. Найденные строки записываются через `StreamWriter`.

## ТЕСТИРОВАНИЕ
![](https://sun9-48.vkuserphoto.ru/s/v1/ig2/k_S2JEthm4rEGrEsjBTm8TjP8YEO0VZTASwtAbQkx7LB7J-TPoa2VgUn9Am4tJ_j9Q2T-prc4uGc6NDaXpiqtV9V.jpg?quality=95&as=32x5,48x7,72x11,108x17,160x25,240x37,360x56,480x75,540x84,640x100,720x112,855x133&from=bu&cs=855x0)
### text.txt
![](https://sun9-8.vkuserphoto.ru/s/v1/ig2/Z3OddJbCLeQk5qD7fqWn-RHHhTCkBk-4pcPEGwCC7BDLIGVjCYNd1VtAOrnC88BXOR08fGazITtj_v9qovdOpaRg.jpg?quality=95&as=32x6,48x9,72x13,108x20,160x30,240x45,360x67,480x89,540x100,640x119,662x123&from=bu&u=I5P8tKnOxcVDODV-7l1vECZ9R4szPttnKmQwu8xXrPE&cs=662x0)
### rezult.txt
![](https://sun9-46.vkuserphoto.ru/s/v1/ig2/ZdPUs7BDtmlCZ-DiE_CwCXm7xPSaffrI7YfIJq6tIjvR6hJPuNbcoF848D0gVBfrXwtBUBTurXWfnflAuw3Q60CB.jpg?quality=95&as=32x3,48x4,72x6,108x10,160x14,240x21,360x32,480x43,540x48,640x57,653x58&from=bu&u=thKlY8P7Fh98F65ngWFtYU5obBGl73lGcoTPpAtin5M&cs=653x0)

