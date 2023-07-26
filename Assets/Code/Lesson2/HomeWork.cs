using UnityEngine;



public class HomeWork : MonoBehaviour
{
    bool bull = true; // 1) Создать переменную булл
    int[] MassiveInt = new int[5]; // 1) в зависимости от ее значения создать массив int\float
    float[] MassiveFl = new float[5]; // 1) в зависимости от ее значения создать массив int\float
    int x = 2; // 2) Создать переменную типа int\float.
    float y = 5f; // 2) Создать переменную типа int\float.


    void Start()
    {
        if (bull == true)
        {
            try // 3) Создать и отловить исключение ( переполнение значения)
            {
                for (int i = 0; i < 6; i++)  // 2) Заполнить массив так, чтобы каждый елемент был квадратом предыдущего. i < 6 создает исключение т.к. длина списка равна 5
                {
                    if (i == 0)
                    {
                        MassiveInt[i] = x;
                        Debug.Log(MassiveInt[i]); // вывод на консоль для самопроверки
                    }
                    else
                    {
                        MassiveInt[i] = methodOne(MassiveInt[i - 1]);
                        Debug.Log(MassiveInt[i]); // вывод на консоль для самопроверки
                    }

                }
            }
            catch
            {
                Debug.Log("Out of range"); // Выводим сообщение об исключении
            }
        }
        else
        {
            try // 3) Создать и отловить исключение ( переполнение значения)
            {
                for (int i = 0; i < 6; i++)  // 2) Заполнить массив так, чтобы каждый елемент был квадратом предыдущего. i < 6 создает исключение т.к. длина списка равна 5
                {
                    if (i == 0)
                    {
                        MassiveFl[i] = y;
                        Debug.Log(MassiveFl[i]); // вывод на консоль для самопроверки
                    }
                    else
                    {
                        MassiveFl[i] = methodTwo(MassiveFl[i - 1]);
                        Debug.Log(MassiveFl[i]); // вывод на консоль для самопроверки
                    }

                }
            }
            catch
            {
                Debug.Log("Out of range"); // Выводим сообщение об исключении
            }
      
        }
    }
    public float methodTwo(float y) // 5) Создать функцию на вход передать переменную ( которая в задании 2). После выполнения функции. Сделать пункт 3\4
    {
        return y * y;
    }

    public int methodOne(int x) //  4) Создать функцию на вход передать переменную ( которая в задании 2). После выполнения функции. Сделать пункт 3\4
    {
        return x * x;
    }
    // Создать функцию на вход передать переменную REF( которая в задании 2). После выполнения функции. Сделать пункт 3\4
    public int methodRef(ref int x)
    {
        return x * x;
    }

    // REF
    public int methodOne(ref int x)
    {
        return x * x;
    }



}

