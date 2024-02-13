using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solo almacena un objeto y le da un metodo para establecerlo
public class ItemSlot : MonoBehaviour
{
    public Item item;

    public void SetItem(Item newItem)
    {
        item = newItem;
    }
}
