using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventario : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public int capacidad = 8;

    public GameObject slotPrefab;

    public Transform slotPanel;

    public Text datos;

    private void Start()
    {
        //Inicializar el inventario
        for (int i = 0; i < capacidad; i++)
        {
            GameObject slot = Instantiate(slotPrefab, slotPanel);

            //Asignar metodos Drag, drop y eliminar
            Slot slotScript = slot.GetComponent<Slot>();
            slotScript.SetInventory(this);
        }       
    }

    public void AddItem(Item item)
    {
        //para agregar objetos
        if (items.Count < capacidad)
        {
            items.Add(item);
            UpdateUI();
        }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        UpdateUI();
    }

    public void SelectItem(Item item)
    {

    }

    //Este va a mostrar la descripción del item cuando el cursor esté sobre el
    public void ShowItemInfo(Item item)
    {
        datos.text = $"Nombre:{item.name} \n Vida: {item.vida} \n Descripción: {item.descrip}";
    }

    //Este hará que la información desaparezca en cuanto quitemos el cursor
    public void ClearItemInfo(Item item)
    {
        datos.text = "";
    }

    //Actualizar la interfaz de usuario con la lista de objetos del inventario 
    private void UpdateUI()
    {
        foreach(Transform child in slotPanel)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0;i < capacidad; i++)
        {
            GameObject slot = Instantiate(slotPrefab, slotPanel);
            ItemSlot itemSlot = slot.GetComponent<ItemSlot>();
            itemSlot.SetItem(items[i]);
        }
    }

   
}
