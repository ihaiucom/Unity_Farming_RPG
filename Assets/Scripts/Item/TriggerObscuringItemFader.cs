using UnityEngine;

public class TriggerObscuringItemFader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Get the gameobject we have collided with, ad then get all the Obscuring Item Fader components on it and its children - and then trigger the out

        ObscuringItemFader[] obscuringItemFader = other.gameObject.GetComponentsInChildren<ObscuringItemFader>();

        if (obscuringItemFader.Length > 0)
        {
            for (int i = 0; i < obscuringItemFader.Length; i++)
            {
                obscuringItemFader[i].FadeOut();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Get the gameobject we have collided with, and then get all the Obscuring Item Fader components on it and its children - and then trigger the fade in

        ObscuringItemFader[] obscuringItemFader = other.gameObject.GetComponentsInChildren<ObscuringItemFader>();

        if (obscuringItemFader.Length > 0)
        {
            for (int i = 0; i < obscuringItemFader.Length; i++)
            {
                obscuringItemFader[i].FadeIn();
            }
        }
    }
}