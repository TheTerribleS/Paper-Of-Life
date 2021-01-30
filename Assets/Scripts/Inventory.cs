using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameItem> PlayerInventory;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<GameItem>() != null)
        {
            GameItem ItemToAdd = collision.gameObject.GetComponent<GameItem>();
            Debug.Log(ItemToAdd.textToDisplayOnPickUp);
            PlayerInventory.Add(ItemToAdd);
            ItemToAdd.gameObject.SetActive(false);
        }
    }
}
