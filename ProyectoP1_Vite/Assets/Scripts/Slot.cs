using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Va a manejar el comportamiento de los slots del inventario y tmb contendrá el Drag and Drop
public class Slot : MonoBehaviour, IDropHandler
{
    private Inventario inventario;

    public void SetInventory(Inventario inv)
    {
        inventario = inv;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            ItemDragHandler dragHandler = eventData.pointerDrag.GetComponent<ItemDragHandler>();

            if (dragHandler != null)
            {
                Item item = dragHandler.GetItem();
                inventario.RemoveItem(item);
                Destroy(eventData.pointerDrag);
            }
        }
    }
}
