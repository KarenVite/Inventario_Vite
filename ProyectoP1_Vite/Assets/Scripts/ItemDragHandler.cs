using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Maneja el drag and drop
public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;

    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / FindObjectOfType<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void SetDragging(bool isDragging)
    { 
       canvasGroup.blocksRaycasts = isDragging;
    }

    public Item GetItem()
    {
        return GetComponent<ItemSlot>().item;
    }
}
