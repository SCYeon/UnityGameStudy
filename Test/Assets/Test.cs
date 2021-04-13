using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mission 1
public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "�������� ������");
    }
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� ������");
    }
}

//Mission 2
public class Rectangle
{
    private int width = 100;
    private int height = 50;

    public void evalArea()
    {
        Debug.Log("���簢�� �ѷ�: " + ((this.width * 2) + (this.height * 2)));
    }
    public void evalPerimeter()
    {
        Debug.Log("���簢�� ����: " + this.width * this.height);
    }
}

//Mission 3
public class Lecture
{
    string name;
    int id = 0;
    int[] score;

    public void evalAverage(int id, string name, int[] score)
    {
        int sum = 0;
        for (int i = 0; i < score.Length; i++)
        {
            sum += score[i];
        }
        int average = sum / score.Length;
        

        Debug.Log(id + ". " + name + "�� ���� ����: " + score[0] +", "+ score[1] + ", " + score[2] + ", " + score[3] + ", " + score[4] + "\n���: " + average);
    }
}   

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Mission 1
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        //Mission 2
        Rectangle myRectangle = new Rectangle();
        myRectangle.evalArea();
        myRectangle.evalPerimeter();

        //Mission 3
        Lecture myStudent = new Lecture();
        int[] Jenny_score = { 80, 85, 85, 90, 100 };
        myStudent.evalAverage(1, "Jenny", Jenny_score);

        int[] Jisu_score = { 70, 100, 95, 90, 80 };
        myStudent.evalAverage(2, "Jisu", Jisu_score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
