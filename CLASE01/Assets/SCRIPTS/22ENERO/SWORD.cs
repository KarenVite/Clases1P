using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWORD : MonoBehaviour
{
    public int Daño;
    public int Resistencia;

    public virtual void Ataque()
    {

    }
}

public class Madera : SWORD
{
    public Madera()
    {
        Daño = 5;
        Resistencia = 15;
    }
}

public class Piedra : SWORD
{
    public Piedra()
    {
        Daño = 10;
        Resistencia = 25;
    }
}

public class Hierro : SWORD
{
    public Hierro()
    {
        Daño = 15;
        Resistencia = 35;
    }
}

public class Oro : SWORD
{
    public Oro()
    {
        Daño = 15;
        Resistencia = 25; //Porque la de Oro no sirve para nadota 
    }
}

public class Diamante : SWORD
{
    public Diamante()
    {
        Daño = 25;
        Resistencia = 45;
    }
}
