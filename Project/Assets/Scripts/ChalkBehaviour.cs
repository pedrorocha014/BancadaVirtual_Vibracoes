using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown() {
        gameObject.GetComponent<MeshRenderer>().enabled =! gameObject.GetComponent<MeshRenderer>().enabled;
    }
}
