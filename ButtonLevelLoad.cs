using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public string mLevelToLoad;
    public TextMeshProUGUI screenText;
    //public string gmObject;
    public void Start()
    {
        //gmObject = this.gameObject.ToString();
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(mLevelToLoad);

    }
    public void OnTriggerEnter()
    {
        if (this.CompareTag("Finish"))
        {   
            if(mLevelToLoad == "") screenText.text = "Completed";
            else
            LoadLevel();
            
        }

    }
}
