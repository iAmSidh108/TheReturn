using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Actions/Help")]
public class Help : Action
{
    public override void RespondToInput(GameController controller, string verb)
    {
        controller.currentText.text = "Type a Verb followed by a noun(E.g. \"Go North\") ";
        controller.currentText.text += "\nAllowed Verbs:\nGo, Examine,Get, Use, Inventory, Give, Say, Read, TalkTo, Help ";

    }
}
