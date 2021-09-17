﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание базы данных из 20 сотрудников
            //Repository repository = new Repository(40);

            //// Печать в консоль всех сотрудников
            //repository.Print("База данных до преобразования");

            //// Увольнение всех работников с именем "Агата"
            //repository.DeleteWorkerByName("Агата");

            //// Печать в консоль сотрудников, которые не попали под увольнение
            //repository.Print("База данных после первого преобразования");

            //// Увольнение всех работников с именем "Аделина"
            //repository.DeleteWorkerByName("Аделина");

            //// Печать в консоль сотрудников, которые не попали под увольнение
            //repository.Print("База данных после второго преобразования");



            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            //Repository repository = new Repository(20);

            // Печать в консоль всех сотрудников
            //repository.Print("База данных до преобразования");

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе должно остаться не более 30 работников

            //Repository repository = new Repository(40);
            //repository.Print("База данных до преобразования");
            //Console.ReadLine();

            //repository.DeleteWorkeUntillThirty();
            //repository.Print("База данных после первого преобразования");


            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб
            Repository repository = new Repository(50);
            repository.Print("База данных до преобразования");
            Console.ReadLine();

            repository.DeleteWorkerBySalary(30000);
            repository.Print("База данных после первого преобразования");


            #endregion
            Console.ReadLine();

        }
    }
}
