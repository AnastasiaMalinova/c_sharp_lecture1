﻿// Поиск позиции нужного нам элемента
int[] array = {51, 22, 31, 4, 35, 26, 87, 18};
// определяем сколько элементов содержится в массиве
// array.Leight - возвращает длину или кол-во элементов массива
int n = array.Length;
// нужно найти значение 4, допустим пользователь вводит значение 4
int find = 4;
int index = 0;
while (index < n)
{
    if(array [index] == find)  // если array [index] совпал с find
    {
        Console.WriteLine(index);
    } 
    // index = index + 1;
    index++;
}