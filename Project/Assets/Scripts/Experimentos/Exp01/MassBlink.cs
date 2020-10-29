using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassBlink : MonoBehaviour
{
    public string answer;
    public GameObject experiment;
    private void OnMouseDown() {
        experiment.GetComponent<Experimento01>().ChangeBlinkState(answer);
    }
}
