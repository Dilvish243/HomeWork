using UnityEngine;



public class HomeWork : MonoBehaviour
{
    bool bull = true; // 1) ������� ���������� ����
    int[] MassiveInt = new int[5]; // 1) � ����������� �� �� �������� ������� ������ int\float
    float[] MassiveFl = new float[5]; // 1) � ����������� �� �� �������� ������� ������ int\float
    int x = 2; // 2) ������� ���������� ���� int\float.
    float y = 5f; // 2) ������� ���������� ���� int\float.


    void Start()
    {
        if (bull == true)
        {
            try // 3) ������� � �������� ���������� ( ������������ ��������)
            {
                for (int i = 0; i < 6; i++)  // 2) ��������� ������ ���, ����� ������ ������� ��� ��������� �����������. i < 6 ������� ���������� �.�. ����� ������ ����� 5
                {
                    if (i == 0)
                    {
                        MassiveInt[i] = x;
                        Debug.Log(MassiveInt[i]); // ����� �� ������� ��� ������������
                    }
                    else
                    {
                        MassiveInt[i] = methodOne(MassiveInt[i - 1]);
                        Debug.Log(MassiveInt[i]); // ����� �� ������� ��� ������������
                    }

                }
            }
            catch
            {
                Debug.Log("Out of range"); // ������� ��������� �� ����������
            }
        }
        else
        {
            try // 3) ������� � �������� ���������� ( ������������ ��������)
            {
                for (int i = 0; i < 6; i++)  // 2) ��������� ������ ���, ����� ������ ������� ��� ��������� �����������. i < 6 ������� ���������� �.�. ����� ������ ����� 5
                {
                    if (i == 0)
                    {
                        MassiveFl[i] = y;
                        Debug.Log(MassiveFl[i]); // ����� �� ������� ��� ������������
                    }
                    else
                    {
                        MassiveFl[i] = methodTwo(MassiveFl[i - 1]);
                        Debug.Log(MassiveFl[i]); // ����� �� ������� ��� ������������
                    }

                }
            }
            catch
            {
                Debug.Log("Out of range"); // ������� ��������� �� ����������
            }
      
        }
    }
    public float methodTwo(float y) // 5) ������� ������� �� ���� �������� ���������� ( ������� � ������� 2). ����� ���������� �������. ������� ����� 3\4
    {
        return y * y;
    }

    public int methodOne(int x) //  4) ������� ������� �� ���� �������� ���������� ( ������� � ������� 2). ����� ���������� �������. ������� ����� 3\4
    {
        return x * x;
    }
    // ������� ������� �� ���� �������� ���������� REF( ������� � ������� 2). ����� ���������� �������. ������� ����� 3\4
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

