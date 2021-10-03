using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Read")]
public class Read : Action
{
    public override void RespondToInput(GameController controller, string noun)
    {
        //use item in room
        if (ReadItem(controller, controller.player.currentLocation.items, noun))
            return;

        // ise item in inventory
        if (ReadItem(controller, controller.player.Inventory, noun))
            return;

        controller.currentText.text = "There is no " + noun;
    }

    private bool ReadItem(GameController controller, List<Item> items, string noun)
    {
        foreach(Item item in items )
        {
            if (controller.player.CanReadItem(controller, item))
            {
                if (item.InteractionWith(controller, "read"))
                    return true;
            }
        }
        return false;
    }
}
