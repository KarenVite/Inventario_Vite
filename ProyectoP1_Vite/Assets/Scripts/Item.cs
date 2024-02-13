using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item : MonoBehaviour
{
    //Definir propiedades del item
    //{get, set} se usan para poder llamar los valores desde otro lugar. caracteristicas orientadas a la programación de objetos
    public Sprite sprite { get; set; }
    public string name { get; set; }
    public int vida { get; set; }
    public string descrip { get; set; }

    //Constructor
    public Item(string name, Sprite sprite, string descrip, int vida)
    {
        name = name;
        sprite = sprite;
        descrip = descrip;
        vida = vida;
    }
}
