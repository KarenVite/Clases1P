using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    

    [Header("CLASE DERIVADA")]
    public string Raza;

    void Start()
    {
        //Name = "José";
        Display();
    }

    public override void move()
    {
        posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;

        Vector3 direccion = (posicionMouse - transform.position).normalized;

        transform.Translate(direccion * speed * Time.deltaTime);
    }

    void Update()
    {
        move();
    }

}
