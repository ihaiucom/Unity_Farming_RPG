using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Item item = other.GetComponent<Item>();

        if (item != null)
        {
            // Get item details

            ItemDetails itemDetails = InventoryManager.Instance.GetItemDetails(item.ItemCode);

            // If item can be picked up
            if (itemDetails.canBePickedUp == true)
            {
                // Add item to inventory
                InventoryManager.Instance.AddItem(InventoryLocation.player, item, other.gameObject);
            }
        }
    }
}
