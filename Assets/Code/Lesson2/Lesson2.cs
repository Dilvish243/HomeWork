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

// public class CarFactory // ���� �����
// {
//  public Car[] carArray = new Car[3]; // ������� ������
//  public List<Car> carList = new List<Car>(); // l������������ ������ (����� ������� ��������� ������)
//  public LinkedList<Car> carLinkedList = new LinkedList<Car>(); // ������� ������, ������ ������� ������ ������ �� ��������� �������, �� �������� �� ������� ����� (����� �� ������������ �����)

//    public void Init() // ��������� ����� Init
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

//  for (int i = 0; i < 3; i++) // ���� for
//    {
//   carList[i].Cost = startPrice + i;
//     }

//  for (int i = 0; i < carList.Count; i++)
//   {
//    carList[i].Cost = startPrice + i;
//    }

//  foreach (var car in carList) // ���� foreach ���������� ������ ������� ������� ��� ������������� ����������
//    {
//  car.Cost = startPrice;
//   }

//  while (bmw.BuyCount < 10) // ���� while
//    {
//   bmw.Cost -= 10;
//    bmw.BuyCount++;
//  }

//  do  // ���� do while ����������� ������ ���� �� 1 ��� ���� ���� ������� ������������
//    {

//     }//  while (bmw.BuyCount < 10);



// }
// public void CreateCar(string name)  // ��� �����
// {
//  switch (name)
//   {
//   case "BMW":

//     throw new Exception();
//   case "Audi":
//       return;  // ���������� �� ������

//   case "Lada":
//      float number = 1.5f; // ������� ���������� � ��������� �������

//        int secondNumber = (int)number; // �������� ���������� secondnumber � ������ �����

//        secondNumber = int.Parse("1"); // ������������ ���������� secondNumber � ������
//       secondNumber = Convert.ToInt32("1"); // ����� Convert ��� �����������

//    case "Reno":
//        break; // ���������� �� ����� switch
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