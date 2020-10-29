using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;

	public Animator animator;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
	}

	public void StartDialogue (Dialogue dialogue,int sentenceId)
	{
		int count = 0;
		//EndDialogue();
		//animator.SetBool("IsOpen", true);

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			if(count >= sentenceId) { sentences.Enqueue(sentence); Debug.Log(sentence); }
		}

		DisplayNextSentence();
	}

	public void ReLoadSentences(Dialogue dialogue, int sentenceId){
		int count = 0;
		
		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			if(count >= sentenceId) { sentences.Enqueue(sentence); Debug.Log(sentence); }
			
			count ++;
		}
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		animator.SetBool("IsOpen", false);
	}

}
