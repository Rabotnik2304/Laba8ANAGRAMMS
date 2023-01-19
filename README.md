# Laba8ANAGRAMMS
Задание 3. Веселье с анаграмами
Две строки являются анаграмами друг друга, если их можно получить перестановками символов - кол-во символов в строках одинаково и состоят из одного и того же набора символов. Например, слово "aaagmnrs" - это анаграма для слова "anagrams". Для данного массива слов удалите все слова, которые являются анаграмами для предыдущих слов в массиве. Оставшиеся строки отсортируйте по алфавиту.
Например, дан массив строк:

array = ['code', 'doce', 'ecod', 'framer', 'frame']


doce является анаграмой слова code, поэтому эту строку убираем из массива. То же касается строки ecod. framer не является анаграмой слова code, поэтому остается в массиве. Строка frame не является анаграмой ни строки code, ни строки framer, поэтому тоже остается в массиве.
После сортировки оставшихся элементов результатом выполнения будет массив:

result = ['code', 'frame', 'framer']
