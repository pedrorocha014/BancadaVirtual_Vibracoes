using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Para verificar:
//[] - A declaração do array cameraPositions talvez não seja o correto e,
//     talvez, a melhor forma seja usando uma lista.
//[] - Verificar a melhor sensibilidade para o translado da câmera.
//[] - Botar a parte do pós-processamento aqui.
//[] - Verificar outras funções e funcionalidades.

public class CameraControl : MonoBehaviour
{
    [Header("Posição das câmeras")]
    public GameObject[] cameraPositions;
    //Posição inicial/atual da câmera e o fator de interpolação para transladar a câmera.
    private Vector3 initialAngle;
    private Vector3 initialPosition;
    private float interpolateFactor;
    //Variável que recebe true quando a coroutine está acontecendo.
    private bool isCoroutine;
    //Index do array/list que deseja-se manipular.      
    private int index;

    void Start() {
        transform.position = cameraPositions[0].transform.position;
        transform.localEulerAngles = cameraPositions[0].transform.localEulerAngles;
        isCoroutine = false;
    }

    //Translada a câmera para a posição desejada a partir do index.
    //A função chama uma coroutine, onde é feita a interpolação por meio
    //da função Vector3.Lerp().
    public void TranslateCameraById(int index){
        this.index = index;
        if(!isCoroutine){StartCoroutine("TranslateCamera");}
    }

    private IEnumerator TranslateCamera(){
        interpolateFactor = 0;
        initialPosition = transform.position;
        initialAngle = transform.localEulerAngles;
        isCoroutine = ! isCoroutine;

        while(interpolateFactor < 1){
            transform.position = Vector3.Lerp(initialPosition, cameraPositions[index].transform.position, interpolateFactor);
            transform.localEulerAngles = Vector3.Lerp(initialAngle, cameraPositions[index].transform.localEulerAngles, interpolateFactor);
            yield return new WaitForSeconds(0.01f);
            interpolateFactor += 0.02f;
        }

        transform.position = cameraPositions[index].transform.position;
        transform.localEulerAngles = cameraPositions[index].transform.localEulerAngles;

        isCoroutine = ! isCoroutine;
    }

    public void CloseApplication(){
        Application.Quit();
    }
}