using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Experimento01 : MonoBehaviour
{
    private int countStep;
    private bool isBlink;
    public GameObject cameraMenu;
    public GameObject controle;
    public GameObject questionPanel;
    public GameObject dialogueBox;
    public GameObject dialogueManager;
    public GameObject continueButton;
    public GameObject dialogueTrigger;
    public GameObject camera;
    public GameObject wheel;
    public GameObject marks_01;
    public GameObject marks_02;
    public GameObject marks_03;
    public GameObject mass_correta;
    public GameObject mass01;
    public GameObject mass02;
    public GameObject desbalanciamentoMass;
    public GameObject angleControl;
    private Imbalance imbalance = new Imbalance();
    public ParametrosControl parametrosControl;
    public GameObject massSelectorPanel;
    public MassController massBlinkController;
    public GameObject yesNoAnswer;
    public GameObject reLoadObject;
    private int selectedMass;
    private bool isReLoaded;
    public GameObject correctPanel;

    public void SetInitialObjectsStates()
    {
        cameraMenu.SetActive(false);
        controle.SetActive(false);
        continueButton.SetActive(false);
        dialogueBox.SetActive(true);

        countStep = 0;

        isReLoaded = false;

        StartCoroutine(FirstStep());
    }

    private IEnumerator FirstStep()
    {

        dialogueTrigger.GetComponent<DialogueTrigger>().TriggerDialogue(0);

        yield return new WaitForSeconds(4f);

        camera.GetComponent<CameraControl>().TranslateCameraById(1);

        countStep = 1;
        Debug.Log("step 1");
        StartCoroutine(SeccondStep());
    }

    private IEnumerator SeccondStep()
    {

        dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
        
        continueButton.SetActive(true);

        countStep = 2;
        Debug.Log("step 2");
        yield return null;
    }

    private IEnumerator ThirdStep()
    {

        camera.GetComponent<CameraControl>().TranslateCameraById(3);

        dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
        Debug.Log("step 3");

        angleControl.SetActive(true);
        yield return null;
    }

    private IEnumerator FourthStep()
    {
        angleControl.SetActive(false);
        controle.SetActive(true);
        continueButton.SetActive(false);

        dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();

        Debug.Log("step 4");

        yield return null;
    }

    private IEnumerator FifthStep()
    {
        continueButton.SetActive(true);
        controle.SetActive(false);
        parametrosControl.SetInitialChart();

        camera.GetComponent<CameraControl>().TranslateCameraById(2);
        dialogueBox.SetActive(false);
        yield return new WaitForSeconds(5f);
        dialogueBox.SetActive(true);
        Debug.Log("step 5");

        GeneralData.interruptor = false;

        GetContinueValue();
    }

    private IEnumerator SixthStep()
    {
        continueButton.SetActive(false);

        camera.GetComponent<CameraControl>().TranslateCameraById(3);
        parametrosControl.Unable();

        if(!isReLoaded){
            dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
        }else{
            reLoadObject.GetComponent<DialogueTrigger>().TriggerDialogue(0);
        }

        massSelectorPanel.SetActive(true);

        yield return null;
        Debug.Log("step 6");
    }

    private IEnumerator SeventhStep()
    {
        dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
        Debug.Log(GeneralData.blinkState);
        StartCoroutine(massBlinkController.GetComponent<MassController>().BlinkMass());

        yield return null;
        Debug.Log("step 7");
    }

    private IEnumerator EighthStep()
    {
        dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();

        controle.SetActive(true);
        continueButton.SetActive(false);

        Debug.Log("step 8");
        yield return null;
    }

    private IEnumerator NinethStep(){
        continueButton.SetActive(true);
        controle.SetActive(false);
        parametrosControl.SetCurrentChart();

        camera.GetComponent<CameraControl>().TranslateCameraById(2);
        dialogueBox.SetActive(false);
        yield return new WaitForSeconds(5f);
        dialogueBox.SetActive(true);
        Debug.Log("step 9");

        GeneralData.interruptor = false;

        GetContinueValue();
    }

    private IEnumerator TenthStep(){
        dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();

        yesNoAnswer.SetActive(true);
        continueButton.SetActive(false);
        Debug.Log("step 10");
        yield return null;
    }

    private IEnumerator FinalStep(){

        if(GeneralData.isCorrect) {
            parametrosControl.Unable();
            correctPanel.SetActive(true);
        }else{
            dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
        }

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("Main");
    }

    private IEnumerator RetryStep()
    {
        yield return null;
    }

    private IEnumerator ErrStep()
    {

        dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();

        yield return new WaitForSeconds(5.0f);

        SceneManager.LoadScene("Main");
    }

    private IEnumerator RightStep()
    {

        dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();
        //dialogueManager.GetComponent<DialogueManager>().DisplayNextSentence();

        yield return new WaitForSeconds(5.0f);


        SceneManager.LoadScene("Main");
    }

    public void GetContinueValue()
    {
        countStep++;
        switch (countStep)
        {
            case 3:
                StartCoroutine(ThirdStep());
                break;

            case 4:
                StartCoroutine(FourthStep());
                break;

            case 5:
                StartCoroutine(FifthStep());
                break;

            case 6:
                StartCoroutine(SixthStep());
                break;

            case 7:
                StartCoroutine(SeventhStep());
                break;

            case 8:
                //Essa aqui vem do Click Blink
                if (CheckMassPosition())
                {
                    Debug.Log("sim");
                    StartCoroutine(EighthStep());
                }
                else
                {
                    //countStep--;
                    Debug.Log("não");
                    //StartCoroutine(RetryStep());
                    StartCoroutine(EighthStep());
                }

                break;

            case 9:
                StartCoroutine(NinethStep());
                break;
            
            case 10:
                StartCoroutine(TenthStep());
                break;

            case 11:
                StartCoroutine(FinalStep());
                break;

            default:
                break;
        }
    }

    public void ReLoad(){
        countStep = 5;

        isReLoaded = true;

        yesNoAnswer.SetActive(false);
        continueButton.SetActive(true);

        //dialogueTrigger.GetComponent<DialogueTrigger>().TriggerDialogue(4);

        GetContinueValue();
    }

    public void ChangeBlinkState(string value)
    {
        isBlink = false;

        switch (value)
        {
            case "err":
                StartCoroutine(ErrStep());
                break;

            case "right":
                StartCoroutine(RightStep());
                break;

            default:
                break;
        }
    }

    public void SelectMass(int value)
    {
        selectedMass = value;
        GeneralData.currentMass = selectedMass;
        massSelectorPanel.SetActive(false);
        GetContinueValue();
    }

    private bool CheckMassPosition()
    {
        bool isRight = false;

        switch (GeneralData.imbalanceObject)
        {
            case "Cylinder01":
                isRight = GeneralData.massState05 || GeneralData.massState13 ? true : false;
                break;
            case "Cylinder901":
                isRight = GeneralData.massState07 || GeneralData.massState15 ? true : false;
                break;
            case "Cylinder2701":
                isRight = GeneralData.massState03 || GeneralData.massState11 ? true : false;
                break;
            case "Cylinder02":
                isRight = GeneralData.massState13 || GeneralData.massState05 ? true : false;
                break;
            case "Cylinder1802":
                isRight = GeneralData.massState09 || GeneralData.massState01 ? true : false;
                break;
        }

        return isRight;
    }
}
