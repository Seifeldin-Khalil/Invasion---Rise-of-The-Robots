using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    private string[] dialogueSentences;
    private int index = 0;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogueBox;
    public Rigidbody2D player;

    private void Start()
    {
        dialogueBox.SetActive(false);
        continueButton.SetActive(false);

        //dialogueSentences = new string[11];
        //dialogueSentences[0] = "Woods: Alex! you are finally out.";
        //dialogueSentences[1] = "Alex: What is happening! why are there robots everywhere?";
        //dialogueSentences[2] = "Woods: Thats a long story, but I will sum it up";
        //dialogueSentences[3] = "Woods: For the past couple of years, humans have turned to robots to perform tasks they didnt want to do...";
        //dialogueSentences[4] = "Woods: but after a while humans wanted the robots to do everything while they relaxed...";
        //dialogueSentences[5] = "Woods: so humans kept on evolving and upgrading the robots technologies untill they became too smart...";
        //dialogueSentences[6] = "Woods: and now the robots have a mind of their own and want to take over the world...";
        //dialogueSentences[7] = "Woods: the only way to stop them is to destroy Ultron, the smartest robot controlling all the other robots...";
        //dialogueSentences[8] = "Woods: you will find him in a building on the other side of the city.";
        //dialogueSentences[9] = "Alex: Im on it, i will find and destroy Ultron.";
        //dialogueSentences[10] = "Goodluck,Alex, you'r gonna need it";

    }

    public IEnumerator TypeDialogue()
    {
        dialogueBox.SetActive(true);
        player.constraints = RigidbodyConstraints2D.FreezeAll;

        foreach (char letter in dialogueSentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds (typingSpeed);
            if (textDisplay.text == dialogueSentences[index])
            {
                continueButton.SetActive(true);
            }
        }
    }
    public void SetSentences(string[] sentences)
    {
        this.dialogueSentences = sentences;
    }


    public void NextSentence()
    {
        continueButton.SetActive(false);
        if(index < dialogueSentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(TypeDialogue());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            dialogueBox.SetActive(false);
            this.dialogueSentences = null;
            index = 0;
            player.constraints = RigidbodyConstraints2D.None;
        }
    }
}
