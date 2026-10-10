using System;
//int total = 8;
//for (int number = total; number >= 1; number--) {
//    Console.WriteLine($"Упражнение {number}");
//}
//Console.WriteLine("Домашнее задание готово");
//
//for (int room = 5; room <= 50; room += 5) {
//    Console.WriteLine($"Кабинет {room}");
//}

//int total = 3;
//for (int week = 1; week <= totalWeeks; week++) {
//    for (int day = 1; day <= 5; day++) {
//        Console.WriteLine($"Неделя {week}, день {day}");
//    }
//    Console.WriteLine("^_^");
//}
//
//int propusk = 0;
//
//for (int ticket = 1; ticket <= 30; ticket++) {
//    if (ticket == 4 || ticket == 12 || ticket == 19) {
//        propusk++; 
//        continue;
//    }
//    Console.WriteLine($"Первый доступный билет: {ticket}");
//    Console.WriteLine($"Пропущено билетов: {propusk}");
//    break;
//}
//
//for (;;) {
//    Console.Write("Введите код группы (для выхода — «выход»): ");
//    string groupCode = Console.ReadLine()!;
//
//    if (groupCode == "выход") {
//        break;
//    }
//
//    Console.WriteLine($"Записан код группы: {groupCode}");
//}
//
//Console.WriteLine("Работа с журналом завершена");

//* a
//int n = 15;
//for (int i = 1; i <= n; i += 2) {Console.WriteLine(i);}
//Console.WriteLine("Готово");
////b
//for (int i = 100; i >= 0; i -= 10) {
//    Console.WriteLine(i);
//}
//**2
//int n = 50;
//int m = 7;
//for (int i = n; i >= 0; i -= m) {
//    Console.WriteLine(i);
//}
////3
//int n = 10;
//for (int i = 1; i <= n; i++) {
//    Console.WriteLine($"{i} -> {i * i * i}");
//}