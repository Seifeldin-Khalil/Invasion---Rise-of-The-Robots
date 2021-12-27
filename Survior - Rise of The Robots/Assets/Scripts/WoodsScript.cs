using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodsScript : MonoBehaviour
{
    public Dialogue dialogueManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            string[] dialogue =
            {
                "Woods: Alex! you are finally out.",
                "Alex: What is happening! why are there robots everywhere?",
                "Woods: Thats a long story, but I will sum it up",
                "Woods: For the past couple of years, humans have turned to robots to perform tasks they didnt want to do...",
                "Woods: but after a while humans wanted the robots to do everything while they relaxed...",
                "Woods: so humans kept on evolving and upgrading the robots technologies untill they became too smart...",
                "Woods: and now the robots have a mind of their own and want to take over the world...",
                "Woods: the only way to stop them is to destroy Ultron, the smartest robot controlling all the other robots...",
                "Woods: you will find him in a building on the other side of the city.",
                "Alex: Im on it, i will find and destroy Ultron.",
                "Woods: Goodluck,Alex, you'r gonna need it."
            };
            dialogueManager.SetSentences(dialogue);
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue());
        }
        
    }
}
