using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class Car
// {
//  public string Name;
//  public int Cost;
// public int BuyCount;
// }

// public class CarFactory // енто класс
// {
//  public Car[] carArray = new Car[3]; // базовый массив
//  public List<Car> carList = new List<Car>(); // lдинамический массив (самая удобная структура данных)
//  public LinkedList<Car> carLinkedList = new LinkedList<Car>(); // связный список, каждый элемент хранит ссылку на следующий элемент, не работает по индексу вроде (можно не использовать особо)

//    public void Init() // обьявляем метод Init
//    {
//  var bmw = new Car();
//  var audi = new Car();
//  var lada = new Car();

//   carArray[0] = bmw;
//  carArray[1] = audi;
//   carArray[2] = lada;

//  carList.Add(bmw);
//  carList.Add(audi);
//  carList.Add(lada);

//   carLinkedList.AddFirst(bmw);

//   var startPrice = 100;

//  for (int i = 0; i < 3; i++) // цикл for
//    {
//   carList[i].Cost = startPrice + i;
//     }

//  for (int i = 0; i < carList.Count; i++)
//   {
//    carList[i].Cost = startPrice + i;
//    }

//  foreach (var car in carList) // цикл foreach перебирает каждый элемент массива без использования итераторов
//    {
//  car.Cost = startPrice;
//   }

//  while (bmw.BuyCount < 10) // цикл while
//    {
//   bmw.Cost -= 10;
//    bmw.BuyCount++;
//  }

//  do  // цикл do while выполняется всегда хотя бы 1 раз даже если условие неккоректное
//    {

//     }//  while (bmw.BuyCount < 10);



// }
// public void CreateCar(string name)  // это метод
// {
//  switch (name)
//   {
//   case "BMW":

//     throw new Exception();
//   case "Audi":
//       return;  // выкидывает из метода

//   case "Lada":
//      float number = 1.5f; // создаем переменную с плавающей запятой

//        int secondNumber = (int)number; // приводим переменную secondnumber к целому числу

//        secondNumber = int.Parse("1"); // конвертируем переменную secondNumber в строку
//       secondNumber = Convert.ToInt32("1"); // класс Convert для конвертации

//    case "Reno":
//        break; // выкидывает из цикла switch
//    default:
//       MakeException();
//        break;
//   }

// }
// public void MakeException()
// {
// 
// }
// }