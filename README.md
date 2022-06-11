# Final test work
## Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Решение:
1. На первом этапе создал метод, возвращающий массив из строк, при помощи которого по средствам ввода строчных данных создаем массив из нужного нам количества элементов.
2. На следующем этапе нарисовал блок-схему алгоритма основной части решения задачи. 
Согласно алгоритму, создавал новый массив, в который помещал элементы из исходного массива, удовлетворяющие заданному условию. В конце алгоритма из массива удаляю пустые ячейки.
3. Далее создал метод на основании блок-схемы. Метод принимает исходный массив строк, а возвращает новый массив трок, согласно заданному условию. Суть метода заключается в том, что в начале задаем новый пустой массив размером равный исходному массиву и переменную счетчик (равную изначально 0), которая будет считать элементы, неудовлетворяющие условию задачи. 
4. Затем в цикле 'for' создаем строку из символов, в которую будем помещать наш i-ый элемент исходного массива и проверять удовлетворяет ли он условию задачи. 
5. Далее если элемент удовлетворяет, заданному условию, помещаем его в новый массив, корректирую его местонахождение счетчиком (для того, чтобы если на предыдущем шаге попался элемент, не удовлетворяющий условию, у нас в массиве не осталась не заполненная ячейка). В итоге все элементы помещаются по порядку в новый массив, а пустые ячейки остаются в конце массива и в итоге удаляются.
6. В конце создал метод для печати массива.
