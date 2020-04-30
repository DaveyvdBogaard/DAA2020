using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class introUI : MonoBehaviour
{
    public GameObject instructions;
    public Text spaceContinue;
    private string continueString;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        continueString = spaceContinue.text;
        StartCoroutine("TextBlink");
    }

    // Update is called once per frame
    void Update()
    {

        OpenInstructions();
    }

    void OpenInstructions()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (instructions.activeSelf == false)
            {
                instructions.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene("Game");
            }
        }
    }

    IEnumerator TextBlink()
    {
        yield return new WaitForSeconds(0.7f);
        spaceContinue.text = "";
        yield return new WaitForSeconds(0.4f);
        spaceContinue.text = continueString;
        StartCoroutine("TextBlink");
    }
}
