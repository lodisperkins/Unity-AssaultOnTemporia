using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBehaviour : EventArgs
{
    private const int SLOTS = 9;

    private List<InventoryBehaviour> mItems = new List<InventoryBehaviour>();

    public event EventHandler<InventoryEventArgs> ItemAdded;

    public void AddItem(IInventoryItem item)
    {
        if(mItems.Count < SLOTS)
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;
                mItems.Add(item);

                item.Onpickup();

                if (ItemAdded != null)
                {
                    ItemAdded(this, new InventoryEventArgs(item));
                }
            }
        }
    }

	// Update is called once per frame
	void Update ()
    {
		
	}
	
}
