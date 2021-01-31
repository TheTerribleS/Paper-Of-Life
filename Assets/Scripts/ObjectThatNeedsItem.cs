using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThatNeedsItem : MonoBehaviour
{
    public string nameOfItemNeeded;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Inventory>() != null)
        {
            Inventory Inventory = collision.gameObject.GetComponent<Inventory>();
            if (Inventory.PlayerInventory.Find(Item => Item.nameOfItem == nameOfItemNeeded) != null)
            {
                Inventory.PlayerInventory.Remove(Inventory.PlayerInventory.Find(Item => Item.nameOfItem == nameOfItemNeeded));
                for (int i = 0; i < gameObject.transform.childCount; i++)
                {
                    gameObject.GetComponentInChildren<Transform>().parent = null;
                }
                gameObject.SetActive(false);
            }
        }
    }
}
