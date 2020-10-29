using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;

	public void TriggerDialogue (int id)
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue, id);
	}

	public void ReLoadDialogue(int id){
		FindObjectOfType<DialogueManager>().ReLoadSentences(dialogue, id);
	}

}
