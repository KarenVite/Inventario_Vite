using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Son Script que contienen clase derivadas que heredan la clase dderivada de nombre item
public class Sword : Item
{
    public string tipo{get; set;}
    public string rareza{get; set;}
    public string habilidad{ get; set;}

    public Sword(string name, Sprite sprite, string descrip, int vida, string tipo, string rareza, string habilidad) : base(name, sprite, descrip, vida)
    {
        tipo = tipo;
        rareza = rareza;
        habilidad = habilidad;
    }
}
